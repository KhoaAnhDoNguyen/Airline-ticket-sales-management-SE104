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
    public partial class ReportUC : UserControl
    {
        public ReportUC()
        {
            InitializeComponent();
            acbTypeReport.SelectedIndex = 0;
        }

        private void loadBody(UserControl uc)
        {
            pnBodyReport.Controls.Clear();
            pnBodyReport.Controls.Add(uc);
        }

        private void acbTypeReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (acbTypeReport.SelectedIndex == 0)
            {
                loadBody(new ReportByMonthUC());
            }
            else
            {
                loadBody(new ReportByYearUC());
            }
        }
    }
}
