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
            this.TimeOfGame = new System.Windows.Forms.Label();
            this.NumberOfMines = new System.Windows.Forms.Label();
            this.GameBoard = new System.Windows.Forms.Panel();
            this.FaceImage = new System.Windows.Forms.PictureBox();
            this.GameStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FaceImage)).BeginInit();
            this.SuspendLayout();
            // 
            // GameStatus
            // 
            this.GameStatus.Controls.Add(this.FaceImage);
            this.GameStatus.Controls.Add(this.TimeOfGame);
            this.GameStatus.Controls.Add(this.NumberOfMines);
            this.GameStatus.Location = new System.Drawing.Point(13, 13);
            this.GameStatus.Name = "GameStatus";
            this.GameStatus.Size = new System.Drawing.Size(194, 67);
            this.GameStatus.TabIndex = 0;
            // 
            // TimeOfGame
            // 
            this.TimeOfGame.AutoSize = true;
            this.TimeOfGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeOfGame.Location = new System.Drawing.Point(136, 23);
            this.TimeOfGame.Name = "TimeOfGame";
            this.TimeOfGame.Size = new System.Drawing.Size(53, 24);
            this.TimeOfGame.TabIndex = 1;
            this.TimeOfGame.Text = "Time";
            // 
            // NumberOfMines
            // 
            this.NumberOfMines.AutoSize = true;
            this.NumberOfMines.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfMines.Location = new System.Drawing.Point(3, 23);
            this.NumberOfMines.Name = "NumberOfMines";
            this.NumberOfMines.Size = new System.Drawing.Size(61, 24);
            this.NumberOfMines.TabIndex = 0;
            this.NumberOfMines.Text = "Mines";
            // 
            // GameBoard
            // 
            this.GameBoard.Location = new System.Drawing.Point(12, 86);
            this.GameBoard.Name = "GameBoard";
            this.GameBoard.Size = new System.Drawing.Size(195, 176);
            this.GameBoard.TabIndex = 1;
            // 
            // FaceImage
            // 
            this.FaceImage.Location = new System.Drawing.Point(70, 3);
            this.FaceImage.Name = "FaceImage";
            this.FaceImage.Size = new System.Drawing.Size(60, 60);
            this.FaceImage.TabIndex = 2;
            this.FaceImage.TabStop = false;
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(217, 281);
            this.Controls.Add(this.GameBoard);
            this.Controls.Add(this.GameStatus);
            this.Name = "Board";
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.Board_Load);
            this.GameStatus.ResumeLayout(false);
            this.GameStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FaceImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GameStatus;
        public System.Windows.Forms.Panel GameBoard;
        public System.Windows.Forms.Label TimeOfGame;
        public System.Windows.Forms.Label NumberOfMines;
        public System.Windows.Forms.PictureBox FaceImage;
    }
}

