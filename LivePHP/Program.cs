using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivePHP {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            App app = new App("LivePHP (" + GetPHPLocation() + ")");

            Application.Run(app);
        }

        static string GetPHPLocation() {
            Process proc = new Process {
                StartInfo = new ProcessStartInfo {
                    FileName = "where",
                    Arguments = "php",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            proc.Start();

            return proc
                .StandardOutput
                .ReadToEnd();
        }
    }
}
