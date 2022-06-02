using HCI_projekat.Events;
using HCI_projekat.Model;
using HCI_projekat.Navigation;
using HCI_projekat.ViewModels.Medicines;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace HCI_projekat.View.Medicines
{
    /// <summary>
    /// Interaction logic for MedicinesPage.xaml
    /// </summary>
    public partial class MedicinesPage : Page
    {
        private MedicinesViewModel _viewModel;
        private ObservableCollection<Medicine> _medicines = new()
        {
            new Medicine("1-A", "Brufen", "Antibiotik", false, "Nov lek"),
            new Medicine("1-B", "Paracetamol", "Antibiotik", false, "Nisu podaci uneti"),
            new Medicine("2-M", "Vitamin C", "Vitamin", true, ""),
        };

        public MedicinesPage()
        {
            InitializeComponent();
            _viewModel = new MedicinesViewModel(_medicines);

            DataContext = _viewModel;
            _viewModel.IsTooltipEnabled = HomePageStateManager.AreTooltipsEnabled;

            TooltipsEnabledEventEmmiter.OnTooltipsEnabled += OnChangeInTooltipEnablingReceived;
        }

        private void OnChangeInTooltipEnablingReceived(bool isTooltipEnabled)
        {
            _viewModel.IsTooltipEnabled = isTooltipEnabled;
        }

        private void btnPrikazLeka_Click(object sender, RoutedEventArgs e)
        {
            if (dgLekovi.SelectedIndex == -1)
            {
                MessageBox.Show("Nijedan lek nije izabran");
                return;
            }

            var selecedMedicine = (Medicine)dgLekovi.SelectedItem;
            HomePageStateManager.NavigationFrame.Navigate(new SingleMedicinePage(selecedMedicine));
        }
    }
}
