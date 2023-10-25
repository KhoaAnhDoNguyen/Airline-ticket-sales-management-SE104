using Airline_ticket_sales_management.Usercontrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_ticket_sales_management
{
    public partial class SettingUC : UserControl
    {
        public SettingUC()
        {
            InitializeComponent();
        }

        private void SettingUC_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; ++i)
            {
                AirportItemUC uc = new AirportItemUC();
                pnListAirport.Controls.Add(uc);
                uc.BringToFront();
                uc.Dock = DockStyle.Top;

                Panel pn = new Panel();
                pnListAirport.Controls.Add(pn);
                pn.Height = 2;
                pn.BackColor = Color.Gray;
                pn.BringToFront();
                pn.Dock = DockStyle.Top;
            }

            for (int i = 0; i < 20; ++i)
            {
                TicketClassItemUC uc = new TicketClassItemUC();
                pnListTicketClass.Controls.Add(uc);
                uc.BringToFront();
                uc.Dock = DockStyle.Top;

                Panel pn = new Panel();
                pnListTicketClass.Controls.Add(pn);
                pn.Height = 2;
                pn.BackColor = Color.Gray;
                pn.BringToFront();
                pn.Dock = DockStyle.Top;
            }
        }
    }
}
