using System;
using System.Windows.Forms;

//此程序的作用：启动程序，打开窗口
namespace ModernCalculator
{
    internal static class Program
    {
        // 程序入口
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}