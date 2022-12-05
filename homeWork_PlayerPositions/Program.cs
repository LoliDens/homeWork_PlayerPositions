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
            char skin = '*';

            Player player = new Player(palyerPositionX, playerPositionY, skin);
            Painter painter = new Painter();

            painter.PrintPlayer(player.PositionX, player.PositionY,player.Skin);
            Console.ReadKey();
        }
    }

    class Player
    {
        public int PositionX { get; private set; }
        public int PositionY { get; private set; }
        public char Skin { get; private set; }

        public Player(int positionX, int positionY, char skin)
        {
            PositionX = positionX;
            PositionY = positionY;
            Skin = skin;
        }
    }

    class Painter 
    {
        public void PrintPlayer(int positionX, int positionY, char skin) 
        {
            Console.SetCursorPosition(positionY, positionX);
            Console.Write(skin);
        }
    }
}
