namespace Airline_ticket_sales_management
{
    partial class FlightUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnMenuFlight = new Panel();
            pnLine = new Panel();
            aButton3 = new AControls.AButton();
            aButton1 = new AControls.AButton();
            aButton2 = new AControls.AButton();
            pnBodyFlight = new Panel();
            flightListUC = new FlightListUC();
            pnMenuFlight.SuspendLayout();
            pnBodyFlight.SuspendLayout();
            SuspendLayout();
            // 
            // pnMenuFlight
            // 
            pnMenuFlight.BackColor = Color.Transparent;
            pnMenuFlight.Controls.Add(pnLine);
            pnMenuFlight.Controls.Add(aButton3);
            pnMenuFlight.Controls.Add(aButton1);
            pnMenuFlight.Controls.Add(aButton2);
            pnMenuFlight.Dock = DockStyle.Top;
            pnMenuFlight.Location = new Point(0, 0);
            pnMenuFlight.Margin = new Padding(3, 4, 3, 4);
            pnMenuFlight.Name = "pnMenuFlight";
            pnMenuFlight.Size = new Size(1500, 105);
            pnMenuFlight.TabIndex = 2;
            // 
            // pnLine
            // 
            pnLine.BackColor = Color.FromArgb(3, 4, 94);
            pnLine.Location = new Point(50, 103);
            pnLine.Margin = new Padding(3, 4, 3, 4);
            pnLine.Name = "pnLine";
            pnLine.Size = new Size(1398, 2);
            pnLine.TabIndex = 3;
            // 
            // aButton3
            // 
            aButton3.BackColor = Color.Transparent;
            aButton3.BackgroundColor = Color.Transparent;
            aButton3.BorderColor = Color.FromArgb(3, 4, 94);
            aButton3.BorderRadius = 30;
            aButton3.BorderSize = 2;
            aButton3.FlatAppearance.BorderSize = 0;
            aButton3.FlatStyle = FlatStyle.Flat;
            aButton3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aButton3.ForeColor = Color.FromArgb(3, 4, 94);
            aButton3.LineType = AControls.AButton.LineStyles.None;
            aButton3.Location = new Point(1310, 30);
            aButton3.Margin = new Padding(3, 4, 3, 4);
            aButton3.Name = "aButton3";
            aButton3.RoundType = AControls.AButton.RoundStyles.Top;
            aButton3.Size = new Size(140, 75);
            aButton3.TabIndex = 2;
            aButton3.Text = "Chi tiết chuyến bay";
            aButton3.TextColor = Color.FromArgb(3, 4, 94);
            aButton3.ThinknessLine = 0;
            aButton3.UseVisualStyleBackColor = false;
            // 
            // aButton1
            // 
            aButton1.BackColor = Color.Transparent;
            aButton1.BackgroundColor = Color.Transparent;
            aButton1.BorderColor = Color.FromArgb(3, 4, 94);
            aButton1.BorderRadius = 30;
            aButton1.BorderSize = 2;
            aButton1.FlatAppearance.BorderSize = 0;
            aButton1.FlatStyle = FlatStyle.Flat;
            aButton1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aButton1.ForeColor = Color.FromArgb(3, 4, 94);
            aButton1.LineType = AControls.AButton.LineStyles.None;
            aButton1.Location = new Point(235, 30);
            aButton1.Margin = new Padding(3, 4, 3, 4);
            aButton1.Name = "aButton1";
            aButton1.RoundType = AControls.AButton.RoundStyles.Top;
            aButton1.Size = new Size(150, 75);
            aButton1.TabIndex = 1;
            aButton1.Text = "Tạo chuyến bay mới";
            aButton1.TextColor = Color.FromArgb(3, 4, 94);
            aButton1.ThinknessLine = 0;
            aButton1.UseVisualStyleBackColor = false;
            // 
            // aButton2
            // 
            aButton2.BackColor = Color.FromArgb(3, 4, 94);
            aButton2.BackgroundColor = Color.FromArgb(3, 4, 94);
            aButton2.BorderColor = Color.FromArgb(3, 4, 94);
            aButton2.BorderRadius = 30;
            aButton2.BorderSize = 2;
            aButton2.FlatAppearance.BorderSize = 0;
            aButton2.FlatStyle = FlatStyle.Flat;
            aButton2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aButton2.ForeColor = Color.White;
            aButton2.LineType = AControls.AButton.LineStyles.None;
            aButton2.Location = new Point(50, 30);
            aButton2.Margin = new Padding(3, 4, 3, 4);
            aButton2.Name = "aButton2";
            aButton2.RoundType = AControls.AButton.RoundStyles.Top;
            aButton2.Size = new Size(160, 75);
            aButton2.TabIndex = 0;
            aButton2.Text = "Danh sách chuyến bay";
            aButton2.TextColor = Color.White;
            aButton2.ThinknessLine = 0;
            aButton2.UseVisualStyleBackColor = false;
            // 
            // pnBodyFlight
            // 
            pnBodyFlight.BackColor = Color.Transparent;
            pnBodyFlight.Controls.Add(flightListUC);
            pnBodyFlight.Dock = DockStyle.Fill;
            pnBodyFlight.Location = new Point(0, 105);
            pnBodyFlight.Margin = new Padding(3, 4, 3, 4);
            pnBodyFlight.Name = "pnBodyFlight";
            pnBodyFlight.Size = new Size(1500, 720);
            pnBodyFlight.TabIndex = 3;
            // 
            // flightListUC
            // 
            flightListUC.BackColor = Color.FromArgb(245, 245, 248);
            flightListUC.Dock = DockStyle.Fill;
            flightListUC.ForeColor = Color.FromArgb(3, 4, 94);
            flightListUC.Location = new Point(0, 0);
            flightListUC.Margin = new Padding(3, 5, 3, 5);
            flightListUC.Name = "flightListUC";
            flightListUC.Size = new Size(1500, 720);
            flightListUC.TabIndex = 0;
            // 
            // FlightUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 248);
            Controls.Add(pnBodyFlight);
            Controls.Add(pnMenuFlight);
            ForeColor = Color.FromArgb(1, 2, 39);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FlightUC";
            Size = new Size(1500, 825);
            Load += FlightUC_Load;
            pnMenuFlight.ResumeLayout(false);
            pnBodyFlight.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnMenuFlight;
        private AControls.AButton aButton2;
        private AControls.AButton aButton1;
        private AControls.AButton aButton3;
        private Panel pnLine;
        private Panel pnBodyFlight;
        private FlightListUC flightListUC;
    }
}
