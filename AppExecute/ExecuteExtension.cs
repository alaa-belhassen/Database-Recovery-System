using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExecute
{
    public static class ExecuteExtension
    {
        public static string executeCommand(string commandType, string commandSentence)
        {

            // info pour le process
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "C:\\Program Files\\PostgreSQL\\14\\bin\\" + commandType + ".exe ";
            info.Arguments = commandSentence;
            info.CreateNoWindow = true;
            info.UseShellExecute = false;

            // execution le process
            Process proc = new Process();
            proc.StartInfo = info;
            proc.Start();
            proc.WaitForExit();
            return "Execution du fichier avec succes";


        }
    }
}
