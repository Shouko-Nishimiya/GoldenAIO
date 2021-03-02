using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenAIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.menu();
        }
        public static void PrintLogo()
        {
            Colorful.Console.Write("\n\n░██████╗░░█████╗░██╗░░░░░██████╗░███████╗███╗░░██╗░█████╗░██╗░█████╗░\n", Color.Gold);
            Colorful.Console.Write("██╔════╝░██╔══██╗██║░░░░░██╔══██╗██╔════╝████╗░██║██╔══██╗██║██╔══██╗\n", Color.Gold);
            Colorful.Console.Write("██║░░██╗░██║░░██║██║░░░░░██║░░██║█████╗░░██╔██╗██║███████║██║██║░░██║\n", Color.Gold);
            Colorful.Console.Write("██║░░╚██╗██║░░██║██║░░░░░██║░░██║██╔══╝░░██║╚████║██╔══██║██║██║░░██║\n", Color.Gold);
            Colorful.Console.Write("╚██████╔╝╚█████╔╝███████╗██████╔╝███████╗██║░╚███║██║░░██║██║╚█████╔╝\n", Color.Gold);
            Colorful.Console.Write("░╚═════╝░░╚════╝░╚══════╝╚═════╝░╚══════╝╚═╝░░╚══╝╚═╝░░╚═╝╚═╝░╚════╝░\n", Color.Gold);
            Colorful.Console.Write("Made By https://github.com/Shouko-Nishimiya \n\n", Color.Cyan);
        }
    }
}
