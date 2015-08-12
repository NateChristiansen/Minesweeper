using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Minesweeper.Properties;

namespace Minesweeper.GameItems
{
    class Game
    {
        private List<List<Spot>> BoardList { get; set; }

        private int Mines { get; set; }

        private int RowSize { get; }

        private int RowWidth { get; }

        private Board GameBoard { get; set; }

        private float Difficulty { get; }

        private readonly Timer _timer = new Timer { Interval = 1000, Enabled = false };

        private int _minesLeft;

        private int Time { get; set; }

        private readonly Random _random = new Random();

        private readonly Dictionary<string, Image> _faceImages = new Dictionary<string, Image>()
        {
            {"Smile", Resources.Smile},
            {"Win", Resources.Win},
            {"Lose", Resources.Lose},
            {"Click", Resources.Click}
        };

        private int MinesLeft
        {
            get { return _minesLeft; }
            set
            {
                _minesLeft = value;
                if (_minesLeft.Equals(0))
                    GameOver(true);
            }
        }

        public Game(int rowSize = 10, int rowWidth = 10, float difficulty = 5)
        {
            RowSize = rowSize;
            RowWidth = rowWidth;
            Difficulty = difficulty;
            _timer.Tick += (sender, args) =>
            {
                if (!GameBoard.FaceImage.Image.Equals(_faceImages["Smile"]))
                    GameBoard.FaceImage.Image = _faceImages["Smile"];
                Time++;
                GameBoard.TimeOfGame.Text = Time.ToString();
            };
            GameBoard = new Board();
            NewGame();
            Application.Run(GameBoard);
        }

        public void FillBoard()
        {
            BoardList = new List<List<Spot>>();
            var mines = CalculateMines();
            for (var i = 0; i < RowSize; i++)
            {
                var row = new List<Spot>();
                for (var j = 0; j < RowWidth; j++)
                {
                    Spot spot;
                    if (Math.Round(_random.NextDouble() * 10).Equals(0) && mines > 0)
                    {
                        mines--;
                        spot = new Mine { XCoordinate = j, YCoordinate = i, Enabled = true };
                        row.Add(spot);
                    }
                    else
                    {
                        spot = new EmptySpot { XCoordinate = j, YCoordinate = i, Enabled = true };
                        row.Add(spot);
                    }
                }
                BoardList.Add(row);
            }
            while (mines > 0)
            {
                var y = _random.Next(0, RowSize - 1);
                var x = _random.Next(0, RowWidth - 1);
                if (BoardList[y][x].GetType() != typeof(EmptySpot)) continue;
                BoardList[y][x] = new Mine { XCoordinate = x, YCoordinate = y };
                mines--;
            }
        }
        private int CalculateMines()
        {
            Mines = (int)((RowSize * RowWidth) / Difficulty);
            MinesLeft = Mines;
            return Mines;
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
                        catch (Exception)
                        {
                            //ignore
                        }
                    }
                }
                spot.AdjacentMines = spot.ContainsMine ? -1 : mines;
                spot.MouseDown += SpotClicked;
            }));
        }

        public void NewGame()
        {
            FillBoard();
            NumberMines();
            GameBoard.MineList = BoardList;
            GameBoard.PopulateBoard();
            GameBoard.UpdateMines(Mines);
            GameBoard.FaceImage.Image = _faceImages["Smile"];
            GameBoard.FaceImage.MouseDown += (sender, args) =>
            {
                Time = 0;
                NewGame();
            };
            GameBoard.GameBoard.Enabled = true;
            _timer.Start();
        }

        public void SpotClicked(object spot, EventArgs e)
        {
            GameBoard.FaceImage.Image = _faceImages["Click"];
            var loc = (Spot)spot;
            var mevent = (MouseEventArgs)e;
            if (mevent.Button.Equals(MouseButtons.Right))
            {
                if (loc.GetType() == typeof(Mine))
                    MinesLeft--;
                Mines = loc.IsRightClicked ? Mines + 1 : Mines - 1;
                GameBoard.UpdateMines(Mines);
            }

            loc.SpotClicked(mevent);
            if (loc.GetType() == typeof(Mine) && mevent.Button.Equals(MouseButtons.Left) && !loc.IsRightClicked)
            {
                GameOver(false);
                return;
            }

            if (!loc.AdjacentMines.Equals(0) || !mevent.Button.Equals(MouseButtons.Left)) return;

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

        public void GameOver(bool didWin)
        {
            _timer.Stop();
            if (didWin)
            {
                BoardList.ForEach(row => row.ForEach(spot =>
                {
                    if (!spot.IsRightClicked)
                        spot.SpotClicked(new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));
                }));
                GameBoard.FaceImage.Image = _faceImages["Win"];
            }
            else
            {
                GameBoard.FaceImage.Image = _faceImages["Lose"];
            }
            GameBoard.GameBoard.Enabled = false;
        }
    }
}
