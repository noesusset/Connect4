namespace Puissance4
{
    public class Player
    { 
        public Color Color { get; set; }
        public int NbPawn { get; set; } = 30;
        public int Joker { get; set; } = 3; 


        public Player(int color)
        {
            Color = (Color) color;
        }
    }
}