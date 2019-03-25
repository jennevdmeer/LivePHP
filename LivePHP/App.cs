using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace LivePHP {
    public partial class App : Form {
        PHPExecutor executor = new PHPExecutor();

        string Title { get; set; }

        public App(string title) {
            InitializeComponent();

            this.Title = title;
            this.Text = this.Title;
            this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
        }

        private void OnInputSave(object sender, KeyEventArgs e) {
            string text = input.Text.Trim();

            output.Text = executor.Run(text);

            this.Text = (0 == text.Length)
                ? this.Title
                : text.Substring(0, Math.Min(text.Length, 25));
        }
    }
}