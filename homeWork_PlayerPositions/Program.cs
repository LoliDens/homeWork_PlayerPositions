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

            Player player = new Player(palyerPositionX, playerPositionY);
            Painter painter = new Painter();

            painter.Paint(player.PositionX, player.PositionY);
            Console.ReadKey();
        }
    }

    class Player
    {
        public int PositionX { get; private set; }
        public int PositionY { get; private set; }
        public Player(int positionX, int positionY)
        {
            PositionX = positionX;
            PositionY = positionY;
        }
    }

    class Painter 
    {
        public void Paint(int positionX, int positionY, char drawSymbol = '@') 
        {
            Console.SetCursorPosition(positionY, positionX);
            Console.Write(drawSymbol);
        }
    }
}
