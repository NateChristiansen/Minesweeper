using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Minesweeper.GameItems
{
    class Game
    {
        private List<List<Spot>> BoardList { get; set; }
        private readonly int _rowSize, _rowWidth;
        private Board _gameBoard;
        private readonly float _difficulty;

        public Game(int rowSize = 10, int rowWidth = 10, float difficulty = 5)
        {
            _rowSize = rowSize;
            _rowWidth = rowWidth;
            _difficulty = difficulty;
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
                    Spot spot;
                    if (random.Next(0, 10) == 0 && mines > 0)
                    {
                        mines--;
                        spot = new Mine { XCoordinate = j, YCoordinate = i };
                        row.Add(spot);
                    }
                    else
                    {
                        spot = new EmptySpot { XCoordinate = j, YCoordinate = i };
                        row.Add(spot);
                    }
                }
                BoardList.Add(row);
            }
            while (mines > 0)
            {
                var y = random.Next(0, _rowSize - 1);
                var x = random.Next(0, _rowWidth - 1);
                if (BoardList[y][x].GetType() != typeof(EmptySpot)) continue;
                BoardList[y][x] = new Mine { XCoordinate = x, YCoordinate = y };
                mines--;
            }
        }
        private int CalculateMines()
        {
            return (int)((_rowSize * _rowWidth) / _difficulty);
        }

        private void NumberMines()
        {
            BoardList.ForEach(row => row.ForEach(spot =>
            {
                var mines = new int();

                for (var i = -1; i <= 1; i++)
                {
                    for (var j = -1; j <= 1; j++)
                    {
                        try
                        {
                            if (BoardList[spot.YCoordinate + i][spot.XCoordinate + j].ContainsMine)
                            {
                                mines++;
                            }
                        }
                        catch (Exception ex)
                        {
                            var stuff = ex;
                        }
                    }
                }
                spot.AdjacentMines = spot.ContainsMine ? -1 : mines;
                spot.MouseDown += SpotClicked;
            }));
        }

        public void NewGame()
        {
            BoardList = new List<List<Spot>>();
            FillBoard();
            NumberMines();
            _gameBoard = new Board { MineList = BoardList };
            Application.Run(_gameBoard);
        }

        public void SpotClicked(object spot, EventArgs e)
        {
            var loc = (Spot)spot;
            var mevent = (MouseEventArgs)e;
            loc.SpotClicked(mevent);
            if (loc.AdjacentMines != 0 || mevent.Button != MouseButtons.Left) return;
            for (var i = -1; i <= 1; i++)
            {
                for (var j = -1; j <= 1; j++)
                {
                    if (i == 0 && j == 0) continue;
                    try
                    {
                        var nextSpot = BoardList[loc.YCoordinate + i][loc.XCoordinate + j];
                        if (nextSpot.Enabled)
                            SpotClicked(nextSpot, mevent);
                    }
                    catch (Exception)
                    {
                        // ignored
                    }
                }
            }
        }
    }
}
