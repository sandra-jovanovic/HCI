using System;

namespace HCI_projekat.Model
{
    public class MedicalRecord
    {
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public string Number { get; set; }
        public DateTime BirthDate { get; set; }
        public string JMBG { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool Married { get; set; }
        public bool Working { get; set; }

        public MedicalRecord()
        {
        }

        public MedicalRecord(string userName, string userLastName, string number, DateTime birthDate, string jMBG, string address, string phone, bool married, bool working)
        {
            UserName = userName;
            UserLastName = userLastName;
            Number = number;
            BirthDate = birthDate;
            JMBG = jMBG;
            Address = address;
            Phone = phone;
            Married = married;
            Working = working;
        }
    }
}
