using System;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class GameSettings : Form
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public GameSettings()
        {
            InitializeComponent();
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
        }
    }
}
