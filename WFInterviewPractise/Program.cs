using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace WFInterviewPractise
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
            Application.Run(new Pokedex());
        }
    }
}