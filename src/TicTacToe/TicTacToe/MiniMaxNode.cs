using System.Collections.Generic;
using System.Linq;

namespace TicTacToe
{
    public class MiniMaxNode
    {
        /// <summary>
        /// Calculate the node
        /// </summary>
        /// <param name="board">Current board state</param>
        /// <param name="currentPosition">Position in board to set</param>
        /// <param name="currentMove">Current move (either Computer or Human)</param>
        /// <param name="depth">Current depth. Used for choosing earliest winning/losing move</param>
        public MiniMaxNode(Board board, int currentPosition, Board.Cell currentMove, int depth)
        {
            // Create the child nodes list
            this.ChildNodes = new List<MiniMaxNode>();

            // Save the index to the cell we are updating. This way we always know what move
            // this node corresponds to
            this.UpdatedCellIndex = currentPosition;
            // Set the cell to Computer/Human
            board.Cells[this.UpdatedCellIndex] = currentMove;

            if (board.GetState() == Board.State.ComputerWins)
            {
                // If Computer wins, give it a high score, but deduct the current depth
                // (So that quick wins have higher scores than lengthy wins)
                this.Score = 10 - depth;
            }
            else if (board.GetState() == Board.State.HumanWins)
            {
                // If Human wins, give it a low score, but add the current depth
                // (So that quick loses have lower scores than lengthy loses)
                this.Score = -10 + depth;
            }
            else if (board.GetState() == Board.State.Draw)
            {
                // If it's a draw, just set to neutral
                this.Score = 0;
            }
            else
            {
                // Invert the player
                var nextMove = currentMove == Board.Cell.Computer ? Board.Cell.Human : Board.Cell.Computer;

                for (var i = 0; i < Board.BoardSize; i++)
                {
                    // For each empty cell
                    if (board.Cells[i] == Board.Cell.Empty)
                    {
                        // Clone the board
                        var childBoard = board.Clone();
                        // Calculate child moves
                        var miniMaxNode = new MiniMaxNode(childBoard, i, nextMove, depth + 1);
                        ChildNodes.Add(miniMaxNode);
                    }
                }

                if (currentMove == Board.Cell.Computer)
                {
                    // Since this isn't a terminal node, give the current node the best score
                    // amongst the child nodes..
                    this.Score = this.ChildNodes.OrderBy(n => n.Score).First().Score;
                }
                else
                {
                    // ..or for Human moves, give it the worst score amongst the children
                    this.Score = this.ChildNodes.OrderBy(n => n.Score).Last().Score;
                }
            }
        }

        /// <summary>
        /// Child nodes
        /// </summary>
        public List<MiniMaxNode> ChildNodes { get; }

        /// <summary>
        /// Current score. Positive for wins, negative for losses.
        /// </summary>
        public int Score { get; }

        /// <summary>
        /// Index of cell that has been updated
        /// </summary>
        public int UpdatedCellIndex { get; }
    }
}