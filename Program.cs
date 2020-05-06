using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5RPPOON
{
    class Program
    {
        static void Main(string[] args)
        {
            LightTheme lightTheme = new LightTheme();
            MyTheme yellowTheme = new MyTheme();
            ReminderNote firstnote = new ReminderNote("Is this working?", lightTheme);
            firstnote.Show();
            ReminderNote secondnote = new ReminderNote("This one is pretty!", yellowTheme);
            secondnote.Show();
            Console.ReadKey();
        }
    }
}
