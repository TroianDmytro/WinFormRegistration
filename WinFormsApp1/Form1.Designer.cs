namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb_Login = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // lb_Login
            // 
            lb_Login.AutoSize = true;
            lb_Login.Location = new Point(18, 12);
            lb_Login.Margin = new Padding(5, 0, 5, 0);
            lb_Login.Name = "lb_Login";
            lb_Login.Size = new Size(64, 28);
            lb_Login.TabIndex = 0;
            lb_Login.Text = "Login";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 44);
            textBox1.Margin = new Padding(5, 4, 5, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(234, 34);
            textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(273, 245);
            Controls.Add(textBox1);
            Controls.Add(lb_Login);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Login;
        private TextBox textBox1;
    }
}
