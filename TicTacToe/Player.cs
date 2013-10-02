using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    public class Player
    {
        public Player()
        {
            this.SelectedCells = new List<Cell>();
        }

        public string Icon { get; set; }

        public List<Cell> SelectedCells { get; private set; }

        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return this.Name.Equals(((Player)obj).Name);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        public void AddCell(Cell selectedCell)
        {
            this.SelectedCells.Add(selectedCell);
        }      
    }
}
