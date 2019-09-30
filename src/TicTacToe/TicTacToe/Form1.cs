using System;
using System.Linq;
using System.Windows.Forms;
using TicTacToe.Properties;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Local variable for the actual board
        /// </summary>
        private Board _board;

        /// <summary>
        /// Boolean for toggling whether the current move is for human or computer
        /// </summary>
        private bool _currentMoveIsHuman = true;

        /// <summary>
        /// Form constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.topInformationTextBox.Text = Resources.Form1_Press_Start_to_play_a_game;
            this.DisableAllCellButtons();
        }

        /// <summary>
        /// Start a game. Clear the board, display the UI and if the first move is human,
        /// let the user click a button, otherwise use Minimax to calculate computer move.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                var miniMaxTree = new MiniMaxTree(_board);
                var bestMove = miniMaxTree.ChildNodes.OrderBy(n => n.Score).Last();
                _board.Cells[bestMove.UpdatedCellIndex] = Board.Cell.Computer;
                this.Process();
            }
        }

        /// <summary>
        /// Main method for actually processing the board. Update the UI and check to see
        /// if someone has won, or we have a draw. If the game is not yet over, let the user
        /// press a button, or calculate the next computer move accordingly.
        /// </summary>
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
                // The game hasn't finished yet (noone has won and it isn't a draw), so invert
                // the current-move boolean.
                this._currentMoveIsHuman = !this._currentMoveIsHuman;
                if (this._currentMoveIsHuman)
                {
                    // If the next move is human, set the text box and do nothing (wait for
                    // user to actually press a button)
                    this.topInformationTextBox.Text = Resources.Form1_Humans_turn;
                }
                else
                {
                    // If the next move is computer, use Minimax to calculate the next move
                    // based on the current board
                    this.topInformationTextBox.Text = Resources.Form1_Computers_turn;
                    var miniMaxTree = new MiniMaxTree(_board);
                    var bestMove = miniMaxTree.ChildNodes.OrderBy(n => n.Score).Last();
                    _board.Cells[bestMove.UpdatedCellIndex] = Board.Cell.Computer;
                    this.Process();
                }
            }
        }

        /// <summary>
        /// Draw the board. Set the text for each cell, and disable any
        /// buttons that have already been set to a Nought or Cross
        /// </summary>
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

        /// <summary>
        /// Set the text (Nought or Cross) for a button, and then
        /// disable it so user cannot click it again during this game.
        /// </summary>
        /// <param name="button">Button to set</param>
        /// <param name="cell">Nought, Cross or Empty</param>
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

        /// <summary>
        /// Disable all 9 buttons. Called when game is over because either someone won
        /// or we reached a draw
        /// </summary>
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
