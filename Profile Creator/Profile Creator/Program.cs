using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Profile_Creator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (IsNet45OrNewer())
            {
                Application.Run(new mainForm());
            }
            else
            {
                if (MessageBox.Show("Microsoft.net framework 4.5 or higher is requried.\r\nPress 'Yes' to download and install and 'No' to cancel.", "Prerequisite not met", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://www.microsoft.com/en-gb/download/details.aspx?id=40779");
                }

            }
        }

        public static bool IsNet45OrNewer()
        {
            return Type.GetType("System.Reflection.ReflectionContext", false) != null;
        }
    }
}
