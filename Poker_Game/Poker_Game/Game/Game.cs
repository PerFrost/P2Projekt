﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace Poker_Game {
    class Game {
        public int CurrentPlayerIndex { get; set; }
        public int DealerButtonPosition { get; set; }
        public bool HandInProgress { get; private set; }
        public bool RoundInProgress { get; private set; }

        public List<Player> Players { get; set; }
        public List<Hand> Hands { get; set; }
        public Settings Settings { get; set; }

        #region Initialization
        public Game(Settings settings) {
            Settings = settings;
            Players = InitializePlayers();
            Hands = new List<Hand>();
            DealerButtonPosition = 0;
            
            NewHand();
            CurrentPlayerIndex = GetStartingPlayerIndex();
        }

        private List<Player> InitializePlayers() {
            List<Player> players = new List<Player>();
            for(int id = 0; id < Settings.NumberOfPlayers; id++) {
                players.Add(new Player(id, Settings.StackSize));
            }
            return players;
        }
        #endregion

        #region Actions
        public void Call() {
            if(CanCall()) {
                // Needs to be cut down
                Bet(Players[CurrentPlayerIndex],Players[CurrentRound().TopBidderIndex].CurrentBet - Players[CurrentPlayerIndex].CurrentBet);
                Players[CurrentPlayerIndex].Action = PlayerAction.Call;
                UpdateState();
                CurrentRound().CycleStep++;
            }
        }

        public void Check() {
            if(CanCheck()) { // Fix this
                Players[CurrentPlayerIndex].Action = PlayerAction.Check;
                UpdateState();
                CurrentRound().CycleStep++;
            }
        }

        public void Fold() {
            Players[CurrentPlayerIndex].Action = PlayerAction.Fold;
            UpdateState();
            CurrentRound().CycleStep++;
        }

        public void Raise() {
            if(CanRaise()) {
                // Needs to be cut down
                Bet(Players[CurrentPlayerIndex], (Players[CurrentRound().TopBidderIndex].CurrentBet - Players[CurrentPlayerIndex].CurrentBet) + (2 * Settings.BlindSize)); // TODO: Optimer. Flyt udreginger til fast variabel
                Players[CurrentPlayerIndex].Action = PlayerAction.Raise;

                // Create functions for this.
                CurrentRound().ChangeTopBidder(CurrentPlayerIndex);
                UpdateState();
                CurrentRound().CycleStep++;
            }
        }

        public void NewHand() {
            if(!HandInProgress) {
                DealerButtonPosition = ++DealerButtonPosition % Settings.NumberOfPlayers; // Separate function?
                Hands.Add(new Hand(Players, DealerButtonPosition));
                PayBlinds();
                HandInProgress = true;
            }
        }

        public void NewRound() {
            if(!RoundInProgress) {
                CurrentHand().StartRound(DealerButtonPosition);
                RoundInProgress = true;
            }
        }

        #endregion

        #region GameState

        public void UpdateState() { // WIP. Split up?
            HandInProgress = IsHandInProgress();
            RoundInProgress = IsRoundInProgress();
            CurrentPlayerIndex = GetNextPlayerIndex();

            if(!RoundInProgress) {
                NewRound();
            }

            if(!HandInProgress) {
                RewardWinner(GetWinner(CurrentHand()));
            }
        }

        private void RewardWinner(Player winner) {
            winner.Stack += CurrentHand().Pot;
        }

        private Player GetWinner(Hand hand) {
            Player winner = null;
            foreach(Player player in hand.Players) {
                player.GetScore();
                if(winner == null) {
                    winner = player;
                } else if(player.Score > winner.Score) {
                    winner = player;
                } else if(player.Score == winner.Score) {
                    // TODO: More than one winner?
                } 
            }
            return winner;
        }

        private bool IsRoundInProgress() {
            return !CurrentRound().IsFinished(); // Could be split up
        }

        private bool IsHandInProgress() {
            return !Hands[Hands.Count - 1].IsFinished();
        }

        private int GetStartingPlayerIndex() {
            return (DealerButtonPosition + 3) % Settings.NumberOfPlayers;
        }

        private int GetNextPlayerIndex() {
            int next = ++CurrentPlayerIndex % Settings.NumberOfPlayers;
            for(int i = 0; i < Settings.NumberOfPlayers; i++) {
                if(Players[next].Action != PlayerAction.Fold) {
                    return next;
                }
                next = ++next % Settings.NumberOfPlayers;
            }
            return -1; // TODO: Do error-handling
        }



        #endregion

        #region Utillity
        public bool CanCheck() {
            return CurrentRound().TopBidderIndex == CurrentPlayerIndex ||
                   Players[CurrentPlayerIndex].CurrentBet - Players[CurrentRound().TopBidderIndex].CurrentBet == 0;
        }

        public bool CanCall() {
            return Players[CurrentRound().TopBidderIndex].CurrentBet - Players[CurrentPlayerIndex].CurrentBet != 0;
        }

        public bool CanRaise() {
            return CurrentRound().Bets != 3;
        }

        public int CurrentHandNumber() {
            return Hands.Count;
        }

        public int CurrentRoundNumber() {
            return Hands[CurrentHandNumber() - 1].CurrentRoundNumber();
        }

        public Round CurrentRound() {
            return Hands[CurrentHandNumber() - 1].Rounds[CurrentRoundNumber() - 1];
        }

        public Hand CurrentHand() {
            return Hands[CurrentHandNumber() - 1];
        }

        public bool IsFinished() { // Checks if players still has $ in stack
            int playersLeft = 0;
            foreach(Player player in Players) {
                if(player.Stack < 1) {
                    playersLeft++;
                    if(playersLeft > 1) {
                        return false;
                    }
                }
            }

            return true;
        }

        #endregion

        #region Betting

        private void Bet(Player player, int amount) {
            if(player.Stack >= amount) {
                player.CurrentBet += amount;
                player.Stack -= amount;
                CurrentHand().Pot += amount;
            } else {
                // Not enough money
                // TODO: Do something
            }
        }

        private void PayBlinds() {
            for (int i = 0; i < Settings.NumberOfPlayers; i++) {
                if(Players[i].IsBigBlind) {
                    Bet(Players[i], 2 * Settings.BlindSize);
                    CurrentRound().TopBidderIndex = i;
                } else if(Players[i].IsSmallBlind) {
                    Bet(Players[i], Settings.BlindSize);
                }
            }
        }

        #endregion

    }
}
