using HCI_projekat.Events;
using HCI_projekat.Model;
using HCI_projekat.Navigation;
using HCI_projekat.ViewModels.Examination;
using System;
using System.Windows;
using System.Windows.Controls;

namespace HCI_projekat.View
{
    /// <summary>
    /// Interaction logic for KeepingInHospitalPage.xaml
    /// </summary>
    public partial class KeepingInHospitalPage : Page
    {
        private KeepInHospitalViewModel viewModel;
        private readonly ScheduledExamination _examination;
        public KeepingInHospitalPage(ScheduledExamination examination)
        {
            InitializeComponent();

            _examination = examination;

            viewModel = new();
            viewModel.Name = examination.FirstName;
            viewModel.LastName = examination.LastName;
            viewModel.ExaminationDate = DateOnly.FromDateTime(examination.Date);
            viewModel.ExaminationTime = TimeOnly.FromDateTime(examination.Date);
            viewModel.MedicalRecord = examination.MedicalRecord;
            viewModel.Room = examination.Room;

            viewModel.IsTooltipEnabled = HomePageStateManager.AreTooltipsEnabled;

            DataContext = viewModel;

            TooltipsEnabledEventEmmiter.OnTooltipsEnabled += OnChangeInTooltipEnablingReceived;
        }

        private void OnChangeInTooltipEnablingReceived(bool isTooltipEnabled)
        {
            viewModel.IsTooltipEnabled = isTooltipEnabled;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Uspešno poslato", "OBAVEŠTENJE");
            viewModel.Notes = "";
            viewModel.StartingDate = null;
            viewModel.Duration = 0;

            HomePageStateManager.NavigationFrame.Navigate(new ExamineExaminationPage(_examination));
        }

        private void btnOdustani_Click(object sender, RoutedEventArgs e)
        {
            HomePageStateManager.NavigationFrame.Navigate(new ExamineExaminationPage(_examination));
        }
    }
}
