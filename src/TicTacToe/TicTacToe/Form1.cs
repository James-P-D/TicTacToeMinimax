using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private Board board;
        private bool CurrentMoveIsHuman = true;

        public Form1()
        {
            InitializeComponent();
            this.topInformationTextBox.Text = "Press Start to play a game";
            this.DisableAllCellButtons();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            this.startButton.Enabled = false;
            this.board = new Board();
            /*
             * this.board = new Board(new Board.Cell[] {
                Board.Cell.Computer, Board.Cell.Empty, Board.Cell.Human,
                Board.Cell.Empty, Board.Cell.Human,Board.Cell.Empty,
                Board.Cell.Computer, Board.Cell.Computer, Board.Cell.Human
            });
            */
            this.DrawBoard();
            this.bottomInformationTextBox.Text = string.Empty;

            if (this.CurrentMoveIsHuman)
            {
                this.topInformationTextBox.Text = "Human's turn";
            }
            else
            {
                this.topInformationTextBox.Text="Computer's turn";
                MiniMaxTree miniMaxTree = new MiniMaxTree(board);
                MiniMaxNode bestMove = miniMaxTree.ChildNodes.OrderBy(n => n.Score).Last();
                board.Cells[bestMove.UpdatedCellIndex] = Board.Cell.Computer;
                this.Process();
            }
        }

        private void Process()
        {
            this.DrawBoard();
            if (this.board.GetState() == Board.State.ComputerWins)
            {
                this.bottomInformationTextBox.Text = "Computer Wins!";
                this.DisableAllCellButtons();
                this.topInformationTextBox.Text = "Press Start to play a game";
                this.startButton.Enabled = true;
                this.CurrentMoveIsHuman = !this.CurrentMoveIsHuman;
            }
            else if (this.board.GetState() == Board.State.HumanWins)
            {
                this.bottomInformationTextBox.Text = "Human Wins!";
                this.DisableAllCellButtons();
                this.topInformationTextBox.Text = "Press Start to play a game";
                this.startButton.Enabled = true;
                this.CurrentMoveIsHuman = !this.CurrentMoveIsHuman;
            }
            else if (this.board.GetState() == Board.State.Draw)
            {
                this.bottomInformationTextBox.Text = "Draw!";
                this.DisableAllCellButtons();
                this.topInformationTextBox.Text = "Press Start to play a game";
                this.startButton.Enabled = true;
                this.CurrentMoveIsHuman = !this.CurrentMoveIsHuman;
            }
            else
            {
                this.CurrentMoveIsHuman = !this.CurrentMoveIsHuman;
                if (this.CurrentMoveIsHuman)
                {
                    this.topInformationTextBox.Text = "Human's turn";
                }
                else
                {
                    this.topInformationTextBox.Text = "Computer's turn";
                    MiniMaxTree miniMaxTree = new MiniMaxTree(board);
                    MiniMaxNode bestMove = miniMaxTree.ChildNodes.OrderBy(n => n.Score).Last();
                    board.Cells[bestMove.UpdatedCellIndex] = Board.Cell.Computer;
                    this.Process();
                }
            }
        }

        private void DrawBoard()
        {
            SetButtonCell(topLeftButton, board.Cells[0]);
            SetButtonCell(topCenterButton, board.Cells[1]);
            SetButtonCell(topRightButton, board.Cells[2]);

            SetButtonCell(middleLeftButton, board.Cells[3]);
            SetButtonCell(middleCenterButton, board.Cells[4]);
            SetButtonCell(middleRightButton, board.Cells[5]);

            SetButtonCell(bottomLeftButton, board.Cells[6]);
            SetButtonCell(bottomCenterButton, board.Cells[7]);
            SetButtonCell(bottomRightButton, board.Cells[8]);
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
            this.board.Cells[0] = Board.Cell.Human;
            this.Process();
        }

        private void TopCenterButton_Click(object sender, EventArgs e)
        {
            this.board.Cells[1] = Board.Cell.Human;
            this.Process();
        }

        private void TopRightButton_Click(object sender, EventArgs e)
        {
            this.board.Cells[2] = Board.Cell.Human;
            this.Process();
        }

        private void MiddleLeftButton_Click(object sender, EventArgs e)
        {
            this.board.Cells[3] = Board.Cell.Human;
            this.Process();
        }

        private void MiddleCenterButton_Click(object sender, EventArgs e)
        {
            this.board.Cells[4] = Board.Cell.Human;
            this.Process();
        }

        private void MiddleRightButton_Click(object sender, EventArgs e)
        {
            this.board.Cells[5] = Board.Cell.Human;
            this.Process();
        }

        private void BottomLeftButton_Click(object sender, EventArgs e)
        {
            this.board.Cells[6] = Board.Cell.Human;
            this.Process();
        }

        private void BottomCenterButton_Click(object sender, EventArgs e)
        {
            this.board.Cells[7] = Board.Cell.Human;
            this.Process();
        }

        private void BottomRightButton_Click(object sender, EventArgs e)
        {
            this.board.Cells[8] = Board.Cell.Human;
            this.Process();
        }

        #endregion 
    }
}
