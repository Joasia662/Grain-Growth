using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    static class BoundaryConditions
    {
       static public int getLeftIndex(int width, int x, string condition)
        {
            if (x == 0 && condition == "periodyczne")
            {
                return width - 1;
            }
            else
            {
                return x - 1;
            }
        }

        static public int getRightIndex(int width, int x, string condition)
        {
            if (x == width - 1)
            {
                return condition == "periodyczne" ? 0 : -1;
            }
            else
            {
                return x + 1;
            }
        }

        static public int getUpperIndex(int height, int y, string condition)
        {
            if (y == 0 && condition == "periodyczne")
            {
                return height - 1;
            }
            else
            {
                return y - 1;
            }
        }

        static public int getLowerIndex(int height, int y, string condition)
        {
            if (y == height - 1)
            {
                return condition == "periodyczne" ? 0 : -1;
            }
            else
            {
                return y + 1;
            }
        }
    }
}

