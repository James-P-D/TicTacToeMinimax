using System;
using System.Linq;
using System.Windows.Forms;
using TicTacToe.Properties;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private Board _board;
        private bool _currentMoveIsHuman = true;

        public Form1()
        {
            InitializeComponent();
            this.topInformationTextBox.Text = Resources.Form1_Press_Start_to_play_a_game;
            this.DisableAllCellButtons();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            this.startButton.Enabled = false;
            this._board = new Board();
            /*
             * this.board = new Board(new Board.Cell[] {
                Board.Cell.Computer, Board.Cell.Empty, Board.Cell.Human,
                Board.Cell.Empty, Board.Cell.Human,Board.Cell.Empty,
                Board.Cell.Computer, Board.Cell.Computer, Board.Cell.Human
            });
            */
            this.DrawBoard();
            this.bottomInformationTextBox.Text = string.Empty;

            if (this._currentMoveIsHuman)
            {
                this.topInformationTextBox.Text = Resources.Form1_Humans_turn;
            }
            else
            {
                this.topInformationTextBox.Text= Resources.Form1_Computers_turn;
                MiniMaxTree miniMaxTree = new MiniMaxTree(_board);
                MiniMaxNode bestMove = miniMaxTree.ChildNodes.OrderBy(n => n.Score).Last();
                _board.Cells[bestMove.UpdatedCellIndex] = Board.Cell.Computer;
                this.Process();
            }
        }

        private void Process()
        {
            this.DrawBoard();
            if (this._board.GetState() == Board.State.ComputerWins)
            {
                this.bottomInformationTextBox.Text = Resources.Form1_Computer_wins;
                this.DisableAllCellButtons();
                this.topInformationTextBox.Text = Resources.Form1_Press_Start_to_play_a_game;
                this.startButton.Enabled = true;
                this._currentMoveIsHuman = !this._currentMoveIsHuman;
            }
            else if (this._board.GetState() == Board.State.HumanWins)
            {
                this.bottomInformationTextBox.Text = Resources.Form1_Human_wins;
                this.DisableAllCellButtons();
                this.topInformationTextBox.Text = Resources.Form1_Press_Start_to_play_a_game;
                this.startButton.Enabled = true;
                this._currentMoveIsHuman = !this._currentMoveIsHuman;
            }
            else if (this._board.GetState() == Board.State.Draw)
            {
                this.bottomInformationTextBox.Text = Resources.From1_Draw;
                this.DisableAllCellButtons();
                this.topInformationTextBox.Text = Resources.Form1_Press_Start_to_play_a_game;
                this.startButton.Enabled = true;
                this._currentMoveIsHuman = !this._currentMoveIsHuman;
            }
            else
            {
                this._currentMoveIsHuman = !this._currentMoveIsHuman;
                if (this._currentMoveIsHuman)
                {
                    this.topInformationTextBox.Text = Resources.Form1_Humans_turn;
                }
                else
                {
                    this.topInformationTextBox.Text = Resources.Form1_Computers_turn;
                    MiniMaxTree miniMaxTree = new MiniMaxTree(_board);
                    MiniMaxNode bestMove = miniMaxTree.ChildNodes.OrderBy(n => n.Score).Last();
                    _board.Cells[bestMove.UpdatedCellIndex] = Board.Cell.Computer;
                    this.Process();
                }
            }
        }

        private void DrawBoard()
        {
            SetButtonCell(topLeftButton, _board.Cells[0]);
            SetButtonCell(topCenterButton, _board.Cells[1]);
            SetButtonCell(topRightButton, _board.Cells[2]);

            SetButtonCell(middleLeftButton, _board.Cells[3]);
            SetButtonCell(middleCenterButton, _board.Cells[4]);
            SetButtonCell(middleRightButton, _board.Cells[5]);

            SetButtonCell(bottomLeftButton, _board.Cells[6]);
            SetButtonCell(bottomCenterButton, _board.Cells[7]);
            SetButtonCell(bottomRightButton, _board.Cells[8]);
        }

        private void SetButtonCell(Button button, Board.Cell cell)
        {
            switch (cell)
            {
                case Board.Cell.Computer:
                    {
                        button.Text = Board.CellToString(cell);
                        button.Enabled = false;
                        break;
                    }
                case Board.Cell.Human:
                    {
                        button.Text = Board.CellToString(cell);
                        button.Enabled = false; break;
                    }
                case Board.Cell.Empty:
                    {
                        button.Text = Board.CellToString(cell);
                        button.Enabled = true;
                        break;
                    }
            }
        }

        private void EnableAllCellButtons()
        {
            topLeftButton.Enabled = true;
            topCenterButton.Enabled = true;
            topRightButton.Enabled = true;

            middleLeftButton.Enabled = true;
            middleCenterButton.Enabled = true;
            middleRightButton.Enabled = true;

            bottomLeftButton.Enabled = true;
            bottomCenterButton.Enabled = true;
            bottomRightButton.Enabled = true;
        }

        private void DisableAllCellButtons()
        {
            topLeftButton.Enabled = false;
            topCenterButton.Enabled = false;
            topRightButton.Enabled = false;

            middleLeftButton.Enabled = false;
            middleCenterButton.Enabled = false;
            middleRightButton.Enabled = false;

            bottomLeftButton.Enabled = false;
            bottomCenterButton.Enabled = false;
            bottomRightButton.Enabled = false;
        }

        #region Cell Button Clicks

        private void TopLeftButton_Click(object sender, EventArgs e)
        {
            this._board.Cells[0] = Board.Cell.Human;
            this.Process();
        }

        private void TopCenterButton_Click(object sender, EventArgs e)
        {
            this._board.Cells[1] = Board.Cell.Human;
            this.Process();
        }

        private void TopRightButton_Click(object sender, EventArgs e)
        {
            this._board.Cells[2] = Board.Cell.Human;
            this.Process();
        }

        private void MiddleLeftButton_Click(object sender, EventArgs e)
        {
            this._board.Cells[3] = Board.Cell.Human;
            this.Process();
        }

        private void MiddleCenterButton_Click(object sender, EventArgs e)
        {
            this._board.Cells[4] = Board.Cell.Human;
            this.Process();
        }

        private void MiddleRightButton_Click(object sender, EventArgs e)
        {
            this._board.Cells[5] = Board.Cell.Human;
            this.Process();
        }

        private void BottomLeftButton_Click(object sender, EventArgs e)
        {
            this._board.Cells[6] = Board.Cell.Human;
            this.Process();
        }

        private void BottomCenterButton_Click(object sender, EventArgs e)
        {
            this._board.Cells[7] = Board.Cell.Human;
            this.Process();
        }

        private void BottomRightButton_Click(object sender, EventArgs e)
        {
            this._board.Cells[8] = Board.Cell.Human;
            this.Process();
        }

        #endregion 
    }
}
