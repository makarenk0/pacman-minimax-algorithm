using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.AI
{
    class MultiAgent
    {
        private int[,] _map;
        private int _width, _height;
        private MinimaxTree _tree;


        public MultiAgent(int[,] map, Point player, Point[] enemies)
        {
            _map = map;
            _width = _map.GetLength(0);
            _height = _map.GetLength(1);
        }

        public void ConstructMinimaxTree(Point player, Point[] enemies)
        {

        }


    }
}
