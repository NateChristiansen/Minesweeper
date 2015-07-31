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
        public Board()
        {
            InitializeComponent();
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
                    Controls.Add(spot);
                });
                y += _size.Height + Space;
            });

            Width = x + _size.Width - 3;
            Height = y + Space + _size.Height * 2;
        }
    }
}
