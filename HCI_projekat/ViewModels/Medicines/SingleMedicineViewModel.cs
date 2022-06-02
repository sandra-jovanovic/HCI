using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_projekat.ViewModels.Medicines
{
    public class SingleMedicineViewModel : ViewModelBase
    {
        private string _id;
        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

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

        private string _category;
        public string Category
        {
            get { return _category; }
            set
            {
                _category = value;
                OnPropertyChanged(nameof(Category));
            }
        }

        private string _approvingState;
        public string ApprovingState
        {
            get { return _approvingState; }
            set
            {
                _approvingState = value;
                OnPropertyChanged(nameof(ApprovingState));
            }
        }

        private string _reasonNotAccepting;
        public string ReasonNotAccepting
        {
            get { return _reasonNotAccepting; }
            set
            {
                _reasonNotAccepting = value;
                OnPropertyChanged(nameof(ReasonNotAccepting));
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
