namespace Airline_ticket_sales_management
{
    partial class ReportUC
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
            aDateTimePicker1 = new AControls.ADateTimePicker();
            acbTypeReport = new AControls.AComboBox();
            pnBodyReport = new Panel();
            SuspendLayout();
            // 
            // aDateTimePicker1
            // 
            aDateTimePicker1.BorderColor = Color.FromArgb(3, 4, 94);
            aDateTimePicker1.BorderSize = 1;
            aDateTimePicker1.CalendarFont = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            aDateTimePicker1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            aDateTimePicker1.Format = DateTimePickerFormat.Custom;
            aDateTimePicker1.Location = new Point(300, 30);
            aDateTimePicker1.MinimumSize = new Size(0, 35);
            aDateTimePicker1.Name = "aDateTimePicker1";
            aDateTimePicker1.Size = new Size(150, 35);
            aDateTimePicker1.SkinColor = Color.White;
            aDateTimePicker1.TabIndex = 1;
            aDateTimePicker1.TextColor = Color.FromArgb(3, 4, 94);
            // 
            // acbTypeReport
            // 
            acbTypeReport.AutoCompleteMode = AutoCompleteMode.Suggest;
            acbTypeReport.AutoCompleteSource = AutoCompleteSource.ListItems;
            acbTypeReport.BackColor = Color.White;
            acbTypeReport.BorderColor = Color.FromArgb(3, 4, 94);
            acbTypeReport.BorderSize = 1;
            acbTypeReport.DropDownStyle = ComboBoxStyle.DropDown;
            acbTypeReport.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            acbTypeReport.ForeColor = Color.DimGray;
            acbTypeReport.IconColor = Color.FromArgb(3, 4, 94);
            acbTypeReport.Items.AddRange(new object[] { "Báo cáo theo tháng", "Báo cáo theo năm" });
            acbTypeReport.ListBackColor = Color.FromArgb(3, 4, 94);
            acbTypeReport.ListTextColor = Color.White;
            acbTypeReport.Location = new Point(50, 30);
            acbTypeReport.MinimumSize = new Size(170, 30);
            acbTypeReport.Name = "acbTypeReport";
            acbTypeReport.Padding = new Padding(1);
            acbTypeReport.Size = new Size(220, 38);
            acbTypeReport.TabIndex = 2;
            acbTypeReport.Texts = "";
            acbTypeReport.SelectedIndexChanged += acbTypeReport_SelectedIndexChanged;
            // 
            // pnBodyReport
            // 
            pnBodyReport.Location = new Point(0, 70);
            pnBodyReport.Name = "pnBodyReport";
            pnBodyReport.Size = new Size(1500, 755);
            pnBodyReport.TabIndex = 3;
            // 
            // ReportUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 248);
            Controls.Add(pnBodyReport);
            Controls.Add(acbTypeReport);
            Controls.Add(aDateTimePicker1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReportUC";
            Size = new Size(1500, 825);
            ResumeLayout(false);
        }

        #endregion
        private AControls.ADateTimePicker aDateTimePicker1;
        private AControls.AComboBox acbTypeReport;
        private Panel pnBodyReport;
    }
}
