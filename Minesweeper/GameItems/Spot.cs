﻿using System;
using System.Reflection;
using System.Windows.Forms;

namespace Minesweeper.GameItems
{
    public abstract class Spot : Button
    {
        public bool ContainsMine { get; set; }
        public bool IsRightClicked { get; set; } = false;
        public int Mines { get; set; }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            switch (mevent.Button)
            {
                case MouseButtons.Left:
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
