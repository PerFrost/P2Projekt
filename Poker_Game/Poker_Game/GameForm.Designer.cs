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
            this.buttonQuitToMenu = new System.Windows.Forms.Button();
            this.buttonRaise = new System.Windows.Forms.Button();
            this.buttonCall = new System.Windows.Forms.Button();
            this.buttonFold = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonQuitToMenu
            // 
            this.buttonQuitToMenu.Location = new System.Drawing.Point(16, 15);
            this.buttonQuitToMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonQuitToMenu.Name = "buttonQuitToMenu";
            this.buttonQuitToMenu.Size = new System.Drawing.Size(143, 36);
            this.buttonQuitToMenu.TabIndex = 0;
            this.buttonQuitToMenu.Text = "Quit to Main Menu";
            this.buttonQuitToMenu.UseVisualStyleBackColor = true;
            this.buttonQuitToMenu.Click += new System.EventHandler(this.buttonQuitToMenu_Click);
            // 
            // buttonRaise
            // 
            this.buttonRaise.Location = new System.Drawing.Point(728, 729);
            this.buttonRaise.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRaise.Name = "buttonRaise";
            this.buttonRaise.Size = new System.Drawing.Size(133, 42);
            this.buttonRaise.TabIndex = 1;
            this.buttonRaise.Text = "Raise";
            this.buttonRaise.UseVisualStyleBackColor = true;
            this.buttonRaise.Click += new System.EventHandler(this.buttonRaise_Click);
            // 
            // buttonCall
            // 
            this.buttonCall.Location = new System.Drawing.Point(585, 729);
            this.buttonCall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCall.Name = "buttonCall";
            this.buttonCall.Size = new System.Drawing.Size(133, 42);
            this.buttonCall.TabIndex = 2;
            this.buttonCall.Text = "Call";
            this.buttonCall.UseVisualStyleBackColor = true;
            this.buttonCall.Click += new System.EventHandler(this.buttonCall_Click);
            // 
            // buttonFold
            // 
            this.buttonFold.Location = new System.Drawing.Point(996, 729);
            this.buttonFold.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFold.Name = "buttonFold";
            this.buttonFold.Size = new System.Drawing.Size(133, 42);
            this.buttonFold.TabIndex = 3;
            this.buttonFold.Text = "Fold";
            this.buttonFold.UseVisualStyleBackColor = true;
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(443, 729);
            this.buttonCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(133, 42);
            this.buttonCheck.TabIndex = 4;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Poker_Game.Properties.Resources.PokerBord;
            this.ClientSize = new System.Drawing.Size(1312, 814);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.buttonFold);
            this.Controls.Add(this.buttonCall);
            this.Controls.Add(this.buttonRaise);
            this.Controls.Add(this.buttonQuitToMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonQuitToMenu;
        private System.Windows.Forms.Button buttonRaise;
        private System.Windows.Forms.Button buttonCall;
        private System.Windows.Forms.Button buttonFold;
        private System.Windows.Forms.Button buttonCheck;
    }
}