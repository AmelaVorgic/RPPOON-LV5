using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5RPPOON
{
    class MyTheme : ITheme
    {
        public void SetBackgroundColor()
        {
            Console.BackgroundColor = ConsoleColor.DarYellow;
        }
        public void SetFontColor()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
        }
        public string GetHeader(int width)
        {
            return new string('~', width);
        }
        public string GetFooter(int width)
        {
            return new string('~', width);
        }
    }
}
