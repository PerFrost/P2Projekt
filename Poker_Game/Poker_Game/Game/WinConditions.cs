﻿using System.Collections.Generic;

// TODO: Make a method for when both players has no winning hand -> Slit the pot

namespace Poker_Game.Game {
    public enum Score {
        None, Pair = 15, TwoPairs, ThreeOfAKind,
        Straight, Flush, FullHouse, FourOfAKind, StraightFlush,
        RoyalFlush
    }

    public class WinConditions {

        public List<Card> DuplicateDeck(List<Card> cards) {
            List<Card> dupeCards = new List<Card>();
            foreach (Card element in cards) {
                dupeCards.Add((Card)element.Clone());
            }
            return dupeCards;
        }
        
        // Checks if the cards in hand / on street matches the different win conditions in the game
        public Score Evaluate(List<Card> cards) {
            List<Card> sortedCards = DuplicateDeck(cards);
            sortedCards.Sort();

            if (HasRoyalFlush(sortedCards)) {
                return Score.RoyalFlush;
            } else if (HasStraightFlush(sortedCards)) {
                return Score.StraightFlush;
            } else if(HasFourOfAKind(sortedCards)) {
                return Score.FourOfAKind;
            } else if(HasFullHouse(sortedCards)) {
                return Score.FullHouse;
            } else if(HasFlush(sortedCards)) {
                return Score.Flush;
            } else if(HasStraight(sortedCards)) {
                return Score.Straight;
            } else if(HasThreeOfAKind(sortedCards)) {
                return Score.ThreeOfAKind;
            } else if(HasTwoPairs(sortedCards)) {
                return Score.TwoPairs;
            } else if (HasPair(sortedCards)) {
                return Score.Pair;
            } else {
                return GetBestCard(sortedCards);
            }
        }

        // Finds the best of 2 cards - 26/4/2019 check
        private Score GetBestCard(List<Card> sortedCards) {
            return (Score) sortedCards[sortedCards.Count - 1].Rank;
        }

        // Checks if the player has a pair - 26/4/2019 check
        public bool HasPair(List<Card> sortedCards) {
            for (int i = 0; i < sortedCards.Count - 1; i++) {
                if (sortedCards[i].Rank == sortedCards[i + 1].Rank) {
                    return true;
                }
            }
            return false;
        }

        // Check if the player has two pairs - 26/4/2019 check
        public bool HasTwoPairs(List<Card> cards) {
            List<Card> sortedCards = DuplicateDeck(cards);

            for (int i = 0; i < sortedCards.Count - 1; i++) {
                if (sortedCards[i].Rank == sortedCards[i + 1].Rank) {
                    return HasPair(RemoveUnfitRank(sortedCards, sortedCards[i].Rank));
                }
            }
            return false;
        }

        // Checks for three of a kind - 26/4/2019 check
        public bool HasThreeOfAKind(List<Card> sortedCards) {
            for (int i = 0; i < sortedCards.Count - 2; i++) {
                if (sortedCards[i].Rank == sortedCards[i + 1].Rank &&
                    sortedCards[i + 1].Rank == sortedCards[i + 2].Rank ) {
                    return true;
                }
            }
            return false;
        }

        // Checks for a full house - 26/4/2019 check
        public bool HasFullHouse(List<Card> cards) {
            List<Card> sortedCards = DuplicateDeck(cards);
            for (int i = 0; i < sortedCards.Count - 2; i++) {
                if (sortedCards[i].Rank == sortedCards[i + 1].Rank &&
                    sortedCards[i + 1].Rank == sortedCards[i + 2].Rank) {
                    return HasPair(RemoveUnfitRank(sortedCards, sortedCards[i].Rank));
                }
            }
            return false;
        }

        // Checks for four of a kind - 26/4/2019 check
        public bool HasFourOfAKind(List<Card> sortedCards) {
            for (int i = 0; i < sortedCards.Count - 3; i++) {
                if (sortedCards[i].Rank == sortedCards[i + 1].Rank &&
                    sortedCards[i + 1].Rank == sortedCards[i + 2].Rank &&
                    sortedCards[i + 2].Rank == sortedCards[i + 3].Rank) {
                    return true;
                }
            }
            return false; 
        }

        // Checks for straight flush - 26/4/2019 check
        public bool HasStraightFlush(List<Card> cards) {
            List<Card> sortedCards = DuplicateDeck(cards);
            if (HasFlush(sortedCards)) {
                return HasStraight(FlushSuit(sortedCards));
            }
            return false;
        }

        // Checks if the player has a royal straight flush - 26/4/2019 check
        public bool HasRoyalFlush(List<Card> cards) {
            List<Card> sortedCards = DuplicateDeck(cards);
            if (HasFlush(sortedCards)) {
                FlushSuit(sortedCards);
                sortedCards.Sort(new CompareBySuit());
                for (int i = 0; i < sortedCards.Count - 4; i++) {
                    if (sortedCards[i].Rank == Rank.Ace &&
                        sortedCards[i+1].Rank == Rank.King &&
                        sortedCards[i+2].Rank == Rank.Queen &&
                        sortedCards[i+3].Rank == Rank.Jack &&
                        sortedCards[i+4].Rank == (Rank)10) {
                        return true;
                    }
                }
            }
            return false;
        }

        // Checks if the player has a straight - Bug: hvis der er 2 kort af samme rank i listen af de 5 kort der bruges til straighten, vil den ikke finde en straight
        public bool HasStraight(List<Card> cards) {
            List<Card> sortedCards = DuplicateDeck(cards);
            sortedCards.Sort();
            RemoveDublicateRank(sortedCards, 0);
            for (int i = 0; i <= sortedCards.Count - 5; i++) {
                if (sortedCards[i].Rank + 1 == sortedCards[i + 1].Rank &&
                    sortedCards[i + 1].Rank + 1 == sortedCards[i + 2].Rank &&
                    sortedCards[i + 2].Rank + 1 == sortedCards[i + 3].Rank &&
                    sortedCards[i + 3].Rank + 1 == sortedCards[i + 4].Rank) {
                    return true;
                }
                if (sortedCards[i + 4].Rank == Rank.Ace) {
                    sortedCards[i + 4].Rank = (Rank)1;
                    return HasStraight(sortedCards);
                }
            }
            return false;
        }

        // Checks if the player has a flush - 26/4/2019 check
        public bool HasFlush(List<Card> hand) {
            int C = 0, D = 0, H = 0, S = 0;
            foreach (Card element in hand) {
                if (element.Suit == Suit.Clubs) {
                    C++;
                } else if (element.Suit == Suit.Diamonds) {
                    D++;
                } else if (element.Suit == Suit.Hearts) {
                    H++;
                } else if (element.Suit == Suit.Spades) {
                    S++;
                }
            }
            if (C > 4 || D > 4 || H > 4 || S > 4) {
                return true;
           }
            return false;
        }

        // Checks if the cards in hand / street forms a correct straight house - 26/4/2019 check
        private List<Card> FlushSuit(List<Card> cards) {
            int C = 0, D = 0, H = 0, S = 0;
            foreach (Card element in cards) {
                if (element.Suit == Suit.Clubs) {
                    C++;
                } else if (element.Suit == Suit.Diamonds) {
                    D++;
                } else if (element.Suit == Suit.Hearts) {
                    H++;
                } else if (element.Suit == Suit.Spades) {
                    S++;
                }
            }
            if (C > D && C > H && C > S) {
                return RemoveUnfitSuit(cards, Suit.Clubs);
            } else if (D > C && D > H && D > S) {
                return RemoveUnfitSuit(cards, Suit.Diamonds);
            } else if (H > C && H > D && H > S) {
                return RemoveUnfitSuit(cards, Suit.Hearts);
            } else  {
                return RemoveUnfitSuit(cards, Suit.Spades);
            }
        }

        //Removes all cards which is not of a given suit - 26/4/2019 check
        private List<Card> RemoveUnfitSuit(List<Card> cards, Suit suit) {
            for(int index = cards.Count - 1; index >= 0; index--) {
                if (cards[index].Suit != suit) {
                    cards.Remove(cards[index]);
                }
            }
            return cards;
        }

        //Removes all cards which is of a given rank - 26/4/2019 check
        private List<Card> RemoveUnfitRank(List<Card> cards, Rank rank) {
            for (int index = cards.Count - 1; index >= 0; index--) {
                if (cards[index].Rank == rank) {
                    cards.Remove(cards[index]);
                }
            }
            return cards;
        }

        //Removes all dublicate ranks
        public List<Card> RemoveDublicateRank(List<Card> cards, int index) {
            if (cards.Count - 1 > index) {
                if (cards[index].Rank == cards[index + 1].Rank) {
                    cards.Remove(cards[index + 1]);
                    return RemoveDublicateRank(cards, index);
                } else {
                    return RemoveDublicateRank(cards, index + 1);
                } 
            }
            return null;
        }

        public Player SameScore(Player player1, Player player2) {  // Missing implementation
            if (player1.Score == Score.RoyalFlush) {
                return null;
            } else if (player1.Score == Score.StraightFlush) {
                return BestStraight(player1, player2);
            } else if (player1.Score == Score.FourOfAKind) {
                return BestFourOfAKind(player1, player2);
            } else if (player1.Score == Score.FullHouse) {
                return BestFullHouse(player1, player2);
            } else if (player1.Score == Score.Flush) {
                return BestFlush(player1, player2);
            } else if (player1.Score == Score.Straight) {
                return BestStraight(player1, player2);
            } else if (player1.Score == Score.ThreeOfAKind) {
                return BestThreeOfAKind(player1, player2);
            } else if (player1.Score == Score.TwoPairs) {
                return BestTwoPairs(player1, player2);
            } else if (player1.Score == Score.Pair) {
                return BestPair(player1, player2);
            } else {
                return GetBestHighestCard(player1, player2);
            }
        }

        private Player GetBestHighestCard(Player player1, Player player2) {
            for (int i = player1.Cards.Count - 1; i >= 0; i--) {
                if (player1.Cards[i].Rank != player2.Cards[i].Rank) {
                    return player1.Cards[i].Rank < player2.Cards[i].Rank ? player2 : player1;
                }
            }
            return null;
        }

        //Returns the player with the best straight in case both get a straight - Bug: hvis der er 2 kort af samme rank i listen af de 5 kort der bruges til straighten, vil den ikke finde en straight
        public Player BestStraight(Player player1, Player player2) {
            List<Card> player1cards = DuplicateDeck(player1.Cards);
            List<Card> player2cards = DuplicateDeck(player2.Cards);
            player1cards.Sort();
            player2cards.Sort();
            RemoveDublicateRank(player1cards, 0);
            RemoveDublicateRank(player2cards, 0);
            for (int i = 0; i < player1cards.Count - 5; i++) {
                if(player1cards[i].Rank + 4 == player1cards[i + 4].Rank) {
                    for (int j = 0; j < player2cards.Count - 5; j++) {
                        if (player2cards[j].Rank + 4 == player2cards[j + 4].Rank) {
                            if (player1cards[i].Rank == player2cards[j].Rank) {
                                return null;
                            } else {
                                return (player1cards[i].Rank > player2cards[j].Rank ? player1 : player2);
                            }
                        }
                    }
                }
            }
            throw new System.InvalidOperationException();
        }

        //Think it works, but need testing
        private Player BestFourOfAKind(Player player1, Player player2) {
            List<Card> player1cards = DuplicateDeck(player1.Cards);
            List<Card> player2cards = DuplicateDeck(player2.Cards);
            player1cards.Sort();
            player2cards.Sort();
            for (int i = 0; i < player1cards.Count - 3; i++) {
                if (player1cards[i].Rank == player1cards[i + 1].Rank &&
                    player1cards[i + 1].Rank == player1cards[i + 2].Rank &&
                    player1cards[i + 2].Rank == player1cards[i + 3].Rank) {
                    for (int j = 0; i < player1cards.Count - 3; j++) {
                        if (player2cards[j].Rank == player2cards[j + 1].Rank &&
                            player2cards[j + 1].Rank == player2cards[j + 2].Rank &&
                            player2cards[j + 2].Rank == player2cards[j + 3].Rank) {
                            if (player1cards[i].Rank == player2cards[j].Rank) {
                                return null;
                            } else {
                                return (player1cards[i].Rank > player2cards[j].Rank ? player1 : player2);
                            }
                        }
                    }
                }
            }
            throw new System.InvalidOperationException();
        }

        //Need input on this one since it is drastically different to the bool version (HasFullHouse)
        private Player BestFullHouse(Player player1, Player player2) {
            List<Card> player1cards = DuplicateDeck(player1.Cards);
            List<Card> player2cards = DuplicateDeck(player2.Cards);
            player1cards.Sort();
            player2cards.Sort();
            if (BestThreeOfAKind(player1, player2) != null) {
                return BestThreeOfAKind(player1, player2);
            } else {
                for (int i = 0; i < player1.Cards.Count - 1; i++) {
                    if (player1.Cards[i].Rank == player1.Cards[i + 1].Rank &&
                        player1.Cards[i + 1].Rank == player1.Cards[i + 2].Rank) {
                        for (int j = 0; j < player2.Cards.Count - 1; j++) {
                            if (player2.Cards[j].Rank == player2.Cards[j + 1].Rank &&
                                player2.Cards[j + 1].Rank == player2.Cards[j + 2].Rank) {
                                Player player1clone = (Player)player1.Clone();
                                Player player2clone = (Player)player2.Clone();
                                player1clone.Cards = RemoveUnfitRank(player1clone.Cards, player1clone.Cards[i].Rank);
                                player2clone.Cards = RemoveUnfitRank(player2clone.Cards, player2clone.Cards[j].Rank);
                                return BestPair(player1clone, player2clone);
                            }
                        }
                    }
                }
            }
            throw new System.InvalidOperationException();
        }

        private Player BestFlush(Player player1, Player player2) {
            Player player1clone = (Player)player1.Clone();
            Player player2clone = (Player)player2.Clone();
            FlushSuit(player1clone.Cards);
            FlushSuit(player2clone.Cards);
            player1clone.Cards.Sort();
            player2clone.Cards.Sort();
            return GetBestHighestCard(player1clone, player2clone);
        }

        private Player BestThreeOfAKind(Player player1, Player player2) {
            for (int i = 0; i < player1.Cards.Count - 1; i++) {
                if (player1.Cards[i].Rank == player1.Cards[i + 1].Rank &&
                    player1.Cards[i + 1].Rank == player1.Cards[i + 2].Rank) {
                    for (int j = 0; j < player2.Cards.Count - 1; j++) {
                        if (player2.Cards[j].Rank == player2.Cards[j + 1].Rank &&
                            player2.Cards[j + 1].Rank == player2.Cards[j + 2].Rank) {
                            if (player1.Cards[i].Rank == player2.Cards[j].Rank) {
                                return null;
                            } else {
                                return (player1.Cards[i].Rank > player2.Cards[j].Rank ? player1 : player2);
                            }
                        }
                    }
                }
            }
            throw new System.InvalidOperationException();
        }

        private Player BestTwoPairs(Player player1, Player player2) {
            List<Card> player1cards = DuplicateDeck(player1.Cards);
            List<Card> player2cards = DuplicateDeck(player2.Cards);
            player1cards.Sort();
            player2cards.Sort();
            for (int i = player1cards.Count - 1; i > 0; i--) {
                if (player1cards[i].Rank == player1cards[i - 1].Rank) {
                    for (int j = player2cards.Count - 1; j > 0; j--) {
                        if (player2cards[j].Rank == player2cards[j - 1].Rank) {
                            if (player1cards[i].Rank == player2cards[j].Rank) {
                                return BestPair(player1,player2);
                            } else {
                                return (player1cards[i].Rank > player2cards[j].Rank ? player1 : player2);
                            }
                        }
                    }
                }
            }
            throw new System.InvalidOperationException();
        }

        private Player BestPair(Player player1, Player player2) {
            for (int i = player1.Cards.Count - 1; i > 0 ; i--) {
                if (player1.Cards[i].Rank == player1.Cards[i - 1].Rank) {
                    for (int j = player2.Cards.Count - 1; j > 0; j--) {
                        if (player2.Cards[j].Rank == player2.Cards[j - 1].Rank) {
                            if (player1.Cards[i].Rank == player2.Cards[j].Rank) {
                                return GetBestHighestCard(player1, player2); 
                            } else {
                                return (player1.Cards[i].Rank > player2.Cards[j].Rank ? player1 : player2);
                            }
                        }
                    }
                }
            }
            throw new System.InvalidOperationException();
        }
    }
}
/*
TÆLLER: 133784560
royalflush: 4324
straightflush: 37260
four: 224848
fullhouse: 3473184
flush: 4047644
straight: 6180020
three: 6461620
twopair: 31433400
pair: 58627800
 */
