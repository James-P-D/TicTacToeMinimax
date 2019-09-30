using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToe
{
    public class MiniMaxTree
    {
        public MiniMaxTree(Board board)
        {
            // MiniMaxTree is only ever called for the Computer player, so presume next move
            // will always be computer.

            this.ChildNodes = new List<MiniMaxNode>();
            for (var i = 0; i < Board.BoardSize; i++)
            {
                if (board.Cells[i] == Board.Cell.Empty)
                {
                    var childBoard = board.Clone();
                    var miniMaxNode = new MiniMaxNode(childBoard, i, Board.Cell.Computer, 0);
                    ChildNodes.Add(miniMaxNode);
                }
            }
        }

        public MiniMaxNode GetBestMove()
        {
            int bestScore = this.ChildNodes.OrderBy(n => n.Score).Last().Score;
            var bestMoves = this.ChildNodes.Where(n => n.Score == bestScore).ToArray();
            Random random = new Random(DateTime.Now.Millisecond);

            return bestMoves[random.Next(bestMoves.Count())];
        }

        private List<MiniMaxNode> ChildNodes { get; }
    }
}
