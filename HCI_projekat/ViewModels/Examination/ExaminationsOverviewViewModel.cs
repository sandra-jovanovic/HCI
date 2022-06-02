using HCI_projekat.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HCI_projekat.ViewModels.Examination
{
    public class ExaminationsOverviewViewModel : ViewModelBase
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

        private ObservableCollection<ScheduledExamination> _examinations;
        public IEnumerable<ScheduledExamination> Examinations
        {
            get { return _examinations; }
            set { 
                _examinations = (ObservableCollection<ScheduledExamination>) value;
                OnPropertyChanged(nameof(Examinations));
            }
        }

        public ExaminationsOverviewViewModel(ObservableCollection<ScheduledExamination> examinations)
        {
            _examinations = examinations;
        }
    }
}
