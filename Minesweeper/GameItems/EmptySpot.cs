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
        }
    }
}
