using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CANVAS
{
 internal class Point
    {
        private int x;
        private int y;
        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        internal int X
        {
            get
            {
                return x;
            }
            set
            {
                if (value >= 0)
                    x = value;
                else
                    Console.WriteLine("Invalid input!");
            }
        }
        internal int Y
        {
            get
            {
                return y;
            }
            set
            {
                if (value >= 0)
                    y = value;
                else
                    Console.WriteLine("Invalid input!");
            }
        }
        public override string ToString()
        {
            return $"({x},{y})";
        }
    }
}
