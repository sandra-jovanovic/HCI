using HCI_projekat.Events;
using HCI_projekat.Navigation;
using HCI_projekat.ViewModels.Examination;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace HCI_projekat.View
{
    /// <summary>
    /// Interaction logic for ScheduleNewExaminationView.xaml
    /// </summary>
    public partial class ScheduleNewExaminationView : Page
    {
        private SingleExaminationViewModel viewModel;
        private List<string> pacients = new()
        {
            "Sandra Jovanovic", "Jovana Ilic", "Marko Simovic"
        };
        private List<string> freeRooms = new()
        {
            "A-234", "C-222", "123-M"
        };

        public ScheduleNewExaminationView()
        {
            InitializeComponent();
            viewModel = new();

            viewModel.IsTooltipEnabled = HomePageStateManager.AreTooltipsEnabled;
            TooltipsEnabledEventEmmiter.OnTooltipsEnabled += OnChangeInTooltipEnablingReceived;

            DataContext = viewModel;

            cbPacijenti.ItemsSource = pacients;
            cbSlobodneProstorije.ItemsSource = freeRooms;
        }

        private void OnChangeInTooltipEnablingReceived(bool isTooltipEnabled)
        {
            viewModel.IsTooltipEnabled = isTooltipEnabled;
        }

        private void btnOdustani_Click(object sender, RoutedEventArgs e)
        {
            HomePageStateManager.NavigationFrame.Navigate(new ExaminationView());
        }

        private void btnZakazi_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Uspešno zakazano", "OBAVEŠTENJE");
            viewModel.User = "";
            viewModel.ExaminationDate = null;
            viewModel.ExaminationTime = null;
            viewModel.TherapyDuration = 0;
            viewModel.Type = "";
            viewModel.Room = "";
        }
    }
}
