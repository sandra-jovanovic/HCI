using MVVMC;

namespace HCI_projekat.Wizard
{
    public class SecondStepViewModel : MVVMCViewModel
    {
        private bool _isDoctor;
        public bool IsDoctor
        {
            get { return _isDoctor; }
            set
            {
                _isDoctor = value;
                OnPropertyChanged();
            }
        }

        private bool _isMedicalTecnician;
        public bool IsMedicalTechnician
        {
            get { return _isMedicalTecnician; }
            set
            {
                _isMedicalTecnician = value;
                OnPropertyChanged();
            }
        }

        private bool _isSupportStaff;
        public bool IsSupportStaff
        {
            get { return _isSupportStaff; }
            set
            {
                _isSupportStaff = value;
                OnPropertyChanged();
            }
        }
    }
}
