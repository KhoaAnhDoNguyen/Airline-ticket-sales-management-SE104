using System.Collections.ObjectModel;

namespace Airline_ticket_sales_management
{
    public partial class FlightUC : UserControl
    {
        //private ObservableCollection<Flight> flights { get; set; }

        public FlightUC()
        {
            InitializeComponent();
        }

        private void pnListFlight_Paint(object sender, PaintEventArgs e)
        {
            //GraphicsPath path = RoundedRectangle.Create(pnListFlight.Width, pnListFlight.Height, 10);
            //pnListFlight.Region = new Region(path);

            // Tạo một Pen mới với màu sắc và độ dày mong muốn
            Pen pen = new Pen(Color.FromArgb(202, 240, 248), 7);

            Graphics graphics = e.Graphics;

            // Vẽ đường viền bằng GraphicsPath và Pen
            //graphics.DrawPath(pen, path);

            base.OnPaint(e);
        }

        private void FlightUC_Load(object sender, EventArgs e)
        {

        }
    }
}
