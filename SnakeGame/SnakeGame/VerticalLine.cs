using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int x, int ybottom, int ytop, char sym)
        {
            pList = new List<Point>();
            for (int y = ybottom; y <= ytop; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void DrawLine()
        {
            foreach (Point p in pList)
            {
                p.Draw();

            }
        }

    }
}
