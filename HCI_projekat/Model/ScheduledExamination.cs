using System;

namespace HCI_projekat.Model
{
    public class ScheduledExamination
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MedicalRecord { get; set; }

        public DateTime Date { get; set; }

        public string Room { get; set; }
        public string Type { get; set; }
        public int Duration { get; set; }

    }
}
