using System.Collections.Generic;
using System.Linq;

namespace TicTacToe
{
    public class MiniMaxNode
    {
        public MiniMaxNode(Board board, int currentPosition, Board.Cell currentMove, int depth)
        {
            this.ChildNodes = new List<MiniMaxNode>();
            this.UpdatedCellIndex = currentPosition;
            board.Cells[this.UpdatedCellIndex] = currentMove;

            if (board.GetState() == Board.State.ComputerWins)
            {
                this.Score = 10 - depth;
            }
            else if (board.GetState() == Board.State.HumanWins)
            {
                this.Score = -10 + depth;
            }
            else if (board.GetState() == Board.State.Draw)
            {
                this.Score = 0;
            }
            else
            {
                // Invert the player
                var nextMove = currentMove == Board.Cell.Computer ? Board.Cell.Human : Board.Cell.Computer;

                for (var i = 0; i < Board.BoardSize; i++)
                {
                    if (board.Cells[i] == Board.Cell.Empty)
                    {
                        var childBoard = board.Clone();
                        var miniMaxNode = new MiniMaxNode(childBoard, i, nextMove, depth + 1);
                        ChildNodes.Add(miniMaxNode);
                    }
                }

                if (currentMove == Board.Cell.Computer)
                {
                    this.Score = this.ChildNodes.OrderBy(n => n.Score).Last().Score;
                }
                else
                {
                    this.Score = this.ChildNodes.OrderBy(n => n.Score).First().Score;
                }
            }
        }

        public List<MiniMaxNode> ChildNodes { get; }

        public int Score { get; }

        public int UpdatedCellIndex { get; }
    }
}