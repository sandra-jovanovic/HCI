using HCI_projekat.Model;
using HCI_projekat.View.MedicalRecordComponents;
using HCI_projekat.ViewModels.MedicalRecords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace HCI_projekat.View
{
    /// <summary>
    /// Interaction logic for MedicalCardPage.xaml
    /// </summary>
    public partial class MedicalRecordPage : Page
    {
        private SingleMedicalRecordViewModel viewModel;
        private List<MedicalReport> reports = new()
        {
            new MedicalReport(DateTime.Parse("02-02-2022"), "Pacijent nije imao simptome na kontroli", "Na prethodnom pregledu, pacijent se žalio na bol u stomaku. Pregledom je utvrđena prehlada, pa je pacijentu prepisana terapija mirovanja."),
            new MedicalReport(DateTime.Parse("12-05-2022"), "Pacijent je imao problema sa vidom", "Na prethodnom pregledu, pacijent se žalio na bol u stomaku. Pregledom je utvrđena prehlada, pa je pacijentu prepisana terapija mirovanja."),
            new MedicalReport(DateTime.Parse("12-06-2022"), "Redovna kontrola, sve je bilo u redu", "Na prethodnom pregledu, pacijent se žalio na bol u stomaku. Pregledom je utvrđena prehlada, pa je pacijentu prepisana terapija mirovanja."),
        };

        public MedicalRecordPage(MedicalRecord medicalRecord)
        {
            InitializeComponent();
            viewModel = new();
            viewModel.Name = medicalRecord.UserName;
            viewModel.LastName = medicalRecord.UserLastName;
            viewModel.MedicalRecordNumber = medicalRecord.Number;
            viewModel.BirthDate = DateOnly.FromDateTime(medicalRecord.BirthDate);
            viewModel.JMBG = medicalRecord.JMBG;
            viewModel.Address = medicalRecord.Address;
            viewModel.Phone = medicalRecord.Phone;
            viewModel.Married = medicalRecord.Married;
            viewModel.Employed = medicalRecord.Working;

            DataContext = viewModel;
        }

        private void btnPretrazi_Click(object sender, RoutedEventArgs e)
        {
            if (dpPocetak.SelectedDate == null && dpKraj.SelectedDate == null)
            {
                MessageBox.Show("Potrebno je da izaberete jedan datum");
                return;
            }

            DateTime startDate = dpPocetak.SelectedDate == null ? DateTime.MinValue : (DateTime)dpPocetak.SelectedDate;
            DateTime endDate = dpKraj.SelectedDate == null ? DateTime.MaxValue : (DateTime)dpKraj.SelectedDate;

            var filteredReports = reports.Where(r => startDate <= r.Date && r.Date <= endDate);
            lwIzvestaji.ItemsSource = filteredReports;
        }

        private void ListViewItem_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var medicalReport = (MedicalReport)lwIzvestaji.SelectedItem;
            MedicalRecordDetailsWindow window = new(medicalReport);
            window.ShowDialog();
        }
    }
}
