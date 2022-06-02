using System;

namespace HCI_projekat.Model
{
    public class MedicalReport
    {
        public DateTime Date { get; set; }
        public string Report { get; set; }

        public MedicalReport(DateTime date, string report)
        {
            Date = date;
            Report = report;
        }
    }
}
