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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        public void pibClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadBody(UserControl uc)
        {
            apnMain.Controls.Clear();
            apnMain.Controls.Add(uc);
        }
    }
}
