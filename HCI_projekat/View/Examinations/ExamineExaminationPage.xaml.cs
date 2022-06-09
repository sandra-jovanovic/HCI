using HCI_projekat.Events;
using HCI_projekat.Model;
using HCI_projekat.Navigation;
using HCI_projekat.ViewModels.Examination;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace HCI_projekat.View
{
    /// <summary>
    /// Interaction logic for ExamineExaminationPage.xaml
    /// </summary>
    public partial class ExamineExaminationPage : Page
    {
        private readonly List<string> _therapyTypes = new()
        {
            "Lekovi", "Injekcije", "Odmor"
        };
        private ExamineExaminationViewModel viewModel;
        private readonly ScheduledExamination _examination;

        public ExamineExaminationPage(ScheduledExamination examination)
        {
            InitializeComponent();

            _examination = examination;

            cbTherapies.ItemsSource = _therapyTypes;

            viewModel = new();
            viewModel.Name = examination.FirstName;
            viewModel.LastName = examination.LastName;
            viewModel.ExaminationDate = DateOnly.FromDateTime(examination.Date);
            viewModel.ExaminationTime = TimeOnly.FromDateTime(examination.Date);
            viewModel.MedicalRecord = examination.MedicalRecord;
            viewModel.Room = examination.Room;
            viewModel.TherapyDuration = examination.Duration;
            viewModel.IsTooltipEnabled = HomePageStateManager.AreTooltipsEnabled;

            DataContext = viewModel;

            TooltipsEnabledEventEmmiter.OnTooltipsEnabled += OnChangeInTooltipEnablingReceived;

        }

        private void btnUputiKodSpecijaliste_Click(object sender, RoutedEventArgs e)
        {
            HomePageStateManager.NavigationFrame.Navigate(new InstructionToSpecialistPage(_examination));
        }

        private void btnZadrziUBolnici_Click(object sender, RoutedEventArgs e)
        {
            HomePageStateManager.NavigationFrame.Navigate(new KeepingInHospitalPage(_examination));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HomePageStateManager.NavigationFrame.Navigate(new MedicalExcusePage(_examination));
        }

        private void OnChangeInTooltipEnablingReceived(bool isTooltipEnabled)
        {
            viewModel.IsTooltipEnabled = isTooltipEnabled;
        }

        private void btnDodajUKarton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Uspešno dodato u karton", "OBAVEŠTENJE");
            HomePageStateManager.NavigationFrame.Navigate(new ExaminationView());
        }
    }
}
