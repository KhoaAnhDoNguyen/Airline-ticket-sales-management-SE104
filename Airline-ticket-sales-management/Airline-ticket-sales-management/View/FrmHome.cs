using Airline_ticket_sales_management.AControls;
using Airline_ticket_sales_management.Utils;
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
    public partial class FrmHome : Form
    {
        private AButton currentButton = null;

        public FrmHome()
        {
            InitializeComponent();
            loadBody(new ReportUC());
        }

        private void loadBody(UserControl uc)
        {
            pnBody.Controls.Clear();
            pnBody.Controls.Add(uc);
        }

        private void pcbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void doActivateButton(AButton abtn)
        {
            abtn.ForeColor = BaseColor.XanhDam;
            abtn.Font = new Font(abtn.Font, FontStyle.Bold);
            abtn.LineType = AButton.LineStyles.Bottom;
        }

        private void doDeactivateButton(AButton abtn)
        {
            abtn.ForeColor = BaseColor.Xam;
            abtn.Font = new Font(abtn.Font, FontStyle.Regular);
            abtn.LineType = AButton.LineStyles.None;
        }

        private void pcbLogo_Click(object sender, EventArgs e)
        {
            if (currentButton != null)
            {
                doDeactivateButton(currentButton);
            }

            currentButton = null;
            loadBody(new HomeAdminUC());
        }

        private void abtnFlight_Click(object sender, EventArgs e)
        {
            if (currentButton != abtnFlight)
            {
                if (currentButton != null)
                {
                    doDeactivateButton(currentButton);
                }

                currentButton = abtnFlight;
                doActivateButton(currentButton);
                loadBody(new FlightUC());
            }
        }

        private void abtnPlane_Click(object sender, EventArgs e)
        {
            if (currentButton != abtnPlane)
            {
                if (currentButton != null)
                {
                    doDeactivateButton(currentButton);
                }

                currentButton = abtnPlane;
                doActivateButton(currentButton);
                loadBody(new PlaneUC());
            }
        }

        private void abtnReport_Click(object sender, EventArgs e)
        {
            if (currentButton != abtnReport)
            {
                if (currentButton != null)
                {
                    doDeactivateButton(currentButton);
                }

                currentButton = abtnReport;
                doActivateButton(currentButton);
                loadBody(new ReportUC());
            }
        }
    }
}
