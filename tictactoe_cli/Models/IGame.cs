﻿using System;
using System.Collections.Generic;
using System.Text;

namespace tictactoe_cli.Models
{
    interface IGame
    {
        public string A1 { get; set; }
        public string B1 { get; set; }
        public string C1 { get; set; }
        public string A2 { get; set; }
        public string B2 { get; set; }
        public string C2 { get; set; }
        public string A3 { get; set; }
        public string B3 { get; set; }
        public string C3 { get; set; }

        public abstract void DisplayGameStatus();
        public abstract void WriteGameLog();
    }
}
