﻿namespace Poker_Game
{
    partial class HandWinnerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelWinnerTEXT = new System.Windows.Forms.Label();
            this.labelWinningPlayerName = new System.Windows.Forms.Label();
            this.labelPotSizeWon = new System.Windows.Forms.Label();
            this.labelWincondition = new System.Windows.Forms.Label();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWinnerTEXT
            // 
            this.labelWinnerTEXT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWinnerTEXT.AutoSize = true;
            this.labelWinnerTEXT.Font = new System.Drawing.Font("Courier New", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWinnerTEXT.Location = new System.Drawing.Point(72, 9);
            this.labelWinnerTEXT.Name = "labelWinnerTEXT";
            this.labelWinnerTEXT.Size = new System.Drawing.Size(143, 38);
            this.labelWinnerTEXT.TabIndex = 0;
            this.labelWinnerTEXT.Text = "WINNER";
            // 
            // labelWinningPlayerName
            // 
            this.labelWinningPlayerName.AutoSize = true;
            this.labelWinningPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWinningPlayerName.Location = new System.Drawing.Point(53, 65);
            this.labelWinningPlayerName.Name = "labelWinningPlayerName";
            this.labelWinningPlayerName.Size = new System.Drawing.Size(165, 20);
            this.labelWinningPlayerName.TabIndex = 1;
            this.labelWinningPlayerName.Text = "PlayerName: xxxxxxxxx";
            // 
            // labelPotSizeWon
            // 
            this.labelPotSizeWon.AutoSize = true;
            this.labelPotSizeWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPotSizeWon.Location = new System.Drawing.Point(53, 95);
            this.labelPotSizeWon.Name = "labelPotSizeWon";
            this.labelPotSizeWon.Size = new System.Drawing.Size(162, 20);
            this.labelPotSizeWon.TabIndex = 2;
            this.labelPotSizeWon.Text = "Potsize Won: xxxxxxxx";
            // 
            // labelWincondition
            // 
            this.labelWincondition.AutoSize = true;
            this.labelWincondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWincondition.Location = new System.Drawing.Point(53, 125);
            this.labelWincondition.Name = "labelWincondition";
            this.labelWincondition.Size = new System.Drawing.Size(266, 20);
            this.labelWincondition.TabIndex = 3;
            this.labelWincondition.Text = "BestCardCombination (wincondition)";
            // 
            // buttonContinue
            // 
            this.buttonContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContinue.Location = new System.Drawing.Point(92, 171);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(104, 36);
            this.buttonContinue.TabIndex = 4;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // HandWinnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 219);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.labelWincondition);
            this.Controls.Add(this.labelPotSizeWon);
            this.Controls.Add(this.labelWinningPlayerName);
            this.Controls.Add(this.labelWinnerTEXT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "HandWinnerForm";
            this.Text = "Hand Winner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWinnerTEXT;
        private System.Windows.Forms.Label labelWinningPlayerName;
        private System.Windows.Forms.Label labelPotSizeWon;
        private System.Windows.Forms.Label labelWincondition;
        private System.Windows.Forms.Button buttonContinue;
    }
}