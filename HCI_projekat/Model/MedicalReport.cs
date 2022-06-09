using System;

namespace HCI_projekat.Model
{
    public class MedicalReport
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Report { get; set; }

        public MedicalReport(DateTime date, string description, string report)
        {
            Date = date;
            Description = description;
            Report = report;
        }

        public override string? ToString()
        {
            return Date + " - " + Description;
        }
    }
}
