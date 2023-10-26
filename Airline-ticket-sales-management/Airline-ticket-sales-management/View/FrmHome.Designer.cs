namespace Airline_ticket_sales_management
{
    partial class FrmHome
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnTop = new Panel();
            pnMenu = new Panel();
            abtnSetting = new AControls.AButton();
            aButton5 = new AControls.AButton();
            abtnPlane = new AControls.AButton();
            abtnReport = new AControls.AButton();
            abtnFlightTicket = new AControls.AButton();
            abtnFlight = new AControls.AButton();
            pcbClose = new PictureBox();
            pcbLogo = new PictureBox();
            pnBody = new Panel();
            pibLoad = new PictureBox();
            pnTop.SuspendLayout();
            pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            pnBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pibLoad).BeginInit();
            SuspendLayout();
            // 
            // pnTop
            // 
            pnTop.BackColor = Color.Transparent;
            pnTop.Controls.Add(pnMenu);
            pnTop.Controls.Add(pcbClose);
            pnTop.Controls.Add(pcbLogo);
            pnTop.Dock = DockStyle.Top;
            pnTop.Location = new Point(0, 0);
            pnTop.Margin = new Padding(3, 4, 3, 4);
            pnTop.Name = "pnTop";
            pnTop.Size = new Size(1500, 125);
            pnTop.TabIndex = 1;
            // 
            // pnMenu
            // 
            pnMenu.BackColor = Color.Transparent;
            pnMenu.Controls.Add(abtnSetting);
            pnMenu.Controls.Add(aButton5);
            pnMenu.Controls.Add(abtnPlane);
            pnMenu.Controls.Add(abtnReport);
            pnMenu.Controls.Add(abtnFlightTicket);
            pnMenu.Controls.Add(abtnFlight);
            pnMenu.Location = new Point(200, 65);
            pnMenu.Margin = new Padding(3, 4, 3, 4);
            pnMenu.Name = "pnMenu";
            pnMenu.Size = new Size(900, 60);
            pnMenu.TabIndex = 3;
            // 
            // abtnSetting
            // 
            abtnSetting.BackColor = Color.Transparent;
            abtnSetting.BackgroundColor = Color.Transparent;
            abtnSetting.BorderColor = Color.FromArgb(124, 124, 124);
            abtnSetting.BorderRadius = 0;
            abtnSetting.BorderSize = 0;
            abtnSetting.Dock = DockStyle.Left;
            abtnSetting.FlatAppearance.BorderSize = 0;
            abtnSetting.FlatStyle = FlatStyle.Flat;
            abtnSetting.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            abtnSetting.ForeColor = Color.FromArgb(124, 124, 124);
            abtnSetting.LineType = AControls.AButton.LineStyles.None;
            abtnSetting.Location = new Point(750, 0);
            abtnSetting.Margin = new Padding(3, 4, 3, 4);
            abtnSetting.Name = "abtnSetting";
            abtnSetting.RoundType = AControls.AButton.RoundStyles.Full;
            abtnSetting.Size = new Size(150, 60);
            abtnSetting.TabIndex = 9;
            abtnSetting.Text = "Cài đặt";
            abtnSetting.TextColor = Color.FromArgb(124, 124, 124);
            abtnSetting.ThinknessLine = 5;
            abtnSetting.UseVisualStyleBackColor = false;
            abtnSetting.Click += abtnSetting_Click;
            // 
            // aButton5
            // 
            aButton5.BackColor = Color.Transparent;
            aButton5.BackgroundColor = Color.Transparent;
            aButton5.BorderColor = Color.FromArgb(124, 124, 124);
            aButton5.BorderRadius = 0;
            aButton5.BorderSize = 0;
            aButton5.Dock = DockStyle.Left;
            aButton5.FlatAppearance.BorderSize = 0;
            aButton5.FlatStyle = FlatStyle.Flat;
            aButton5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aButton5.ForeColor = Color.FromArgb(124, 124, 124);
            aButton5.LineType = AControls.AButton.LineStyles.None;
            aButton5.Location = new Point(600, 0);
            aButton5.Margin = new Padding(3, 4, 3, 4);
            aButton5.Name = "aButton5";
            aButton5.RoundType = AControls.AButton.RoundStyles.Full;
            aButton5.Size = new Size(150, 60);
            aButton5.TabIndex = 8;
            aButton5.Text = "Liên hệ";
            aButton5.TextColor = Color.FromArgb(124, 124, 124);
            aButton5.ThinknessLine = 5;
            aButton5.UseVisualStyleBackColor = false;
            // 
            // abtnPlane
            // 
            abtnPlane.BackColor = Color.Transparent;
            abtnPlane.BackgroundColor = Color.Transparent;
            abtnPlane.BorderColor = Color.FromArgb(124, 124, 124);
            abtnPlane.BorderRadius = 0;
            abtnPlane.BorderSize = 0;
            abtnPlane.Dock = DockStyle.Left;
            abtnPlane.FlatAppearance.BorderSize = 0;
            abtnPlane.FlatStyle = FlatStyle.Flat;
            abtnPlane.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            abtnPlane.ForeColor = Color.FromArgb(124, 124, 124);
            abtnPlane.LineType = AControls.AButton.LineStyles.None;
            abtnPlane.Location = new Point(450, 0);
            abtnPlane.Margin = new Padding(3, 4, 3, 4);
            abtnPlane.Name = "abtnPlane";
            abtnPlane.RoundType = AControls.AButton.RoundStyles.Full;
            abtnPlane.Size = new Size(150, 60);
            abtnPlane.TabIndex = 7;
            abtnPlane.Text = "Máy bay";
            abtnPlane.TextColor = Color.FromArgb(124, 124, 124);
            abtnPlane.ThinknessLine = 5;
            abtnPlane.UseVisualStyleBackColor = false;
            abtnPlane.Click += abtnPlane_Click;
            // 
            // abtnReport
            // 
            abtnReport.BackColor = Color.Transparent;
            abtnReport.BackgroundColor = Color.Transparent;
            abtnReport.BorderColor = Color.FromArgb(124, 124, 124);
            abtnReport.BorderRadius = 0;
            abtnReport.BorderSize = 0;
            abtnReport.Dock = DockStyle.Left;
            abtnReport.FlatAppearance.BorderSize = 0;
            abtnReport.FlatStyle = FlatStyle.Flat;
            abtnReport.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            abtnReport.ForeColor = Color.FromArgb(124, 124, 124);
            abtnReport.LineType = AControls.AButton.LineStyles.None;
            abtnReport.Location = new Point(300, 0);
            abtnReport.Margin = new Padding(3, 4, 3, 4);
            abtnReport.Name = "abtnReport";
            abtnReport.RoundType = AControls.AButton.RoundStyles.Full;
            abtnReport.Size = new Size(150, 60);
            abtnReport.TabIndex = 6;
            abtnReport.Text = "Báo cáo";
            abtnReport.TextColor = Color.FromArgb(124, 124, 124);
            abtnReport.ThinknessLine = 5;
            abtnReport.UseVisualStyleBackColor = false;
            abtnReport.Click += abtnReport_Click;
            // 
            // abtnFlightTicket
            // 
            abtnFlightTicket.BackColor = Color.Transparent;
            abtnFlightTicket.BackgroundColor = Color.Transparent;
            abtnFlightTicket.BorderColor = Color.FromArgb(124, 124, 124);
            abtnFlightTicket.BorderRadius = 0;
            abtnFlightTicket.BorderSize = 0;
            abtnFlightTicket.Dock = DockStyle.Left;
            abtnFlightTicket.FlatAppearance.BorderSize = 0;
            abtnFlightTicket.FlatStyle = FlatStyle.Flat;
            abtnFlightTicket.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            abtnFlightTicket.ForeColor = Color.FromArgb(124, 124, 124);
            abtnFlightTicket.LineType = AControls.AButton.LineStyles.None;
            abtnFlightTicket.Location = new Point(150, 0);
            abtnFlightTicket.Margin = new Padding(3, 4, 3, 4);
            abtnFlightTicket.Name = "abtnFlightTicket";
            abtnFlightTicket.RoundType = AControls.AButton.RoundStyles.Full;
            abtnFlightTicket.Size = new Size(150, 60);
            abtnFlightTicket.TabIndex = 5;
            abtnFlightTicket.Text = "Vé máy bay";
            abtnFlightTicket.TextColor = Color.FromArgb(124, 124, 124);
            abtnFlightTicket.ThinknessLine = 5;
            abtnFlightTicket.UseVisualStyleBackColor = false;
            abtnFlightTicket.Click += abtnFlightTicket_Click;
            // 
            // abtnFlight
            // 
            abtnFlight.BackColor = Color.Transparent;
            abtnFlight.BackgroundColor = Color.Transparent;
            abtnFlight.BorderColor = Color.FromArgb(3, 4, 94);
            abtnFlight.BorderRadius = 0;
            abtnFlight.BorderSize = 0;
            abtnFlight.Dock = DockStyle.Left;
            abtnFlight.FlatAppearance.BorderSize = 0;
            abtnFlight.FlatStyle = FlatStyle.Flat;
            abtnFlight.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            abtnFlight.ForeColor = Color.FromArgb(124, 124, 124);
            abtnFlight.LineType = AControls.AButton.LineStyles.None;
            abtnFlight.Location = new Point(0, 0);
            abtnFlight.Margin = new Padding(3, 4, 3, 4);
            abtnFlight.Name = "abtnFlight";
            abtnFlight.RoundType = AControls.AButton.RoundStyles.Full;
            abtnFlight.Size = new Size(150, 60);
            abtnFlight.TabIndex = 4;
            abtnFlight.Text = "Chuyến bay";
            abtnFlight.TextColor = Color.FromArgb(124, 124, 124);
            abtnFlight.ThinknessLine = 5;
            abtnFlight.UseVisualStyleBackColor = false;
            abtnFlight.Click += abtnFlight_Click;
            // 
            // pcbClose
            // 
            pcbClose.BackColor = Color.Transparent;
            pcbClose.BackgroundImage = Properties.Resources.closeIcon;
            pcbClose.BackgroundImageLayout = ImageLayout.Stretch;
            pcbClose.Cursor = Cursors.Hand;
            pcbClose.Location = new Point(1455, 20);
            pcbClose.Margin = new Padding(3, 4, 3, 4);
            pcbClose.Name = "pcbClose";
            pcbClose.Size = new Size(24, 30);
            pcbClose.TabIndex = 1;
            pcbClose.TabStop = false;
            pcbClose.Click += pcbClose_Click;
            // 
            // pcbLogo
            // 
            pcbLogo.BackgroundImage = Properties.Resources.LogoMAT;
            pcbLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pcbLogo.Location = new Point(51, 47);
            pcbLogo.Margin = new Padding(3, 4, 3, 4);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(100, 100);
            pcbLogo.TabIndex = 0;
            pcbLogo.TabStop = false;
            pcbLogo.Click += pcbLogo_Click;
            // 
            // pnBody
            // 
            pnBody.BackColor = Color.Transparent;
            pnBody.Controls.Add(pibLoad);
            pnBody.Dock = DockStyle.Fill;
            pnBody.Location = new Point(0, 125);
            pnBody.Margin = new Padding(3, 4, 3, 4);
            pnBody.Name = "pnBody";
            pnBody.Size = new Size(1500, 825);
            pnBody.TabIndex = 2;
            // 
            // pibLoad
            // 
            pibLoad.BackgroundImageLayout = ImageLayout.Stretch;
            pibLoad.Image = Properties.Resources.load625;
            pibLoad.Location = new Point(437, 100);
            pibLoad.Name = "pibLoad";
            pibLoad.Size = new Size(625, 625);
            pibLoad.TabIndex = 4;
            pibLoad.TabStop = false;
            pibLoad.Visible = false;
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 248);
            ClientSize = new Size(1500, 950);
            Controls.Add(pnBody);
            Controls.Add(pnTop);
            DoubleBuffered = true;
            ForeColor = Color.FromArgb(1, 2, 39);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý";
            pnTop.ResumeLayout(false);
            pnMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            pnBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pibLoad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pcbLogo;
        private Panel pnTop;
        private PictureBox pcbClose;
        private Panel pnMenu;
        private Panel pnBody;
        private AControls.AButton abtnFlight;
        private AControls.AButton abtnFlightTicket;
        private AControls.AButton abtnPlane;
        private AControls.AButton abtnReport;
        private AControls.AButton abtnSetting;
        private AControls.AButton aButton5;
        private PictureBox pibLoad;
    }
}

