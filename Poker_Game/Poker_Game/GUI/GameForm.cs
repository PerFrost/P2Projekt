﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

// TODO: When a player folds, show it on screen and start new game.

/* Har ryddet lidt op i jeres kode og lavet nogle få hjælpe funktioner
   der (forhåbentligt) giver klarhed og sparer kode. Har også lavet nogle
   få metode-navne om, således at de beskriver det det gør, ifølge min mening.
   Ændr dem endelig bare igen, hvis det ikke fungerer for jer, det hjalp mig
   bare da jeg organiserede metoderne. Håber jeg har gjort det mere overskueligt
   
   - Magnus
*/

namespace Poker_Game {
    public partial class GameForm : Form {
        private Settings Settings;
        private Game Game;

        #region Initialization

        public GameForm(string inputPlayerName, int inputStackSize, int inputBlindSize, int blindIncrease, bool blindIsRoundBased) { //Think about making Settings in settingsform and has it as a parameter. 
            InitializeComponent();
            labelPlayerName.Text = inputPlayerName;

            Settings = CreateGameSettings(inputPlayerName, inputStackSize, inputBlindSize, blindIncrease, blindIsRoundBased);

            // Creates the game so to say...
            Game = new Game(Settings);
            labelPlayerStack.Text = Convert.ToString(Game.Players[0].Stack);
            labelTablePot.Text = Convert.ToString("Pot:   $" + 0);
            ShowPlayerHand(Game.Players[0].Cards);
            UpdateAll();
        }

        private Settings CreateGameSettings(string playerName, int stackSize, int blindSize, int blindIncrease, bool blindIsRoundBased) {
            return new Settings(2, stackSize, blindSize, blindIsRoundBased, blindIncrease, playerName);
        }

        private void Form1_Load(object sender, EventArgs e) { // Events when the form loads
            //Set the window form.
            this.MaximumSize = new Size(1000, 700);
            this.MinimumSize = new Size(1000, 700);
            Size = new Size(1000, 700);
            StartPosition = FormStartPosition.CenterScreen;

            //Load background picture.
            this.BackgroundImage = Properties.Resources.PokerBord;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        #endregion

        #region CardDrawing

        private void ShowCardImage(PictureBox obj, Card card)
        {
            obj.Image = card.Image;
        }

        private void ShowPlayerHand(List<Card> cards) // Takes card list from player hand
        {
            picturePlayerCard1.Image = cards[0].Image;
            picturePlayerCard2.Image = cards[1].Image;
        }

        private void ShowOpponentHand(List<Card> cards) // Takes card list from opponent's (AI) hand
        {
            pictureAICard1.Image = cards[0].Image;
            pictureAICard2.Image = cards[1].Image;
        }

        private void ShowTurnCard(List<Card> cards) {
            pictureTableCard4.Image = cards[3].Image;
        }

        private void ShowRiverCard(List<Card> cards) {
            pictureTableCard5.Image = cards[4].Image;
        }

        private void ResetCards() {
            // Reset table and AI cards to be "invisible".
            pictureAICard1.Image = Properties.Resources.z_Back_of_card2;
            pictureAICard2.Image = Properties.Resources.z_Back_of_card2;
            pictureTableCard1.Image = Properties.Resources.z_Back_of_card2;
            pictureTableCard2.Image = Properties.Resources.z_Back_of_card2;
            pictureTableCard3.Image = Properties.Resources.z_Back_of_card2;
            pictureTableCard4.Image = Properties.Resources.z_Back_of_card2;
            pictureTableCard5.Image = Properties.Resources.z_Back_of_card2;
        }

        #endregion

        #region Updates

        private void UpdateAll() { // Name-change?
            UpdateCurrentPlayer();
            UpdateCards();
            UpdatePlayerStack(Game.Players[0], Game.Players[1]);
            UpdatePotSize(Game.CurrentHand());
            UpdatePlayerBlind(Game.Players[0]);
            // CheckPlayerTurn(Game.CurrentPlayerIndex); Disabled until AI has been implemented
        }

        private void UpdateCards() {
            if (Game.CurrentRoundNumber() == 2)
            {
                ShowCardImage(pictureTableCard1, Game.CurrentHand().Street[0]); // Shows image of the the first table card (flop)
                ShowCardImage(pictureTableCard1, Game.CurrentHand().Street[1]); // Shows image of the second table card (flop)
                ShowCardImage(pictureTableCard1, Game.CurrentHand().Street[2]); // Shows image of the third table card (flop)
            }
            else if (Game.CurrentRoundNumber() == 3)
            {
                ShowTurnCard(Game.CurrentHand().Street);
                ShowCardImage(pictureTableCard1, Game.CurrentHand().Street[3]); // Shows turn card
            }
            else if (Game.CurrentRoundNumber() == 4)
            {
                ShowCardImage(pictureTableCard1, Game.CurrentHand().Street[4]); // Shows river card
            }
            else if (Game.CurrentRoundNumber() == 5)
            {
                Showdown();
            }
        }

        private void UpdateCurrentPlayer() { // Highlights current player's name. 
            if(Game.CurrentPlayerIndex == 0) {
                labelPlayerName.ForeColor = Color.Yellow;
                labelAIStack.ForeColor = Color.White;
                ChangeActionButtonState(true);
            } else {
                labelAIStack.ForeColor = Color.Yellow;
                labelPlayerName.ForeColor = Color.White;
                //Disabled untill AI has been implemented
                //ChangeActionButtonState(false);
            }
        }

        private void UpdatePlayerStack(Player player, Player AI) {
            labelPlayerStack.Text = "Your Stack:" + Environment.NewLine + player.Stack;
            labelAIStack.Text = "AI" + Environment.NewLine + "Stack:" + Environment.NewLine + AI.Stack;
        }

        private void UpdatePotSize(Hand hand) {
            labelTablePot.Text = "Pot:   $" + Convert.ToString(hand.Pot);
        }

        private void UpdatePlayerBlind(Player player) {
            if(player.IsBigBlind) {
                labelAIBlind.Text = "Small blind";
                labelPlayerBlind.Text = "Big blind";
            } else {
                labelPlayerBlind.Text = "Small blind";
                labelAIBlind.Text = "Big blind";
            }
        }

        private void CheckPlayerTurn(int id) {
            ChangeActionButtonState(id == 0);
        }


        #endregion

        #region ButtonEvents

        private void buttonQuitToMenu_Click(object sender, EventArgs e) {
            QuitConfirmationForm formConfirmationQuit = new QuitConfirmationForm(this);
            formConfirmationQuit.ShowDialog();
        }

        private void buttonCall_Click(object sender, EventArgs e) {
            Game.Call();
            UpdateAll();
        }

        private void buttonCheck_Click(object sender, EventArgs e) {
            Game.Check();
            UpdateAll();
        }

        private void buttonRaise_Click(object sender, EventArgs e) {
            Game.Raise();
            UpdateAll();
        }

        private void buttonFold_Click(object sender, EventArgs e) {
            Game.Fold();
            UpdateAll();
        }

        private void buttonMakeNewHand_Click(object sender, EventArgs e) {
            CreateNewHand();
            UpdatePotSize(Game.CurrentHand());
            ChangeActionButtonState(true);
            buttonMakeNewHand.Visible = false;
        }

        #endregion

        #region Utility

        private void ChangeActionButtonState(bool updatedState) {
            buttonCall.Enabled = updatedState;
            buttonCheck.Enabled = updatedState;
            buttonRaise.Enabled = updatedState;
            buttonFold.Enabled = updatedState;
        }


        #endregion

        // Un-categorized for now
        #region Other

        private void Showdown() {
            ChangeActionButtonState(false);
            ShowOpponentHand(Game.Players[1].Cards);
            //TODO: Show winner and score
            buttonMakeNewHand.Visible = true;
        }

        private void CreateNewHand() {
            Game.NewHand();
            ResetCards();

            // Shows player new hand cards
            ShowPlayerHand(Game.CurrentHand().Players[0].Cards);
        }

        #endregion

    }
}