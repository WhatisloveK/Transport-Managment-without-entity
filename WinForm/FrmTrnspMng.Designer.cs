namespace WinForm
{
    partial class FrmTrnspMng
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCities = new System.Windows.Forms.TabPage();
            this.buttonCitiesDelete = new System.Windows.Forms.Button();
            this.buttonCitiesSave = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabDepartures = new System.Windows.Forms.TabPage();
            this.buttonDeparturesDelete = new System.Windows.Forms.Button();
            this.buttonDeparturesSave = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabCargos = new System.Windows.Forms.TabPage();
            this.buttonCargosDelete = new System.Windows.Forms.Button();
            this.buttonCargosSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabTruckers = new System.Windows.Forms.TabPage();
            this.buttonTruckersDelete = new System.Windows.Forms.Button();
            this.buttonTruckersSave = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabTrucks = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.tabTruckTypes = new System.Windows.Forms.TabPage();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.tabTrailers = new System.Windows.Forms.TabPage();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.tabTrailerTypes = new System.Windows.Forms.TabPage();
            this.dataGridView8 = new System.Windows.Forms.DataGridView();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dGVCities = new System.Windows.Forms.DataGridView();
            this.cITIESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsTranspManag1 = new TranspManagDATA.DSTranspManag();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dGVDepartures = new System.Windows.Forms.DataGridView();
            this.dEPARTURESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dGVCargos = new System.Windows.Forms.DataGridView();
            this.tRUCKERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cARGOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.dGVTruckers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TruckTR = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tRUCKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.buttonTrucksDelete = new System.Windows.Forms.Button();
            this.buttonTrucksSave = new System.Windows.Forms.Button();
            this.dGVTrucks = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeTP = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tRUCKTYPESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Capacity = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrailerTR = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tRAILERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.buttonTruckTypesDelete = new System.Windows.Forms.Button();
            this.buttonTruckTypesSave = new System.Windows.Forms.Button();
            this.dGVTruckTypes = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.buttonTrailersDelete = new System.Windows.Forms.Button();
            this.buttonTrailersSave = new System.Windows.Forms.Button();
            this.dGVTrailers = new System.Windows.Forms.DataGridView();
            this.tRAILERTYPESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.buttonTrailerTypesDelete = new System.Windows.Forms.Button();
            this.buttonTrailerTypesSave = new System.Windows.Forms.Button();
            this.dGVTrailerTypes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queriesTableAdapter1 = new TranspManagDATA.DSTranspManagTableAdapters.QueriesTableAdapter();
            this.citiesTableAdapter1 = new TranspManagDATA.DSTranspManagTableAdapters.CITIESTableAdapter();
            this.departuresTableAdapter1 = new TranspManagDATA.DSTranspManagTableAdapters.DEPARTURESTableAdapter();
            this.cargosTableAdapter1 = new TranspManagDATA.DSTranspManagTableAdapters.CARGOSTableAdapter();
            this.truckersTableAdapter1 = new TranspManagDATA.DSTranspManagTableAdapters.TRUCKERSTableAdapter();
            this.truckTableAdapter1 = new TranspManagDATA.DSTranspManagTableAdapters.TRUCKTableAdapter();
            this.trucK_TYPESTableAdapter1 = new TranspManagDATA.DSTranspManagTableAdapters.TRUCK_TYPESTableAdapter();
            this.trailerTableAdapter1 = new TranspManagDATA.DSTranspManagTableAdapters.TRAILERTableAdapter();
            this.traileR_TYPESTableAdapter1 = new TranspManagDATA.DSTranspManagTableAdapters.TRAILER_TYPESTableAdapter();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrailerTypeTP = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CitY = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeparturePlaceDP = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGDEPARTUREDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TruckerTR = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination_dp = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGARRIVALDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabCities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabDepartures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabCargos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabTruckers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabTrucks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.tabTruckTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.tabTrailers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            this.tabTrailerTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cITIESBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTranspManag1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDepartures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTURESBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCargos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRUCKERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARGOSBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTruckers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRUCKBindingSource)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTrucks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRUCKTYPESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAILERBindingSource)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTruckTypes)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTrailers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAILERTYPESBindingSource)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTrailerTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCities);
            this.tabControl1.Controls.Add(this.tabDepartures);
            this.tabControl1.Controls.Add(this.tabCargos);
            this.tabControl1.Controls.Add(this.tabTruckers);
            this.tabControl1.Controls.Add(this.tabTrucks);
            this.tabControl1.Controls.Add(this.tabTruckTypes);
            this.tabControl1.Controls.Add(this.tabTrailers);
            this.tabControl1.Controls.Add(this.tabTrailerTypes);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(744, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCities
            // 
            this.tabCities.Controls.Add(this.buttonCitiesDelete);
            this.tabCities.Controls.Add(this.buttonCitiesSave);
            this.tabCities.Controls.Add(this.dataGridView2);
            this.tabCities.Location = new System.Drawing.Point(4, 22);
            this.tabCities.Name = "tabCities";
            this.tabCities.Size = new System.Drawing.Size(736, 425);
            this.tabCities.TabIndex = 4;
            this.tabCities.Text = "Cities";
            this.tabCities.UseVisualStyleBackColor = true;
            // 
            // buttonCitiesDelete
            // 
            this.buttonCitiesDelete.Location = new System.Drawing.Point(87, 3);
            this.buttonCitiesDelete.Name = "buttonCitiesDelete";
            this.buttonCitiesDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonCitiesDelete.TabIndex = 2;
            this.buttonCitiesDelete.Text = "Delete";
            this.buttonCitiesDelete.UseVisualStyleBackColor = true;
            this.buttonCitiesDelete.Click += new System.EventHandler(this.buttonCitiesDelete_Click);
            // 
            // buttonCitiesSave
            // 
            this.buttonCitiesSave.Location = new System.Drawing.Point(6, 3);
            this.buttonCitiesSave.Name = "buttonCitiesSave";
            this.buttonCitiesSave.Size = new System.Drawing.Size(75, 23);
            this.buttonCitiesSave.TabIndex = 1;
            this.buttonCitiesSave.Text = "Save";
            this.buttonCitiesSave.UseVisualStyleBackColor = true;
            this.buttonCitiesSave.Click += new System.EventHandler(this.buttonCitiesSave_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(-4, 31);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(743, 394);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabDepartures
            // 
            this.tabDepartures.Controls.Add(this.buttonDeparturesDelete);
            this.tabDepartures.Controls.Add(this.buttonDeparturesSave);
            this.tabDepartures.Controls.Add(this.dataGridView3);
            this.tabDepartures.Location = new System.Drawing.Point(4, 22);
            this.tabDepartures.Name = "tabDepartures";
            this.tabDepartures.Size = new System.Drawing.Size(736, 425);
            this.tabDepartures.TabIndex = 3;
            this.tabDepartures.Text = "Departures";
            this.tabDepartures.UseVisualStyleBackColor = true;
            // 
            // buttonDeparturesDelete
            // 
            this.buttonDeparturesDelete.Location = new System.Drawing.Point(87, 3);
            this.buttonDeparturesDelete.Name = "buttonDeparturesDelete";
            this.buttonDeparturesDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDeparturesDelete.TabIndex = 3;
            this.buttonDeparturesDelete.Text = "Delete";
            this.buttonDeparturesDelete.UseVisualStyleBackColor = true;
            this.buttonDeparturesDelete.Click += new System.EventHandler(this.buttonDeparturesDelete_Click);
            // 
            // buttonDeparturesSave
            // 
            this.buttonDeparturesSave.Location = new System.Drawing.Point(6, 3);
            this.buttonDeparturesSave.Name = "buttonDeparturesSave";
            this.buttonDeparturesSave.Size = new System.Drawing.Size(75, 23);
            this.buttonDeparturesSave.TabIndex = 2;
            this.buttonDeparturesSave.Text = "Save";
            this.buttonDeparturesSave.UseVisualStyleBackColor = true;
            this.buttonDeparturesSave.Click += new System.EventHandler(this.buttonDeparturesSave_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(-4, 31);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(743, 394);
            this.dataGridView3.TabIndex = 1;
            // 
            // tabCargos
            // 
            this.tabCargos.Controls.Add(this.buttonCargosDelete);
            this.tabCargos.Controls.Add(this.buttonCargosSave);
            this.tabCargos.Controls.Add(this.dataGridView1);
            this.tabCargos.Location = new System.Drawing.Point(4, 22);
            this.tabCargos.Name = "tabCargos";
            this.tabCargos.Padding = new System.Windows.Forms.Padding(3);
            this.tabCargos.Size = new System.Drawing.Size(736, 425);
            this.tabCargos.TabIndex = 0;
            this.tabCargos.Text = "Cargos";
            this.tabCargos.UseVisualStyleBackColor = true;
            // 
            // buttonCargosDelete
            // 
            this.buttonCargosDelete.Location = new System.Drawing.Point(87, 3);
            this.buttonCargosDelete.Name = "buttonCargosDelete";
            this.buttonCargosDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonCargosDelete.TabIndex = 2;
            this.buttonCargosDelete.Text = "Delete";
            this.buttonCargosDelete.UseVisualStyleBackColor = true;
            this.buttonCargosDelete.Click += new System.EventHandler(this.buttonCargosDelete_Click);
            // 
            // buttonCargosSave
            // 
            this.buttonCargosSave.Location = new System.Drawing.Point(6, 3);
            this.buttonCargosSave.Name = "buttonCargosSave";
            this.buttonCargosSave.Size = new System.Drawing.Size(75, 23);
            this.buttonCargosSave.TabIndex = 1;
            this.buttonCargosSave.Text = "Save";
            this.buttonCargosSave.UseVisualStyleBackColor = true;
            this.buttonCargosSave.Click += new System.EventHandler(this.buttonCargosSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 394);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabTruckers
            // 
            this.tabTruckers.Controls.Add(this.buttonTruckersDelete);
            this.tabTruckers.Controls.Add(this.buttonTruckersSave);
            this.tabTruckers.Controls.Add(this.dataGridView4);
            this.tabTruckers.Location = new System.Drawing.Point(4, 22);
            this.tabTruckers.Name = "tabTruckers";
            this.tabTruckers.Padding = new System.Windows.Forms.Padding(3);
            this.tabTruckers.Size = new System.Drawing.Size(736, 425);
            this.tabTruckers.TabIndex = 1;
            this.tabTruckers.Text = "Truckers";
            this.tabTruckers.UseVisualStyleBackColor = true;
            // 
            // buttonTruckersDelete
            // 
            this.buttonTruckersDelete.Location = new System.Drawing.Point(87, 3);
            this.buttonTruckersDelete.Name = "buttonTruckersDelete";
            this.buttonTruckersDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonTruckersDelete.TabIndex = 3;
            this.buttonTruckersDelete.Text = "Delete";
            this.buttonTruckersDelete.UseVisualStyleBackColor = true;
            this.buttonTruckersDelete.Click += new System.EventHandler(this.buttonTruckersDelete_Click);
            // 
            // buttonTruckersSave
            // 
            this.buttonTruckersSave.Location = new System.Drawing.Point(6, 3);
            this.buttonTruckersSave.Name = "buttonTruckersSave";
            this.buttonTruckersSave.Size = new System.Drawing.Size(75, 23);
            this.buttonTruckersSave.TabIndex = 2;
            this.buttonTruckersSave.Text = "Save";
            this.buttonTruckersSave.UseVisualStyleBackColor = true;
            this.buttonTruckersSave.Click += new System.EventHandler(this.buttonTruckersSave_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(-4, 31);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(743, 394);
            this.dataGridView4.TabIndex = 1;
            // 
            // tabTrucks
            // 
            this.tabTrucks.Controls.Add(this.dataGridView5);
            this.tabTrucks.Location = new System.Drawing.Point(4, 22);
            this.tabTrucks.Name = "tabTrucks";
            this.tabTrucks.Size = new System.Drawing.Size(736, 425);
            this.tabTrucks.TabIndex = 7;
            this.tabTrucks.Text = "Trucks";
            this.tabTrucks.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(-4, 31);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(743, 394);
            this.dataGridView5.TabIndex = 2;
            // 
            // tabTruckTypes
            // 
            this.tabTruckTypes.Controls.Add(this.dataGridView6);
            this.tabTruckTypes.Location = new System.Drawing.Point(4, 22);
            this.tabTruckTypes.Name = "tabTruckTypes";
            this.tabTruckTypes.Size = new System.Drawing.Size(736, 425);
            this.tabTruckTypes.TabIndex = 6;
            this.tabTruckTypes.Text = "Truck types";
            this.tabTruckTypes.UseVisualStyleBackColor = true;
            // 
            // dataGridView6
            // 
            this.dataGridView6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(-4, 31);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(743, 394);
            this.dataGridView6.TabIndex = 3;
            // 
            // tabTrailers
            // 
            this.tabTrailers.Controls.Add(this.dataGridView7);
            this.tabTrailers.Location = new System.Drawing.Point(4, 22);
            this.tabTrailers.Name = "tabTrailers";
            this.tabTrailers.Size = new System.Drawing.Size(736, 425);
            this.tabTrailers.TabIndex = 2;
            this.tabTrailers.Text = "Trailers";
            this.tabTrailers.UseVisualStyleBackColor = true;
            // 
            // dataGridView7
            // 
            this.dataGridView7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Location = new System.Drawing.Point(-4, 31);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.Size = new System.Drawing.Size(743, 394);
            this.dataGridView7.TabIndex = 3;
            // 
            // tabTrailerTypes
            // 
            this.tabTrailerTypes.Controls.Add(this.dataGridView8);
            this.tabTrailerTypes.Location = new System.Drawing.Point(4, 22);
            this.tabTrailerTypes.Name = "tabTrailerTypes";
            this.tabTrailerTypes.Size = new System.Drawing.Size(736, 425);
            this.tabTrailerTypes.TabIndex = 5;
            this.tabTrailerTypes.Text = "Trailer types";
            this.tabTrailerTypes.UseVisualStyleBackColor = true;
            // 
            // dataGridView8
            // 
            this.dataGridView8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView8.Location = new System.Drawing.Point(-4, 31);
            this.dataGridView8.Name = "dataGridView8";
            this.dataGridView8.Size = new System.Drawing.Size(743, 394);
            this.dataGridView8.TabIndex = 3;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Location = new System.Drawing.Point(2, 1);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(950, 451);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.dGVCities);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(942, 425);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Cities";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonCitiesDelete_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonCitiesSave_Click);
            // 
            // dGVCities
            // 
            this.dGVCities.AutoGenerateColumns = false;
            this.dGVCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dGVCities.DataSource = this.cITIESBindingSource1;
            this.dGVCities.Location = new System.Drawing.Point(-4, 31);
            this.dGVCities.Name = "dGVCities";
            this.dGVCities.Size = new System.Drawing.Size(943, 394);
            this.dGVCities.TabIndex = 0;
            // 
            // cITIESBindingSource1
            // 
            this.cITIESBindingSource1.DataMember = "CITIES";
            this.cITIESBindingSource1.DataSource = this.dsTranspManag1;
            // 
            // dsTranspManag1
            // 
            this.dsTranspManag1.DataSetName = "DSTranspManag";
            this.dsTranspManag1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.dGVDepartures);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(942, 425);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Departures";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(87, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonDeparturesDelete_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonDeparturesSave_Click);
            // 
            // dGVDepartures
            // 
            this.dGVDepartures.AutoGenerateColumns = false;
            this.dGVDepartures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDepartures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CitY,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dGVDepartures.DataSource = this.dEPARTURESBindingSource;
            this.dGVDepartures.Location = new System.Drawing.Point(-4, 31);
            this.dGVDepartures.Name = "dGVDepartures";
            this.dGVDepartures.Size = new System.Drawing.Size(946, 394);
            this.dGVDepartures.TabIndex = 1;
            // 
            // dEPARTURESBindingSource
            // 
            this.dEPARTURESBindingSource.DataMember = "DEPARTURES";
            this.dEPARTURESBindingSource.DataSource = this.dsTranspManag1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonSearch);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.dGVCargos);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(942, 425);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Cargos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(168, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(87, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonCargosDelete_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "Save";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonCargosSave_Click);
            // 
            // dGVCargos
            // 
            this.dGVCargos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVCargos.AutoGenerateColumns = false;
            this.dGVCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCargos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.DeparturePlaceDP,
            this.dataGridViewTextBoxColumn11,
            this.cGDEPARTUREDATEDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn12,
            this.TruckerTR,
            this.dataGridViewTextBoxColumn9,
            this.Destination_dp,
            this.dataGridViewTextBoxColumn10,
            this.cGARRIVALDATEDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn14});
            this.dGVCargos.DataSource = this.cARGOSBindingSource;
            this.dGVCargos.Location = new System.Drawing.Point(-4, 35);
            this.dGVCargos.Name = "dGVCargos";
            this.dGVCargos.Size = new System.Drawing.Size(943, 394);
            this.dGVCargos.TabIndex = 0;
            this.dGVCargos.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dGVCargos_EditingControlShowing);
            this.dGVCargos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dGVCargos_KeyPress);
            // 
            // tRUCKERSBindingSource
            // 
            this.tRUCKERSBindingSource.DataMember = "TRUCKERS";
            this.tRUCKERSBindingSource.DataSource = this.dsTranspManag1;
            // 
            // cARGOSBindingSource
            // 
            this.cARGOSBindingSource.DataMember = "CARGOS";
            this.cARGOSBindingSource.DataSource = this.dsTranspManag1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button7);
            this.tabPage4.Controls.Add(this.button8);
            this.tabPage4.Controls.Add(this.dGVTruckers);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(942, 425);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Truckers";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(87, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 3;
            this.button7.Text = "Delete";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonTruckersDelete_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 2;
            this.button8.Text = "Save";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttonTruckersSave_Click);
            // 
            // dGVTruckers
            // 
            this.dGVTruckers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVTruckers.AutoGenerateColumns = false;
            this.dGVTruckers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTruckers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.TruckTR,
            this.dataGridViewTextBoxColumn20});
            this.dGVTruckers.DataSource = this.tRUCKERSBindingSource;
            this.dGVTruckers.Location = new System.Drawing.Point(0, 35);
            this.dGVTruckers.Name = "dGVTruckers";
            this.dGVTruckers.Size = new System.Drawing.Size(946, 394);
            this.dGVTruckers.TabIndex = 1;
            this.dGVTruckers.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVTruckers_CellEndEdit);
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "TR_ID";
            this.dataGridViewTextBoxColumn15.HeaderText = "TR_ID";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "TR_NAME";
            this.dataGridViewTextBoxColumn16.HeaderText = "Name";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "TR_SURNAME";
            this.dataGridViewTextBoxColumn17.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "TR_BIRTH";
            this.dataGridViewTextBoxColumn18.HeaderText = "Birthday";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "TR_START_DRIVE";
            this.dataGridViewTextBoxColumn19.HeaderText = "Start driving";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // TruckTR
            // 
            this.TruckTR.DataPropertyName = "TR_TRUCK";
            this.TruckTR.DataSource = this.tRUCKBindingSource;
            this.TruckTR.DisplayMember = "TRUCK_INSURANCE_EXPIRATION";
            this.TruckTR.HeaderText = "Truck";
            this.TruckTR.Name = "TruckTR";
            this.TruckTR.ValueMember = "TRUCK_ID";
            // 
            // tRUCKBindingSource
            // 
            this.tRUCKBindingSource.DataMember = "TRUCK";
            this.tRUCKBindingSource.DataSource = this.dsTranspManag1;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "TR_TRUCK";
            this.dataGridViewTextBoxColumn20.HeaderText = "TR_TRUCK";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Visible = false;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.buttonTrucksDelete);
            this.tabPage5.Controls.Add(this.buttonTrucksSave);
            this.tabPage5.Controls.Add(this.dGVTrucks);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(942, 425);
            this.tabPage5.TabIndex = 7;
            this.tabPage5.Text = "Trucks";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // buttonTrucksDelete
            // 
            this.buttonTrucksDelete.Location = new System.Drawing.Point(87, 3);
            this.buttonTrucksDelete.Name = "buttonTrucksDelete";
            this.buttonTrucksDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonTrucksDelete.TabIndex = 4;
            this.buttonTrucksDelete.Text = "Delete";
            this.buttonTrucksDelete.UseVisualStyleBackColor = true;
            this.buttonTrucksDelete.Click += new System.EventHandler(this.buttonTrucksDelete_Click);
            // 
            // buttonTrucksSave
            // 
            this.buttonTrucksSave.Location = new System.Drawing.Point(6, 3);
            this.buttonTrucksSave.Name = "buttonTrucksSave";
            this.buttonTrucksSave.Size = new System.Drawing.Size(75, 23);
            this.buttonTrucksSave.TabIndex = 3;
            this.buttonTrucksSave.Text = "Save";
            this.buttonTrucksSave.UseVisualStyleBackColor = true;
            this.buttonTrucksSave.Click += new System.EventHandler(this.buttonTrucksSave_Click);
            // 
            // dGVTrucks
            // 
            this.dGVTrucks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVTrucks.AutoGenerateColumns = false;
            this.dGVTrucks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTrucks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.TypeTP,
            this.Capacity,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.TrailerTR});
            this.dGVTrucks.DataSource = this.tRUCKBindingSource;
            this.dGVTrucks.Location = new System.Drawing.Point(-4, 31);
            this.dGVTrucks.Name = "dGVTrucks";
            this.dGVTrucks.Size = new System.Drawing.Size(949, 394);
            this.dGVTrucks.TabIndex = 2;
            this.dGVTrucks.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dGVTrucks_EditingControlShowing);
            this.dGVTrucks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dGVTrucks_KeyPress);
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "TRUCK_ID";
            this.dataGridViewTextBoxColumn21.HeaderText = "TRUCK_ID";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Visible = false;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "TRUCK_NUMBER";
            this.dataGridViewTextBoxColumn22.HeaderText = "Number";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "TRUCK_TYPE";
            this.dataGridViewTextBoxColumn23.HeaderText = "TRUCK_TYPE";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Visible = false;
            // 
            // TypeTP
            // 
            this.TypeTP.DataPropertyName = "TRUCK_TYPE";
            this.TypeTP.DataSource = this.tRUCKTYPESBindingSource;
            this.TypeTP.DisplayMember = "TYPE_MODEL";
            this.TypeTP.HeaderText = "Model";
            this.TypeTP.Name = "TypeTP";
            this.TypeTP.ValueMember = "TYPE_ID";
            // 
            // tRUCKTYPESBindingSource
            // 
            this.tRUCKTYPESBindingSource.DataMember = "TRUCK_TYPES";
            this.tRUCKTYPESBindingSource.DataSource = this.dsTranspManag1;
            // 
            // Capacity
            // 
            this.Capacity.DataPropertyName = "TRUCK_TYPE";
            this.Capacity.DataSource = this.tRUCKTYPESBindingSource;
            this.Capacity.DisplayMember = "TYPE_CAPACITY";
            this.Capacity.HeaderText = "Capacity";
            this.Capacity.Name = "Capacity";
            this.Capacity.ValueMember = "TYPE_ID";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "TRUCK_INSURANCE_EXPIRATION";
            this.dataGridViewTextBoxColumn24.HeaderText = "Insurance expiration";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "TRUCK_TRAILER";
            this.dataGridViewTextBoxColumn25.HeaderText = "TRUCK_TRAILER";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Visible = false;
            // 
            // TrailerTR
            // 
            this.TrailerTR.DataPropertyName = "TRUCK_TRAILER";
            this.TrailerTR.DataSource = this.tRAILERBindingSource;
            this.TrailerTR.DisplayMember = "TRAILER_LAST_OVERHAUL";
            this.TrailerTR.HeaderText = "Trailer";
            this.TrailerTR.Name = "TrailerTR";
            this.TrailerTR.ValueMember = "TRAILER_ID";
            // 
            // tRAILERBindingSource
            // 
            this.tRAILERBindingSource.DataMember = "TRAILER";
            this.tRAILERBindingSource.DataSource = this.dsTranspManag1;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.buttonTruckTypesDelete);
            this.tabPage6.Controls.Add(this.buttonTruckTypesSave);
            this.tabPage6.Controls.Add(this.dGVTruckTypes);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(942, 425);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Text = "Truck types";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // buttonTruckTypesDelete
            // 
            this.buttonTruckTypesDelete.Location = new System.Drawing.Point(87, 3);
            this.buttonTruckTypesDelete.Name = "buttonTruckTypesDelete";
            this.buttonTruckTypesDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonTruckTypesDelete.TabIndex = 5;
            this.buttonTruckTypesDelete.Text = "Delete";
            this.buttonTruckTypesDelete.UseVisualStyleBackColor = true;
            this.buttonTruckTypesDelete.Click += new System.EventHandler(this.buttonTruckTypesDelete_Click);
            // 
            // buttonTruckTypesSave
            // 
            this.buttonTruckTypesSave.Location = new System.Drawing.Point(6, 3);
            this.buttonTruckTypesSave.Name = "buttonTruckTypesSave";
            this.buttonTruckTypesSave.Size = new System.Drawing.Size(75, 23);
            this.buttonTruckTypesSave.TabIndex = 4;
            this.buttonTruckTypesSave.Text = "Save";
            this.buttonTruckTypesSave.UseVisualStyleBackColor = true;
            this.buttonTruckTypesSave.Click += new System.EventHandler(this.buttonTruckTypesSave_Click);
            // 
            // dGVTruckTypes
            // 
            this.dGVTruckTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVTruckTypes.AutoGenerateColumns = false;
            this.dGVTruckTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTruckTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29});
            this.dGVTruckTypes.DataSource = this.tRUCKTYPESBindingSource;
            this.dGVTruckTypes.Location = new System.Drawing.Point(-4, 31);
            this.dGVTruckTypes.Name = "dGVTruckTypes";
            this.dGVTruckTypes.Size = new System.Drawing.Size(949, 394);
            this.dGVTruckTypes.TabIndex = 3;
            this.dGVTruckTypes.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dGVTruckTypes_EditingControlShowing);
            this.dGVTruckTypes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dGVTruckTypes_KeyPress);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.buttonTrailersDelete);
            this.tabPage7.Controls.Add(this.buttonTrailersSave);
            this.tabPage7.Controls.Add(this.dGVTrailers);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(942, 425);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "Trailers";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // buttonTrailersDelete
            // 
            this.buttonTrailersDelete.Location = new System.Drawing.Point(87, 3);
            this.buttonTrailersDelete.Name = "buttonTrailersDelete";
            this.buttonTrailersDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonTrailersDelete.TabIndex = 5;
            this.buttonTrailersDelete.Text = "Delete";
            this.buttonTrailersDelete.UseVisualStyleBackColor = true;
            this.buttonTrailersDelete.Click += new System.EventHandler(this.buttonTrailersDelete_Click);
            // 
            // buttonTrailersSave
            // 
            this.buttonTrailersSave.Location = new System.Drawing.Point(6, 3);
            this.buttonTrailersSave.Name = "buttonTrailersSave";
            this.buttonTrailersSave.Size = new System.Drawing.Size(75, 23);
            this.buttonTrailersSave.TabIndex = 4;
            this.buttonTrailersSave.Text = "Save";
            this.buttonTrailersSave.UseVisualStyleBackColor = true;
            this.buttonTrailersSave.Click += new System.EventHandler(this.buttonTrailersSave_Click);
            // 
            // dGVTrailers
            // 
            this.dGVTrailers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVTrailers.AutoGenerateColumns = false;
            this.dGVTrailers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTrailers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.TrailerTypeTP,
            this.dataGridViewTextBoxColumn33});
            this.dGVTrailers.DataSource = this.tRAILERBindingSource;
            this.dGVTrailers.Location = new System.Drawing.Point(-4, 31);
            this.dGVTrailers.Name = "dGVTrailers";
            this.dGVTrailers.Size = new System.Drawing.Size(949, 394);
            this.dGVTrailers.TabIndex = 3;
            // 
            // tRAILERTYPESBindingSource
            // 
            this.tRAILERTYPESBindingSource.DataMember = "TRAILER_TYPES";
            this.tRAILERTYPESBindingSource.DataSource = this.dsTranspManag1;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.buttonTrailerTypesDelete);
            this.tabPage8.Controls.Add(this.buttonTrailerTypesSave);
            this.tabPage8.Controls.Add(this.dGVTrailerTypes);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(942, 425);
            this.tabPage8.TabIndex = 5;
            this.tabPage8.Text = "Trailer types";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // buttonTrailerTypesDelete
            // 
            this.buttonTrailerTypesDelete.Location = new System.Drawing.Point(87, 3);
            this.buttonTrailerTypesDelete.Name = "buttonTrailerTypesDelete";
            this.buttonTrailerTypesDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonTrailerTypesDelete.TabIndex = 5;
            this.buttonTrailerTypesDelete.Text = "Delete";
            this.buttonTrailerTypesDelete.UseVisualStyleBackColor = true;
            this.buttonTrailerTypesDelete.Click += new System.EventHandler(this.buttonTrailerTypesDelete_Click);
            // 
            // buttonTrailerTypesSave
            // 
            this.buttonTrailerTypesSave.Location = new System.Drawing.Point(6, 3);
            this.buttonTrailerTypesSave.Name = "buttonTrailerTypesSave";
            this.buttonTrailerTypesSave.Size = new System.Drawing.Size(75, 23);
            this.buttonTrailerTypesSave.TabIndex = 4;
            this.buttonTrailerTypesSave.Text = "Save";
            this.buttonTrailerTypesSave.UseVisualStyleBackColor = true;
            this.buttonTrailerTypesSave.Click += new System.EventHandler(this.buttonTrailerTypesSave_Click);
            // 
            // dGVTrailerTypes
            // 
            this.dGVTrailerTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVTrailerTypes.AutoGenerateColumns = false;
            this.dGVTrailerTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTrailerTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn35,
            this.dataGridViewTextBoxColumn36,
            this.dataGridViewTextBoxColumn37});
            this.dGVTrailerTypes.DataSource = this.tRAILERTYPESBindingSource;
            this.dGVTrailerTypes.Location = new System.Drawing.Point(-4, 31);
            this.dGVTrailerTypes.Name = "dGVTrailerTypes";
            this.dGVTrailerTypes.Size = new System.Drawing.Size(949, 394);
            this.dGVTrailerTypes.TabIndex = 3;
            this.dGVTrailerTypes.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dGVTrailerTypes_EditingControlShowing);
            this.dGVTrailerTypes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dGVTrailerTypes_KeyPress);
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "TYPE_TR_ID";
            this.dataGridViewTextBoxColumn34.HeaderText = "TYPE_TR_ID";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            this.dataGridViewTextBoxColumn34.Visible = false;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "TYPE_TR_MODEL";
            this.dataGridViewTextBoxColumn35.HeaderText = "Model";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "TYPE_TR_CAPACITY";
            this.dataGridViewTextBoxColumn36.HeaderText = "Capacity";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "TYPE_TR_TYPE";
            this.dataGridViewTextBoxColumn37.HeaderText = "Type";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            // 
            // citiesTableAdapter1
            // 
            this.citiesTableAdapter1.ClearBeforeFill = true;
            // 
            // departuresTableAdapter1
            // 
            this.departuresTableAdapter1.ClearBeforeFill = true;
            // 
            // cargosTableAdapter1
            // 
            this.cargosTableAdapter1.ClearBeforeFill = true;
            // 
            // truckersTableAdapter1
            // 
            this.truckersTableAdapter1.ClearBeforeFill = true;
            // 
            // truckTableAdapter1
            // 
            this.truckTableAdapter1.ClearBeforeFill = true;
            // 
            // trucK_TYPESTableAdapter1
            // 
            this.trucK_TYPESTableAdapter1.ClearBeforeFill = true;
            // 
            // trailerTableAdapter1
            // 
            this.trailerTableAdapter1.ClearBeforeFill = true;
            // 
            // traileR_TYPESTableAdapter1
            // 
            this.traileR_TYPESTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "TRAILER_ID";
            this.dataGridViewTextBoxColumn30.HeaderText = "TRAILER_ID";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            this.dataGridViewTextBoxColumn30.Visible = false;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "TRAILER_LAST_OVERHAUL";
            this.dataGridViewTextBoxColumn31.HeaderText = "Last overhaul";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "TRAILER_SERIAL_NUMBER";
            this.dataGridViewTextBoxColumn32.HeaderText = "Serial number";
            this.dataGridViewTextBoxColumn32.MaxInputLength = 49;
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            // 
            // TrailerTypeTP
            // 
            this.TrailerTypeTP.DataPropertyName = "TRAILER_TYPE";
            this.TrailerTypeTP.DataSource = this.tRAILERTYPESBindingSource;
            this.TrailerTypeTP.DisplayMember = "TYPE_TR_CAPACITY";
            this.TrailerTypeTP.HeaderText = "Trailer Type";
            this.TrailerTypeTP.Name = "TrailerTypeTP";
            this.TrailerTypeTP.ValueMember = "TYPE_TR_ID";
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "TRAILER_TYPE";
            this.dataGridViewTextBoxColumn33.HeaderText = "TRAILER_TYPE";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CITY_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CITY_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CITY_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 49;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // CitY
            // 
            this.CitY.DataPropertyName = "DP_CITY";
            this.CitY.DataSource = this.cITIESBindingSource1;
            this.CitY.DisplayMember = "CITY_NAME";
            this.CitY.HeaderText = "City";
            this.CitY.Name = "CitY";
            this.CitY.ValueMember = "CITY_ID";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DP_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "DP_ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DP_CITY";
            this.dataGridViewTextBoxColumn4.HeaderText = "DP_CITY";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DP_ADRESS";
            this.dataGridViewTextBoxColumn5.HeaderText = "Adress";
            this.dataGridViewTextBoxColumn5.MaxInputLength = 49;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DP_NAME";
            this.dataGridViewTextBoxColumn6.HeaderText = "Name";
            this.dataGridViewTextBoxColumn6.MaxInputLength = 49;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CG_ID";
            this.dataGridViewTextBoxColumn7.HeaderText = "CG_ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CG_NUMBER";
            this.dataGridViewTextBoxColumn8.HeaderText = "Number";
            this.dataGridViewTextBoxColumn8.MaxInputLength = 49;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // DeparturePlaceDP
            // 
            this.DeparturePlaceDP.DataPropertyName = "CG_DEPARTURE_PLACE";
            this.DeparturePlaceDP.DataSource = this.dEPARTURESBindingSource;
            this.DeparturePlaceDP.DisplayMember = "DP_ADRESS";
            this.DeparturePlaceDP.HeaderText = "Departure Place";
            this.DeparturePlaceDP.Name = "DeparturePlaceDP";
            this.DeparturePlaceDP.ValueMember = "DP_ID";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "CG_DEPARTURE_PLACE";
            this.dataGridViewTextBoxColumn11.HeaderText = "CG_DEPARTURE_PLACE";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // cGDEPARTUREDATEDataGridViewTextBoxColumn
            // 
            this.cGDEPARTUREDATEDataGridViewTextBoxColumn.DataPropertyName = "CG_DEPARTURE_DATE";
            this.cGDEPARTUREDATEDataGridViewTextBoxColumn.HeaderText = "Departure date";
            this.cGDEPARTUREDATEDataGridViewTextBoxColumn.Name = "cGDEPARTUREDATEDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "CG_DEPARTURE_TIME";
            this.dataGridViewTextBoxColumn13.HeaderText = "Departure time";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "CG_TRUCKER";
            this.dataGridViewTextBoxColumn12.HeaderText = "CG_TRUCKER";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // TruckerTR
            // 
            this.TruckerTR.DataPropertyName = "CG_TRUCKER";
            this.TruckerTR.DataSource = this.tRUCKERSBindingSource;
            this.TruckerTR.DisplayMember = "TR_SURNAME";
            this.TruckerTR.HeaderText = "Trucker";
            this.TruckerTR.Name = "TruckerTR";
            this.TruckerTR.ValueMember = "TR_ID";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CG_WEIGHT";
            this.dataGridViewTextBoxColumn9.HeaderText = "Weight";
            this.dataGridViewTextBoxColumn9.MaxInputLength = 5;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // Destination_dp
            // 
            this.Destination_dp.DataPropertyName = "CG_DESTINATION";
            this.Destination_dp.DataSource = this.dEPARTURESBindingSource;
            this.Destination_dp.DisplayMember = "DP_ADRESS";
            this.Destination_dp.HeaderText = "Destination";
            this.Destination_dp.Name = "Destination_dp";
            this.Destination_dp.ValueMember = "DP_ID";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CG_DESTINATION";
            this.dataGridViewTextBoxColumn10.HeaderText = "Destination";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // cGARRIVALDATEDataGridViewTextBoxColumn
            // 
            this.cGARRIVALDATEDataGridViewTextBoxColumn.DataPropertyName = "CG_ARRIVAL_DATE";
            this.cGARRIVALDATEDataGridViewTextBoxColumn.HeaderText = "Destination date";
            this.cGARRIVALDATEDataGridViewTextBoxColumn.Name = "cGARRIVALDATEDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "CG_ARRIVAL_TIME";
            this.dataGridViewTextBoxColumn14.HeaderText = "Destination time";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "TYPE_ID";
            this.dataGridViewTextBoxColumn26.HeaderText = "TYPE_ID";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            this.dataGridViewTextBoxColumn26.Visible = false;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "TYPE_MODEL";
            this.dataGridViewTextBoxColumn27.HeaderText = "Model";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "TYPE_CAPACITY";
            this.dataGridViewTextBoxColumn28.HeaderText = "Capacity";
            this.dataGridViewTextBoxColumn28.MaxInputLength = 5;
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "TYPE_CLASS";
            this.dataGridViewTextBoxColumn29.HeaderText = "Class";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FrmTrnspMng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(948, 450);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmTrnspMng";
            this.Text = "Transport Managment";
            this.tabControl1.ResumeLayout(false);
            this.tabCities.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabDepartures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabCargos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabTruckers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabTrucks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.tabTruckTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.tabTrailers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            this.tabTrailerTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cITIESBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTranspManag1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDepartures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTURESBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVCargos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRUCKERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARGOSBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVTruckers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRUCKBindingSource)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVTrucks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRUCKTYPESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAILERBindingSource)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVTruckTypes)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVTrailers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAILERTYPESBindingSource)).EndInit();
            this.tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVTrailerTypes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCargos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabTruckers;
        private System.Windows.Forms.Button buttonCargosSave;
        private System.Windows.Forms.TabPage tabTrailers;
        private System.Windows.Forms.TabPage tabDepartures;
        private System.Windows.Forms.TabPage tabCities;
        private System.Windows.Forms.TabPage tabTrailerTypes;
        private System.Windows.Forms.TabPage tabTruckTypes;
        private System.Windows.Forms.TabPage tabTrucks;
        private System.Windows.Forms.Button buttonCargosDelete;
        private System.Windows.Forms.Button buttonCitiesDelete;
        private System.Windows.Forms.Button buttonCitiesSave;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cITYIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cITYNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cITIESBindingSource;
        private System.Windows.Forms.Button buttonDeparturesDelete;
        private System.Windows.Forms.Button buttonDeparturesSave;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPCITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPADRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonTruckersDelete;
        private System.Windows.Forms.Button buttonTruckersSave;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRSURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRBIRTHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRSTARTDRIVEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRTRUCKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRUCKIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRUCKNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRUCKTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRUCKINSURANCEEXPIRATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRUCKTRAILERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPEMODELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPECAPACITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPECLASSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAILERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAILERLASTOVERHAULDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAILERSERIALNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAILERTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView8;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPETRIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPETRMODELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPETRCAPACITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPETRTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dGVCities;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dGVDepartures;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dGVCargos;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dGVTruckers;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dGVTrucks;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dGVTruckTypes;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataGridView dGVTrailers;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.DataGridView dGVTrailerTypes;
        private System.Windows.Forms.Button buttonTrucksDelete;
        private System.Windows.Forms.Button buttonTrucksSave;
        private System.Windows.Forms.Button buttonTruckTypesDelete;
        private System.Windows.Forms.Button buttonTruckTypesSave;
        private System.Windows.Forms.Button buttonTrailersDelete;
        private System.Windows.Forms.Button buttonTrailersSave;
        private System.Windows.Forms.Button buttonTrailerTypesDelete;
        private System.Windows.Forms.Button buttonTrailerTypesSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn cITYIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cITYNAMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPEIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPEMODELDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPECAPACITYDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPECLASSDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPETRIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPETRMODELDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPETRCAPACITYDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPETRTYPEDataGridViewTextBoxColumn1;
        private TranspManagDATA.DSTranspManagTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPCITYDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPADRESSDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPNAMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRNAMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRSURNAMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRBIRTHDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRSTARTDRIVEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRUCKIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRUCKNUMBERDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRUCKTYPEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRUCKINSURANCEEXPIRATIONDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRUCKTRAILERDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAILERIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAILERLASTOVERHAULDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAILERSERIALNUMBERDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAILERTYPEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGDEPARTUREPLACEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGDEPARTURETIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGWEIGHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGARRIVALTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGDESTINATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGTRUCKERDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cITIESBindingSource1;
        private TranspManagDATA.DSTranspManagTableAdapters.CITIESTableAdapter citiesTableAdapter1;
        private TranspManagDATA.DSTranspManag dsTranspManag1;
        private System.Windows.Forms.BindingSource dEPARTURESBindingSource;
        private System.Windows.Forms.BindingSource cARGOSBindingSource;
        private System.Windows.Forms.BindingSource tRUCKERSBindingSource;
        private TranspManagDATA.DSTranspManagTableAdapters.DEPARTURESTableAdapter departuresTableAdapter1;
        private TranspManagDATA.DSTranspManagTableAdapters.CARGOSTableAdapter cargosTableAdapter1;
        private System.Windows.Forms.BindingSource tRUCKBindingSource;
        private System.Windows.Forms.BindingSource tRUCKTYPESBindingSource;
        private System.Windows.Forms.BindingSource tRAILERBindingSource;
        private System.Windows.Forms.BindingSource tRAILERTYPESBindingSource;
        private TranspManagDATA.DSTranspManagTableAdapters.TRUCKERSTableAdapter truckersTableAdapter1;
        private TranspManagDATA.DSTranspManagTableAdapters.TRUCKTableAdapter truckTableAdapter1;
        private TranspManagDATA.DSTranspManagTableAdapters.TRUCK_TYPESTableAdapter trucK_TYPESTableAdapter1;
        private TranspManagDATA.DSTranspManagTableAdapters.TRAILERTableAdapter trailerTableAdapter1;
        private TranspManagDATA.DSTranspManagTableAdapters.TRAILER_TYPESTableAdapter traileR_TYPESTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewComboBoxColumn TruckTR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewComboBoxColumn TypeTP;
        private System.Windows.Forms.DataGridViewComboBoxColumn Capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewComboBoxColumn TrailerTR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn CitY;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewComboBoxColumn DeparturePlaceDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGDEPARTUREDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewComboBoxColumn TruckerTR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewComboBoxColumn Destination_dp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGARRIVALDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewComboBoxColumn TrailerTypeTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
    }
}

