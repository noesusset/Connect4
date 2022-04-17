using System;
using System.Collections;
using System.Data;
using System.Linq;

using System.Globalization;
using System.Runtime.InteropServices.ComTypes;
using System.Xml;

namespace Puissance4
{
    class Program
    {
        static void Main(string[] args)
        {
            Board test = new Board();
            Player player = new Player(0);
            Player player2 = new Player(1);
            test.Print();
            Pawn.AddPawn(test, player, 2);
            Pawn.AddPawn(test, player2, 2);
            Pawn.AddPawn(test, player, 2);
            Pawn.AddPawn(test, player, 2);
            Pawn.AddPawn(test, player, 2);
            Pawn.AddPawn(test, player, 2);
            Pawn.AddPawn(test, player2, 2);
            Pawn.AddPawn(test, player2, 2);
            test.Print();
            test.Rotation(Orientation.South);
            test.Print();
        }
    }
}
