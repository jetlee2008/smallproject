using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LiteDB;

namespace DataManagmentSystem
{
    public partial class ShowRecords : Form
    {
        public ShowRecords()
        {
            InitializeComponent();
            //Width = 1024;
            //Height = 768;
        }

        private void ShowRecords_Load(object sender, EventArgs e)
        {
            dgvRecords.AutoGenerateColumns = true;
            SearchAll(db => db.FindAll());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbType.Text.Trim()))
            {
                SearchAll(db => db.FindAll());
            }
            else
            {
                SearchAll(db => db.Find(x => x.Type == tbType.Text.Trim()));

            }
        }

        private void SearchAll(Func<LiteCollection<Record>, IEnumerable<Record>> func)
        {
            using (var db = new LiteDatabase(@"MyData.db"))
            {
                var col = db.GetCollection<Record>("records");
                var records = func(col);

                var source = new BindingSource();
                source.DataSource = records.ToList();
                dgvRecords.DataSource = source;
            }
        }
    }
}
