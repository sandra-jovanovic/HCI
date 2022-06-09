using HCI_projekat.Events;
using HCI_projekat.Model;
using HCI_projekat.Navigation;
using HCI_projekat.ViewModels.MedicalRecords;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace HCI_projekat.View
{
    /// <summary>
    /// Interaction logic for MedicalRecordsPage.xaml
    /// </summary>
    public partial class MedicalRecordsPage : Page
    {
        private MedicalRecordsOverviewViewModel viewModel;
        private readonly ObservableCollection<MedicalRecord> _medicalRecords = new()
        {
            new MedicalRecord("Ana", "Ikonic", "A776", DateTime.Parse("02-05-2001"), "12432483672135", "Radnicka 12", "064777888", false, true),
            new MedicalRecord("Milana", "Dokic", "k16a", DateTime.Parse("11-11-2002"), "21543483672135", "Solunska 24", "063111288", false, false),
            new MedicalRecord("Sandra", "Jovanovic", "555KL", DateTime.Parse("11-11-2002"), "21543483672135", "Solunska 24", "063111288", false, false),
            new MedicalRecord("Ana", "Lazic", "LL12", DateTime.Parse("11-11-2002"), "21543483672135", "Solunska 24", "063111288", false, false),
        };
        public MedicalRecordsPage()
        {
            InitializeComponent();
            viewModel = new MedicalRecordsOverviewViewModel(_medicalRecords);
            DataContext = viewModel;
            viewModel.IsTooltipEnabled = HomePageStateManager.AreTooltipsEnabled;

            TooltipsEnabledEventEmmiter.OnTooltipsEnabled += OnChangeInTooltipEnablingReceived;
        }

        private void OnChangeInTooltipEnablingReceived(bool isTooltipEnabled)
        {
            viewModel.IsTooltipEnabled = isTooltipEnabled;
        }

        private void btnPrikazKartona_Click(object sender, RoutedEventArgs e)
        {
            if (dgKartoni.SelectedIndex == -1)
            {
                MessageBox.Show("Nijedan karton nije izabran");
                return;
            }

            var selecedMedicalRecord = (MedicalRecord)dgKartoni.SelectedItem;
            HomePageStateManager.NavigationFrame.Navigate(new MedicalRecordPage(selecedMedicalRecord));
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            var filteredList = _medicalRecords.Where(m => m.Number.ToLower().Contains(tbSearch.Text.ToLower())).ToList();
            viewModel.MedicalRecords = new ObservableCollection<MedicalRecord>(filteredList);
        }
    }
}
