using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AntiCoin
{
    class Utils
    {
        public static string hostsPath = "C:\\Windows\\System32\\drivers\\etc\\hosts";

        public static void addLineUnderHosts(string line)
        {
            File.AppendAllLines(hostsPath, new String[] { line });
        }

        public static void RemoveLineFromFile(string line_to_delete)
        {
            var ni = System.IO.File.ReadAllLines(hostsPath).Where(l => l != line_to_delete);
            File.WriteAllLines(hostsPath, ni);
        }

        public static bool amIAdmin()
        {
            var i = WindowsIdentity.GetCurrent();
            var p = new WindowsPrincipal(i);
            return p.IsInRole(WindowsBuiltInRole.Administrator);
        }

    }
}
