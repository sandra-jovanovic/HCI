using HCI_projekat.Events;
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
        public KeepingInHospitalPage()
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

            TooltipsEnabledEventEmmiter.OnTooltipsEnabled += OnChangeInTooltipEnablingReceived;
        }

        private void OnChangeInTooltipEnablingReceived(bool isTooltipEnabled)
        {
            viewModel.IsTooltipEnabled = isTooltipEnabled;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(viewModel);
            MessageBox.Show("Uspešno poslato", "OBAVEŠTENJE");
            viewModel.Notes = "";
            viewModel.StartingDate = null;
            viewModel.Duration = 0;
        }
    }
}
