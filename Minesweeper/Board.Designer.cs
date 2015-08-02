using System.ComponentModel;

namespace Minesweeper
{
    partial class Board
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.GameStatus = new System.Windows.Forms.Panel();
            this.GameBoard = new System.Windows.Forms.Panel();
            this.NumberOfMines = new System.Windows.Forms.Label();
            this.TimeOfGame = new System.Windows.Forms.Label();
            this.GameStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameStatus
            // 
            this.GameStatus.Controls.Add(this.TimeOfGame);
            this.GameStatus.Controls.Add(this.NumberOfMines);
            this.GameStatus.Location = new System.Drawing.Point(13, 13);
            this.GameStatus.Name = "GameStatus";
            this.GameStatus.Size = new System.Drawing.Size(384, 46);
            this.GameStatus.TabIndex = 0;
            // 
            // GameBoard
            // 
            this.GameBoard.Location = new System.Drawing.Point(12, 65);
            this.GameBoard.Name = "GameBoard";
            this.GameBoard.Size = new System.Drawing.Size(385, 276);
            this.GameBoard.TabIndex = 1;
            // 
            // NumberOfMines
            // 
            this.NumberOfMines.AutoSize = true;
            this.NumberOfMines.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfMines.Location = new System.Drawing.Point(3, 11);
            this.NumberOfMines.Name = "NumberOfMines";
            this.NumberOfMines.Size = new System.Drawing.Size(61, 24);
            this.NumberOfMines.TabIndex = 0;
            this.NumberOfMines.Text = "Mines";
            // 
            // TimeOfGame
            // 
            this.TimeOfGame.AutoSize = true;
            this.TimeOfGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeOfGame.Location = new System.Drawing.Point(70, 11);
            this.TimeOfGame.Name = "TimeOfGame";
            this.TimeOfGame.Size = new System.Drawing.Size(53, 24);
            this.TimeOfGame.TabIndex = 1;
            this.TimeOfGame.Text = "Time";
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(461, 228);
            this.Controls.Add(this.GameBoard);
            this.Controls.Add(this.GameStatus);
            this.Name = "Board";
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.Board_Load);
            this.GameStatus.ResumeLayout(false);
            this.GameStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GameStatus;
        public System.Windows.Forms.Panel GameBoard;
        public System.Windows.Forms.Label TimeOfGame;
        public System.Windows.Forms.Label NumberOfMines;
    }
}

