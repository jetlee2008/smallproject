using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DataManagmentSystem
{
    public class Record
    {
        [DisplayName("序号")]
        public int Id { get; set; }

        [DisplayName("宗教类别")]
        public string Type { get; set; }

        [DisplayName("场所名称")]
        public string TempalName { get; set; }

        [DisplayName("地址")]
        public string Address { get; set; }

        [DisplayName("负责人名称")]
        public string ChargeManName { get; set; }

        [DisplayName("负责人出生日期")]
        public string ChargeManBirthDay { get; set; }

        [DisplayName("负责人籍贯")]
        public string ChargeManComeFrom { get; set; }

        [DisplayName("负责人家庭住址")]
        public string ChargeManHomeAddress { get; set; }

        [DisplayName("负责人简历")]
        public string ChargeManSimpleLife { get; set; }

        [DisplayName("负责人电话")]
        public string ChargeManPersonalPhone { get; set; }

        [DisplayName("负责人身份证")]
        public string ChargeManPersonalID { get; set; }

        [DisplayName("场所规模")]
        public string Room { get; set; }

        [DisplayName("场所人数")]
        public string PeopleCount { get; set; }

        [DisplayName("信教人数")]
        public string PeopleInReligion { get; set; }

        [DisplayName("备注")]
        public string Comments { get; set; }

        public Record()
        {
        }
    }
}
