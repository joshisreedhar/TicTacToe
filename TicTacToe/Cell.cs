using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace TicTacToe
{
    public class Cell
    {
        public event GridEventHandler CellOccupied;

        protected void OnCellOccupied()
        {
            CellOccupied(this, new GridEventArgs() { LastActedPlayer = this.OccupiedBy });
        }
       
        public Cell(string locationString)
        {
            LocatePosition(locationString);
        }

        private void LocatePosition(string positionString)
        {
             this.Position = Utils.GetpointRepresentationFromString(positionString);
        }

        public Player OccupiedBy { get; private set; }

        public void Occupy(Player player)
        {
            this.OccupiedBy = player;
            OnCellOccupied();
        }

        public Point Position
        {
            get;
            private set;
        }

        public bool IsFree
        {
            get
            {
                return this.OccupiedBy == null;
            }
        }

        internal void SetFree()
        {
            this.OccupiedBy = null;
        }
    }
}
