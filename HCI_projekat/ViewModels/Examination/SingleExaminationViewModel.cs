using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_projekat.ViewModels.Examination
{
    public class SingleExaminationViewModel : ViewModelBase
    {
        private string _user;
        public string User
        {
            get
            {
                return _user;
            }
            set
            {
                _user = value;
                OnPropertyChanged(nameof(User));
            }
        }

        private DateTime? _examinationDate;
        public DateTime? ExaminationDate
        {
            get
            {
                return _examinationDate;
            }
            set
            {
                _examinationDate = value;
                OnPropertyChanged(nameof(ExaminationDate));
            }
        }
        private DateTime? _examinationTime;
        public DateTime? ExaminationTime
        {
            get
            {
                return _examinationTime;
            }
            set
            {
                _examinationTime = value;
                OnPropertyChanged(nameof(ExaminationTime));
            }
        }

        private int _therapyDuration;
        public int TherapyDuration
        {
            get
            {
                return _therapyDuration;
            }
            set
            {
                _therapyDuration = value;
                OnPropertyChanged(nameof(TherapyDuration));
            }
        }

        private string _room;
        public string Room
        {
            get
            {
                return _room;
            }
            set
            {
                _room = value;
                OnPropertyChanged(nameof(Room));
            }
        }

        private string _type;
        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }

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
    }
}
