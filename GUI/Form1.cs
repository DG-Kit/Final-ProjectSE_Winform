using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        BUS_Accountant acc;
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_Email.KeyPress += new KeyPressEventHandler(textBox_Email_KeyPress);
            textBox_Password.KeyPress += new KeyPressEventHandler(textBox_Password_KeyPress);
        }

        private void textBox_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                bLogin_Click(sender, e);
            }
        }

        private void textBox_Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                bLogin_Click(sender, e);
            }
            if (e.KeyChar == (char)Keys.Tab)
            {
                textBox_Password_Click(sender, e);
            }
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(textBox_Password.Text);
            acc = new BUS_Accountant(0, "", textBox_Email.Text, "", 0);
            DataTable account = acc.selectEmail();
            if (account.Rows.Count > 0)
            {
                DataTable passwordQuery = acc.selectPassword();
                string password = passwordQuery.Rows[0][0].ToString();
                Debug.WriteLine(password);
                if (password == textBox_Password.Text)
                {
                    AccountantManagement home = new AccountantManagement(textBox_Email.Text, textBox_Password.Text);
                    this.Visible = false;
                    home.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid password");
                }
            }
            else
            {
                MessageBox.Show("The email is not exist");
            }
            /*if(!(account.Rows.Count > 0))
            {
                MessageBox.Show("The email is not exist");
            }
            else
            {
                DataTable passwordQuery = acc.selectPassword();
                string password = passwordQuery.Rows[0][0].ToString();
                Debug.WriteLine(password);
                if (password == textBox_Password.Text)
                {
                    AccountantManagement accountantManagement = new AccountantManagement(textBox_Email.Text, textBox_Password.Text);
                    this.Visible = false;
                    accountantManagement.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid password");
                }
            }*/
        }

        private void textBox_Password_Leave(object sender, EventArgs e)
        {
            if (textBox_Password.Text == "")
            {
                textBox_Password.Text = "Type your password";

            }
        }

        private void textBox_Email_Leave(object sender, EventArgs e)
        {
            if (textBox_Email.Text == "")
            {
                textBox_Email.Text = "Type your email";
            }
        }

        private void textBox_Password_Click(object sender, EventArgs e)
        {
            if (textBox_Password.Text == "Type your password")
            {
                textBox_Password.Text = string.Empty;
                textBox_Password.UseSystemPasswordChar = true;
            }
        }

        private void textBox_Email_Click(object sender, EventArgs e)
        {
            if (textBox_Email.Text == "Type your email")
            {
                textBox_Email.Text = string.Empty;
            }
        }

    }
}
