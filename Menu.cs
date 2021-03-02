using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenAIO
{
    class Menu
    {
        public static void menu()
        {
            Program.PrintLogo();
            Colorful.Console.Title = "GoldenAIO Best Open Sourced AIO Around";
            Colorful.Console.Write("[", Color.Gold);
            Colorful.Console.Write("1", Color.Cyan);
            Colorful.Console.Write("] ", Color.Gold);
            Colorful.Console.Write("Checker Modules\n", Color.Orange);

            Colorful.Console.Write("[", Color.Gold);
            Colorful.Console.Write("2", Color.Cyan);
            Colorful.Console.Write("] ", Color.Gold);
            Colorful.Console.Write("Combo Editor\n", Color.Orange);

            Colorful.Console.Write("[", Color.Gold);
            Colorful.Console.Write("X", Color.Cyan);
            Colorful.Console.Write("] ", Color.Gold);
            Colorful.Console.Write("exit\n\n", Color.Orange);

            string input = Console.ReadLine();

            if(input=="1")
            {
                Console.Clear();
                Program.PrintLogo();
                CheckerMenu.checkermenu();
            }
            else if(input=="2")
            {
                Console.Clear();
                Program.PrintLogo();
            }
            else if(input=="x")
            {
                Environment.Exit(0);
            }
            else if(input=="X")
            {
                Environment.Exit(0);
            }
        }
    }
}
