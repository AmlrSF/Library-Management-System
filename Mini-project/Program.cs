using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_project
{
    internal static class Program
    {
        internal static LibraryManagementSystem libray { get; } = new LibraryManagementSystem();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new splach());
        }
    }
}
