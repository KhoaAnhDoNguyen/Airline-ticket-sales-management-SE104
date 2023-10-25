namespace Airline_ticket_sales_management
{
    partial class FrmLogin
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
            pibClose = new PictureBox();
            apnMain = new AControls.APanel();
            pictureBox2 = new PictureBox();
            aCircularPictureBox1 = new AControls.ACircularPictureBox();
            loginuc1 = new LoginUC();
            ((System.ComponentModel.ISupportInitialize)pibClose).BeginInit();
            apnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)aCircularPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pibClose
            // 
            pibClose.BackgroundImage = Properties.Resources.CloseIcon2;
            pibClose.BackgroundImageLayout = ImageLayout.Stretch;
            pibClose.Cursor = Cursors.Hand;
            pibClose.Location = new Point(1310, 12);
            pibClose.Name = "pibClose";
            pibClose.Size = new Size(30, 30);
            pibClose.TabIndex = 0;
            pibClose.TabStop = false;
            pibClose.Click += pibClose_Click;
            // 
            // apnMain
            // 
            apnMain.BackColor = Color.White;
            apnMain.BackgroundColor = Color.White;
            apnMain.BorderColor = Color.PaleVioletRed;
            apnMain.BorderRadius = 50;
            apnMain.BorderSize = 0;
            apnMain.Controls.Add(loginuc1);
            apnMain.ForeColor = Color.Black;
            apnMain.Location = new Point(100, 50);
            apnMain.Name = "apnMain";
            apnMain.RoundType = AControls.APanel.RoundStyles.Full;
            apnMain.Size = new Size(500, 668);
            apnMain.TabIndex = 1;
            apnMain.TextColor = Color.Black;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.Ellipse_2;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(766, 134);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(500, 500);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // aCircularPictureBox1
            // 
            aCircularPictureBox1.BackColor = Color.Transparent;
            aCircularPictureBox1.BackgroundImage = Properties.Resources.Ellipse_1;
            aCircularPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            aCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            aCircularPictureBox1.BorderColor = Color.Transparent;
            aCircularPictureBox1.BorderColor2 = Color.Transparent;
            aCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            aCircularPictureBox1.BorderSize = 0;
            aCircularPictureBox1.GradientAngle = 50F;
            aCircularPictureBox1.Location = new Point(786, 154);
            aCircularPictureBox1.Name = "aCircularPictureBox1";
            aCircularPictureBox1.Size = new Size(460, 460);
            aCircularPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            aCircularPictureBox1.TabIndex = 3;
            aCircularPictureBox1.TabStop = false;
            // 
            // loginuc1
            // 
            loginuc1.BackColor = Color.White;
            loginuc1.Dock = DockStyle.Fill;
            loginuc1.Location = new Point(0, 0);
            loginuc1.Margin = new Padding(4, 3, 4, 3);
            loginuc1.Name = "loginuc1";
            loginuc1.Size = new Size(500, 668);
            loginuc1.TabIndex = 0;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(97, 114, 243);
            ClientSize = new Size(1366, 768);
            Controls.Add(aCircularPictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(apnMain);
            Controls.Add(pibClose);
            Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)pibClose).EndInit();
            apnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)aCircularPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pibClose;
        private AControls.APanel apnMain;
        private PictureBox pictureBox2;
        private AControls.ACircularPictureBox aCircularPictureBox1;
        private LoginUC loginuc1;
    }
}