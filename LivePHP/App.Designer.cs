namespace LivePHP {
    partial class App {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.input = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.Color.WhiteSmoke;
            this.input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.input.Font = new System.Drawing.Font("Roboto Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.Location = new System.Drawing.Point(6, 6);
            this.input.Margin = new System.Windows.Forms.Padding(6, 6, 3, 6);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(408, 552);
            this.input.TabIndex = 0;
            this.input.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnInputSave);
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.WhiteSmoke;
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.output.Font = new System.Drawing.Font("Roboto Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(420, 6);
            this.output.Margin = new System.Windows.Forms.Padding(3, 6, 6, 6);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.output.Size = new System.Drawing.Size(409, 552);
            this.output.TabIndex = 1;
            // 
            // TableLayout
            // 
            this.TableLayout.AutoSize = true;
            this.TableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TableLayout.BackColor = System.Drawing.Color.White;
            this.TableLayout.ColumnCount = 2;
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout.Controls.Add(this.output, 1, 0);
            this.TableLayout.Controls.Add(this.input, 0, 0);
            this.TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayout.Location = new System.Drawing.Point(0, 0);
            this.TableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayout.MinimumSize = new System.Drawing.Size(200, 200);
            this.TableLayout.Name = "TableLayout";
            this.TableLayout.RowCount = 1;
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout.Size = new System.Drawing.Size(835, 564);
            this.TableLayout.TabIndex = 2;
            // 
            // App
            // 
            this.ClientSize = new System.Drawing.Size(835, 564);
            this.Controls.Add(this.TableLayout);
            this.Name = "App";
            this.TableLayout.ResumeLayout(false);
            this.TableLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.TableLayoutPanel TableLayout;
    }
}