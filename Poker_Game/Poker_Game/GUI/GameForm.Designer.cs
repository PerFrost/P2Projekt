﻿// Autogenerated code by VS toolbox. Event-methods are in GameForm.cs
namespace Poker_Game {
    partial class GameForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
       
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.buttonQuitToMenu = new System.Windows.Forms.Button();
            this.buttonRaise = new System.Windows.Forms.Button();
            this.buttonCall = new System.Windows.Forms.Button();
            this.buttonFold = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.playerName = new System.Windows.Forms.Label();
            this.labelPlayerStack = new System.Windows.Forms.Label();
            this.labelTablePot = new System.Windows.Forms.Label();
            this.labelAIStack = new System.Windows.Forms.Label();
            this.pictureTableCard1 = new System.Windows.Forms.PictureBox();
            this.pictureTableCard2 = new System.Windows.Forms.PictureBox();
            this.pictureTableCard3 = new System.Windows.Forms.PictureBox();
            this.pictureTableCard4 = new System.Windows.Forms.PictureBox();
            this.pictureTableCard5 = new System.Windows.Forms.PictureBox();
            this.pictureAICard2 = new System.Windows.Forms.PictureBox();
            this.pictureAICard1 = new System.Windows.Forms.PictureBox();
            this.picturePlayerCard1 = new System.Windows.Forms.PictureBox();
            this.picturePlayerCard2 = new System.Windows.Forms.PictureBox();
            this.labelAIBlind = new System.Windows.Forms.Label();
            this.labelPlayerBlind = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTableCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTableCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTableCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTableCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTableCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAICard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAICard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayerCard2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonQuitToMenu
            // 
            this.buttonQuitToMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonQuitToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitToMenu.Location = new System.Drawing.Point(829, 11);
            this.buttonQuitToMenu.Name = "buttonQuitToMenu";
            this.buttonQuitToMenu.Size = new System.Drawing.Size(146, 37);
            this.buttonQuitToMenu.TabIndex = 0;
            this.buttonQuitToMenu.Text = "Quit to Main Menu";
            this.buttonQuitToMenu.UseVisualStyleBackColor = true;
            this.buttonQuitToMenu.Click += new System.EventHandler(this.buttonQuitToMenu_Click);
            // 
            // buttonRaise
            // 
            this.buttonRaise.BackColor = System.Drawing.Color.Maroon;
            this.buttonRaise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRaise.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRaise.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRaise.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRaise.Location = new System.Drawing.Point(417, 588);
            this.buttonRaise.Name = "buttonRaise";
            this.buttonRaise.Size = new System.Drawing.Size(110, 59);
            this.buttonRaise.TabIndex = 1;
            this.buttonRaise.Text = "Raise";
            this.buttonRaise.UseVisualStyleBackColor = false;
            this.buttonRaise.Click += new System.EventHandler(this.buttonRaise_Click);
            // 
            // buttonCall
            // 
            this.buttonCall.BackColor = System.Drawing.Color.Maroon;
            this.buttonCall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCall.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCall.Location = new System.Drawing.Point(301, 588);
            this.buttonCall.Name = "buttonCall";
            this.buttonCall.Size = new System.Drawing.Size(110, 59);
            this.buttonCall.TabIndex = 2;
            this.buttonCall.Text = "Call";
            this.buttonCall.UseVisualStyleBackColor = false;
            this.buttonCall.Click += new System.EventHandler(this.buttonCall_Click);
            // 
            // buttonFold
            // 
            this.buttonFold.BackColor = System.Drawing.Color.Red;
            this.buttonFold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonFold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFold.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFold.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFold.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonFold.Location = new System.Drawing.Point(10, 588);
            this.buttonFold.Name = "buttonFold";
            this.buttonFold.Size = new System.Drawing.Size(110, 59);
            this.buttonFold.TabIndex = 3;
            this.buttonFold.Text = "Fold";
            this.buttonFold.UseVisualStyleBackColor = false;
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.Maroon;
            this.buttonCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheck.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCheck.Location = new System.Drawing.Point(184, 588);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(110, 59);
            this.buttonCheck.TabIndex = 4;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // playerName
            // 
            this.playerName.BackColor = System.Drawing.Color.Transparent;
            this.playerName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerName.ForeColor = System.Drawing.Color.White;
            this.playerName.Location = new System.Drawing.Point(536, 556);
            this.playerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(142, 32);
            this.playerName.TabIndex = 5;
            this.playerName.Text = "Name";
            // 
            // labelPlayerStack
            // 
            this.labelPlayerStack.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayerStack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelPlayerStack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerStack.ForeColor = System.Drawing.Color.White;
            this.labelPlayerStack.Location = new System.Drawing.Point(536, 588);
            this.labelPlayerStack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlayerStack.Name = "labelPlayerStack";
            this.labelPlayerStack.Size = new System.Drawing.Size(142, 49);
            this.labelPlayerStack.TabIndex = 6;
            this.labelPlayerStack.Text = "Stack";
            // 
            // labelTablePot
            // 
            this.labelTablePot.BackColor = System.Drawing.Color.Transparent;
            this.labelTablePot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelTablePot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTablePot.ForeColor = System.Drawing.Color.White;
            this.labelTablePot.Location = new System.Drawing.Point(413, 457);
            this.labelTablePot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTablePot.Name = "labelTablePot";
            this.labelTablePot.Size = new System.Drawing.Size(155, 37);
            this.labelTablePot.TabIndex = 7;
            this.labelTablePot.Text = "Pot";
            // 
            // labelAIStack
            // 
            this.labelAIStack.BackColor = System.Drawing.Color.Transparent;
            this.labelAIStack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelAIStack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAIStack.ForeColor = System.Drawing.Color.White;
            this.labelAIStack.Location = new System.Drawing.Point(302, 17);
            this.labelAIStack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAIStack.Name = "labelAIStack";
            this.labelAIStack.Size = new System.Drawing.Size(134, 88);
            this.labelAIStack.TabIndex = 8;
            this.labelAIStack.Text = "AI";
            // 
            // pictureTableCard1
            // 
            this.pictureTableCard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTableCard1.BackgroundImage")));
            this.pictureTableCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTableCard1.Location = new System.Drawing.Point(296, 281);
            this.pictureTableCard1.Name = "pictureTableCard1";
            this.pictureTableCard1.Size = new System.Drawing.Size(66, 92);
            this.pictureTableCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTableCard1.TabIndex = 9;
            this.pictureTableCard1.TabStop = false;
            // 
            // pictureTableCard2
            // 
            this.pictureTableCard2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTableCard2.BackgroundImage")));
            this.pictureTableCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTableCard2.Location = new System.Drawing.Point(375, 281);
            this.pictureTableCard2.Name = "pictureTableCard2";
            this.pictureTableCard2.Size = new System.Drawing.Size(66, 92);
            this.pictureTableCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTableCard2.TabIndex = 10;
            this.pictureTableCard2.TabStop = false;
            // 
            // pictureTableCard3
            // 
            this.pictureTableCard3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTableCard3.BackgroundImage")));
            this.pictureTableCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTableCard3.Location = new System.Drawing.Point(454, 281);
            this.pictureTableCard3.Name = "pictureTableCard3";
            this.pictureTableCard3.Size = new System.Drawing.Size(66, 92);
            this.pictureTableCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTableCard3.TabIndex = 11;
            this.pictureTableCard3.TabStop = false;
            // 
            // pictureTableCard4
            // 
            this.pictureTableCard4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTableCard4.BackgroundImage")));
            this.pictureTableCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTableCard4.Location = new System.Drawing.Point(533, 281);
            this.pictureTableCard4.Name = "pictureTableCard4";
            this.pictureTableCard4.Size = new System.Drawing.Size(66, 92);
            this.pictureTableCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTableCard4.TabIndex = 12;
            this.pictureTableCard4.TabStop = false;
            // 
            // pictureTableCard5
            // 
            this.pictureTableCard5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTableCard5.BackgroundImage")));
            this.pictureTableCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTableCard5.Location = new System.Drawing.Point(612, 281);
            this.pictureTableCard5.Name = "pictureTableCard5";
            this.pictureTableCard5.Size = new System.Drawing.Size(66, 92);
            this.pictureTableCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTableCard5.TabIndex = 13;
            this.pictureTableCard5.TabStop = false;
            // 
            // pictureAICard2
            // 
            this.pictureAICard2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureAICard2.BackgroundImage")));
            this.pictureAICard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureAICard2.Location = new System.Drawing.Point(204, 11);
            this.pictureAICard2.Name = "pictureAICard2";
            this.pictureAICard2.Size = new System.Drawing.Size(66, 92);
            this.pictureAICard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAICard2.TabIndex = 14;
            this.pictureAICard2.TabStop = false;
            // 
            // pictureAICard1
            // 
            this.pictureAICard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureAICard1.BackgroundImage")));
            this.pictureAICard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureAICard1.Location = new System.Drawing.Point(132, 11);
            this.pictureAICard1.Name = "pictureAICard1";
            this.pictureAICard1.Size = new System.Drawing.Size(66, 92);
            this.pictureAICard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAICard1.TabIndex = 15;
            this.pictureAICard1.TabStop = false;
            // 
            // picturePlayerCard1
            // 
            this.picturePlayerCard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picturePlayerCard1.BackgroundImage")));
            this.picturePlayerCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturePlayerCard1.Location = new System.Drawing.Point(706, 555);
            this.picturePlayerCard1.Name = "picturePlayerCard1";
            this.picturePlayerCard1.Size = new System.Drawing.Size(66, 92);
            this.picturePlayerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePlayerCard1.TabIndex = 16;
            this.picturePlayerCard1.TabStop = false;
            // 
            // picturePlayerCard2
            // 
            this.picturePlayerCard2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picturePlayerCard2.BackgroundImage")));
            this.picturePlayerCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturePlayerCard2.Location = new System.Drawing.Point(778, 555);
            this.picturePlayerCard2.Name = "picturePlayerCard2";
            this.picturePlayerCard2.Size = new System.Drawing.Size(66, 92);
            this.picturePlayerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePlayerCard2.TabIndex = 17;
            this.picturePlayerCard2.TabStop = false;
            // 
            // labelAIBlind
            // 
            this.labelAIBlind.BackColor = System.Drawing.Color.Transparent;
            this.labelAIBlind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAIBlind.ForeColor = System.Drawing.Color.White;
            this.labelAIBlind.Location = new System.Drawing.Point(128, 106);
            this.labelAIBlind.Name = "labelAIBlind";
            this.labelAIBlind.Size = new System.Drawing.Size(100, 23);
            this.labelAIBlind.TabIndex = 18;
            this.labelAIBlind.Text = "Small blind";
            // 
            // labelPlayerBlind
            // 
            this.labelPlayerBlind.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayerBlind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerBlind.ForeColor = System.Drawing.Color.White;
            this.labelPlayerBlind.Location = new System.Drawing.Point(702, 529);
            this.labelPlayerBlind.Name = "labelPlayerBlind";
            this.labelPlayerBlind.Size = new System.Drawing.Size(100, 23);
            this.labelPlayerBlind.TabIndex = 19;
            this.labelPlayerBlind.Text = "Big blind";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Poker_Game.Properties.Resources.PokerBord;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.labelPlayerBlind);
            this.Controls.Add(this.labelAIBlind);
            this.Controls.Add(this.picturePlayerCard2);
            this.Controls.Add(this.picturePlayerCard1);
            this.Controls.Add(this.pictureAICard1);
            this.Controls.Add(this.pictureAICard2);
            this.Controls.Add(this.pictureTableCard5);
            this.Controls.Add(this.pictureTableCard4);
            this.Controls.Add(this.pictureTableCard3);
            this.Controls.Add(this.pictureTableCard2);
            this.Controls.Add(this.pictureTableCard1);
            this.Controls.Add(this.labelAIStack);
            this.Controls.Add(this.labelTablePot);
            this.Controls.Add(this.labelPlayerStack);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.buttonFold);
            this.Controls.Add(this.buttonCall);
            this.Controls.Add(this.buttonRaise);
            this.Controls.Add(this.buttonQuitToMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deep Per";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTableCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTableCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTableCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTableCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTableCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAICard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAICard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayerCard2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonQuitToMenu;
        private System.Windows.Forms.Button buttonRaise;
        private System.Windows.Forms.Button buttonCall;
        private System.Windows.Forms.Button buttonFold;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label playerName;
        private System.Windows.Forms.Label labelPlayerStack;
        private System.Windows.Forms.Label labelTablePot;
        private System.Windows.Forms.Label labelAIStack;
        private System.Windows.Forms.PictureBox pictureTableCard1;
        private System.Windows.Forms.PictureBox pictureTableCard2;
        private System.Windows.Forms.PictureBox pictureTableCard3;
        private System.Windows.Forms.PictureBox pictureTableCard4;
        private System.Windows.Forms.PictureBox pictureTableCard5;
        private System.Windows.Forms.PictureBox pictureAICard2;
        private System.Windows.Forms.PictureBox pictureAICard1;
        private System.Windows.Forms.PictureBox picturePlayerCard1;
        private System.Windows.Forms.PictureBox picturePlayerCard2;
        private System.Windows.Forms.Label labelAIBlind;
        private System.Windows.Forms.Label labelPlayerBlind;
    }
}