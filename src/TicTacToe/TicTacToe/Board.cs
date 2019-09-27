using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Board
    {
        public enum Cell { Computer, Human, Empty };
        public enum State { ComputerWins, HumanWins, Draw, Incomplete };
        public const int BOARD_WIDTH = 3;
        public const int BOARD_HEIGHT = 3;
        public const int BOARD_SIZE = BOARD_WIDTH * BOARD_HEIGHT;

        public Board()
        {
            this.Cells = new Cell[BOARD_SIZE];
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                this.Cells[i] = Cell.Empty;
            }
        }

        public Board(Cell[] initialCells)
        {
            if (initialCells.Length != BOARD_SIZE)
            {
                throw new Exception("Board size does not match");
            }
            this.Cells = new Cell[BOARD_SIZE];
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                this.Cells[i] = initialCells[i];
            }
        }

        public bool IsMatch(Board otherBoard)
        {
            if (otherBoard.Cells.Length != BOARD_SIZE)
            {
                throw new Exception("Board size does not match");
            }

            for (int i = 0; i < BOARD_SIZE; i++)
            {
                if (this.Cells[i] != otherBoard.Cells[i])
                {
                    return false;
                }
            }

            return true;
        }

        public Cell[] Cells { get; set; }

        public void Output()
        {
            Console.WriteLine(" {0} | {1} | {2} ", CellToString(this.Cells[0]), CellToString(this.Cells[1]), CellToString(this.Cells[2]));
            Console.WriteLine("-----+-----+-----");
            Console.WriteLine(" {0} | {1} | {2} ", CellToString(this.Cells[3]), CellToString(this.Cells[4]), CellToString(this.Cells[5]));
            Console.WriteLine("-----+-----+-----");
            Console.WriteLine(" {0} | {1} | {2} ", CellToString(this.Cells[6]), CellToString(this.Cells[7]), CellToString(this.Cells[8]));
        }

        public State GetState()
        {
            // Check Rows
            if ((this.Cells[0] == this.Cells[1]) && (this.Cells[1] == this.Cells[2]))
            {
                if (this.Cells[0] == Cell.Computer)
                {
                    return State.ComputerWins;
                }
                else if (this.Cells[0] == Cell.Human)
                {
                    return State.HumanWins;
                }
            }
            if ((this.Cells[3] == this.Cells[4]) && (this.Cells[4] == this.Cells[5]))
            {
                if (this.Cells[3] == Cell.Computer)
                {
                    return State.ComputerWins;
                }
                else if (this.Cells[3] == Cell.Human)
                {
                    return State.HumanWins;
                }
            }
            if ((this.Cells[6] == this.Cells[7]) && (this.Cells[7] == this.Cells[8]))
            {
                if (this.Cells[6] == Cell.Computer)
                {
                    return State.ComputerWins;
                }
                else if (this.Cells[6] == Cell.Human)
                {
                    return State.HumanWins;
                }
            }

            // Check Columns
            if ((this.Cells[0] == this.Cells[3]) && (this.Cells[3] == this.Cells[6]))
            {
                if (this.Cells[0] == Cell.Computer)
                {
                    return State.ComputerWins;
                }
                else if (this.Cells[0] == Cell.Human)
                {
                    return State.HumanWins;
                }
            }
            if ((this.Cells[1] == this.Cells[4]) && (this.Cells[4] == this.Cells[7]))
            {
                if (this.Cells[1] == Cell.Computer)
                {
                    return State.ComputerWins;
                }
                else if (this.Cells[1] == Cell.Human)
                {
                    return State.HumanWins;
                }
            }
            if ((this.Cells[2] == this.Cells[5]) && (this.Cells[5] == this.Cells[8]))
            {
                if (this.Cells[2] == Cell.Computer)
                {
                    return State.ComputerWins;
                }
                else if (this.Cells[2] == Cell.Human)
                {
                    return State.HumanWins;
                }
            }

            // Check diagonals
            if ((this.Cells[0] == this.Cells[4]) && (this.Cells[4] == this.Cells[8]))
            {
                if (this.Cells[0] == Cell.Computer)
                {
                    return State.ComputerWins;
                }
                else if (this.Cells[0] == Cell.Human)
                {
                    return State.HumanWins;
                }
            }
            if ((this.Cells[2] == this.Cells[4]) && (this.Cells[4] == this.Cells[6]))
            {
                if (this.Cells[2] == Cell.Computer)
                {
                    return State.ComputerWins;
                }
                else if (this.Cells[2] == Cell.Human)
                {
                    return State.HumanWins;
                }
            }

            if (Cells.Any(c => c == Cell.Empty))
            {
                // If there are still some empty cells, and the Computer and Human still
                // haven't won, then the game is incomplete so far.
                return State.Incomplete;
            }
            else
            {
                // If there is no winner, and but no empty spaces, then its a draw
                return State.Draw;
            }
        }

        public static string CellToString(Cell cell)
        {
            switch (cell)
            {
                case Cell.Computer: return "X";
                case Cell.Human: return "0";
                default: return " ";
            }
        }

        public Board Clone()
        {
            return new Board(this.Cells);
        }
    }
}
