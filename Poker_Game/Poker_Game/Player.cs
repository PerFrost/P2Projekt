﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker_Game {
    class Player {
        public int Stack {
            get {
                return Stack;
            } set {
                if(value > 100 && value < int.MaxValue/2) { // Minimum and maximum stacksizes not defined yet
                    Stack = value;
                } else {
                    throw new ArgumentOutOfRangeException("{0} is not an accepted value for this property.", value.ToString());
                }
            }
        }
        public bool IsSmallBlind { get; set; }
        public bool IsBigBlind { get; set; }
        public bool HasFolded { get; set; }
        public List<Card> Cards { get; set; }

        public Player(int stackSize) {
            Cards = new List<Card>();
            Stack = stackSize;
            IsBigBlind = false;
            IsSmallBlind = false;
            HasFolded = false;
        }
    }
}