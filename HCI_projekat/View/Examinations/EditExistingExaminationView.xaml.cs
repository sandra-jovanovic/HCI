using HCI_projekat.Model;
using HCI_projekat.Navigation;
using HCI_projekat.ViewModels.Examination;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace HCI_projekat.View.Examinations
{
    /// <summary>
    /// Interaction logic for EditExistingExaminationView.xaml
    /// </summary>
    public partial class EditExistingExaminationView : Page
    {
        private SingleExaminationViewModel viewModel;
        private List<string> freeRooms = new()
        {
            "A-234", "C-222", "123-M"
        };
        private List<string> pacients = new()
        {
            "Sandra Jovanovic", "Jovana Ilic", "Marko Simovic"
        };

        public EditExistingExaminationView(ScheduledExamination examination)
        {
            InitializeComponent();
            viewModel = new();
            viewModel.User = examination.FirstName + " " + examination.LastName;
            viewModel.ExaminationDate = examination.Date;
            viewModel.ExaminationTime = examination.Date;
            viewModel.Type = examination.Type;
            viewModel.Room = examination.Room;
            viewModel.TherapyDuration = examination.Duration;

            DataContext = viewModel;

            cbPacijenti.ItemsSource = pacients;
            cbSlobodneProstorije.ItemsSource = freeRooms;
        }

        private void btnOdustani_Click(object sender, RoutedEventArgs e)
        {
            HomePageStateManager.NavigationFrame.Navigate(new ExaminationView());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Uspešno izmenjeno", "OBAVEŠTENJE");
        }
    }
}
