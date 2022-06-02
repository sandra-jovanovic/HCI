using HCI_projekat.Events;
using HCI_projekat.Navigation;
using HCI_projekat.ViewModels.Requests;
using System.Windows;
using System.Windows.Controls;

namespace HCI_projekat.View
{
    /// <summary>
    /// Interaction logic for WorkingHoursChangePage.xaml
    /// </summary>
    public partial class WorkingHoursChangePage : Page
    {
        private WorkingHoursViewModel viewModel;
        public WorkingHoursChangePage()
        {
            InitializeComponent();
            viewModel = new();

            viewModel.IsTooltipEnabled = HomePageStateManager.AreTooltipsEnabled;

            DataContext = viewModel;

            TooltipsEnabledEventEmmiter.OnTooltipsEnabled += OnChangeInTooltipEnablingReceived;
        }

        private void OnChangeInTooltipEnablingReceived(bool isTooltipEnabled)
        {
            viewModel.IsTooltipEnabled = isTooltipEnabled;
        }

        private void btnPosalji_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Zahtev poslat", "OBAVEŠTENJE");

            viewModel.StartTime = null;
            viewModel.EndTime = null;
            viewModel.Date = null;
            viewModel.Notes = "";
        }
    }
}
