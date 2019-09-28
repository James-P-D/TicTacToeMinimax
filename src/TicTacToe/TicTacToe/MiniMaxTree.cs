using System.Collections.Generic;

namespace TicTacToe
{
    public class MiniMaxTree
    {
        public MiniMaxTree(Board board)
        {
            // MiniMaxTree is only ever called for the Computer player, so presume next move
            // will always be computer.

            this.ChildNodes = new List<MiniMaxNode>();
            for (int i = 0; i < Board.BoardSize; i++)
            {
                if (board.Cells[i] == Board.Cell.Empty)
                {
                    Board childBoard = board.Clone();
                    MiniMaxNode miniMaxNode = new MiniMaxNode(childBoard, i, Board.Cell.Computer, 0);
                    ChildNodes.Add(miniMaxNode);
                }
            }
        }

        public List<MiniMaxNode> ChildNodes { get; private set; }
    }
}
