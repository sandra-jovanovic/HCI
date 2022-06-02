using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace HCI_projekat.View
{
    /// <summary>
    /// Interaction logic for Notifications.xaml
    /// </summary>
    public partial class NotificationsPage : Page
    {
        private readonly ObservableCollection<string> _notifications = new()
        {
            "Novi lekovi ubaceni u sistem.",
            "Zakazan je sastanak u sali 414 u ponedeljak, 21.12.2022. u 19.00h",
            "Odobreni slobodni dani za 24.05. i 25.05."
        };

        public NotificationsPage()
        {
            InitializeComponent();

            lvNotifikacije.ItemsSource = _notifications;
        }
    }
}
