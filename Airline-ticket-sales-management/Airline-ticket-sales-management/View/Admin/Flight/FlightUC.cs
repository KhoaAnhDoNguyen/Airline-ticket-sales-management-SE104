using System.Collections.ObjectModel;

namespace Airline_ticket_sales_management
{
    public partial class FlightUC : UserControl
    {
        //private ObservableCollection<Flight> flights { get; set; }

        public FlightUC()
        {
            InitializeComponent();
            loadBody(new FlightListUC());
        }
        
        private void loadBody(UserControl uc)
        {
            pnBodyFlight.Controls.Clear();
            pnBodyFlight.Controls.Add(uc);
        }
    }
}
