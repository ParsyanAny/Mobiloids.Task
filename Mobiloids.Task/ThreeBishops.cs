using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiloids.Task
{
    static class ThreeBishops
    {
        public static int MinMoves(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            if (IsBlack(x1, y1) != IsBlack(x2, y2) || IsBlack(x1,y1) != IsBlack(x3,y3))
                return - 1;
            else
            {
                if (InSameCell(x1, y1, x2, y2, x3, y3))
                    return 0;
                else if (InSameCell(x1, y1, x2, y2) || InSameCell(x1, y1, x3, y3) || InSameCell(x3, y3, x2, y2))
                    return 1;
                else 
                {

                    return 0;
                }
            }
        }

        private static bool IsBlack(int x, int y)
             {
                if ((x + y) % 2 != 0)
                    return false;
                return true;
             }
        private static bool InSameCell(int x1, int y1, int x2, int y2)
        {
            if (x1 == x2 && y1 == y2)
                return true;
            return false;
        }
        private static bool InSameCell(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            if (x1 == x2 && x1 == x3 && y1 == y2 && y1 == y3)
                return true;
            return false;
        }
    }
}
