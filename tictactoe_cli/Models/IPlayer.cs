using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace tictactoe_cli.Models
{
    interface IPlayer
    {
        public string Name { get; set; }
        public Bitmap Avatar { get; set; }
        public string Symbol { get; set; }

    }
}
