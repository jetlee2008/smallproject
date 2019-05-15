using System;
using System.Collections.Generic;
using System.Text;

namespace DataManagmentSystem
{
    public class Record
    {
        public int Index { get; set; }

        public string Type { get; set; }

        public string TempalName { get; set; }

        public string Address { get; set; }

        public ChargeMan ChargeMan { get; set; }

        public string Room { get; set; }

        public string PeopleCount { get; set; }

        public string PeopleInReligion { get; set; }

        public string Comments { get; set; }

        public Record()
        {
            ChargeMan = new ChargeMan();
        }
    }

    public class ChargeMan
    {
        public string Name { get; set; }

        public string BirthDay { get; set; }

        public string ComeFrom { get; set; }

        public string HomeAddress { get; set; }

        public string SimpleLife { get; set; }

        public string PersonalPhone { get; set; }
    }
}
