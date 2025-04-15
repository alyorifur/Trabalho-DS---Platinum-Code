using System;
using System.Windows.Forms;

namespace platinum_code
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1()); // ou qualquer outro form principal
        }
    }
}

