using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CANVAS
{
    public class MyCanvas
    {
        public const int MaxWidth = 800;
        public const int MaxHeight= 600;
        private static int buttonIndex = 0;
        private static int MaxButtons=3;
        private static MyButton[] buttons = new MyButton[MaxButtons];
        public static bool CreateNewButton(int x1,int y1,int x2,int y2)
        {
           if(buttonIndex==MaxButtons)
                return false;
            Point topLeft = new Point(x1, y1);
            Point buttomRight = new Point(x2, y2);
            buttons[buttonIndex] = new MyButton(topLeft, buttomRight);
            buttonIndex++;
            return true;
                
        }
        public static bool MoveButton(int buttonNumber,int x,int y)
        {
            if (buttonNumber > buttonIndex)
                return false;
            Point movePointTopLeft = new Point(x, y);
            Point movePointButtomRight = new Point((x + buttons[buttonNumber].Width), (y - buttons[buttonNumber].Height));
            buttons[buttonNumber] =new MyButton(movePointTopLeft, movePointButtomRight);
            return true;
        }
        public static bool DeletLastButton()
        {
            if (buttonIndex == 0)
                return false;
            buttons[buttonIndex] = null;
            buttonIndex--;
            return true;
        }
        public static void ClearAllButton()
        {
            if (buttonIndex == 0)
                return;
            for (int i = 0; i < buttons.Length-1; i++)
            {
                buttons[i] = null;
            }
            buttonIndex = 0;
        }
        public static int GetMaxNumberOfButtons()
        {
            return MaxButtons;
        }
        public static int GetMaxWidth()
        {
            if (buttonIndex == 0)
                return 0;
            int temp = 0;
            foreach (MyButton item in buttons)
            {
                if (item != null)
                {
                    if (item.Width > temp)
                        temp = item.Width;
                }
            }
            return temp;
        }
        public static int GetMaxHeight()
        {
            if (buttonIndex == 0)
                return 0;
            int temp = 0;
            foreach (MyButton item in buttons)
            {
                if (item != null)
                {
                    if (item.Height > temp)
                        temp = item.Height;
                }
            }
            return temp;
        }
        public static bool IsPOintInsideAButton(int x,int y)
        {
            if (buttonIndex == 0)
                return false;
            foreach (var item in buttons)
            {
                if (item != null)
                {
                    if (item.TopLeft.Y >= y & item.ButtomRight.Y <= y & item.TopLeft.X <= x & item.ButtomRight.X >= x)
                        return true;
                }
            }
            return false;
            
        }
        public static bool IsOverlapping()
        {
            if (buttonIndex == 0)
                return false;
           
            for (int i = 0; i < buttons.Length; i++)
            {

                for (int j = i + 1; j < buttons.Length; j++)
                {


                    if (IsPOintInsideAButton(buttons[i].TopLeft.X, buttons[i].TopLeft.Y) | IsPOintInsideAButton(buttons[i].ButtomRight.X, buttons[i].ButtomRight.Y))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public override string ToString()
        {
            string btnPoints="";
            foreach (var item in buttons)
            {
               // if(item!=null)
                btnPoints += " "+item.ToString();
            }
            return $"Max number of buttons{MaxButtons} Canvas Grid{MaxWidth}X{MaxHeight} number of Button(s) {buttonIndex} Buttons:{btnPoints}";
        }

    }
}
