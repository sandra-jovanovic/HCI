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
    /// Interaction logic for EquipmentExchangePage.xaml
    /// </summary>
    public partial class EquipmentExchangePage : Page
    {
        private EquipmentViewModel viewModel;
        private List<string> equipmentNames = new()
        {
            "operacioni sto", "rendgen", "ultrazvuk masina"
        };

        public EquipmentExchangePage()
        {
            InitializeComponent();

            viewModel = new();

            viewModel.IsTooltipEnabled = HomePageStateManager.AreTooltipsEnabled;

            DataContext = viewModel;

            cbOprema.ItemsSource = equipmentNames;

            TooltipsEnabledEventEmmiter.OnTooltipsEnabled += OnChangeInTooltipEnablingReceived;
        }

        private void OnChangeInTooltipEnablingReceived(bool isTooltipEnabled)
        {
            viewModel.IsTooltipEnabled = isTooltipEnabled;
        }

        private void btnPosalji_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Uspešno slanje", "OBAVEŠTENJE");
            viewModel.Name = "";
            viewModel.Quantity = 0;
            viewModel.Date = null;
            viewModel.Time = null;
            viewModel.Room = "";
            viewModel.Notes = "";
        }
    }
}
