namespace Minesweeper.GameItems
{
    class EmptySpot: Spot
    {
        public EmptySpot()
        {
            ContainsMine = false;
        }
        protected override void PostClick()
        {
            if (AdjacentMines > 0)
                Text = AdjacentMines.ToString();
            Enabled = false;
        }
    }
}
