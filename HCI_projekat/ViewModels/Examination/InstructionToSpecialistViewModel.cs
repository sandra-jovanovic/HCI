using System;

namespace HCI_projekat.ViewModels.Examination
{
    public class InstructionToSpecialistViewModel : ViewModelBase
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
        private string _specialist;
        public string Specialist
        {
            get
            {
                return _specialist;
            }
            set
            {
                _specialist = value;
                OnPropertyChanged(nameof(Specialist));
            }
        }

        private DateTime? _therapyDate;
        public DateTime? TherapyDate
        {
            get
            {
                return _therapyDate;
            }
            set
            {
                _therapyDate = value;
                OnPropertyChanged(nameof(TherapyDate));
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
