using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class GameSettings : Form
    {
        public int Rows { get; set; }
        public int Columns { get; set; }

        public float Difficulty { get; set; }

        private readonly Dictionary<string, float> _difficulty = new Dictionary<string, float>
        {
            {"Easy", (float) 6.7},
            {"Normal", 5},
            {"Hard", (float) 4.3},
        };

        public GameSettings()
        {
            InitializeComponent();
            DifficultyBox.SelectedIndex = 1;
        }

        private void GameSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            PopulateFields();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            PopulateFields();
            Close();
        }

        private void PopulateFields()
        {
            Rows = int.Parse(RowBox.Text);
            Columns = int.Parse(ColumnBox.Text);
            Difficulty = _difficulty[DifficultyBox.Text];
        }
    }
}
