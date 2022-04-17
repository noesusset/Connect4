using System;

namespace Puissance4
{
    public class Board
    {
        public const int BoardSize = 7;
        public const int NbTiles = 49;
        private Orientation Orientation { get; set; } = Orientation.North;

        public Pawn[] Tiles { get; set; } = new Pawn[NbTiles];

        public Board()
        {
            for (int i = 0; i < Tiles.Length; i++)
            {
                Tiles[i] = new Pawn(Color.Empty, this);
            }
        }


        public void Print()
        { 
            for (int i = 0; i < BoardSize; i++)
            {
                PrintLine(i);
                auxPrintNumbers(i*BoardSize);

            }
            PrintLine(BoardSize);
        }
        
        public void PrintLine(int i) 
        { 
            if (i == 0) 
            {
                Console.Write("╔═══");
                for (int j = 0; j < 6 ; j++)
                {
                    Console.Write("╦═══");
                }
                Console.WriteLine("╗");
            }
            
            else if (i == BoardSize) 
            { 
                Console.Write("╚═══");
                for (int j = 0; j < 6 ; j++) 
                { 
                    Console.Write("╩═══");
                }
                Console.WriteLine("╝");
            }
            else 
            { 
                Console.Write("╠═══");
                for (int j = 0; j < 6 ; j++) 
                { 
                    Console.Write("╬═══");
                }
                Console.WriteLine("╣");
            }
        }
        
        private  void auxPrintNumbers(int index) 
        {
            String res = ""; 
            res+= "║"; 
            for (int i = index; i< BoardSize + index; i++) 
            { 
                switch (Tiles[i].Color)
                {
                    case Color.Empty:
                        res += "   ";
                        break;
                    case Color.Red:
                        res += " X ";
                        break;
                    case Color.Yellow:
                        res += " O ";
                        break;

                }
                
                res += "║"; 
            }

            Console.WriteLine(res);
        }
    }


}