using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace LeagueOverlay.Klasy.Konsola
{
    internal class Konsola
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public Konsola()
        {

        }

        public void WlaczKonsole()
        {
            AllocConsole();
        }

    }
}
