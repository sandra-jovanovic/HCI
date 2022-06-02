using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_projekat.ViewModels.Examination
{
    public class MedicalExcuseViewModel : ViewModelBase
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
        private string _description;
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
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
