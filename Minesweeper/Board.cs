using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Minesweeper.GameItems;

namespace Minesweeper
{
    public partial class Board : Form
    {
        private readonly Size _size = new Size(20,20);
        private const int Space = 0;
        public List<List<Spot>> MineList { get; set; }
        private readonly Label _timeOfGame, _minesLeftInGame;

        public Board()
        {
            _timeOfGame = new Label {Anchor = AnchorStyles.Top | AnchorStyles.Left, Text = "Time"};
            _minesLeftInGame = new Label {Anchor = AnchorStyles.Top | AnchorStyles.Right, Text = "Mines"};
            InitializeComponent();
        }

        private void Board_Load(object sender, System.EventArgs e)
        {
            PopulateBoard();
        }

        public void PopulateBoard()
        {
            var x = Space;
            var y = Space;
            MineList.ForEach(row =>
            {
                x = Space;
                row.ForEach(spot =>
                {
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
            GameStatus.Controls.Add(_minesLeftInGame);
            GameStatus.Controls.Add(_timeOfGame);
            Height = GameBoard.Height + GameStatus.Height + 25;
            Width = GameBoard.Width + 20;
        }
    }
}
