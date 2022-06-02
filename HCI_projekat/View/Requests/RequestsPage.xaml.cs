using HCI_projekat.Events;
using HCI_projekat.Navigation;
using HCI_projekat.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace HCI_projekat.View
{
    /// <summary>
    /// Interaction logic for RequestsPage.xaml
    /// </summary>
    public partial class RequestsPage : Page
    {
        private IsTooltipEnabledViewModel viewModel;

        public RequestsPage()
        {
            InitializeComponent();

            frRequestsPage.Navigate(new EquipmentExchangePage());
            lwMain.SelectedIndex = 0;

            viewModel = new();
            viewModel.IsTooltipEnabled = HomePageStateManager.AreTooltipsEnabled;

            DataContext = viewModel;

            TooltipsEnabledEventEmmiter.OnTooltipsEnabled += OnChangeInTooltipEnablingReceived;
        }

        private void OnChangeInTooltipEnablingReceived(bool isTooltipEnabled)
        {
            viewModel.IsTooltipEnabled = isTooltipEnabled;
        }


        private void liOprema_Selected(object sender, RoutedEventArgs e)
        {
            frRequestsPage.Navigate(new EquipmentExchangePage());
        }

        private void liRadnoVreme_Selected(object sender, RoutedEventArgs e)
        {
            frRequestsPage.Navigate(new WorkingHoursChangePage());
        }

        private void liSlobodniDani_Selected(object sender, RoutedEventArgs e)
        {
            frRequestsPage.Navigate(new FreeDaysRequestPage());
        }
    }
}
