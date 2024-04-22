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
            lb_Password = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
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
            // lb_Password
            // 
            lb_Password.AutoSize = true;
            lb_Password.Location = new Point(14, 82);
            lb_Password.Margin = new Padding(5, 0, 5, 0);
            lb_Password.Name = "lb_Password";
            lb_Password.Size = new Size(101, 28);
            lb_Password.TabIndex = 12;
            lb_Password.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(14, 114);
            textBox2.Margin = new Padding(5, 4, 5, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(234, 34);
            textBox2.TabIndex = 15;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(69, 184);
            button1.Name = "button1";
            button1.Size = new Size(116, 38);
            button1.TabIndex = 17;
            button1.Text = "Registration";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(273, 245);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(lb_Password);
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
        private Label lb_Password;
        private TextBox textBox2;
        private Button button1;
    }
}
