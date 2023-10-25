namespace Airline_ticket_sales_management
{
    partial class OperationPlaneUC
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
            aTextboxUC1 = new AControls.ATextboxUC();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // aTextboxUC1
            // 
            aTextboxUC1.BackColor = Color.White;
            aTextboxUC1.BorderColor = Color.FromArgb(3, 4, 94);
            aTextboxUC1.BorderFocusColor = Color.FromArgb(0, 138, 184);
            aTextboxUC1.BorderRadius = 5;
            aTextboxUC1.BorderSize = 2;
            aTextboxUC1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            aTextboxUC1.ForeColor = Color.DimGray;
            aTextboxUC1.Location = new Point(50, 38);
            aTextboxUC1.Margin = new Padding(4, 5, 4, 5);
            aTextboxUC1.Multiline = false;
            aTextboxUC1.Name = "aTextboxUC1";
            aTextboxUC1.Padding = new Padding(7, 9, 7, 9);
            aTextboxUC1.PasswordChar = false;
            aTextboxUC1.PlaceholderColor = Color.DarkGray;
            aTextboxUC1.PlaceholderText = "Tên máy bay";
            aTextboxUC1.RoundType = AControls.ATextboxUC.RoundStyles.Full;
            aTextboxUC1.Size = new Size(200, 41);
            aTextboxUC1.TabIndex = 0;
            aTextboxUC1.Texts = "";
            aTextboxUC1.UnderlinedStyle = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(350, 38);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 624);
            panel1.TabIndex = 1;
            // 
            // OperationPlaneUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 248);
            Controls.Add(panel1);
            Controls.Add(aTextboxUC1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OperationPlaneUC";
            Size = new Size(1500, 750);
            ResumeLayout(false);
        }

        #endregion

        private AControls.ATextboxUC aTextboxUC1;
        private Panel panel1;
    }
}
