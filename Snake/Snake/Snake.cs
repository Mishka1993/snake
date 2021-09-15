using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Snake: Figure
    {
        Direction direction;
        public Snake(Point tail, int lenght, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i,direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }
        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandleKey(ConsoleKey Key)
        {
                if (Key == ConsoleKey.LeftArrow)
                {
                    direction = Direction.Left;
                }
                else if (Key == ConsoleKey.RightArrow)
                {
                    direction = Direction.Right;
                }
                else if (Key == ConsoleKey.UpArrow)
                {
                    direction = Direction.Up;
                }
                else if (Key == ConsoleKey.DownArrow)
                {
                    direction = Direction.Down;
                }
            }
    }
}

