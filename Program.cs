using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TVP_projekat1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogIn());
            if (FrmLogIn.UserSuccessfullyAuthenticatedAsAdmin)
            {
                // MainForm is defined elsewhere
                Application.Run(new FrmMain());
                
            }

            else if (FrmLogIn.UserSuccessfullyAuthenticatedAsKorisnik)
            {
                Application.Run(new FrmReservation());

            }
        }
    }
}
