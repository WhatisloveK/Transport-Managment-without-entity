namespace WinForm
{
    partial class FrmCargoSearch
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
            this.components = new System.ComponentModel.Container();
            this.dGVSearchCargos = new System.Windows.Forms.DataGridView();
            this.cGIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGDEPARTUREDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGDEPARTURETIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPARTURECITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPARTUREDPADRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGWEIGHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGTRUCKERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESTINATIONCITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESTINATIONDPADRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGARRIVALDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGARRIVALTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargosCitySearchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTranspManag1 = new TranspManagDATA.DSTranspManag();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.textBoxDeparture = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.Trucker = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tRUCKERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxDestinationAdress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDepartureAdress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datePickerDeparture = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.datePickerDestination = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timePickerDepartures = new System.Windows.Forms.DateTimePicker();
            this.timePickerDestination = new System.Windows.Forms.DateTimePicker();
            this.checkBoxDepartureTime = new System.Windows.Forms.CheckBox();
            this.checkBoxDestinationTime = new System.Windows.Forms.CheckBox();
            this.checkBoxDepartureDay = new System.Windows.Forms.CheckBox();
            this.checkBoxDestinationDay = new System.Windows.Forms.CheckBox();
            this.cargosCitySearchTableAdapter1 = new TranspManagDATA.DSTranspManagTableAdapters.CargosCitySearchTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSearchCargos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargosCitySearchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTranspManag1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRUCKERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVSearchCargos
            // 
            this.dGVSearchCargos.AutoGenerateColumns = false;
            this.dGVSearchCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSearchCargos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cGIDDataGridViewTextBoxColumn,
            this.cGDEPARTUREDATEDataGridViewTextBoxColumn,
            this.cGDEPARTURETIMEDataGridViewTextBoxColumn,
            this.dEPARTURECITYDataGridViewTextBoxColumn,
            this.dEPARTUREDPADRESSDataGridViewTextBoxColumn,
            this.cGWEIGHTDataGridViewTextBoxColumn,
            this.cGTRUCKERDataGridViewTextBoxColumn,
            this.dESTINATIONCITYDataGridViewTextBoxColumn,
            this.dESTINATIONDPADRESSDataGridViewTextBoxColumn,
            this.cGARRIVALDATEDataGridViewTextBoxColumn,
            this.cGARRIVALTIMEDataGridViewTextBoxColumn});
            this.dGVSearchCargos.DataSource = this.cargosCitySearchBindingSource;
            this.dGVSearchCargos.Location = new System.Drawing.Point(-2, 118);
            this.dGVSearchCargos.Name = "dGVSearchCargos";
            this.dGVSearchCargos.Size = new System.Drawing.Size(946, 260);
            this.dGVSearchCargos.TabIndex = 0;
            // 
            // cGIDDataGridViewTextBoxColumn
            // 
            this.cGIDDataGridViewTextBoxColumn.DataPropertyName = "CG_ID";
            this.cGIDDataGridViewTextBoxColumn.HeaderText = "CG_ID";
            this.cGIDDataGridViewTextBoxColumn.Name = "cGIDDataGridViewTextBoxColumn";
            this.cGIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cGIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cGDEPARTUREDATEDataGridViewTextBoxColumn
            // 
            this.cGDEPARTUREDATEDataGridViewTextBoxColumn.DataPropertyName = "CG_DEPARTURE_DATE";
            this.cGDEPARTUREDATEDataGridViewTextBoxColumn.HeaderText = "Departure date";
            this.cGDEPARTUREDATEDataGridViewTextBoxColumn.Name = "cGDEPARTUREDATEDataGridViewTextBoxColumn";
            // 
            // cGDEPARTURETIMEDataGridViewTextBoxColumn
            // 
            this.cGDEPARTURETIMEDataGridViewTextBoxColumn.DataPropertyName = "CG_DEPARTURE_TIME";
            this.cGDEPARTURETIMEDataGridViewTextBoxColumn.HeaderText = "Departure time";
            this.cGDEPARTURETIMEDataGridViewTextBoxColumn.Name = "cGDEPARTURETIMEDataGridViewTextBoxColumn";
            // 
            // dEPARTURECITYDataGridViewTextBoxColumn
            // 
            this.dEPARTURECITYDataGridViewTextBoxColumn.DataPropertyName = "DEPARTURE_CITY";
            this.dEPARTURECITYDataGridViewTextBoxColumn.HeaderText = "Departure city";
            this.dEPARTURECITYDataGridViewTextBoxColumn.Name = "dEPARTURECITYDataGridViewTextBoxColumn";
            // 
            // dEPARTUREDPADRESSDataGridViewTextBoxColumn
            // 
            this.dEPARTUREDPADRESSDataGridViewTextBoxColumn.DataPropertyName = "DEPARTURE_DP_ADRESS";
            this.dEPARTUREDPADRESSDataGridViewTextBoxColumn.HeaderText = "Departure adress";
            this.dEPARTUREDPADRESSDataGridViewTextBoxColumn.Name = "dEPARTUREDPADRESSDataGridViewTextBoxColumn";
            // 
            // cGWEIGHTDataGridViewTextBoxColumn
            // 
            this.cGWEIGHTDataGridViewTextBoxColumn.DataPropertyName = "CG_WEIGHT";
            this.cGWEIGHTDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.cGWEIGHTDataGridViewTextBoxColumn.Name = "cGWEIGHTDataGridViewTextBoxColumn";
            // 
            // cGTRUCKERDataGridViewTextBoxColumn
            // 
            this.cGTRUCKERDataGridViewTextBoxColumn.DataPropertyName = "CG_TRUCKER";
            this.cGTRUCKERDataGridViewTextBoxColumn.HeaderText = "CG_TRUCKER";
            this.cGTRUCKERDataGridViewTextBoxColumn.Name = "cGTRUCKERDataGridViewTextBoxColumn";
            this.cGTRUCKERDataGridViewTextBoxColumn.Visible = false;
            // 
            // dESTINATIONCITYDataGridViewTextBoxColumn
            // 
            this.dESTINATIONCITYDataGridViewTextBoxColumn.DataPropertyName = "DESTINATION_CITY";
            this.dESTINATIONCITYDataGridViewTextBoxColumn.HeaderText = "Destination city";
            this.dESTINATIONCITYDataGridViewTextBoxColumn.Name = "dESTINATIONCITYDataGridViewTextBoxColumn";
            // 
            // dESTINATIONDPADRESSDataGridViewTextBoxColumn
            // 
            this.dESTINATIONDPADRESSDataGridViewTextBoxColumn.DataPropertyName = "DESTINATION_DP_ADRESS";
            this.dESTINATIONDPADRESSDataGridViewTextBoxColumn.HeaderText = "Destination adress";
            this.dESTINATIONDPADRESSDataGridViewTextBoxColumn.Name = "dESTINATIONDPADRESSDataGridViewTextBoxColumn";
            // 
            // cGARRIVALDATEDataGridViewTextBoxColumn
            // 
            this.cGARRIVALDATEDataGridViewTextBoxColumn.DataPropertyName = "CG_ARRIVAL_DATE";
            this.cGARRIVALDATEDataGridViewTextBoxColumn.HeaderText = "Arrival date";
            this.cGARRIVALDATEDataGridViewTextBoxColumn.Name = "cGARRIVALDATEDataGridViewTextBoxColumn";
            // 
            // cGARRIVALTIMEDataGridViewTextBoxColumn
            // 
            this.cGARRIVALTIMEDataGridViewTextBoxColumn.DataPropertyName = "CG_ARRIVAL_TIME";
            this.cGARRIVALTIMEDataGridViewTextBoxColumn.HeaderText = "Arrival time";
            this.cGARRIVALTIMEDataGridViewTextBoxColumn.Name = "cGARRIVALTIMEDataGridViewTextBoxColumn";
            // 
            // cargosCitySearchBindingSource
            // 
            this.cargosCitySearchBindingSource.DataMember = "CargosCitySearch";
            this.cargosCitySearchBindingSource.DataSource = this.dsTranspManag1;
            // 
            // dsTranspManag1
            // 
            this.dsTranspManag1.DataSetName = "DSTranspManag";
            this.dsTranspManag1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Location = new System.Drawing.Point(97, 48);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(100, 20);
            this.textBoxDestination.TabIndex = 1;
            // 
            // textBoxDeparture
            // 
            this.textBoxDeparture.Location = new System.Drawing.Point(97, 12);
            this.textBoxDeparture.Name = "textBoxDeparture";
            this.textBoxDeparture.Size = new System.Drawing.Size(100, 20);
            this.textBoxDeparture.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Destination city";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Departure city";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(560, 82);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(82, 23);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // Trucker
            // 
            this.Trucker.DataPropertyName = "CG_TRUCKER";
            this.Trucker.DataSource = this.tRUCKERSBindingSource;
            this.Trucker.HeaderText = "Trucker";
            this.Trucker.Name = "Trucker";
            // 
            // tRUCKERSBindingSource
            // 
            this.tRUCKERSBindingSource.DataMember = "TRUCKERS";
            this.tRUCKERSBindingSource.DataSource = this.dsTranspManag1;
            // 
            // textBoxDestinationAdress
            // 
            this.textBoxDestinationAdress.Location = new System.Drawing.Point(317, 48);
            this.textBoxDestinationAdress.Name = "textBoxDestinationAdress";
            this.textBoxDestinationAdress.Size = new System.Drawing.Size(100, 20);
            this.textBoxDestinationAdress.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Destination adrerss";
            // 
            // textBoxDepartureAdress
            // 
            this.textBoxDepartureAdress.Location = new System.Drawing.Point(317, 12);
            this.textBoxDepartureAdress.Name = "textBoxDepartureAdress";
            this.textBoxDepartureAdress.Size = new System.Drawing.Size(100, 20);
            this.textBoxDepartureAdress.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Departure adress";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Departure day";
            // 
            // datePickerDeparture
            // 
            this.datePickerDeparture.Location = new System.Drawing.Point(545, 6);
            this.datePickerDeparture.Name = "datePickerDeparture";
            this.datePickerDeparture.Size = new System.Drawing.Size(200, 20);
            this.datePickerDeparture.TabIndex = 13;
            this.datePickerDeparture.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Destination day";
            // 
            // datePickerDestination
            // 
            this.datePickerDestination.Location = new System.Drawing.Point(545, 45);
            this.datePickerDestination.Name = "datePickerDestination";
            this.datePickerDestination.Size = new System.Drawing.Size(200, 20);
            this.datePickerDestination.TabIndex = 15;
            this.datePickerDestination.Value = new System.DateTime(2000, 1, 1, 10, 20, 0, 0);
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Location = new System.Drawing.Point(413, 85);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownWeight.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(366, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Weight";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(751, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Departure time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(751, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Destination time";
            // 
            // timePickerDepartures
            // 
            this.timePickerDepartures.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerDepartures.Location = new System.Drawing.Point(860, 9);
            this.timePickerDepartures.Name = "timePickerDepartures";
            this.timePickerDepartures.ShowUpDown = true;
            this.timePickerDepartures.Size = new System.Drawing.Size(84, 20);
            this.timePickerDepartures.TabIndex = 20;
            this.timePickerDepartures.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // timePickerDestination
            // 
            this.timePickerDestination.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerDestination.Location = new System.Drawing.Point(860, 43);
            this.timePickerDestination.Name = "timePickerDestination";
            this.timePickerDestination.ShowUpDown = true;
            this.timePickerDestination.Size = new System.Drawing.Size(84, 20);
            this.timePickerDestination.TabIndex = 21;
            this.timePickerDestination.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // checkBoxDepartureTime
            // 
            this.checkBoxDepartureTime.AutoSize = true;
            this.checkBoxDepartureTime.Location = new System.Drawing.Point(839, 11);
            this.checkBoxDepartureTime.Name = "checkBoxDepartureTime";
            this.checkBoxDepartureTime.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDepartureTime.TabIndex = 22;
            this.checkBoxDepartureTime.UseVisualStyleBackColor = true;
            // 
            // checkBoxDestinationTime
            // 
            this.checkBoxDestinationTime.AutoSize = true;
            this.checkBoxDestinationTime.Location = new System.Drawing.Point(839, 48);
            this.checkBoxDestinationTime.Name = "checkBoxDestinationTime";
            this.checkBoxDestinationTime.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDestinationTime.TabIndex = 23;
            this.checkBoxDestinationTime.UseVisualStyleBackColor = true;
            // 
            // checkBoxDepartureDay
            // 
            this.checkBoxDepartureDay.AutoSize = true;
            this.checkBoxDepartureDay.Location = new System.Drawing.Point(524, 12);
            this.checkBoxDepartureDay.Name = "checkBoxDepartureDay";
            this.checkBoxDepartureDay.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDepartureDay.TabIndex = 24;
            this.checkBoxDepartureDay.UseVisualStyleBackColor = true;
            // 
            // checkBoxDestinationDay
            // 
            this.checkBoxDestinationDay.AutoSize = true;
            this.checkBoxDestinationDay.Location = new System.Drawing.Point(524, 48);
            this.checkBoxDestinationDay.Name = "checkBoxDestinationDay";
            this.checkBoxDestinationDay.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDestinationDay.TabIndex = 25;
            this.checkBoxDestinationDay.UseVisualStyleBackColor = true;
            // 
            // cargosCitySearchTableAdapter1
            // 
            this.cargosCitySearchTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmCargoSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 377);
            this.Controls.Add(this.checkBoxDestinationDay);
            this.Controls.Add(this.checkBoxDepartureDay);
            this.Controls.Add(this.checkBoxDestinationTime);
            this.Controls.Add(this.checkBoxDepartureTime);
            this.Controls.Add(this.timePickerDestination);
            this.Controls.Add(this.timePickerDepartures);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownWeight);
            this.Controls.Add(this.datePickerDestination);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.datePickerDeparture);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDepartureAdress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDestinationAdress);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDeparture);
            this.Controls.Add(this.textBoxDestination);
            this.Controls.Add(this.dGVSearchCargos);
            this.Name = "FrmCargoSearch";
            this.Text = "Search Cargos";
            ((System.ComponentModel.ISupportInitialize)(this.dGVSearchCargos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargosCitySearchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTranspManag1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRUCKERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVSearchCargos;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.TextBox textBoxDeparture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSearch;
        private TranspManagDATA.DSTranspManag dsTranspManag1;
        private TranspManagDATA.DSTranspManagTableAdapters.CargosCitySearchTableAdapter cargosCitySearchTableAdapter1;
        private System.Windows.Forms.BindingSource tRUCKERSBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn Trucker;
        private System.Windows.Forms.TextBox textBoxDestinationAdress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDepartureAdress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datePickerDeparture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datePickerDestination;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker timePickerDepartures;
        private System.Windows.Forms.DateTimePicker timePickerDestination;
        private System.Windows.Forms.BindingSource cargosCitySearchBindingSource;
        private System.Windows.Forms.CheckBox checkBoxDepartureTime;
        private System.Windows.Forms.CheckBox checkBoxDestinationTime;
        private System.Windows.Forms.CheckBox checkBoxDepartureDay;
        private System.Windows.Forms.CheckBox checkBoxDestinationDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGDEPARTUREDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGDEPARTURETIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPARTURECITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPARTUREDPADRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGWEIGHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGTRUCKERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESTINATIONCITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESTINATIONDPADRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGARRIVALDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGARRIVALTIMEDataGridViewTextBoxColumn;
    }
}