using Microsoft.Win32;
using System.Windows.Forms;

namespace _50PSAM
{
    static class RegistryManager
    {
        private readonly static RegistryKey key = Registry.CurrentUser.OpenSubKey(@"software\Microsoft\Windows\CurrentVersion\Run", true);

        public static void SetOnStartup(bool run, bool minimized, bool hidden)
        {
            if (run)
            {
                key.SetValue(Application.ProductName, Application.ExecutablePath);
                if (hidden)
                    key.SetValue(Application.ProductName, $"{Application.ExecutablePath} -h");
                else if (minimized)
                    key.SetValue(Application.ProductName, $"{Application.ExecutablePath} -m");
            }
            else
                key.DeleteValue(Application.ProductName, false);
        }
    }
}
