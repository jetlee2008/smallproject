using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LiteDB;

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
            Text = $@"欢迎 {UserName}";
        }

        private void 信息录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var recordsForm = new RecordsForm();
            recordsForm.ShowDialog();
        }

        private void 信息展示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var showRecords = new ShowRecords();
            showRecords.ShowDialog();
        }

        private void 信息导入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            var fileName = fileDialog.FileName;
            IEnumerable<Record> records = null;

            using (var db = new LiteDatabase(fileName))
            {
                var col = db.GetCollection<Record>("records");
                records = col.FindAll();
            }

            using (var db = new LiteDatabase(@"MyData.db"))
            {
                var col = db.GetCollection<Record>("records");
                foreach (var record in records)
                {
                    record.Id = 0;
                    col.Insert(record);
                }
            }

            MessageBox.Show("加载完成");
        }
    }
}
