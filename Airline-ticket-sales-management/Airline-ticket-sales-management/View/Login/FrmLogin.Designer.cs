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
            pictureBox2 = new PictureBox();
            aCircularPictureBox1 = new AControls.ACircularPictureBox();
            apnMain = new AControls.APanel();
            loginuc1 = new LoginUC();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pibClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)aCircularPictureBox1).BeginInit();
            apnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pibClose
            // 
            pibClose.BackgroundImage = Properties.Resources.CloseIcon2;
            pibClose.BackgroundImageLayout = ImageLayout.Stretch;
            pibClose.Cursor = Cursors.Hand;
            pibClose.Location = new Point(1331, 12);
            pibClose.Margin = new Padding(2, 3, 2, 3);
            pibClose.Name = "pibClose";
            pibClose.Size = new Size(24, 27);
            pibClose.TabIndex = 0;
            pibClose.TabStop = false;
            pibClose.Click += pibClose_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.Ellipse_2;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(766, 167);
            pictureBox2.Margin = new Padding(2, 3, 2, 3);
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
            aCircularPictureBox1.Location = new Point(786, 187);
            aCircularPictureBox1.Margin = new Padding(2, 3, 2, 3);
            aCircularPictureBox1.Name = "aCircularPictureBox1";
            aCircularPictureBox1.Size = new Size(460, 460);
            aCircularPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            aCircularPictureBox1.TabIndex = 3;
            aCircularPictureBox1.TabStop = false;
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
            apnMain.Margin = new Padding(2, 3, 2, 3);
            apnMain.Name = "apnMain";
            apnMain.RoundType = AControls.APanel.RoundStyles.Full;
            apnMain.Size = new Size(500, 668);
            apnMain.TabIndex = 1;
            apnMain.TextColor = Color.Black;
            // 
            // loginuc1
            // 
            loginuc1.BackColor = Color.White;
            loginuc1.Dock = DockStyle.Fill;
            loginuc1.Location = new Point(0, 0);
            loginuc1.Name = "loginuc1";
            loginuc1.Size = new Size(500, 668);
            loginuc1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Screenshot_2023_10_30_003909;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(725, 117);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(550, 550);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(97, 114, 243);
            ClientSize = new Size(1366, 768);
            Controls.Add(pictureBox1);
            Controls.Add(aCircularPictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(apnMain);
            Controls.Add(pibClose);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)pibClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)aCircularPictureBox1).EndInit();
            apnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pibClose;
        private PictureBox pictureBox2;
        private AControls.ACircularPictureBox aCircularPictureBox1;
        private AControls.APanel apnMain;
        private LoginUC loginuc1;
        private PictureBox pictureBox1;
    }
}