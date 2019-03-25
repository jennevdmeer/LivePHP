using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace LivePHP {
    class PHPExecutor {
        public string Run(string content) {
            StringBuilder args = new StringBuilder();

            args.Append("-r " + this.Quote(this.Escape(content)));

            return this.RunPHP(args.ToString());
        }

        private string RunPHP(string args) {
            Process proc = new Process {
                StartInfo = new ProcessStartInfo {
                    FileName = "php",
                    Arguments = args,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            proc.Start();

            return OutputFormatting(proc
                .StandardOutput
                .ReadToEnd());
        }

        private string OutputFormatting(string str) {
            return str
                .Replace("\n", "\r\n")
                .Trim();
        }

        private string Quote(string str) {
            return "\"" + str + ";\"";
        }

        private string Escape(string str) {
            return str
                .Replace("\\", "\\\\")
                .Replace("\"", "\\\"");
        }
    }
}

