using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PicasaGrabber
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form mainFrame = new MainFrame();
            Application.Run(mainFrame);
        }
    }
}