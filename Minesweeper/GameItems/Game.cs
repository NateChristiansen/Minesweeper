using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Minesweeper.GameItems
{
    class Game
    {
        public List<List<Spot>> BoardList { get; set; }
        private readonly int _rowSize, _rowWidth;
        private Board _gameBoard;

        public Game(int rowSize = 10, int rowWidth = 10)
        {
            _rowSize = rowSize;
            _rowWidth = rowWidth;
            NewGame();
        }

        public void FillBoard()
        {
            var mines = CalculateMines();
            var random = new Random();
            for (var i = 0; i < _rowSize; i++)
            {
                var row = new List<Spot>();
                for (var j = 0; j < _rowWidth; j++)
                {
                    if (random.Next(0, 6) == 0 && mines > 0)
                    {
                        mines--;
                        row.Add(new Mine());
                    }
                    else 
                        row.Add(new EmptySpot());
                }
                BoardList.Add(row);
            }
            while (mines > 0)
            {
                var spot = BoardList[random.Next(0, _rowSize - 1)][random.Next(0, _rowWidth - 1)];
                if (spot.GetType() != typeof (EmptySpot)) continue;
                spot = new Mine();
                mines--;
            }
        }
        private int CalculateMines()
        {
            return (int) ((_rowSize * _rowWidth) / 6.4);
        }

        public void NewGame()
        {
            BoardList = new List<List<Spot>>();
            FillBoard();
            _gameBoard = new Board { MineList = BoardList };
            _gameBoard.PopulateBoard();
            Application.Run(_gameBoard);
        }
    }
}
