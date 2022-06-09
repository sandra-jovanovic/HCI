using HCI_projekat.Events;
using HCI_projekat.Model;
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
        private readonly ScheduledExamination _examination;
        public MedicalExcusePage(ScheduledExamination examination)
        {
            InitializeComponent();

            _examination = examination;

            viewModel = new();
            viewModel.Name = examination.FirstName;
            viewModel.LastName = examination.LastName;
            viewModel.ExaminationDate = DateOnly.FromDateTime(examination.Date);
            viewModel.ExaminationTime = TimeOnly.FromDateTime(examination.Date);
            viewModel.MedicalRecord = examination.MedicalRecord;
            viewModel.Room = examination.Room;

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

            HomePageStateManager.NavigationFrame.Navigate(new ExamineExaminationPage(_examination));
        }

        private void btnOdustani_Click(object sender, RoutedEventArgs e)
        {
            HomePageStateManager.NavigationFrame.Navigate(new ExamineExaminationPage(_examination));
        }
    }
}
