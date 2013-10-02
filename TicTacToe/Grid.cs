using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TicTacToe
{
    public class Grid
    {
        public const int LIMIT = 2;

        public event GridEventHandler GridFilled;
        public event GridEventHandler GameComplete;

        protected void OnGridFilled(Player lastPlayer)
        {
            if (this.GridFilled != null)
            {
                GridFilled(this, new GridEventArgs() { LastActedPlayer = lastPlayer});
            }
        }

        public Grid()
        {
            this.Cells = new List<Cell>();
            for (int rowIndex = 0; rowIndex <= LIMIT; rowIndex++)
            {
                for (int colIndex = 0; colIndex <= LIMIT; colIndex++)
                {
                    Cell cell = new Cell(string.Format("{0}{1}", rowIndex, colIndex));                   
                    cell.CellOccupied += CheckIfPlayerWon;
                    cell.CellOccupied += CheckIfGridFilled;
                    this.Cells.Add(cell);
                }
            }
        }

        protected void CheckIfGridFilled(object sender, GridEventArgs e)
        {
            if (this.Cells.Where(c => c.IsFree).Count() == 0)
            {
                OnGridFilled(e.LastActedPlayer);
            }
        }

        protected void CheckIfPlayerWon(object sender, GridEventArgs e)
        {
            foreach (GridProjection projection in this.GetProjections())
            {
                if (projection.IsFilled(e.LastActedPlayer))
                {
                    OnGameComplete(e.LastActedPlayer);
                    break;
                }
            }
        }

        private void OnGameComplete(Player player)
        {
            if (GameComplete != null)
            {
                GameComplete(this, new GridEventArgs() { LastActedPlayer = player });
            }
        }

        public List<Cell> Cells { get; private set; }

        public Cell GetCell(Point position)
        {
            if (IsInvalidPointOnGrid(position))
            {
                throw new ArgumentException("Invalid Position");
            }
            return this.Cells.Where(c => c.Position == position).SingleOrDefault();
        }

        private bool IsInvalidPointOnGrid(Point position)
        {
            return (position.X < 0 && position.X > LIMIT) && (position.Y < 0 && position.Y > LIMIT);
        }

        private Row GetRow(int rowIndex)
        {
            return new Row(rowIndex, this);
        }

        private Column GetColumn(int colIndex)
        {
            return new Column(colIndex, this);
        }

        private Diagnol GetDiagnol(int startCellRowIndex)
        {
            return new Diagnol(startCellRowIndex, this);
        }

        private bool IsOnDiagnol(Cell cell)
        {
            return (cell.Position.X + cell.Position.Y == 0 || cell.Position.X + cell.Position.Y == LIMIT || cell.Position.X + cell.Position.Y == 2 * LIMIT);
        }
        
        public Cell GetSequenceCompletionCellFor(Player player)
        {
            Cell completionCell = null;
            foreach (GridProjection projection in GetProjections())
            {
                Cell projectionCompletionCell = projection.GetSequenceCompletionCellFor(player);
                if (projectionCompletionCell != null)
                {
                    completionCell = projectionCompletionCell;
                    break;
                }
            }
            return completionCell;
        }

        private List<GridProjection> GetProjections()
        {
            List<GridProjection> projections = new List<GridProjection>();
            for (int index = 0; index <= LIMIT; index++)
            {
                projections.Add(GetRow(index));
                projections.Add(GetColumn(index));
            }

            projections.Add(GetDiagnol(0));
            projections.Add(GetDiagnol(2));

            return projections;
        }

        public List<Cell> GetFreeCells()
        {
            return this.Cells.Where(c => c.IsFree).ToList();
        }

        public void Refresh()
        {
            foreach (Cell cell in this.Cells)
            {
                cell.SetFree();
            }
        }
    }

    public class Row : GridProjection
    {
        public Row(int rowIndex, Grid grid)
        {
            this.Index = rowIndex;
            this.Cells = new List<Cell>();
            this.Cells.AddRange(grid.Cells.Where(c => c.Position.Y == rowIndex));
        }
       
    }

    public class Column : GridProjection
    {
        public Column(int colIndex, Grid grid)
        {
            this.Index = colIndex;
            this.Cells = new List<Cell>();
            this.Cells.AddRange(grid.Cells.Where(c => c.Position.X == colIndex));
        }
    }

    public class Diagnol:GridProjection
    {
        public Diagnol(int startColIndex, Grid grid)
        {
            if(startColIndex != 0 && startColIndex != 2)
            {
                throw new ArgumentException("Invalid Diagnol");
            }
            this.Index = startColIndex;
            this.Cells = new List<Cell>();
            if(startColIndex == 0)
            {
                this.Cells.AddRange(grid.Cells.Where(dc => ((dc.Position == new Point(0, 0)) || (dc.Position == new Point(1, 1)) || (dc.Position == new Point(2, 2))))); 
            }
            else
            {
                this.Cells.AddRange(grid.Cells.Where(dc => ((dc.Position == new Point(2, 0)) || (dc.Position == new Point(1, 1)) || (dc.Position == new Point(0, 2))))); 
            }
        }
        
    }
}
