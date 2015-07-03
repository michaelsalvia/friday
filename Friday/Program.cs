using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Recognition;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Friday
{

    static class Program
    {

        static FridayConsole fridayConsole = null;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            fridayConsole = new FridayConsole();
            Application.Run(fridayConsole);

        }

    }
}

