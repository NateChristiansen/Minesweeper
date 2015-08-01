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
            this.SuspendLayout();
            // 
            // GameStatus
            // 
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
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(461, 228);
            this.Controls.Add(this.GameBoard);
            this.Controls.Add(this.GameStatus);
            this.Name = "Board";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Board_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GameStatus;
        private System.Windows.Forms.Panel GameBoard;
    }
}

