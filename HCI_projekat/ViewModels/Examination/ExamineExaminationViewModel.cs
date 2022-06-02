using System;

namespace HCI_projekat.ViewModels.Examination
{
    public class ExamineExaminationViewModel : ViewModelBase
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
        private string _therapy;
        public string Therapy
        {
            get
            {
                return _therapy;
            }
            set
            {
                _therapy = value;

                if (string.IsNullOrEmpty(value))
                {
                    CheckError();
                    throw new ArgumentException("Terapija mora da bude izabrana");
                }

                OnPropertyChanged(nameof(Therapy));
                CheckError();
            }
        }
        private int? _therapyDuration;
        public int? TherapyDuration
        {
            get
            {
                return _therapyDuration;
            }
            set
            {
                _therapyDuration = value;
                if (value == 0)
                {
                    CheckError();
                    throw new ArgumentException("Trajanje terapije mora da bude uneto");
                }

                OnPropertyChanged(nameof(TherapyDuration));
                CheckError();
            }
        }
        private int? _dailyTherapyDuration;
        public int? DailyTherapyDuration
        {
            get
            {
                return _dailyTherapyDuration;
            }
            set
            {
                _dailyTherapyDuration = value;

                if (value == 0)
                {
                    CheckError();
                    throw new ArgumentException("Dužina dnevne terapija mora da bude veća od nule");
                }

                
                OnPropertyChanged(nameof(DailyTherapyDuration));
                CheckError();
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

        private bool _withoutError = false;
        public bool WithoutError
        {
            get { return _withoutError; }
            set
            {
                _withoutError = value;
                OnPropertyChanged(nameof(WithoutError));
            }
        }

        private void CheckError()
        {
            try
            {
                WithoutError = !string.IsNullOrEmpty(_therapy) && 
                                _therapyDuration is not null && _therapyDuration != 0 && 
                                _dailyTherapyDuration is not null && _dailyTherapyDuration != 0;
            } catch (ArgumentException ex)
            {
                WithoutError = false;
            }
        }
    }
}
