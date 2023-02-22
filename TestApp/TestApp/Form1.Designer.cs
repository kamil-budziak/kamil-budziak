namespace TestApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.FlightsView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.txtBoxYear = new System.Windows.Forms.TextBox();
            this.txtBoxAirline = new System.Windows.Forms.TextBox();
            this.txtBoxDepAP = new System.Windows.Forms.TextBox();
            this.txtBoxArrAP = new System.Windows.Forms.TextBox();
            this.txtBoxMonth = new System.Windows.Forms.TextBox();
            this.txtBoxDay = new System.Windows.Forms.TextBox();
            this.Flight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Airline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureAirport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalAirport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.FlightsView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date:";
            // 
            // FlightsView
            // 
            this.FlightsView.AllowUserToAddRows = false;
            this.FlightsView.AllowUserToDeleteRows = false;
            this.FlightsView.AllowUserToResizeColumns = false;
            this.FlightsView.AllowUserToResizeRows = false;
            this.FlightsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.FlightsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Flight,
            this.Airline,
            this.DepartureAirport,
            this.Departure,
            this.Arrival,
            this.ArrivalAirport});
            this.FlightsView.Location = new System.Drawing.Point(12, 67);
            this.FlightsView.MultiSelect = false;
            this.FlightsView.Name = "FlightsView";
            this.FlightsView.ReadOnly = true;
            this.FlightsView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.FlightsView.RowTemplate.Height = 25;
            this.FlightsView.Size = new System.Drawing.Size(904, 538);
            this.FlightsView.TabIndex = 8;
            this.FlightsView.TabStop = false;
            this.FlightsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Departure Airport:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Arrival Airport:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Airline:";
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.LightPink;
            this.BtnSearch.Location = new System.Drawing.Point(841, 38);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 5;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtBoxYear
            // 
            this.txtBoxYear.Location = new System.Drawing.Point(61, 6);
            this.txtBoxYear.Name = "txtBoxYear";
            this.txtBoxYear.Size = new System.Drawing.Size(47, 23);
            this.txtBoxYear.TabIndex = 1;
            // 
            // txtBoxAirline
            // 
            this.txtBoxAirline.Location = new System.Drawing.Point(61, 35);
            this.txtBoxAirline.Name = "txtBoxAirline";
            this.txtBoxAirline.Size = new System.Drawing.Size(199, 23);
            this.txtBoxAirline.TabIndex = 6;
            // 
            // txtBoxDepAP
            // 
            this.txtBoxDepAP.Location = new System.Drawing.Point(385, 6);
            this.txtBoxDepAP.Name = "txtBoxDepAP";
            this.txtBoxDepAP.Size = new System.Drawing.Size(199, 23);
            this.txtBoxDepAP.TabIndex = 4;
            // 
            // txtBoxArrAP
            // 
            this.txtBoxArrAP.Location = new System.Drawing.Point(717, 6);
            this.txtBoxArrAP.Name = "txtBoxArrAP";
            this.txtBoxArrAP.Size = new System.Drawing.Size(199, 23);
            this.txtBoxArrAP.TabIndex = 5;
            // 
            // txtBoxMonth
            // 
            this.txtBoxMonth.Location = new System.Drawing.Point(114, 6);
            this.txtBoxMonth.Name = "txtBoxMonth";
            this.txtBoxMonth.Size = new System.Drawing.Size(32, 23);
            this.txtBoxMonth.TabIndex = 2;
            // 
            // txtBoxDay
            // 
            this.txtBoxDay.Location = new System.Drawing.Point(152, 6);
            this.txtBoxDay.Name = "txtBoxDay";
            this.txtBoxDay.Size = new System.Drawing.Size(32, 23);
            this.txtBoxDay.TabIndex = 3;
            // 
            // Flight
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Flight.DefaultCellStyle = dataGridViewCellStyle1;
            this.Flight.HeaderText = "Flight No.";
            this.Flight.Name = "Flight";
            this.Flight.ReadOnly = true;
            this.Flight.Width = 80;
            // 
            // Airline
            // 
            this.Airline.HeaderText = "Airline";
            this.Airline.Name = "Airline";
            this.Airline.ReadOnly = true;
            this.Airline.Width = 120;
            // 
            // DepartureAirport
            // 
            this.DepartureAirport.HeaderText = "Departure Airport";
            this.DepartureAirport.Name = "DepartureAirport";
            this.DepartureAirport.ReadOnly = true;
            this.DepartureAirport.Width = 200;
            // 
            // Departure
            // 
            this.Departure.HeaderText = "Departure Time";
            this.Departure.Name = "Departure";
            this.Departure.ReadOnly = true;
            this.Departure.Width = 120;
            // 
            // Arrival
            // 
            this.Arrival.HeaderText = "Arrival Time";
            this.Arrival.Name = "Arrival";
            this.Arrival.ReadOnly = true;
            this.Arrival.Width = 120;
            // 
            // ArrivalAirport
            // 
            this.ArrivalAirport.HeaderText = "Arrival Airport";
            this.ArrivalAirport.Name = "ArrivalAirport";
            this.ArrivalAirport.ReadOnly = true;
            this.ArrivalAirport.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 617);
            this.Controls.Add(this.txtBoxDay);
            this.Controls.Add(this.txtBoxMonth);
            this.Controls.Add(this.txtBoxArrAP);
            this.Controls.Add(this.txtBoxDepAP);
            this.Controls.Add(this.txtBoxAirline);
            this.Controls.Add(this.txtBoxYear);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FlightsView);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FlightsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView FlightsView;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BtnSearch;
        private TextBox txtBoxYear;
        private TextBox txtBoxAirline;
        private TextBox txtBoxDepAP;
        private TextBox txtBoxArrAP;
        private TextBox txtBoxMonth;
        private TextBox txtBoxDay;
        private DataGridViewTextBoxColumn Flight;
        private DataGridViewTextBoxColumn Airline;
        private DataGridViewTextBoxColumn DepartureAirport;
        private DataGridViewTextBoxColumn Departure;
        private DataGridViewTextBoxColumn Arrival;
        private DataGridViewTextBoxColumn ArrivalAirport;
    }
}