using System;

namespace HCI_projekat.ViewModels.MedicalRecords
{
    public class SingleMedicalRecordViewModel : ViewModelBase
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }

        private string _medicalRecordNumber;
        public string MedicalRecordNumber
        {
            get { return _medicalRecordNumber; }
            set
            {
                _medicalRecordNumber = value;
                OnPropertyChanged(nameof(MedicalRecordNumber));
            }
        }

        private DateOnly _birthDate;
        public DateOnly BirthDate
        {
            get { return _birthDate; }
            set
            {
                _birthDate = value;
                OnPropertyChanged(nameof(BirthDate));
            }
        }

        private string _jmbg;
        public string JMBG
        {
            get { return _jmbg; }
            set
            {
                _jmbg = value;
                OnPropertyChanged(nameof(JMBG));
            }
        }

        private string _address;
        public string Address
        {
            get { return _address; }
            set
            {
                _address = value;
                OnPropertyChanged(nameof(Address));
            }
        }

        private string _phone;
        public string Phone
        {
            get { return _phone; }
            set
            {
                _phone = value;
                OnPropertyChanged(nameof(Phone));
            }
        }

        private bool _married;
        public bool Married
        {
            get { return _married; }
            set
            {
                _married = value;
                OnPropertyChanged(nameof(Married));
            }
        }

        private bool _employed;
        public bool Employed
        {
            get { return _employed; }
            set
            {
                _employed = value;
                OnPropertyChanged(nameof(Employed));
            }
        }
    }
}
