using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CANVAS
{
    internal class MyButton
    {
        protected Point topLeft;
        protected Point buttomRight;
        private int height;
        private int width;
        public MyButton(Point topLeft, Point buttomRight)
        {
            this.topLeft = topLeft;
            this.buttomRight = buttomRight;
        }
        internal int Height
        {
            get
            {
                height = topLeft.Y - buttomRight.Y;
                return height;
            }
           
        }
        internal int Width
        {
            get
            {
                width = buttomRight.X - topLeft.X;
                return width;
            }
           
        }
        internal Point TopLeft
        {
            get
            {
                return this.topLeft;
            }
        }
            internal bool SetTopLeft(Point topLeft, Point buttomRight)
        {
            if (topLeft.X - buttomRight.X >= 0 | topLeft.Y - buttomRight.Y <= 0 | buttomRight.X > MyCanvas.MaxWidth | buttomRight.Y > MyCanvas.MaxHeight)
            {

                Console.WriteLine("Invalid Input!");
                return false;
            }
            else
                this.topLeft = topLeft;
            return true;
        }
    
       
            internal bool SetButtomRight(Point topLeft,Point buttomRight) 
            {
                if (topLeft.X - buttomRight.X >= 0 | topLeft.Y - buttomRight.Y <= 0 | buttomRight.X > MyCanvas.MaxWidth | buttomRight.Y > MyCanvas.MaxHeight)
                {
                    
                    Console.WriteLine("Invalid Input!");
                    return false;
               }
                else
                    this.buttomRight = buttomRight;
            return true;
            }
        internal Point ButtomRight
        {
            get
            {
                return this.buttomRight;
            }
        }
    
        public override string ToString()
        {
            return $"Top Left {topLeft.ToString()} Buttom Right {buttomRight.ToString()} Height {height} Width {width}";
        }
    }
}
