using HCI_projekat.Navigation;
using System;

namespace HCI_projekat.Events
{
    public static class TooltipsEnabledEventEmmiter
    {
        public static void Emit(bool isEnabled)
        {
            OnTooltipsEnabled(isEnabled);
            HomePageStateManager.AreTooltipsEnabled = isEnabled;
        }

        public static Action<bool> OnTooltipsEnabled;
    }
}
