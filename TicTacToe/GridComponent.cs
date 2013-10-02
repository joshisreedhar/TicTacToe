using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToe
{
    public class GridProjection
    {
        public List<Cell> Cells { get; protected set; }

        public int Index { get; protected set; }

        public bool IsFilled(Player player)
        {
            return this.Cells.Where(rc => rc.OccupiedBy == player).Count() == 3;
        }

        public Cell GetSequenceCompletionCellFor(Player player)
        {
            Cell sequenceCompletionStep = null;
            if (this.Cells.Where(c => c.OccupiedBy == player).Count() == 2 && this.Cells.Where(c => c.IsFree).Count() > 0)
            {
                sequenceCompletionStep = this.Cells.Where(c => c.IsFree).SingleOrDefault();
            }
            return sequenceCompletionStep;
        }
    }
}
