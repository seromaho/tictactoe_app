using System;
using System.Collections.Generic;
using System.Text;

namespace tictactoe_cli.Models
{
    interface IGame
    {
        public string[] A1 { get; set; }
        public string[] B1 { get; set; }
        public string[] C1 { get; set; }
        public string[] A2 { get; set; }
        public string[] B2 { get; set; }
        public string[] C2 { get; set; }
        public string[] A3 { get; set; }
        public string[] B3 { get; set; }
        public string[] C3 { get; set; }
        public bool GameIsOver { get; set; }
        public IPlayer Player_1 { get; set; }
        public IPlayer Player_2 { get; set; }

        public abstract void DisplayGameBoard();
        public abstract void DisplayGameStatus();
        public abstract void DisplayGameStatus(IPlayer player);
        public abstract void DisplayPlayerScore(IPlayer player_1, IPlayer player_2);
        public abstract void ResetGameBoard();
        public abstract void TakeAction(IPlayer player);
        public abstract void CheckIfGameIsDraw();
        public abstract void CheckIfGameIsWon(IPlayer player);
        public abstract void CheckIfGameIsOver(IPlayer player);
        public abstract void WriteGameLog();
    }
}
