using System;
using System.Threading;
using System.Windows.Forms;

namespace _50PSAM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool createNew;
            _ = new Mutex(false, Application.ProductName, out createNew);
            if (createNew)
            {
                MainForm form1 = new MainForm();
                if (args.Length > 0)
                {
                    if (args[0].Equals("-m"))
                    {
                        form1.HiddenOnStart = false;
                        form1.WindowState = FormWindowState.Minimized;

                    }
                    if (args[0].Equals("-h"))
                    {
                        form1.HiddenOnStart = true;
                        form1.Opacity = 0;
                        /*form1.WindowState = FormWindowState.Minimized;
                        form1.ShowInTaskbar = false;*/
                    }
                }
                try
                {
                    Application.Run(form1);
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Vyskytla se chyba!\n{ex.Message}\n\n{ex.StackTrace}");
                    Console.ResetColor();
                    Console.ReadKey();
                    MessageBox.Show($"Vyskytla se chyba!\n{ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Aplikace již běží!", "Upozornění", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
