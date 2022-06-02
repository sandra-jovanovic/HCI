using HCI_projekat.Events;
using HCI_projekat.Navigation;
using HCI_projekat.ViewModels.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HCI_projekat.View
{
    /// <summary>
    /// Interaction logic for FreeDaysRequestPage.xaml
    /// </summary>
    public partial class FreeDaysRequestPage : Page
    {
        private FreeDaysViewModel viewModel;
        public FreeDaysRequestPage()
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
            lblError.Visibility = Visibility.Hidden;
            lblError.Content = "";

            if (viewModel.StartDate > viewModel.EndDate)
            {
                lblError.Content = "Početni datum mora da bude raniji od završnog";
                lblError.Visibility = Visibility.Visible;
                return;
            } else if (viewModel.StartDate == null || viewModel.EndDate == null)
            {
                lblError.Content = "Početni i krajnji datum moraju da budu izabrani";
                lblError.Visibility = Visibility.Visible;
                return;
            }

            MessageBox.Show("Zahtev poslat", "OBAVEŠTENJE");

            viewModel.StartDate = null;
            viewModel.EndDate = null;
            viewModel.Notes = "";
        }
    }
}
