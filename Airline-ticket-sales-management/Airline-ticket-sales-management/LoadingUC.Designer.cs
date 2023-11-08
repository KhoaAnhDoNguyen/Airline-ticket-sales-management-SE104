namespace Airline_ticket_sales_management
{
    partial class LoadingUC
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
            pibLoad = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pibLoad).BeginInit();
            SuspendLayout();
            // 
            // pibLoad
            // 
            pibLoad.BackgroundImageLayout = ImageLayout.Stretch;
            pibLoad.Image = Properties.Resources.load625;
            pibLoad.Location = new Point(438, 48);
            pibLoad.Name = "pibLoad";
            pibLoad.Size = new Size(625, 625);
            pibLoad.TabIndex = 5;
            pibLoad.TabStop = false;
            // 
            // LoadingUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 248);
            Controls.Add(pibLoad);
            Name = "LoadingUC";
            Size = new Size(1500, 720);
            ((System.ComponentModel.ISupportInitialize)pibLoad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pibLoad;
    }
}
