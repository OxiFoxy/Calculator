using AnalaizerClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphInterface
{
    static class Program
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AllocConsole();
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool FreeConsole();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                AnalaizerClass.expression = args[0];
                string result = AnalaizerClass.Estimate();
                ConsoleColor color = ConsoleColor.White;
                if (result.StartsWith("&"))
                {
                    result = result.TrimStart('&');
                    color = ConsoleColor.Red;
                }
                else
                    result = result + Environment.NewLine + "0";
                if (AllocConsole())
                {
                    Console.ForegroundColor = color;
                    Console.OutputEncoding = Encoding.UTF8;
                    Console.WriteLine(result);
                    Console.WriteLine("Для виходу натисніть будь-яку клавішу...");
                    Console.ReadKey(); FreeConsole();
                }
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
