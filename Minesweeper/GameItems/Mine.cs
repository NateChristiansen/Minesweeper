namespace Minesweeper.GameItems
{
    class Mine : Spot
    {
        public Mine()
        {
            ContainsMine = true;
        }
        protected override void PostClick()
        {
        }
    }
}
