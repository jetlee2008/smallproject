using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataManagmentSystem
{
    public partial class MainForm : Form
    {
        public string UserName { get; set; }

        public MainForm(string username)
        {
            InitializeComponent();
            UserName = username;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Text= $@"欢迎 {UserName}";
        }

        private void 信息录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var recordsForm=new RecordsForm();
            recordsForm.ShowDialog();
        }
    }
}
