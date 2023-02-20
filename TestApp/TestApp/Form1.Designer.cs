﻿namespace TestApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.FlightsView = new System.Windows.Forms.DataGridView();
            this.Flight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Airline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureAirport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalAirport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.txtBoxDate = new System.Windows.Forms.TextBox();
            this.txtBoxAirline = new System.Windows.Forms.TextBox();
            this.txtBoxDepAP = new System.Windows.Forms.TextBox();
            this.txtBoxArrAP = new System.Windows.Forms.TextBox();
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
            this.FlightsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FlightsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Flight,
            this.Airline,
            this.DepartureAirport,
            this.Departure,
            this.Arrival,
            this.ArrivalAirport});
            this.FlightsView.Location = new System.Drawing.Point(12, 67);
            this.FlightsView.Name = "FlightsView";
            this.FlightsView.RowTemplate.Height = 25;
            this.FlightsView.Size = new System.Drawing.Size(904, 538);
            this.FlightsView.TabIndex = 1;
            this.FlightsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Flight
            // 
            this.Flight.HeaderText = "Flight No.";
            this.Flight.Name = "Flight";
            this.Flight.Width = 80;
            // 
            // Airline
            // 
            this.Airline.HeaderText = "Airline";
            this.Airline.Name = "Airline";
            this.Airline.Width = 120;
            // 
            // DepartureAirport
            // 
            this.DepartureAirport.HeaderText = "Departure Airport";
            this.DepartureAirport.Name = "DepartureAirport";
            this.DepartureAirport.Width = 200;
            // 
            // Departure
            // 
            this.Departure.HeaderText = "Departure Time";
            this.Departure.Name = "Departure";
            this.Departure.Width = 120;
            // 
            // Arrival
            // 
            this.Arrival.HeaderText = "Arrival Time";
            this.Arrival.Name = "Arrival";
            this.Arrival.Width = 120;
            // 
            // ArrivalAirport
            // 
            this.ArrivalAirport.HeaderText = "Arrival Airport";
            this.ArrivalAirport.Name = "ArrivalAirport";
            this.ArrivalAirport.Width = 200;
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
            this.BtnSearch.Location = new System.Drawing.Point(841, 38);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 5;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtBoxDate
            // 
            this.txtBoxDate.Location = new System.Drawing.Point(61, 6);
            this.txtBoxDate.Name = "txtBoxDate";
            this.txtBoxDate.Size = new System.Drawing.Size(92, 23);
            this.txtBoxDate.TabIndex = 6;
            // 
            // txtBoxAirline
            // 
            this.txtBoxAirline.Location = new System.Drawing.Point(61, 35);
            this.txtBoxAirline.Name = "txtBoxAirline";
            this.txtBoxAirline.Size = new System.Drawing.Size(199, 23);
            this.txtBoxAirline.TabIndex = 7;
            // 
            // txtBoxDepAP
            // 
            this.txtBoxDepAP.Location = new System.Drawing.Point(385, 6);
            this.txtBoxDepAP.Name = "txtBoxDepAP";
            this.txtBoxDepAP.Size = new System.Drawing.Size(199, 23);
            this.txtBoxDepAP.TabIndex = 8;
            // 
            // txtBoxArrAP
            // 
            this.txtBoxArrAP.Location = new System.Drawing.Point(717, 6);
            this.txtBoxArrAP.Name = "txtBoxArrAP";
            this.txtBoxArrAP.Size = new System.Drawing.Size(199, 23);
            this.txtBoxArrAP.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 617);
            this.Controls.Add(this.txtBoxArrAP);
            this.Controls.Add(this.txtBoxDepAP);
            this.Controls.Add(this.txtBoxAirline);
            this.Controls.Add(this.txtBoxDate);
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
        private DataGridViewTextBoxColumn Flight;
        private DataGridViewTextBoxColumn Airline;
        private DataGridViewTextBoxColumn DepartureAirport;
        private DataGridViewTextBoxColumn Departure;
        private DataGridViewTextBoxColumn Arrival;
        private DataGridViewTextBoxColumn ArrivalAirport;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BtnSearch;
        private TextBox txtBoxDate;
        private TextBox txtBoxAirline;
        private TextBox txtBoxDepAP;
        private TextBox txtBoxArrAP;
    }
}