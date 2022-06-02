using HCI_projekat.Events;
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
        public InstructionToSpecialistPage()
        {
            InitializeComponent();

            viewModel = new();
            viewModel.Name = "Sandra";
            viewModel.LastName = "Jovanovic";
            viewModel.ExaminationDate = DateOnly.FromDateTime(DateTime.Now);
            viewModel.ExaminationTime = TimeOnly.FromDateTime(DateTime.Now);
            viewModel.MedicalRecord = "1352B";
            viewModel.Room = "12-C";

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
        }
    }
}
