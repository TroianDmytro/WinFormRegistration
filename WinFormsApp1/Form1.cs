using WinFormsApp1.Controlls;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CorrectData.IsStrongPassword(textBox2.Text))
            {
                MessageBox.Show("Ok");
            }
            else
            {
                MessageBox.Show("Password is not strong", "",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
