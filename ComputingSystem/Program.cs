using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputingSystem
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmDetailed());




            /*Process proc = new Process(4, 100);
            Console.WriteLine(proc);
            Resource res = new Resource();
            res.ActiveProcess = proc;
            Console.WriteLine(res);
            SystemClock sc = new SystemClock();*/
        }
    }
}
