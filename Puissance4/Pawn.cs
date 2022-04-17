namespace Puissance4
{
    public class Pawn
    {
        public Color Color { get; set; }


        public Pawn(Color color, Board board)
        {
            Color = color;
        }

        public static bool AddPawn(Board board, Player player, int column)
        {
            column -= 1;
            while (column < Board.NbTiles && board.Tiles[column].Color is Color.Empty)
            {
                column += 7;
            }

            column -= 7;

            if (column > 0 && board.Tiles[column].Color is Color.Empty  )
            {
                board.Tiles[column] = new Pawn(player.Color, board);
                player.NbPawn -= 1;
                return true;
            }

            return false;
        }
    }
}