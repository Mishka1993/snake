using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4,6,'#');
            p2.Draw();


            HorizontalLine HLine = new HorizontalLine(5,10,8,'+');
            HLine.Draw();

            VerticalLine VLine = new VerticalLine(5, 8, 13, '+');
            VLine.Draw();

            Console.ReadLine();
        
        }
    }
}
