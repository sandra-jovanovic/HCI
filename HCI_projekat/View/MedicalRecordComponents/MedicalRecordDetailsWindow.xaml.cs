using HCI_projekat.Model;
using System.Windows;

namespace HCI_projekat.View.MedicalRecordComponents
{
    /// <summary>
    /// Interaction logic for MedicalRecordDetails.xaml
    /// </summary>
    public partial class MedicalRecordDetailsWindow : Window
    {
        public MedicalRecordDetailsWindow(MedicalReport medicalReport)
        {
            InitializeComponent();
            double screenWidth = SystemParameters.PrimaryScreenWidth;
            double screenHeight = SystemParameters.PrimaryScreenHeight;
            double windowWidth = this.Width;
            double windowHeight = this.Height;
            Left = (screenWidth / 2) - (windowWidth / 2);
            Top = (screenHeight / 2) - (windowHeight / 2);

            DataContext = medicalReport;
        }
    }
}
