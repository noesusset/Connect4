namespace Puissance4
{
    public class Pawn
    {
        public Color Color { get; set; }


        public Pawn(Color color, Board board)
        {
            Color = color;
        }

        public bool AddPawn(Board board, Player player, int column)
        {
            for (int i = column; i < Board.NbTiles; i+=7)
            {
                if (board.Tiles[i].Color is Color.Empty)
                {
                    board.Tiles[i] = new Pawn(player.Color, board);
                }
            }

            return false;
        }
    }
}