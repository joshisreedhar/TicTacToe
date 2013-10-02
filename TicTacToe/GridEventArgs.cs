using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    public class GridEventArgs : EventArgs
    {
        public Player LastActedPlayer { get; set; }
    }

    public delegate void GridEventHandler(object sender, GridEventArgs e);
}
