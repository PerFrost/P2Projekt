﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO: Max number of betting-rounds in round. 3

namespace Poker_Game {
    class Round {
        public int TopBidderIndex { get; set; }
        public int CycleStep { get; set; }
        public int Bets { get; set; }

        public List<Turn> Turns { get; set; }
        public List<Player> Players { get; set; }

        #region Initialization
        public Round(List<Player> players) {
            Turns = new List<Turn>();
            Players = players;
            //Players = GetActivePlayers(players);
            TopBidderIndex = 0;
            CycleStep = 0;
            Bets = 0;
        }

        private List<Player> GetActivePlayers(List<Player> players) {
            List<Player> output = new List<Player>();
            foreach(Player player in players) {
                if(player.Action != PlayerAction.Fold) {
                    output.Add(player);
                }
            }
            return output;
        }

        #endregion

        #region Actions

        public void ChangeTopBidder(int playerIndex) { // Validation needed. Cannot bet more than 3 times
            for(int i = 0; i < Players.Count; i++) {
                if(Players[i].CompareTo(Players[playerIndex]) == 0) {
                    TopBidderIndex = i;
                    CycleStep = 0;
                }
            }

            Bets++;
        }

        #endregion

        #region Utility

        public bool IsFinished() {
            //System.Windows.Forms.MessageBox.Show(AllChecked() + " or " + (CycleFinished() && Bets == 3));
            return AllChecked() || Turns.Count > 2 && AllCalled();
        }

        private bool AllChecked() {
            foreach(Player player in Players) {
                if(player.Action != PlayerAction.Check) {
                    return false;
                }
            }

            return true;
        }

        private bool AllCalled() {
            if(Bets == 3 && CycleFinished()) {
                for(int i = 0; i < Players.Count; i++) {
                    if(Players[i].Action != PlayerAction.Call && i != TopBidderIndex) {
                        return false;
                    }
                }
            }

            return true;
        }

        private bool CycleFinished() {
            return CycleStep == Players.Count;
        }

        #endregion

    }
}
