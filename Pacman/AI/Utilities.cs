using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.AI
{
    static class Utilities
    {
        public static int GetDicrection(Point p1, Point p2)
        {
            if(p1.X - p2.X < 0) { return 2; }
            else if(p1.X - p2.X > 0) { return 4; }
            else if(p1.Y - p2.Y < 0) { return 3; }
            else if(p1.Y - p2.Y > 0) { return 1; }
            return 0;
        }

        public static void PrintTree(Node root)
        {
            root.PrintPretty("", true);
        }
    }
}
