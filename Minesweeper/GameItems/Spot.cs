using System;
using System.Reflection;
using System.Windows.Forms;

namespace Minesweeper.GameItems
{
    public abstract class Spot : Button
    {
        public bool ContainsMine { get; set; }
        public bool IsRightClicked { get; set; } = false;
        public int AdjacentMines { get; set; }
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        public void SpotClicked(MouseEventArgs mevent)
        {
            switch (mevent.Button)
            {
                case MouseButtons.Left:
                    if (!IsRightClicked)
                        PostClick();
                    break;
                case MouseButtons.Right:
                    RightClick();
                    break;
            }
        }

        protected abstract void PostClick();

        protected void RightClick()
        {
            if (!IsRightClicked)
            {
                IsRightClicked = true;
                Image = Properties.Resources.Flag;
            }
            else
            {
                IsRightClicked = false;
                Image = null;
            }
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // Spot
            // 
            Size = new System.Drawing.Size(25, 25);
            ResumeLayout(false);

        }
    }
}
