using HCI_projekat.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HCI_projekat.ViewModels.Medicines
{
    public class MedicinesViewModel : ViewModelBase
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

        private readonly ObservableCollection<Medicine> _medicines;
        public IEnumerable<Medicine> Medicines => _medicines;

        public MedicinesViewModel(ObservableCollection<Medicine> medicines)
        {
            _medicines = medicines;
        }
    }
}
