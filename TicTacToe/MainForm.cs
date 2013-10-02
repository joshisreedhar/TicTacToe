using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using TicTacToe.Extensions;

namespace TicTacToe
{
    public partial class MainForm : Form
    {
        private Player _currentPlayer;
        private Grid _grid;
        private Cell _actedCell;
        private Player _computer;
        private Player _human;
        private Dictionary<Point, Button> _cellMap;

        public MainForm()
        {
            InitializeComponent();
            _cellMap = new Dictionary<Point, Button>();
            _computer = new Player() { Icon = "O", Name = "Computer" };
            _human = new Player() { Icon = "X", Name = "Human" };
            InitializeGrid();
            MapGridPoistionToControls();
            StartGame();
        }

        private void MapGridPoistionToControls()
        {
            foreach (Control c in this.panel1.Controls)
            {
                if (c is Button)
                {
                    Button mappedControl = c as Button;
                    _cellMap.Add(mappedControl.GetCoordinates(), mappedControl);
                }
            }
        }

        private void InitializeGrid()
        {
            _grid = new Grid();
            _grid.GridFilled += GridFilled;
            _grid.GameComplete += GameComplete;
        }

        public void GridFilled(object sender, GridEventArgs e)
        {
            DialogResult messageresult = MessageBox.Show("Game Over! Play Again", "Tic Tac Toe", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (messageresult == System.Windows.Forms.DialogResult.No)
            {
                this.Close();
                return;
            }
            ResetGrid();
        }

        public void GameComplete(object sender, GridEventArgs e)
        {
            DialogResult messageresult = MessageBox.Show(string.Format("{0} won! Play Again", e.LastActedPlayer.Name), "Tic Tac Toe", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (messageresult == System.Windows.Forms.DialogResult.No)
            {
                this.Close();
                return;
            }
            ResetGrid();
        }

        private void StartGame()
        {
            InitializePlayers();
            NextMove();
        }

        private void ResetGrid()
        {
            ClearGridText();
            EnableGrid();
            _grid.Refresh();
        }

        private void InitializePlayers()
        {
            _currentPlayer = _human;
        }

        private void EnableGrid()
        {
            Cell_00.Enabled = true;
            Cell_01.Enabled = true;
            Cell_02.Enabled = true;
            Cell_10.Enabled = true;
            Cell_11.Enabled = true;
            Cell_12.Enabled = true;
            Cell_20.Enabled = true;
            Cell_21.Enabled = true;
            Cell_22.Enabled = true;
        }

        private void ClearGridText()
        {
            Cell_00.Text = string.Empty;
            Cell_01.Text = string.Empty;
            Cell_02.Text = string.Empty;
            Cell_10.Text = string.Empty;
            Cell_11.Text = string.Empty;
            Cell_12.Text = string.Empty;
            Cell_20.Text = string.Empty;
            Cell_21.Text = string.Empty;
            Cell_22.Text = string.Empty;
        }

        protected void HandleAction(object sender, EventArgs args)
        {
            if (_currentPlayer.Equals(_human))
            {
                Point clickedPosition = _cellMap.Where(v => v.Value == sender).Select(k => k.Key).SingleOrDefault();
                if (clickedPosition != null)
                {
                    SelectCell(clickedPosition);
                }
                TogglePlayer();
                NextMove();
            }
        }

        private void AdjustDisplay(Button clickedButton)
        {
            string cellPosition = clickedButton.Name.Split('_')[1];
            clickedButton.Text = _currentPlayer.Icon;
            clickedButton.Enabled = false;
        }

        private void TogglePlayer()
        {
            if (_currentPlayer.Equals(_computer))
            {
                _currentPlayer = _human;
            }
            else
            {
                _currentPlayer = _computer;
            }
        }

        private void NextMove()
        {
            Point selectedCellPosition = new Point(-1, -1); ;
            if (_currentPlayer == _computer)
            {
                Cell computerCompletionCell = _grid.GetSequenceCompletionCellFor(_computer);
                if (computerCompletionCell != null)
                {
                    selectedCellPosition = computerCompletionCell.Position;
                }
                else
                {
                    Cell completionCell = _grid.GetSequenceCompletionCellFor(_human);
                    bool playerAboutTowin = completionCell != null;
                    if (playerAboutTowin)
                    {
                        selectedCellPosition = completionCell.Position;
                    }
                    else
                    {
                        if (_grid.GetFreeCells().Count() > 0)
                        {
                            selectedCellPosition = _grid.GetFreeCells().First().Position;
                        }
                    }
                }
                if (selectedCellPosition.X >= 0)
                {
                    SelectCell(selectedCellPosition);
                    TogglePlayer();
                }
            }

        }

        private void SelectCell(Point clickedPosition)
        {
            Button buttonClicked = _cellMap[clickedPosition];
            AdjustDisplay(buttonClicked);
            _actedCell = _grid.GetCell(clickedPosition);
            AssignPlayerToCell();
        }

        private void AssignPlayerToCell()
        {
            this._actedCell.Occupy(this._currentPlayer);
        }
    }
}