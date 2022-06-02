using System;

namespace HCI_projekat.ViewModels.Examination
{
    public class KeepInHospitalViewModel : ViewModelBase
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }
        private DateOnly _examinationDate;
        public DateOnly ExaminationDate
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
        private TimeOnly _examinationTime;
        public TimeOnly ExaminationTime
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
        private string _medicalRecord;
        public string MedicalRecord
        {
            get
            {
                return _medicalRecord;
            }
            set
            {
                _medicalRecord = value;
                OnPropertyChanged(nameof(MedicalRecord));
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
        private string _notes;
        public string Notes
        {
            get
            {
                return _notes;
            }
            set
            {
                _notes = value;
                OnPropertyChanged(nameof(Notes));
            }
        }

        private DateTime? _startingDate;
        public DateTime? StartingDate
        {
            get
            {
                return _startingDate;
            }
            set
            {
                _startingDate = value;
                OnPropertyChanged(nameof(StartingDate));
            }
        }

        private int _duration;
        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                _duration = value;
                OnPropertyChanged(nameof(Duration));
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
