using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "ramtin" && textBox2.Text == "1384")
            {
                //MessageBox.Show("خوش آمدید");

                Form frm2 = new Form2();
                this.Hide();
                frm2.Show();
            }
            else
            {
                MessageBox.Show("نام کاربری یا رمز عبور اشتباه می باشد");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Close();

            DialogResult q = MessageBox.Show("آیا می خواهید خارج شوید؟", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (q == DialogResult.Yes)
                Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if(checkBox1.Checked)
            //    textBox2.PasswordChar = '\0';
            //else
            //    textBox2.PasswordChar = '*';

            if (textBox2.PasswordChar == '*')
                textBox2.PasswordChar = '\0';
            else
                textBox2.PasswordChar = '*';
        }
    }
}
