using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataManagmentSystem
{
    public partial class Login : Form
    {
        public string UserName { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VerifyUserCode(tbUserName.Text, tbPassword.Text))
            {
                UserName = tbUserName.Text;
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.No;
            }
        }

        private bool VerifyUserCode(string username, string password)
        {
            return true;
        }
    }
}
