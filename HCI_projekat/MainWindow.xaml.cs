using HCI_projekat.Navigation;
using HCI_projekat.View;
using HCI_projekat.Wizard;
using System.IO;
using System.Windows;

namespace HCI_projekat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            double screenWidth = SystemParameters.PrimaryScreenWidth;
            double screenHeight = SystemParameters.PrimaryScreenHeight;
            double windowWidth = this.Width;
            double windowHeight = this.Height;
            Left = (screenWidth / 2) - (windowWidth / 2);
            Top = (screenHeight / 2) - (windowHeight / 2);

            LoginPage loginPage = new LoginPage();
            MainFrame.NavigationService.Navigate(loginPage);

            if (!File.Exists("app_used.bin"))
            {
                WizardWindow win = new WizardWindow();
                win.ShowDialog();

                File.Create("app_used.bin");
            }

        }

    }
}
