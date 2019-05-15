using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            Height = 650;
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
                ChargeMan = new ChargeMan
                {
                    BirthDay = tbChargeManBirthDay.Text,
                    ComeFrom = tbComeFrom.Text,
                    HomeAddress = tbChargeManHomeAddress.Text,
                    Name = tbChargeManName.Text,
                    PersonalPhone = tbChargeManPhone.Text,
                    SimpleLife = tbChargeManSampleLife.Text
                },
                Comments = tbComments.Text,
                PeopleInReligion = tbPeopleInReligion.Text,
                PeopleCount = tbPeopleCount.Text,
                Room = tbRoom.Text
            };
        }
    }
}
