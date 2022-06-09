using HCI_projekat.Events;
using HCI_projekat.Navigation;
using HCI_projekat.View.Medicines;
using HCI_projekat.ViewModels.Examination;
using System.Windows;
using System.Windows.Controls;

namespace HCI_projekat.View
{
    /// <summary>
    /// Interaction logic for HomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        private Frame _mainFrameDoctor;
        private HomeWindowViewModel viewModel;
        public HomeWindow()
        {
            InitializeComponent();
            double screenWidth = SystemParameters.PrimaryScreenWidth;
            double screenHeight = SystemParameters.PrimaryScreenHeight;
            double windowWidth = this.Width;
            double windowHeight = this.Height;
            Left = (screenWidth / 2) - (windowWidth / 2);
            Top = (screenHeight / 2) - (windowHeight / 2);

            viewModel = new HomeWindowViewModel();
            DataContext = viewModel;

            _mainFrameDoctor = this.MainFrameDoctor;
            HomePageStateManager.NavigationFrame = _mainFrameDoctor;

            _mainFrameDoctor.NavigationService.Navigate(new ExaminationView());
            lwMain.SelectedIndex = 0;
        }

        public object NavigationService { get; internal set; }

        private void Pregledi_Selected(object sender, RoutedEventArgs e)
        {
            _mainFrameDoctor.NavigationService.Navigate(new ExaminationView());
        }

        private void Kartoni_Selected(object sender, RoutedEventArgs e)
        {
            _mainFrameDoctor.NavigationService.Navigate(new MedicalRecordsPage());
        }

        private void Requirements_Selected(object sender, RoutedEventArgs e)
        {
            _mainFrameDoctor.NavigationService.Navigate(new RequestsPage());
        }

        private void btnOdjava_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = MessageBox.Show("Da li ste sigurni da želite da se odjavite?", "ODJAVA", MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                LoginPage loginPage = new LoginPage();
                MainWindow mainWindow = new MainWindow();
                mainWindow.MainFrame.NavigationService.Navigate(loginPage);
                mainWindow.Show();
                Close();
            }
        }

        private void chbPomoc_Checked(object sender, RoutedEventArgs e)
        {
            TooltipsEnabledEventEmmiter.Emit(true);
        }

        private void chbPomoc_Unchecked(object sender, RoutedEventArgs e)
        {
            TooltipsEnabledEventEmmiter.Emit(false);
        }

        private void liNotifikacije_Selected(object sender, RoutedEventArgs e)
        {
            _mainFrameDoctor.NavigationService.Navigate(new NotificationsPage());
        }

        private void lwLekovi_Selected(object sender, RoutedEventArgs e)
        {

            _mainFrameDoctor.NavigationService.Navigate(new MedicinesPage());
        }
    }
}
