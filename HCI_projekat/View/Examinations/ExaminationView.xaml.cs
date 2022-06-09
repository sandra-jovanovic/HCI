using HCI_projekat.Events;
using HCI_projekat.Model;
using HCI_projekat.Navigation;
using HCI_projekat.View.Examinations;
using HCI_projekat.ViewModels.Examination;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace HCI_projekat.View
{
    /// <summary>
    /// Interaction logic for ExaminationView.xaml
    /// </summary>
    public partial class ExaminationView : Page
    {
        private ExaminationsOverviewViewModel viewModel;
        private ObservableCollection<ScheduledExamination> examinations = new()
        {
            new ScheduledExamination() { FirstName = "Sandra", LastName = "Jovanovic", Date = DateTime.Now, MedicalRecord = "F4AF", Room = "A-234", Type = "pregled", Duration = 2 },
            new ScheduledExamination() { FirstName = "Ana", LastName = "Ikonic", Date = DateTime.Parse("02-02-2018"), MedicalRecord = "F89B", Room = "A-234", Type = "kontrola", Duration = 1 }
        };

        public ExaminationView()
        {
            InitializeComponent();

            viewModel = new ExaminationsOverviewViewModel(examinations);
            DataContext = viewModel;
            viewModel.IsTooltipEnabled = HomePageStateManager.AreTooltipsEnabled;

            TooltipsEnabledEventEmmiter.OnTooltipsEnabled += OnChangeInTooltipEnablingReceived;
        }

        private void OpenSchedule(object sender, RoutedEventArgs e)
        {
            HomePageStateManager.NavigationFrame.Navigate(new ScheduleNewExaminationView());
        }

        private void OnChangeInTooltipEnablingReceived(bool isTooltipEnabled)
        {
            viewModel.IsTooltipEnabled = isTooltipEnabled;
        }

        private void btnOtkazi_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridExamination.SelectedIndex == -1)
            {
                MessageBox.Show("Nijedan pregled nije izabran");
                return;
            }

            var selecedExamination = (ScheduledExamination)dataGridExamination.SelectedItem;
            MessageBoxResult messageBoxResult = MessageBox.Show("Da li ste sigurni da želite da otkažete pregled?", "OTKAŽI", MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                examinations.Remove(selecedExamination);
            }
        }

        private void btnObaviPregled_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridExamination.SelectedIndex == -1)
            {
                MessageBox.Show("Nijedan pregled nije izabran");
                return;
            }

            var selecedExamination = (ScheduledExamination)dataGridExamination.SelectedItem;
            HomePageStateManager.NavigationFrame.Navigate(new ExamineExaminationPage(selecedExamination));
        }

        private void btnIzmeni_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridExamination.SelectedIndex == -1)
            {
                MessageBox.Show("Nijedan pregled nije izabran");
                return;
            }

            var selecedExamination = (ScheduledExamination)dataGridExamination.SelectedItem;
            HomePageStateManager.NavigationFrame.Navigate(new EditExistingExaminationView(selecedExamination));
        }

        private void btnPretraga_Click(object sender, RoutedEventArgs e)
        {
            var filter = tbSearch.Text.ToLower();
            var filteredList = examinations.Where(e => e.FirstName.ToLower().Contains(filter) ||
                                                  e.LastName.ToLower().Contains(filter) || 
                                                  e.MedicalRecord.ToLower().Contains(filter) ||
                                                  e.Room.ToLower().Contains(filter) ||
                                                  e.Date.ToString().Contains(filter)).ToList();

            viewModel.Examinations = new ObservableCollection<ScheduledExamination>(filteredList);
        }
    }
}
