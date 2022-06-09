using MVVMC;

namespace HCI_projekat.Wizard
{
    public class Model
    {
        public string Position { get; set; }
    }

    public class WizardController : Controller
    {
        private Model _model;

        public override void Initial()
        {
            FirstStep();
        }

        private void FirstStep()
        {
            _model = new Model();
            ExecuteNavigation();
        }

        private void SecondStep()
        {
            ExecuteNavigation();
        }

        private void RequestsStep()
        {
            ExecuteNavigation();
        }

        private void ExaminationsStep()
        {
            ExecuteNavigation();
        }

        private void MedicalRecordsStep()
        {
            ExecuteNavigation();
        }

        private void MedicinesStep()
        {
            ExecuteNavigation();
        }

        private void NotificationsStep()
        {
            ExecuteNavigation();
        }

        private void HelpStep()
        {
            ExecuteNavigation();
        }

        private void EndStep()
        {
            ExecuteNavigation();
        }

        public void Next()
        {
            if (this.GetCurrentPageName() + "View" == nameof(FirstStepView))
            {
                SecondStep();
            }
            else if (this.GetCurrentViewModel() is SecondStepViewModel secondStepViewModel)
            {
                _model.Position = GetPosition(secondStepViewModel);
                if (_model.Position == "Lekar")
                {
                    ExaminationsStep();
                } else if (_model.Position == "Medicinski tehničar")
                {
                    MedicalRecordsStep();
                } else if (_model.Position == "Pomoćno osoblje")
                {
                    NotificationsStep();
                }
            }
            else if (this.GetCurrentPageName() + "View" == nameof(ExaminationsStepView))
            {
                RequestsStep();
            }
            else if (this.GetCurrentPageName() + "View" == nameof(RequestsStepView))
            {
                MedicalRecordsStep();
            }
            else if (this.GetCurrentPageName() + "View" == nameof(MedicalRecordsStepView))
            {
                if (_model.Position == "Lekar")
                {
                    MedicinesStep();
                } else if (_model.Position == "Medicinski tehničar")
                {
                    NotificationsStep();
                }
            }
            else if (this.GetCurrentPageName() + "View" == nameof(MedicinesStepView))
            {
                NotificationsStep();
            }
            else if (this.GetCurrentPageName() + "View" == nameof(NotificationsStepView))
            {
                HelpStep();
            }
            else if (this.GetCurrentPageName() + "View" == nameof(HelpStepView))
            {
                EndStep();
            }
            else
            {
                ClearHistory();
                FirstStep();
            }
        }

        private string GetPosition(SecondStepViewModel secondStepViewModel)
        {
            if (secondStepViewModel.IsDoctor)
                return "Lekar";
            else if (secondStepViewModel.IsMedicalTechnician)
                return "Medicinski tehničar";
            else
                return "Pomoćno osoblje";
        }
    }
}
