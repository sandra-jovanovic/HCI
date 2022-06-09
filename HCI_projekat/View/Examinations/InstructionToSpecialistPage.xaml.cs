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
    /// Interaction logic for InstructionToSpecialistPage.xaml
    /// </summary>
    public partial class InstructionToSpecialistPage : Page
    {
        private readonly List<string> specialists = new()
        {
            "Kardiolog", "Neurolog", "Hirurg"
        };
        private InstructionToSpecialistViewModel viewModel;
        private readonly ScheduledExamination _examination;
        public InstructionToSpecialistPage(ScheduledExamination examination)
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

            cbSpecijalisti.ItemsSource = specialists;

            TooltipsEnabledEventEmmiter.OnTooltipsEnabled += OnChangeInTooltipEnablingReceived;
        }

        private void OnChangeInTooltipEnablingReceived(bool isTooltipEnabled)
        {
            viewModel.IsTooltipEnabled = isTooltipEnabled;
        }

        private void btnPotvrdi_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Uspešno sačuvano", "OBAVEŠTENJE");
            viewModel.Specialist = "";
            viewModel.TherapyDate = null;
            viewModel.TherapyDuration = 0;
            viewModel.Notes = "";

            HomePageStateManager.NavigationFrame.Navigate(new ExamineExaminationPage(_examination));
        }

        private void btnOdustani_Click(object sender, RoutedEventArgs e)
        {
            HomePageStateManager.NavigationFrame.Navigate(new ExamineExaminationPage(_examination));
        }
    }
}
