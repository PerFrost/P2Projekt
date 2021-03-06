﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Poker_Game.Game {
    public class PokerGame {
        public int CurrentPlayerIndex { get; private set; }
        public List<Player> Players { get; }
        public List<Hand> Hands { get; }
        public Settings Settings { get; }

        private int _dealerButtonPosition;
        private bool _handInProgress;
        private bool _roundInProgress;


        #region Initialization
        public PokerGame(Settings settings) {
            Settings = settings;
            Players = InitializePlayers();
            Hands = new List<Hand>();
            _dealerButtonPosition = 0;
            NewHand();
            CurrentPlayerIndex = GetStartingPlayerIndex();
        }
    
        public PokerGame() { // For testing purpose only
            Hands = new List<Hand>();
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
        public void Call() { // Method used for coding a press of Call-button in GameForm.
            if (CanCall()) {
                // Needs to be cut down
                Bet(Players[CurrentPlayerIndex], Math.Abs(Players[CurrentPlayerIndex].CurrentBet - Players[(CurrentPlayerIndex + 1) % 2].CurrentBet));
                Players[CurrentPlayerIndex].Action = PlayerAction.Call;
                Players[CurrentPlayerIndex].PreviousAction = PlayerAction.Call;
                CurrentRound().UncalledRaise = false;
                NewTurn();
                UpdateState();
            }
        }

        public void Check() { // Method used for coding a press of Check-button in GameForm.
            if (CanCheck()) { // Needs fixing
                CurrentPlayer().Action = PlayerAction.Check;
                Players[CurrentPlayerIndex].PreviousAction = PlayerAction.Check;
                CurrentPlayer().BetsTaken++;
                NewTurn();
                UpdateState();
            }
        }

        public void Raise() { // Method used for coding a press of Raise-button in GameForm.
            if(CanRaise()) {
                // Needs to be cut down
                Bet(Players[CurrentPlayerIndex],Math.Abs(Players[CurrentPlayerIndex].CurrentBet - Players[(CurrentPlayerIndex + 1) % 2].CurrentBet) + 2 * Settings.BlindSize);
                Players[CurrentPlayerIndex].Action = PlayerAction.Raise;
                Players[CurrentPlayerIndex].PreviousAction = PlayerAction.Raise;
                CurrentPlayer().BetsTaken++;
                CurrentRound().UncalledRaise = true;

                // Create functions for this.
                NewTurn();
                UpdateState();
            }
        }

        public void Fold() { // Method used for coding a press of Fold-button in GameForm.
            Players[CurrentPlayerIndex].Action = PlayerAction.Fold;
            Players[CurrentPlayerIndex].PreviousAction = PlayerAction.Fold;
            NewTurn();
            UpdateState();
        }

        #endregion

        public void NewHand() {
                _dealerButtonPosition = ++_dealerButtonPosition % Settings.NumberOfPlayers; // Separate function?
                Hands.Add(new Hand(Players, _dealerButtonPosition));
                PayBlinds();
                _handInProgress = true;
        }
        private void NewRound() {
            if(!_roundInProgress) {
                CurrentHand().StartRound();
                _roundInProgress = true;
                CurrentPlayerIndex = GetStartingPlayerIndex();
            }
        }

        private void NewTurn() {
            CurrentRound().NewTurn(Players[CurrentPlayerIndex]);
        }

        public void UpdateState() { // WIP. Split up?
            _handInProgress = IsHandInProgress();
            _roundInProgress = IsRoundInProgress();
            CurrentPlayerIndex = (CurrentPlayerIndex + 1) % Settings.NumberOfPlayers;

            if(!_roundInProgress && _handInProgress) {
                NewRound();
            }

            if(!_handInProgress) {
                RewardWinners(GetWinners(CurrentHand()));
            }
        }

        private void RewardWinners(List<Player> winners) { 
            foreach(Player player in winners) {
                player.Stack += CurrentHand().Pot / winners.Count;
            }
        }

        public List<Player> GetWinners(Hand hand) {
            List<Player> players = GetUnfoldedPlayers(hand.Players);
            if(players.Count == 1) {
                return players;
            }
            return GetWinningPlayers(players);
        }

        private List<Player> GetWinningPlayers(List<Player> players) {
            foreach (Player player in players) {
                player.Cards.Sort();
                player.GetScore();
            }
            if (players[0].Score > players[1].Score) {
                return new List<Player> { players[0] };
            }
            if (players[0].Score < players[1].Score) {
                return new List<Player> { players[1] };
            }
            return GetSameScoreWinners(players);
        }

        private List<Player> GetSameScoreWinners(List<Player> players) {
            WinConditions wc = new WinConditions();
            Player tempPlayer = wc.SameScore(players[0], players[1]);
            if(tempPlayer == null) {
                List<Player> winners = new List<Player>();
                winners.Add(players[0]);
                winners.Add(players[1]);
                return winners;
            }
            return new List<Player> { tempPlayer };
        }

        private List<Player> GetUnfoldedPlayers(List<Player> players) {
            List<Player> playersLeft = new List<Player>();
            foreach(Player player in players) {
                if(player.Action != PlayerAction.Fold) {
                    playersLeft.Add(player);
                }
            }
            return playersLeft;
        }

        private int GetStartingPlayerIndex() {
            return Players[0].IsSmallBlind ? 0 : 1;
        }

        private void Bet(Player player, int amount) {
            if(player.Stack >= amount) {
                player.CurrentBet += amount;
                player.Stack -= amount;
                CurrentHand().Pot += amount;
            }
        }

        private void PayBlinds() {
            for(int i = 0; i < Settings.NumberOfPlayers; i++) {
                if(Players[i].IsBigBlind) {
                    Bet(Players[i], 2 * Settings.BlindSize);
                    Players[i].Action = PlayerAction.Raise;
                    Players[i].PreviousAction = PlayerAction.Raise;
                } else if(Players[i].IsSmallBlind) {
                    Bet(Players[i], Settings.BlindSize);
                }
            }
        }

        #region Utillity

        private bool IsRoundInProgress() {
            return !CurrentRound().IsFinished();
        }

        private bool IsHandInProgress() {
            return !Hands[Hands.Count - 1].IsFinished();
        }

        public bool CanCheck() {
            return Players[0].CurrentBet - Players[1].CurrentBet == 0;
        }

        public bool CanCall() {
            return Players[0].CurrentBet - Players[1].CurrentBet != 0;
        }

        public bool CanRaise() {
            return CurrentPlayer().BetsTaken < Settings.MaxBetsPerRound && CurrentPlayer().Stack >= Settings.BlindSize * 2;
        }

        public int CurrentHandNumber() {
            return Hands.Count;
        }

        public int CurrentRoundNumber() {
            return Hands[CurrentHandNumber() - 1].CurrentRoundNumber();
        }

        public int CurrentTurnNumber() {
            return Hands[CurrentHandNumber() - 1].Rounds[CurrentRoundNumber() - 1].CurrentTurnNumber();
        }

        public Round CurrentRound() {
            return Hands[CurrentHandNumber() - 1].Rounds[CurrentRoundNumber() - 1];
        }

        public Hand CurrentHand() {
            return Hands[CurrentHandNumber() - 1];
        }

        public Player CurrentPlayer() {
            return Players[CurrentPlayerIndex];
        }
        #endregion
    }
}
