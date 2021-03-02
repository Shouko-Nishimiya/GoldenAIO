using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldenAIO.Checkers.Minecraft
{
    class Program
    {
        [STAThread]

        public static void Brute()
        {
            Console.Clear();
            Colorful.Console.Write("  [-] ", Color.Aqua);
            Colorful.Console.Write("How many threads: ", Color.White);
            try
            {
                Request.threads = int.Parse(Console.ReadLine());
            }
            catch
            {
                Request.threads = 80;
            }

            Console.Clear();
            for (; ; )
            {
                Colorful.Console.Write("  [-] ", Color.Aqua);
                Colorful.Console.Write("What type of proxies - HTTP | SOCKS4 | SOCKS5 -: ", Color.White);
                Request.proxyType = Console.ReadLine();
                Request.proxyType = Request.proxyType.ToUpper();
                if (Request.proxyType.Contains("HTTP") || Request.proxyType.Contains("SOCKS4") || Request.proxyType.Contains("SOCKS5"))
                {
                    break;
                }
                Colorful.Console.Write("  > Please select a valid proxyType", Color.Red);
            }

            Thread.Sleep(2000);
            Console.Clear();
            Task.Factory.StartNew(delegate ()
            {
                Request.updateTitle();
            });


            string fileName = "Combo.txt";
            while (!System.IO.File.Exists("Combo.txt")) ;
            DateTime befDT = DateTime.Now;
            List<string> comboList = new List<string>((IEnumerable<string>)System.IO.File.ReadAllLines("Combo.txt"));
            using (FileStream fileStream = System.IO.File.Open("Combo.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (BufferedStream bufferedStream = new BufferedStream((Stream)fileStream))
                {
                    using (StreamReader streamReader = new StreamReader((Stream)bufferedStream))
                    {
                        while (streamReader.ReadLine() != null) ;
                    }
                }
            }
            while (!File.Exists(fileName));

            Request.comboList = new List<string>(File.ReadAllLines(fileName));
            Request.LoadCombos(fileName);

            Colorful.Console.Write("\n  > ", Color.Aqua);
            Colorful.Console.Write("Succesfully Loaded " + Request.totalCounter + " Combo lines", Color.White);

            Thread.Sleep(1000);
            Console.Clear();
            do
            {
                fileName = "proxies.txt";
                while (!System.IO.File.Exists("proxies.txt")) ;
                befDT = DateTime.Now;
                List<string> proxyList = new List<string>((IEnumerable<string>)System.IO.File.ReadAllLines("proxies.txt"));
                using (FileStream fileStream = System.IO.File.Open("proxies.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (BufferedStream bufferedStream = new BufferedStream((Stream)fileStream))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)bufferedStream))
                        {
                            while (streamReader.ReadLine() != null) ;
                        }
                    }
                }
            }
            while (!File.Exists(fileName));

            Request.proxyList = new List<string>(File.ReadAllLines(fileName));
            Request.Loadproxies(fileName);
            Colorful.Console.Clear();

            Colorful.Console.Write("  > ", Color.Aqua);
            Colorful.Console.Write("Succesfully Loaded " + Request.proxyTotalCounter + " Proxy lines", Color.White);

            Thread.Sleep(1000);
            Console.Clear();

            for (int i = 0; i <= Request.threads; i++)
            {
                new Thread(new ThreadStart(Request.Check)).Start();
            }

            Colorful.Console.ReadLine();
            Environment.Exit(0);
        }
    }

}
