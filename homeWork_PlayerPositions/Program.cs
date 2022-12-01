using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_PlayerPositions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int palyerPositionX = 5;
            int playerPositionY = 5;
            char symbolPlayer = '@';

            Player player = new Player(palyerPositionX, playerPositionY, symbolPlayer);
            Painter painter = new Painter();

            painter.PrintPlayer(player.PositionX, player.PositionY,player.SymbolPlayer);
            Console.ReadKey();
        }
    }

    class Player
    {
        public int PositionX { get; private set; }
        public int PositionY { get; private set; }
        public char SymbolPlayer { get; private set; }

        public Player(int positionX, int positionY, char symbolPlayer)
        {
            PositionX = positionX;
            PositionY = positionY;
            SymbolPlayer = symbolPlayer;
        }
    }

    class Painter 
    {
        public void PrintPlayer(int positionX, int positionY, char symbolPalyer) 
        {
            Console.SetCursorPosition(positionY, positionX);
            Console.Write(symbolPalyer);
        }
    }
}
