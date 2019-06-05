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
    public partial class RecordsForm : Form
    {
        public RecordsForm()
        {
            InitializeComponent();
        }

        private void Records_Load(object sender, EventArgs e)
        {
            Height = 750;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var record = new Record
            {
                Type = tbType.Text,
                TempalName = tbTempalName.Text,
                Address = tbAddress.Text,
                ChargeManBirthDay = tbChargeManBirthDay.Text,
                ChargeManComeFrom = tbComeFrom.Text,
                ChargeManHomeAddress = tbChargeManHomeAddress.Text,
                ChargeManName = tbChargeManName.Text,
                ChargeManPersonalPhone = tbChargeManPhone.Text,
                ChargeManSimpleLife = tbChargeManSampleLife.Text,
                Comments = tbComments.Text,
                PeopleInReligion = tbPeopleInReligion.Text,
                PeopleCount = tbPeopleCount.Text,
                Room = tbRoom.Text,
                ChargeManPersonalID=tbChargeManID.Text
            };

            using (var db = new LiteDatabase(@"MyData.db"))
            {
                var col = db.GetCollection<Record>("records");
                col.Insert(record);
            }

            MessageBox.Show("保存成功");
            this.Close();
        }
    }
}
