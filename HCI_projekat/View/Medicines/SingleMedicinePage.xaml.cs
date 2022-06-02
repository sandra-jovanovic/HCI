using HCI_projekat.Events;
using HCI_projekat.Model;
using HCI_projekat.Navigation;
using HCI_projekat.ViewModels.Medicines;
using System.Windows;
using System.Windows.Controls;

namespace HCI_projekat.View.Medicines
{
    /// <summary>
    /// Interaction logic for SingleMedicinePage.xaml
    /// </summary>
    public partial class SingleMedicinePage : Page
    {
        private SingleMedicineViewModel _viewModel;
        public SingleMedicinePage(Medicine medicine)
        {
            InitializeComponent();

            _viewModel = new();
            _viewModel.Id = medicine.Id;
            _viewModel.Name = medicine.Name;
            _viewModel.Category = medicine.Category;
            _viewModel.ReasonNotAccepting = medicine.ReasonForNotAccepting;
            _viewModel.ApprovingState = medicine.Approved ? "odobreno" : "neodobreno";

            DataContext = _viewModel;
            _viewModel.IsTooltipEnabled = HomePageStateManager.AreTooltipsEnabled;

            TooltipsEnabledEventEmmiter.OnTooltipsEnabled += OnChangeInTooltipEnablingReceived;
        }

        private void OnChangeInTooltipEnablingReceived(bool isTooltipEnabled)
        {
            _viewModel.IsTooltipEnabled = isTooltipEnabled;
        }

        private void btnPosalji_Click(object sender, RoutedEventArgs e)
        {
            if (_viewModel.ApprovingState == "neodobreno" && string.IsNullOrEmpty(_viewModel.ReasonNotAccepting))
            {
                MessageBox.Show("Potrebno je da unese razlog zbog kog lek nije odboren");
                return;
            } else
            {
                MessageBox.Show("Uspesno poslato");
                HomePageStateManager.NavigationFrame.Navigate(new MedicinesPage());
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            tbReason.IsEnabled = false;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            tbReason.IsEnabled = true;
            _viewModel.ReasonNotAccepting = "";
        }
    }
}
