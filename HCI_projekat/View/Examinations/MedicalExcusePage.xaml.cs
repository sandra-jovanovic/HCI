using HCI_projekat.Events;
using HCI_projekat.Navigation;
using HCI_projekat.ViewModels.Examination;
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
    /// Interaction logic for MedicalExcusePage.xaml
    /// </summary>
    public partial class MedicalExcusePage : Page
    {
        private MedicalExcuseViewModel viewModel;
        public MedicalExcusePage()
        {
            InitializeComponent();

            viewModel = new();
            viewModel.Name = "Sandra";
            viewModel.LastName = "Jovanovic";
            viewModel.ExaminationDate = DateOnly.FromDateTime(DateTime.Now);
            viewModel.ExaminationTime = TimeOnly.FromDateTime(DateTime.Now);
            viewModel.MedicalRecord = "1352B";
            viewModel.Room = "12-C";

            viewModel.IsTooltipEnabled = HomePageStateManager.AreTooltipsEnabled;

            DataContext = viewModel;

            TooltipsEnabledEventEmmiter.OnTooltipsEnabled += OnChangeInTooltipEnablingReceived;
        }

        private void OnChangeInTooltipEnablingReceived(bool isTooltipEnabled)
        {
            viewModel.IsTooltipEnabled = isTooltipEnabled;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(viewModel);
            MessageBox.Show("Uspešno izdato", "OBAVEŠTENJE");
            viewModel.Description = "";
        }
    }
}
