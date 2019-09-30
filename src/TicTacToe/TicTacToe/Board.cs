using System;
using System.Linq;

namespace TicTacToe
{
    public class Board
    {
        /// <summary>
        /// Cell enum. Each cell is either Computer, Human or currently empty
        /// </summary>
        public enum Cell { Computer, Human, Empty };

        /// <summary>
        /// The board can be in four possible states. Either someone has won,
        /// it's a draw, or the game is incomplete
        /// </summary>
        public enum State { ComputerWins, HumanWins, Draw, Incomplete };

        /// <summary>
        /// Board width
        /// </summary>
        public const int BoardWidth = 3;

        /// <summary>
        /// Board height
        /// </summary>
        public const int BoardHeight = 3;

        /// <summary>
        /// Board size (height * width)
        /// </summary>
        public const int BoardSize = BoardWidth * BoardHeight;

        /// <summary>
        /// Actual Cell array. Will be BoardSize in length.
        /// </summary>
        public Cell[] Cells { get; set; }

        /// <summary>
        /// Board constructor. Initialise all cells to empty.
        /// </summary>
        public Board()
        {
            this.Cells = new Cell[BoardSize];
            for (var i = 0; i < BoardSize; i++)
            {
                this.Cells[i] = Cell.Empty;
            }
        }

        /// <summary>
        /// Board constructor. Initialise cells to input parameter.
        /// Used for cloning boards.
        /// </summary>
        /// <param name="initialCells">Array of Cells</param>
        public Board(Cell[] initialCells)
        {
            if (initialCells.Length != BoardSize)
            {
                throw new Exception("Board size does not match");
            }

            this.Cells = new Cell[BoardSize];
            for (var i = 0; i < BoardSize; i++)
            {
                this.Cells[i] = initialCells[i];
            }
        }
        
        /// <summary>
        /// Output the current board. Used for debugging online.
        /// </summary>
        public void Output()
        {
            Console.WriteLine(" {0} | {1} | {2} ", CellToString(this.Cells[0]), CellToString(this.Cells[1]), CellToString(this.Cells[2]));
            Console.WriteLine("-----+-----+-----");
            Console.WriteLine(" {0} | {1} | {2} ", CellToString(this.Cells[3]), CellToString(this.Cells[4]), CellToString(this.Cells[5]));
            Console.WriteLine("-----+-----+-----");
            Console.WriteLine(" {0} | {1} | {2} ", CellToString(this.Cells[6]), CellToString(this.Cells[7]), CellToString(this.Cells[8]));
        }

        /// <summary>
        /// Get the current state (human won, computer won, draw, or incomplete)
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Convert cell to a string (Computer is 'X', Human is '0')
        /// </summary>
        /// <param name="cell">Individual cell</param>
        /// <returns>String for Cell ('X', '0' or ' ')</returns>
        public static string CellToString(Cell cell)
        {
            switch (cell)
            {
                case Cell.Computer: return "X";
                case Cell.Human: return "0";
                default: return " ";
            }
        }

        /// <summary>
        /// Make a copy of the board
        /// </summary>
        /// <returns></returns>
        public Board Clone()
        {
            return new Board(this.Cells);
        }
    }
}
