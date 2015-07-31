using System.ComponentModel;
using System.Windows.Forms;

namespace Minesweeper
{
    partial class GameSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GoButton = new System.Windows.Forms.Button();
            this.RowBox = new System.Windows.Forms.NumericUpDown();
            this.ColumnBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.RowBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rows:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Columns:";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(15, 63);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(109, 23);
            this.GoButton.TabIndex = 4;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // RowBox
            // 
            this.RowBox.Location = new System.Drawing.Point(68, 13);
            this.RowBox.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.RowBox.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.RowBox.Name = "RowBox";
            this.RowBox.Size = new System.Drawing.Size(56, 20);
            this.RowBox.TabIndex = 5;
            this.RowBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ColumnBox
            // 
            this.ColumnBox.Location = new System.Drawing.Point(68, 39);
            this.ColumnBox.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.ColumnBox.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ColumnBox.Name = "ColumnBox";
            this.ColumnBox.Size = new System.Drawing.Size(56, 20);
            this.ColumnBox.TabIndex = 6;
            this.ColumnBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // GameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(136, 98);
            this.Controls.Add(this.ColumnBox);
            this.Controls.Add(this.RowBox);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GameSettings";
            this.Text = "GameSettings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameSettings_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.RowBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button GoButton;
        private NumericUpDown RowBox;
        private NumericUpDown ColumnBox;
    }
}