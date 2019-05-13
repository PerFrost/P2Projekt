﻿// Autogenerated code by VS toolbox. Event-methods are in GameForm.cs
namespace Poker_Game {
    public partial class GameForm {
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
            this.labelPlayerName = new System.Windows.Forms.Label();
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
            this.labelRoundName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPlayerCurrentBet = new System.Windows.Forms.Label();
            this.labelAICurrentBet = new System.Windows.Forms.Label();
            this.checkboxEnableTimer = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTableCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTableCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTableCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTableCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTableCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAICard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAICard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayerCard2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonQuitToMenu
            // 
            this.buttonQuitToMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonQuitToMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonQuitToMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonQuitToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitToMenu.Location = new System.Drawing.Point(829, 11);
            this.buttonQuitToMenu.Name = "buttonQuitToMenu";
            this.buttonQuitToMenu.Size = new System.Drawing.Size(146, 37);
            this.buttonQuitToMenu.TabIndex = 0;
            this.buttonQuitToMenu.TabStop = false;
            this.buttonQuitToMenu.Text = "Quit to Main Menu";
            this.buttonQuitToMenu.UseVisualStyleBackColor = false;
            this.buttonQuitToMenu.Click += new System.EventHandler(this.ButtonQuitToMenu_Click);
            // 
            // buttonRaise
            // 
            this.buttonRaise.BackColor = System.Drawing.Color.Red;
            this.buttonRaise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRaise.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRaise.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRaise.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRaise.Location = new System.Drawing.Point(417, 588);
            this.buttonRaise.Name = "buttonRaise";
            this.buttonRaise.Size = new System.Drawing.Size(110, 59);
            this.buttonRaise.TabIndex = 2;
            this.buttonRaise.Text = "Raise";
            this.buttonRaise.UseVisualStyleBackColor = false;
            this.buttonRaise.Click += new System.EventHandler(this.ButtonRaise_Click);
            this.buttonRaise.MouseEnter += new System.EventHandler(this.ButtonRaise_MouseEnter);
            this.buttonRaise.MouseLeave += new System.EventHandler(this.ButtonRaise_MouseLeave);
            // 
            // buttonCall
            // 
            this.buttonCall.BackColor = System.Drawing.Color.Red;
            this.buttonCall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCall.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCall.Location = new System.Drawing.Point(301, 588);
            this.buttonCall.Name = "buttonCall";
            this.buttonCall.Size = new System.Drawing.Size(110, 59);
            this.buttonCall.TabIndex = 1;
            this.buttonCall.Text = "Call";
            this.buttonCall.UseVisualStyleBackColor = false;
            this.buttonCall.Click += new System.EventHandler(this.ButtonCall_Click);
            this.buttonCall.MouseEnter += new System.EventHandler(this.ButtonCall_MouseEnter);
            this.buttonCall.MouseLeave += new System.EventHandler(this.ButtonCall_MouseLeave);
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
            this.buttonFold.TabStop = false;
            this.buttonFold.Text = "Fold";
            this.buttonFold.UseVisualStyleBackColor = false;
            this.buttonFold.Click += new System.EventHandler(this.ButtonFold_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.Red;
            this.buttonCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheck.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCheck.Location = new System.Drawing.Point(184, 588);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(110, 59);
            this.buttonCheck.TabIndex = 0;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.ButtonCheck_Click);
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayerName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerName.ForeColor = System.Drawing.Color.White;
            this.labelPlayerName.Location = new System.Drawing.Point(536, 556);
            this.labelPlayerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(142, 32);
            this.labelPlayerName.TabIndex = 5;
            this.labelPlayerName.Text = "Name";
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
            this.labelAIStack.Text = "Deep Peer";
            // 
            // pictureTableCard1
            // 
            this.pictureTableCard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTableCard1.BackgroundImage")));
            this.pictureTableCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTableCard1.Location = new System.Drawing.Point(282, 281);
            this.pictureTableCard1.Name = "pictureTableCard1";
            this.pictureTableCard1.Size = new System.Drawing.Size(80, 100);
            this.pictureTableCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTableCard1.TabIndex = 9;
            this.pictureTableCard1.TabStop = false;
            // 
            // pictureTableCard2
            // 
            this.pictureTableCard2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTableCard2.BackgroundImage")));
            this.pictureTableCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTableCard2.Location = new System.Drawing.Point(368, 281);
            this.pictureTableCard2.Name = "pictureTableCard2";
            this.pictureTableCard2.Size = new System.Drawing.Size(80, 100);
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
            this.pictureTableCard3.Size = new System.Drawing.Size(80, 100);
            this.pictureTableCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTableCard3.TabIndex = 11;
            this.pictureTableCard3.TabStop = false;
            // 
            // pictureTableCard4
            // 
            this.pictureTableCard4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTableCard4.BackgroundImage")));
            this.pictureTableCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTableCard4.Location = new System.Drawing.Point(540, 281);
            this.pictureTableCard4.Name = "pictureTableCard4";
            this.pictureTableCard4.Size = new System.Drawing.Size(80, 100);
            this.pictureTableCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTableCard4.TabIndex = 12;
            this.pictureTableCard4.TabStop = false;
            // 
            // pictureTableCard5
            // 
            this.pictureTableCard5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTableCard5.BackgroundImage")));
            this.pictureTableCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTableCard5.Location = new System.Drawing.Point(626, 281);
            this.pictureTableCard5.Name = "pictureTableCard5";
            this.pictureTableCard5.Size = new System.Drawing.Size(80, 100);
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
            this.pictureAICard2.Size = new System.Drawing.Size(80, 100);
            this.pictureAICard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAICard2.TabIndex = 14;
            this.pictureAICard2.TabStop = false;
            // 
            // pictureAICard1
            // 
            this.pictureAICard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureAICard1.BackgroundImage")));
            this.pictureAICard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureAICard1.Location = new System.Drawing.Point(118, 11);
            this.pictureAICard1.Name = "pictureAICard1";
            this.pictureAICard1.Size = new System.Drawing.Size(80, 100);
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
            this.picturePlayerCard1.Size = new System.Drawing.Size(80, 100);
            this.picturePlayerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePlayerCard1.TabIndex = 16;
            this.picturePlayerCard1.TabStop = false;
            // 
            // picturePlayerCard2
            // 
            this.picturePlayerCard2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picturePlayerCard2.BackgroundImage")));
            this.picturePlayerCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturePlayerCard2.Location = new System.Drawing.Point(801, 555);
            this.picturePlayerCard2.Name = "picturePlayerCard2";
            this.picturePlayerCard2.Size = new System.Drawing.Size(80, 100);
            this.picturePlayerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePlayerCard2.TabIndex = 17;
            this.picturePlayerCard2.TabStop = false;
            // 
            // labelAIBlind
            // 
            this.labelAIBlind.BackColor = System.Drawing.Color.Transparent;
            this.labelAIBlind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAIBlind.ForeColor = System.Drawing.Color.White;
            this.labelAIBlind.Location = new System.Drawing.Point(114, 137);
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
            this.labelPlayerBlind.Location = new System.Drawing.Point(702, 520);
            this.labelPlayerBlind.Name = "labelPlayerBlind";
            this.labelPlayerBlind.Size = new System.Drawing.Size(100, 23);
            this.labelPlayerBlind.TabIndex = 19;
            this.labelPlayerBlind.Text = "Big blind";
            // 
            // labelRoundName
            // 
            this.labelRoundName.AutoSize = true;
            this.labelRoundName.BackColor = System.Drawing.Color.Transparent;
            this.labelRoundName.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelRoundName.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoundName.Location = new System.Drawing.Point(411, 228);
            this.labelRoundName.Name = "labelRoundName";
            this.labelRoundName.Size = new System.Drawing.Size(164, 21);
            this.labelRoundName.TabIndex = 21;
            this.labelRoundName.Text = "labelRoundName";
            this.labelRoundName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 207);
            this.panel1.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "label5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diagnostics";
            // 
            // labelPlayerCurrentBet
            // 
            this.labelPlayerCurrentBet.AutoSize = true;
            this.labelPlayerCurrentBet.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayerCurrentBet.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelPlayerCurrentBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerCurrentBet.ForeColor = System.Drawing.Color.Red;
            this.labelPlayerCurrentBet.Location = new System.Drawing.Point(297, 541);
            this.labelPlayerCurrentBet.Name = "labelPlayerCurrentBet";
            this.labelPlayerCurrentBet.Size = new System.Drawing.Size(224, 24);
            this.labelPlayerCurrentBet.TabIndex = 23;
            this.labelPlayerCurrentBet.Text = "labelPlayerCurrentBetsize";
            // 
            // labelAICurrentBet
            // 
            this.labelAICurrentBet.AutoSize = true;
            this.labelAICurrentBet.BackColor = System.Drawing.Color.Transparent;
            this.labelAICurrentBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAICurrentBet.ForeColor = System.Drawing.Color.Red;
            this.labelAICurrentBet.Location = new System.Drawing.Point(400, 86);
            this.labelAICurrentBet.Name = "labelAICurrentBet";
            this.labelAICurrentBet.Size = new System.Drawing.Size(189, 24);
            this.labelAICurrentBet.TabIndex = 24;
            this.labelAICurrentBet.Text = "labelAICurrentBetsize";
            // 
            // checkboxEnableTimer
            // 
            this.checkboxEnableTimer.AutoSize = true;
            this.checkboxEnableTimer.BackColor = System.Drawing.Color.Transparent;
            this.checkboxEnableTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxEnableTimer.ForeColor = System.Drawing.Color.Red;
            this.checkboxEnableTimer.Location = new System.Drawing.Point(829, 54);
            this.checkboxEnableTimer.Name = "checkboxEnableTimer";
            this.checkboxEnableTimer.Size = new System.Drawing.Size(149, 20);
            this.checkboxEnableTimer.TabIndex = 26;
            this.checkboxEnableTimer.Text = "Enable Result Timer";
            this.checkboxEnableTimer.UseVisualStyleBackColor = false;
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
            this.Controls.Add(this.checkboxEnableTimer);
            this.Controls.Add(this.labelAICurrentBet);
            this.Controls.Add(this.labelPlayerCurrentBet);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelRoundName);
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
            this.Controls.Add(this.labelPlayerName);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.buttonFold);
            this.Controls.Add(this.buttonCall);
            this.Controls.Add(this.buttonRaise);
            this.Controls.Add(this.buttonQuitToMenu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonQuitToMenu;
        private System.Windows.Forms.Button buttonRaise;
        private System.Windows.Forms.Button buttonCall;
        private System.Windows.Forms.Button buttonFold;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label labelPlayerName;
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
        private System.Windows.Forms.Label labelRoundName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelPlayerCurrentBet;
        private System.Windows.Forms.Label labelAICurrentBet;
        private System.Windows.Forms.CheckBox checkboxEnableTimer;
    }
}