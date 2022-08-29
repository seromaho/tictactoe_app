using System.Drawing;

namespace tictactoe_cli.Models
{
    interface IPlayer
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public Bitmap Avatar { get; set; }
        public int NumGamesWon { get; set; }
    }
}
