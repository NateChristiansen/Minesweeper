using System.Windows.Forms;

namespace Minesweeper.GameItems
{
    public abstract class Spot : Button
    {
        public bool ContainsMine { get; set; }

        public bool Clicked()
        {
            PostClick();
            return ContainsMine;
        }

        protected abstract void PostClick();

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Spot
            // 
            this.Size = new System.Drawing.Size(25, 25);
            this.ResumeLayout(false);

        }
    }
}
