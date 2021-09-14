using System;
using System.Collections.Generic;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.SetBufferSize(120, 30);

            HorizontalLine upLine = new HorizontalLine(0, 119, 0, '-');
            HorizontalLine downLine = new HorizontalLine(0, 119, 29, '-');
            VerticalLine leftLine = new VerticalLine(0, 29, 0, '|');
            VerticalLine rightLine = new VerticalLine(0, 29, 119, '|');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            Point p = new Point(4,5,'@');
            Snake snake = new Snake(p, 4, Direction.Down);
            snake.Draw();
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
        }
    }
}
