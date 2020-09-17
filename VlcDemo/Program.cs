using LightLog;
using System;
using System.Linq;
using System.Windows.Forms;

namespace VlcDemo
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Log.SetFolderPath(System.AppDomain.CurrentDomain.BaseDirectory + "log");
#if DEBUG
            Log.Debug(Newtonsoft.Json.JsonConvert.SerializeObject(args));
#endif
            bool stdin = args.FirstOrDefault() == "--input-title-format";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Player(stdin));
        }
    }
}
