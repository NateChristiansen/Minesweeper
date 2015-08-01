using System;
using System.Windows.Forms;

namespace Minesweeper
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var settings = new GameSettings();
            Application.Run(settings);
            new GameItems.Game(settings.Rows, settings.Columns, settings.Difficulty);
        }
    }
}
