using System;
using System.Windows.Forms;


namespace LeagueOverlay
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form1 = new Form1();

            Application.Run(form1);
        }
    }
}
