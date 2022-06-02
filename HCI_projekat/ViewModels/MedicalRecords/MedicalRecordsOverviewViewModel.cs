using HCI_projekat.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HCI_projekat.ViewModels.MedicalRecords
{
    public class MedicalRecordsOverviewViewModel : ViewModelBase
    {
        private bool _isTooltipEnabled;
        public bool IsTooltipEnabled
        {
            get { return _isTooltipEnabled; }
            set
            {
                _isTooltipEnabled = value;
                OnPropertyChanged(nameof(IsTooltipEnabled));
            }
        }

        private ObservableCollection<MedicalRecord> _medicalRecords;
        public IEnumerable<MedicalRecord> MedicalRecords
        {
            get { return _medicalRecords; }
            set { 
                _medicalRecords = (ObservableCollection<MedicalRecord>) value;
                OnPropertyChanged(nameof(MedicalRecords));
            }
        }

        public MedicalRecordsOverviewViewModel(ObservableCollection<MedicalRecord> medicalRecords)
        {
            _medicalRecords = medicalRecords;
        }
    }
}
