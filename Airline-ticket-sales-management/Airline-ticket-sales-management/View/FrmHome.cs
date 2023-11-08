using Airline_ticket_sales_management.AControls;
using Airline_ticket_sales_management.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_ticket_sales_management
{
    public partial class FrmHome : Form
    {
        private AButton currentButton = null;
        private UserControl oldBody = null;

        public FrmHome()
        {
            InitializeComponent();
            loadBody(new PlaneUC());
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath path = RoundedRectangle.Create(this.Width, this.Height, 40);

            // Đặt Region cho Form để tạo hình dạng bo tròn
            this.Region = new Region(path);
        }

        private void loadBody(UserControl uc)
        {
            if (oldBody != null)
            {
                pnBody.Controls.Remove(oldBody);
            }

            pnBody.Controls.Add(uc);
            oldBody = uc;
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

                loadBody(new LoadingUC());

                FlightUC newBody = new FlightUC();
                loadBody(newBody);
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

        private void abtnSetting_Click(object sender, EventArgs e)
        {
            if (currentButton != abtnReport)
            {
                if (currentButton != null)
                {
                    doDeactivateButton(currentButton);
                }

                currentButton = abtnSetting;
                doActivateButton(currentButton);
                loadBody(new SettingUC());
            }
        }

        private void abtnFlightTicket_Click(object sender, EventArgs e)
        {
            if (currentButton != abtnFlightTicket)
            {
                if (currentButton != null)
                {
                    doDeactivateButton(currentButton);
                }

                currentButton = abtnFlightTicket;
                doActivateButton(currentButton);
                loadBody(new FlightTicketUC());
            }
        }
    }
}
