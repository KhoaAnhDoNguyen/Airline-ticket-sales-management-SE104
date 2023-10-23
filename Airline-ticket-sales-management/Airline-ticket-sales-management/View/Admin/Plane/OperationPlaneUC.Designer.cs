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
            this.aTextboxUC1 = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // aTextboxUC1
            // 
            this.aTextboxUC1.BackColor = System.Drawing.Color.White;
            this.aTextboxUC1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.aTextboxUC1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(184)))));
            this.aTextboxUC1.BorderRadius = 5;
            this.aTextboxUC1.BorderSize = 2;
            this.aTextboxUC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aTextboxUC1.ForeColor = System.Drawing.Color.DimGray;
            this.aTextboxUC1.Location = new System.Drawing.Point(50, 30);
            this.aTextboxUC1.Margin = new System.Windows.Forms.Padding(4);
            this.aTextboxUC1.Multiline = false;
            this.aTextboxUC1.Name = "aTextboxUC1";
            this.aTextboxUC1.Padding = new System.Windows.Forms.Padding(7);
            this.aTextboxUC1.PasswordChar = false;
            this.aTextboxUC1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.aTextboxUC1.PlaceholderText = "Tên máy bay";
            this.aTextboxUC1.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.aTextboxUC1.Size = new System.Drawing.Size(200, 37);
            this.aTextboxUC1.TabIndex = 0;
            this.aTextboxUC1.Texts = "";
            this.aTextboxUC1.UnderlinedStyle = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(350, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 499);
            this.panel1.TabIndex = 1;
            // 
            // CreatePlaneUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.aTextboxUC1);
            this.Name = "CreatePlaneUC";
            this.Size = new System.Drawing.Size(1500, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private AControls.ATextboxUC aTextboxUC1;
        private System.Windows.Forms.Panel panel1;
    }
}
