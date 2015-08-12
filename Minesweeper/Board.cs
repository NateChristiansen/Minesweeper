using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Minesweeper.GameItems;

namespace Minesweeper
{
    public partial class Board : Form
    {
        private readonly Size _size = new Size(20, 20);
        private const int Space = 0;
        public List<List<Spot>> MineList { get; set; }

        public Board()
        {
            InitializeComponent();
        }

        private void Board_Load(object sender, System.EventArgs e)
        {
            PopulateBoard();
        }

        public void PopulateBoard()
        {
            GameBoard.Controls.Clear();
            var x = Space;
            var y = Space;
            MineList.ForEach(row =>
            {
                x = Space;
                row.ForEach(spot =>
                {
                    spot.Enabled = true;
                    spot.Size = _size;
                    spot.Location = new Point(x, y);
                    x += _size.Width + Space;
                    GameBoard.Controls.Add(spot);
                });
                y += _size.Height + Space;
            });

            GameBoard.Width = x + _size.Width - 3;
            GameBoard.Height = y + Space + _size.Height * 2;
            GameStatus.Width = GameBoard.Width;
            Height = GameBoard.Height + GameStatus.Height + 25;
            Width = GameBoard.Width + 20;
        }

        public void UpdateMines(int mines)
        {
            NumberOfMines.Text = mines.ToString();
        }
    }
}
