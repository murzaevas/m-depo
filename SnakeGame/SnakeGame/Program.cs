using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.SetBufferSize(80, 25);

            HorizontalLine upline = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downline = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftline = new VerticalLine(0, 0, 24, '+');
            VerticalLine rightline = new VerticalLine(78, 0, 24, '+');
            upline.DrawLine();
            downline.DrawLine();
            leftline.DrawLine();
            rightline.DrawLine();


                       
            Point p = new Point(4,5,'#');

            Snake snake = new Snake(p, 5, Direction.RIGHT);
            snake.DrawLine();

            



           Console.ReadLine();
        }

    }
}
