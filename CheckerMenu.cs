using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenAIO
{
    class CheckerMenu
    {
        public static void checkermenu()
        {
            Console.Clear();
            Program.PrintLogo();

            Colorful.Console.Write("[", Color.Gold);
            Colorful.Console.Write("1", Color.Cyan);
            Colorful.Console.Write("] ", Color.Gold);
            Colorful.Console.Write(" Gaming Checkers\n", Color.Orange);

            string input = Console.ReadLine();

            if (input == "1")
            {
                gaming();
            }
        }
        public static void gaming()
        {
            Console.Clear();
            Program.PrintLogo();

            Colorful.Console.Write("[", Color.Gold);
            Colorful.Console.Write("1", Color.Cyan);
            Colorful.Console.Write("] ", Color.Gold);
            Colorful.Console.Write("Minecraft\n", Color.Orange);

            string input = Console.ReadLine();

            if (input == "1")
            {
                Checkers.Minecraft.Program.Brute();
            }
        }
    }
}
