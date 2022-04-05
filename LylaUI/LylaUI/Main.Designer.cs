namespace LylaUI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.saleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sysDataSet = new LylaUI.sysDataSet();
            this.datePurchasedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialsCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netProfitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raffleNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raffleEligibleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSaleID = new System.Windows.Forms.TextBox();
            this.gbControls = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnOpenSales = new System.Windows.Forms.Button();
            this.btnOpenRecipies = new System.Windows.Forms.Button();
            this.btnOpenMaterials = new System.Windows.Forms.Button();
            this.btnOpenCustomers = new System.Windows.Forms.Button();
            this.btnOpenInventory = new System.Windows.Forms.Button();
            this.btnCompleteSale = new System.Windows.Forms.Button();
            this.btnCancelSale = new System.Windows.Forms.Button();
            this.btnCreateSale = new System.Windows.Forms.Button();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.cboRaffleNumber = new System.Windows.Forms.ComboBox();
            this.cboAddress = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cboNetProfit = new System.Windows.Forms.ComboBox();
            this.cboShippingCost = new System.Windows.Forms.ComboBox();
            this.cboMaterialsCost = new System.Windows.Forms.ComboBox();
            this.cboOrderTotal = new System.Windows.Forms.ComboBox();
            this.cboDatePurchased = new System.Windows.Forms.ComboBox();
            this.cboSaleNumber = new System.Windows.Forms.ComboBox();
            this.cboLastName = new System.Windows.Forms.ComboBox();
            this.cboFirstName = new System.Windows.Forms.ComboBox();
            this.cboUsername = new System.Windows.Forms.ComboBox();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cboTier = new System.Windows.Forms.ComboBox();
            this.cboMedium = new System.Windows.Forms.ComboBox();
            this.cboPhone = new System.Windows.Forms.ComboBox();
            this.cboEmail = new System.Windows.Forms.ComboBox();
            this.cboZIP = new System.Windows.Forms.ComboBox();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.rtbComments = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.salesTableAdapter = new LylaUI.sysDataSetTableAdapters.salesTableAdapter();
            this.customerTableAdapter = new LylaUI.sysDataSetTableAdapters.customerTableAdapter();
            this.customersalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            this.gbControls.SuspendLayout();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersalesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitMain.IsSplitterFixed = true;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.AutoScroll = true;
            this.splitMain.Panel1.Controls.Add(this.dgvSales);
            this.splitMain.Panel1.Controls.Add(this.txtSaleID);
            this.splitMain.Panel1MinSize = 503;
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.gbControls);
            this.splitMain.Panel2.Controls.Add(this.gbDetails);
            this.splitMain.Panel2MinSize = 504;
            this.splitMain.Size = new System.Drawing.Size(1055, 580);
            this.splitMain.SplitterDistance = 503;
            this.splitMain.TabIndex = 0;
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.AllowUserToResizeRows = false;
            this.dgvSales.AutoGenerateColumns = false;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleIDDataGridViewTextBoxColumn,
            this.Active,
            this.customerIDDataGridViewTextBoxColumn,
            this.datePurchasedDataGridViewTextBoxColumn,
            this.orderTotalDataGridViewTextBoxColumn,
            this.shippingCostDataGridViewTextBoxColumn,
            this.materialsCostDataGridViewTextBoxColumn,
            this.netProfitDataGridViewTextBoxColumn,
            this.raffleNumberDataGridViewTextBoxColumn,
            this.raffleEligibleDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn});
            this.dgvSales.DataSource = this.salesBindingSource;
            this.dgvSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSales.Location = new System.Drawing.Point(0, 0);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.RowHeadersVisible = false;
            this.dgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSales.Size = new System.Drawing.Size(503, 580);
            this.dgvSales.TabIndex = 0;
            // 
            // saleIDDataGridViewTextBoxColumn
            // 
            this.saleIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.saleIDDataGridViewTextBoxColumn.DataPropertyName = "SaleID";
            this.saleIDDataGridViewTextBoxColumn.HeaderText = "Sale Number";
            this.saleIDDataGridViewTextBoxColumn.Name = "saleIDDataGridViewTextBoxColumn";
            this.saleIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.HeaderText = "Active";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            this.Active.Visible = false;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.DataSource = this.customerBindingSource;
            this.customerIDDataGridViewTextBoxColumn.DisplayMember = "Username";
            this.customerIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.customerIDDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "Requester";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.customerIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.customerIDDataGridViewTextBoxColumn.ValueMember = "CustomerID";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.sysDataSet;
            // 
            // sysDataSet
            // 
            this.sysDataSet.DataSetName = "sysDataSet";
            this.sysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datePurchasedDataGridViewTextBoxColumn
            // 
            this.datePurchasedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datePurchasedDataGridViewTextBoxColumn.DataPropertyName = "DatePurchased";
            this.datePurchasedDataGridViewTextBoxColumn.HeaderText = "Order Date";
            this.datePurchasedDataGridViewTextBoxColumn.Name = "datePurchasedDataGridViewTextBoxColumn";
            this.datePurchasedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderTotalDataGridViewTextBoxColumn
            // 
            this.orderTotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderTotalDataGridViewTextBoxColumn.DataPropertyName = "OrderTotal";
            this.orderTotalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.orderTotalDataGridViewTextBoxColumn.Name = "orderTotalDataGridViewTextBoxColumn";
            this.orderTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shippingCostDataGridViewTextBoxColumn
            // 
            this.shippingCostDataGridViewTextBoxColumn.DataPropertyName = "ShippingCost";
            this.shippingCostDataGridViewTextBoxColumn.HeaderText = "ShippingCost";
            this.shippingCostDataGridViewTextBoxColumn.Name = "shippingCostDataGridViewTextBoxColumn";
            this.shippingCostDataGridViewTextBoxColumn.ReadOnly = true;
            this.shippingCostDataGridViewTextBoxColumn.Visible = false;
            // 
            // materialsCostDataGridViewTextBoxColumn
            // 
            this.materialsCostDataGridViewTextBoxColumn.DataPropertyName = "MaterialsCost";
            this.materialsCostDataGridViewTextBoxColumn.HeaderText = "MaterialsCost";
            this.materialsCostDataGridViewTextBoxColumn.Name = "materialsCostDataGridViewTextBoxColumn";
            this.materialsCostDataGridViewTextBoxColumn.ReadOnly = true;
            this.materialsCostDataGridViewTextBoxColumn.Visible = false;
            // 
            // netProfitDataGridViewTextBoxColumn
            // 
            this.netProfitDataGridViewTextBoxColumn.DataPropertyName = "NetProfit";
            this.netProfitDataGridViewTextBoxColumn.HeaderText = "NetProfit";
            this.netProfitDataGridViewTextBoxColumn.Name = "netProfitDataGridViewTextBoxColumn";
            this.netProfitDataGridViewTextBoxColumn.ReadOnly = true;
            this.netProfitDataGridViewTextBoxColumn.Visible = false;
            // 
            // raffleNumberDataGridViewTextBoxColumn
            // 
            this.raffleNumberDataGridViewTextBoxColumn.DataPropertyName = "RaffleNumber";
            this.raffleNumberDataGridViewTextBoxColumn.HeaderText = "RaffleNumber";
            this.raffleNumberDataGridViewTextBoxColumn.Name = "raffleNumberDataGridViewTextBoxColumn";
            this.raffleNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.raffleNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // raffleEligibleDataGridViewTextBoxColumn
            // 
            this.raffleEligibleDataGridViewTextBoxColumn.DataPropertyName = "RaffleEligible";
            this.raffleEligibleDataGridViewTextBoxColumn.HeaderText = "RaffleEligible";
            this.raffleEligibleDataGridViewTextBoxColumn.Name = "raffleEligibleDataGridViewTextBoxColumn";
            this.raffleEligibleDataGridViewTextBoxColumn.ReadOnly = true;
            this.raffleEligibleDataGridViewTextBoxColumn.Visible = false;
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn.FillWeight = 150F;
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            this.commentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "sales";
            this.salesBindingSource.DataSource = this.sysDataSet;
            // 
            // txtSaleID
            // 
            this.txtSaleID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesBindingSource, "SaleID", true));
            this.txtSaleID.Enabled = false;
            this.txtSaleID.Location = new System.Drawing.Point(31, 78);
            this.txtSaleID.Name = "txtSaleID";
            this.txtSaleID.Size = new System.Drawing.Size(100, 20);
            this.txtSaleID.TabIndex = 1;
            // 
            // gbControls
            // 
            this.gbControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbControls.Controls.Add(this.btnRefresh);
            this.gbControls.Controls.Add(this.btnOpenSales);
            this.gbControls.Controls.Add(this.btnOpenRecipies);
            this.gbControls.Controls.Add(this.btnOpenMaterials);
            this.gbControls.Controls.Add(this.btnOpenCustomers);
            this.gbControls.Controls.Add(this.btnOpenInventory);
            this.gbControls.Controls.Add(this.btnCompleteSale);
            this.gbControls.Controls.Add(this.btnCancelSale);
            this.gbControls.Controls.Add(this.btnCreateSale);
            this.gbControls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbControls.Location = new System.Drawing.Point(3, 303);
            this.gbControls.Name = "gbControls";
            this.gbControls.Size = new System.Drawing.Size(540, 274);
            this.gbControls.TabIndex = 2;
            this.gbControls.TabStop = false;
            this.gbControls.Text = "Controls";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(208)))), ((int)(((byte)(235)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Location = new System.Drawing.Point(6, 219);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(128, 44);
            this.btnRefresh.TabIndex = 70;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnOpenSales
            // 
            this.btnOpenSales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnOpenSales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenSales.ForeColor = System.Drawing.Color.Black;
            this.btnOpenSales.Location = new System.Drawing.Point(408, 219);
            this.btnOpenSales.Name = "btnOpenSales";
            this.btnOpenSales.Size = new System.Drawing.Size(128, 44);
            this.btnOpenSales.TabIndex = 69;
            this.btnOpenSales.Text = "Sales";
            this.btnOpenSales.UseVisualStyleBackColor = false;
            this.btnOpenSales.Click += new System.EventHandler(this.btnOpenSales_Click);
            // 
            // btnOpenRecipies
            // 
            this.btnOpenRecipies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenRecipies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnOpenRecipies.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenRecipies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenRecipies.ForeColor = System.Drawing.Color.Black;
            this.btnOpenRecipies.Location = new System.Drawing.Point(408, 169);
            this.btnOpenRecipies.Name = "btnOpenRecipies";
            this.btnOpenRecipies.Size = new System.Drawing.Size(128, 44);
            this.btnOpenRecipies.TabIndex = 68;
            this.btnOpenRecipies.Text = "Crafting Recipies";
            this.btnOpenRecipies.UseVisualStyleBackColor = false;
            this.btnOpenRecipies.Click += new System.EventHandler(this.btnOpenRecipies_Click);
            // 
            // btnOpenMaterials
            // 
            this.btnOpenMaterials.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenMaterials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnOpenMaterials.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenMaterials.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenMaterials.ForeColor = System.Drawing.Color.Black;
            this.btnOpenMaterials.Location = new System.Drawing.Point(408, 119);
            this.btnOpenMaterials.Name = "btnOpenMaterials";
            this.btnOpenMaterials.Size = new System.Drawing.Size(128, 44);
            this.btnOpenMaterials.TabIndex = 67;
            this.btnOpenMaterials.Text = "Materials";
            this.btnOpenMaterials.UseVisualStyleBackColor = false;
            this.btnOpenMaterials.Click += new System.EventHandler(this.btnOpenMaterials_Click);
            // 
            // btnOpenCustomers
            // 
            this.btnOpenCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnOpenCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenCustomers.ForeColor = System.Drawing.Color.Black;
            this.btnOpenCustomers.Location = new System.Drawing.Point(408, 19);
            this.btnOpenCustomers.Name = "btnOpenCustomers";
            this.btnOpenCustomers.Size = new System.Drawing.Size(128, 44);
            this.btnOpenCustomers.TabIndex = 66;
            this.btnOpenCustomers.Text = "Customers";
            this.btnOpenCustomers.UseVisualStyleBackColor = false;
            this.btnOpenCustomers.Click += new System.EventHandler(this.btnOpenCustomers_Click);
            // 
            // btnOpenInventory
            // 
            this.btnOpenInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnOpenInventory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenInventory.ForeColor = System.Drawing.Color.Black;
            this.btnOpenInventory.Location = new System.Drawing.Point(408, 69);
            this.btnOpenInventory.Name = "btnOpenInventory";
            this.btnOpenInventory.Size = new System.Drawing.Size(128, 44);
            this.btnOpenInventory.TabIndex = 65;
            this.btnOpenInventory.Text = "Inventory";
            this.btnOpenInventory.UseVisualStyleBackColor = false;
            this.btnOpenInventory.Click += new System.EventHandler(this.btnOpenInventory_Click);
            // 
            // btnCompleteSale
            // 
            this.btnCompleteSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompleteSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(99)))), ((int)(((byte)(204)))));
            this.btnCompleteSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCompleteSale.Location = new System.Drawing.Point(140, 19);
            this.btnCompleteSale.Name = "btnCompleteSale";
            this.btnCompleteSale.Size = new System.Drawing.Size(128, 44);
            this.btnCompleteSale.TabIndex = 65;
            this.btnCompleteSale.Text = "Complete Sale";
            this.btnCompleteSale.UseVisualStyleBackColor = false;
            this.btnCompleteSale.Click += new System.EventHandler(this.btnCompleteSale_Click);
            // 
            // btnCancelSale
            // 
            this.btnCancelSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(208)))), ((int)(((byte)(235)))));
            this.btnCancelSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelSale.Location = new System.Drawing.Point(274, 19);
            this.btnCancelSale.Name = "btnCancelSale";
            this.btnCancelSale.Size = new System.Drawing.Size(128, 44);
            this.btnCancelSale.TabIndex = 65;
            this.btnCancelSale.Text = "Cancel Sale";
            this.btnCancelSale.UseVisualStyleBackColor = false;
            this.btnCancelSale.Click += new System.EventHandler(this.btnCancelSale_Click);
            // 
            // btnCreateSale
            // 
            this.btnCreateSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.btnCreateSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateSale.Location = new System.Drawing.Point(6, 19);
            this.btnCreateSale.Name = "btnCreateSale";
            this.btnCreateSale.Size = new System.Drawing.Size(128, 44);
            this.btnCreateSale.TabIndex = 0;
            this.btnCreateSale.Text = "Create Sale";
            this.btnCreateSale.UseVisualStyleBackColor = false;
            this.btnCreateSale.Click += new System.EventHandler(this.btnCreateSale_Click);
            // 
            // gbDetails
            // 
            this.gbDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDetails.Controls.Add(this.cboRaffleNumber);
            this.gbDetails.Controls.Add(this.cboAddress);
            this.gbDetails.Controls.Add(this.label22);
            this.gbDetails.Controls.Add(this.comboBox2);
            this.gbDetails.Controls.Add(this.label19);
            this.gbDetails.Controls.Add(this.cboNetProfit);
            this.gbDetails.Controls.Add(this.cboShippingCost);
            this.gbDetails.Controls.Add(this.cboMaterialsCost);
            this.gbDetails.Controls.Add(this.cboOrderTotal);
            this.gbDetails.Controls.Add(this.cboDatePurchased);
            this.gbDetails.Controls.Add(this.cboSaleNumber);
            this.gbDetails.Controls.Add(this.cboLastName);
            this.gbDetails.Controls.Add(this.cboFirstName);
            this.gbDetails.Controls.Add(this.cboUsername);
            this.gbDetails.Controls.Add(this.cboCity);
            this.gbDetails.Controls.Add(this.label17);
            this.gbDetails.Controls.Add(this.cboTier);
            this.gbDetails.Controls.Add(this.cboMedium);
            this.gbDetails.Controls.Add(this.cboPhone);
            this.gbDetails.Controls.Add(this.cboEmail);
            this.gbDetails.Controls.Add(this.cboZIP);
            this.gbDetails.Controls.Add(this.cboState);
            this.gbDetails.Controls.Add(this.cboCountry);
            this.gbDetails.Controls.Add(this.rtbComments);
            this.gbDetails.Controls.Add(this.label10);
            this.gbDetails.Controls.Add(this.label14);
            this.gbDetails.Controls.Add(this.label16);
            this.gbDetails.Controls.Add(this.label20);
            this.gbDetails.Controls.Add(this.label21);
            this.gbDetails.Controls.Add(this.label11);
            this.gbDetails.Controls.Add(this.label12);
            this.gbDetails.Controls.Add(this.label13);
            this.gbDetails.Controls.Add(this.label15);
            this.gbDetails.Controls.Add(this.label9);
            this.gbDetails.Controls.Add(this.label8);
            this.gbDetails.Controls.Add(this.label7);
            this.gbDetails.Controls.Add(this.label6);
            this.gbDetails.Controls.Add(this.label5);
            this.gbDetails.Controls.Add(this.label4);
            this.gbDetails.Controls.Add(this.label3);
            this.gbDetails.Controls.Add(this.label2);
            this.gbDetails.Controls.Add(this.label1);
            this.gbDetails.Location = new System.Drawing.Point(3, 3);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(540, 301);
            this.gbDetails.TabIndex = 1;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details";
            // 
            // cboRaffleNumber
            // 
            this.cboRaffleNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboRaffleNumber.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salesBindingSource, "CustomerID", true));
            this.cboRaffleNumber.DataSource = this.salesBindingSource;
            this.cboRaffleNumber.DisplayMember = "RaffleNumber";
            this.cboRaffleNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboRaffleNumber.Enabled = false;
            this.cboRaffleNumber.FormattingEnabled = true;
            this.cboRaffleNumber.Location = new System.Drawing.Point(381, 174);
            this.cboRaffleNumber.Name = "cboRaffleNumber";
            this.cboRaffleNumber.Size = new System.Drawing.Size(150, 21);
            this.cboRaffleNumber.TabIndex = 64;
            // 
            // cboAddress
            // 
            this.cboAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAddress.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salesBindingSource, "CustomerID", true));
            this.cboAddress.DataSource = this.customerBindingSource;
            this.cboAddress.DisplayMember = "Address";
            this.cboAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboAddress.Enabled = false;
            this.cboAddress.FormattingEnabled = true;
            this.cboAddress.Location = new System.Drawing.Point(99, 135);
            this.cboAddress.Name = "cboAddress";
            this.cboAddress.Size = new System.Drawing.Size(150, 21);
            this.cboAddress.TabIndex = 41;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(266, 175);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(116, 20);
            this.label22.TabIndex = 63;
            this.label22.Text = "Raffle Number:";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salesBindingSource, "CustomerID", true));
            this.comboBox2.DataSource = this.salesBindingSource;
            this.comboBox2.DisplayMember = "RaffleEligible";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(381, 154);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(150, 21);
            this.comboBox2.TabIndex = 62;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(266, 154);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(116, 20);
            this.label19.TabIndex = 61;
            this.label19.Text = "Raffle Eligable:";
            // 
            // cboNetProfit
            // 
            this.cboNetProfit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNetProfit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salesBindingSource, "CustomerID", true));
            this.cboNetProfit.DataSource = this.salesBindingSource;
            this.cboNetProfit.DisplayMember = "NetProfit";
            this.cboNetProfit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboNetProfit.Enabled = false;
            this.cboNetProfit.FormattingEnabled = true;
            this.cboNetProfit.Location = new System.Drawing.Point(381, 114);
            this.cboNetProfit.Name = "cboNetProfit";
            this.cboNetProfit.Size = new System.Drawing.Size(150, 21);
            this.cboNetProfit.TabIndex = 58;
            // 
            // cboShippingCost
            // 
            this.cboShippingCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboShippingCost.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salesBindingSource, "CustomerID", true));
            this.cboShippingCost.DataSource = this.salesBindingSource;
            this.cboShippingCost.DisplayMember = "ShippingCost";
            this.cboShippingCost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboShippingCost.Enabled = false;
            this.cboShippingCost.FormattingEnabled = true;
            this.cboShippingCost.Location = new System.Drawing.Point(381, 95);
            this.cboShippingCost.Name = "cboShippingCost";
            this.cboShippingCost.Size = new System.Drawing.Size(150, 21);
            this.cboShippingCost.TabIndex = 57;
            // 
            // cboMaterialsCost
            // 
            this.cboMaterialsCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMaterialsCost.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salesBindingSource, "CustomerID", true));
            this.cboMaterialsCost.DataSource = this.salesBindingSource;
            this.cboMaterialsCost.DisplayMember = "MaterialsCost";
            this.cboMaterialsCost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboMaterialsCost.Enabled = false;
            this.cboMaterialsCost.FormattingEnabled = true;
            this.cboMaterialsCost.Location = new System.Drawing.Point(381, 75);
            this.cboMaterialsCost.Name = "cboMaterialsCost";
            this.cboMaterialsCost.Size = new System.Drawing.Size(150, 21);
            this.cboMaterialsCost.TabIndex = 56;
            // 
            // cboOrderTotal
            // 
            this.cboOrderTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboOrderTotal.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salesBindingSource, "CustomerID", true));
            this.cboOrderTotal.DataSource = this.salesBindingSource;
            this.cboOrderTotal.DisplayMember = "OrderTotal";
            this.cboOrderTotal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboOrderTotal.Enabled = false;
            this.cboOrderTotal.FormattingEnabled = true;
            this.cboOrderTotal.Location = new System.Drawing.Point(381, 55);
            this.cboOrderTotal.Name = "cboOrderTotal";
            this.cboOrderTotal.Size = new System.Drawing.Size(150, 21);
            this.cboOrderTotal.TabIndex = 55;
            // 
            // cboDatePurchased
            // 
            this.cboDatePurchased.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDatePurchased.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salesBindingSource, "CustomerID", true));
            this.cboDatePurchased.DataSource = this.salesBindingSource;
            this.cboDatePurchased.DisplayMember = "DatePurchased";
            this.cboDatePurchased.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboDatePurchased.Enabled = false;
            this.cboDatePurchased.FormattingEnabled = true;
            this.cboDatePurchased.Location = new System.Drawing.Point(381, 36);
            this.cboDatePurchased.Name = "cboDatePurchased";
            this.cboDatePurchased.Size = new System.Drawing.Size(150, 21);
            this.cboDatePurchased.TabIndex = 54;
            // 
            // cboSaleNumber
            // 
            this.cboSaleNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSaleNumber.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salesBindingSource, "CustomerID", true));
            this.cboSaleNumber.DataSource = this.salesBindingSource;
            this.cboSaleNumber.DisplayMember = "SaleID";
            this.cboSaleNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboSaleNumber.Enabled = false;
            this.cboSaleNumber.FormattingEnabled = true;
            this.cboSaleNumber.Location = new System.Drawing.Point(381, 16);
            this.cboSaleNumber.Name = "cboSaleNumber";
            this.cboSaleNumber.Size = new System.Drawing.Size(150, 21);
            this.cboSaleNumber.TabIndex = 53;
            // 
            // cboLastName
            // 
            this.cboLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLastName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salesBindingSource, "CustomerID", true));
            this.cboLastName.DataSource = this.customerBindingSource;
            this.cboLastName.DisplayMember = "LastName";
            this.cboLastName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboLastName.Enabled = false;
            this.cboLastName.FormattingEnabled = true;
            this.cboLastName.Location = new System.Drawing.Point(99, 56);
            this.cboLastName.Name = "cboLastName";
            this.cboLastName.Size = new System.Drawing.Size(150, 21);
            this.cboLastName.TabIndex = 52;
            this.cboLastName.ValueMember = "CustomerID";
            // 
            // cboFirstName
            // 
            this.cboFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFirstName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salesBindingSource, "CustomerID", true));
            this.cboFirstName.DataSource = this.customerBindingSource;
            this.cboFirstName.DisplayMember = "FirstName";
            this.cboFirstName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboFirstName.Enabled = false;
            this.cboFirstName.FormattingEnabled = true;
            this.cboFirstName.Location = new System.Drawing.Point(99, 37);
            this.cboFirstName.Name = "cboFirstName";
            this.cboFirstName.Size = new System.Drawing.Size(150, 21);
            this.cboFirstName.TabIndex = 51;
            this.cboFirstName.ValueMember = "CustomerID";
            // 
            // cboUsername
            // 
            this.cboUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboUsername.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salesBindingSource, "CustomerID", true));
            this.cboUsername.DataSource = this.customerBindingSource;
            this.cboUsername.DisplayMember = "Username";
            this.cboUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboUsername.Enabled = false;
            this.cboUsername.FormattingEnabled = true;
            this.cboUsername.Location = new System.Drawing.Point(99, 17);
            this.cboUsername.Name = "cboUsername";
            this.cboUsername.Size = new System.Drawing.Size(150, 21);
            this.cboUsername.TabIndex = 50;
            this.cboUsername.ValueMember = "CustomerID";
            // 
            // cboCity
            // 
            this.cboCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCity.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salesBindingSource, "CustomerID", true));
            this.cboCity.DataSource = this.customerBindingSource;
            this.cboCity.DisplayMember = "City";
            this.cboCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboCity.Enabled = false;
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Location = new System.Drawing.Point(99, 115);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(150, 21);
            this.cboCity.TabIndex = 49;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(54, 116);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 20);
            this.label17.TabIndex = 48;
            this.label17.Text = "City:";
            // 
            // cboTier
            // 
            this.cboTier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTier.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salesBindingSource, "CustomerID", true));
            this.cboTier.DataSource = this.customerBindingSource;
            this.cboTier.DisplayMember = "MembershipStatus";
            this.cboTier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboTier.Enabled = false;
            this.cboTier.FormattingEnabled = true;
            this.cboTier.Location = new System.Drawing.Point(99, 273);
            this.cboTier.Name = "cboTier";
            this.cboTier.Size = new System.Drawing.Size(150, 21);
            this.cboTier.TabIndex = 46;
            this.cboTier.ValueMember = "CustomerID";
            // 
            // cboMedium
            // 
            this.cboMedium.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMedium.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salesBindingSource, "CustomerID", true));
            this.cboMedium.DataSource = this.customerBindingSource;
            this.cboMedium.DisplayMember = "PurchaseMedium";
            this.cboMedium.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboMedium.Enabled = false;
            this.cboMedium.FormattingEnabled = true;
            this.cboMedium.Location = new System.Drawing.Point(99, 253);
            this.cboMedium.Name = "cboMedium";
            this.cboMedium.Size = new System.Drawing.Size(150, 21);
            this.cboMedium.TabIndex = 45;
            this.cboMedium.ValueMember = "CustomerID";
            // 
            // cboPhone
            // 
            this.cboPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPhone.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salesBindingSource, "CustomerID", true));
            this.cboPhone.DataSource = this.customerBindingSource;
            this.cboPhone.DisplayMember = "PhoneNumber";
            this.cboPhone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboPhone.Enabled = false;
            this.cboPhone.FormattingEnabled = true;
            this.cboPhone.Location = new System.Drawing.Point(99, 214);
            this.cboPhone.Name = "cboPhone";
            this.cboPhone.Size = new System.Drawing.Size(150, 21);
            this.cboPhone.TabIndex = 44;
            this.cboPhone.ValueMember = "CustomerID";
            // 
            // cboEmail
            // 
            this.cboEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboEmail.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salesBindingSource, "CustomerID", true));
            this.cboEmail.DataSource = this.customerBindingSource;
            this.cboEmail.DisplayMember = "Email";
            this.cboEmail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboEmail.Enabled = false;
            this.cboEmail.FormattingEnabled = true;
            this.cboEmail.Location = new System.Drawing.Point(99, 194);
            this.cboEmail.Name = "cboEmail";
            this.cboEmail.Size = new System.Drawing.Size(150, 21);
            this.cboEmail.TabIndex = 43;
            this.cboEmail.ValueMember = "CustomerID";
            // 
            // cboZIP
            // 
            this.cboZIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboZIP.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salesBindingSource, "CustomerID", true));
            this.cboZIP.DataSource = this.customerBindingSource;
            this.cboZIP.DisplayMember = "ZIP";
            this.cboZIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboZIP.Enabled = false;
            this.cboZIP.FormattingEnabled = true;
            this.cboZIP.Location = new System.Drawing.Point(99, 155);
            this.cboZIP.Name = "cboZIP";
            this.cboZIP.Size = new System.Drawing.Size(150, 21);
            this.cboZIP.TabIndex = 42;
            // 
            // cboState
            // 
            this.cboState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboState.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salesBindingSource, "CustomerID", true));
            this.cboState.DataSource = this.customerBindingSource;
            this.cboState.DisplayMember = "State";
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboState.Enabled = false;
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(99, 96);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(150, 21);
            this.cboState.TabIndex = 40;
            this.cboState.ValueMember = "CustomerID";
            // 
            // cboCountry
            // 
            this.cboCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCountry.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salesBindingSource, "CustomerID", true));
            this.cboCountry.DataSource = this.customerBindingSource;
            this.cboCountry.DisplayMember = "Country";
            this.cboCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboCountry.Enabled = false;
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(99, 76);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(150, 21);
            this.cboCountry.TabIndex = 2;
            this.cboCountry.ValueMember = "CustomerID";
            // 
            // rtbComments
            // 
            this.rtbComments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbComments.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesBindingSource, "Comments", true));
            this.rtbComments.Enabled = false;
            this.rtbComments.Location = new System.Drawing.Point(380, 196);
            this.rtbComments.Name = "rtbComments";
            this.rtbComments.Size = new System.Drawing.Size(150, 98);
            this.rtbComments.TabIndex = 19;
            this.rtbComments.Text = "";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(292, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Comments:";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(24, 254);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 20);
            this.label14.TabIndex = 36;
            this.label14.Text = "Medium:";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(13, 274);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 20);
            this.label16.TabIndex = 35;
            this.label16.Text = "Cust. Tier:";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(42, 194);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 20);
            this.label20.TabIndex = 28;
            this.label20.Text = "Email:";
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(34, 214);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 20);
            this.label21.TabIndex = 27;
            this.label21.Text = "Phone:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(41, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "State:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Address:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(55, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "ZIP:";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(25, 76);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 20);
            this.label15.TabIndex = 18;
            this.label15.Text = "Country:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(254, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Date Purchased:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Username:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "First Name:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(270, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Shipping Cost:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(268, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Materials Cost:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Order Total:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Net Profit:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sale Number:";
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // customersalesBindingSource
            // 
            this.customersalesBindingSource.DataMember = "customer_sales";
            this.customersalesBindingSource.DataSource = this.customerBindingSource;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1055, 580);
            this.Controls.Add(this.splitMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Little Lylas";
            this.Load += new System.EventHandler(this.Main_Load);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel1.PerformLayout();
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            this.gbControls.ResumeLayout(false);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersalesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.DataGridView dgvSales;
        private sysDataSet sysDataSet;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private sysDataSetTableAdapters.salesTableAdapter salesTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private sysDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.RichTextBox rtbComments;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource customersalesBindingSource;
        private System.Windows.Forms.ComboBox cboTier;
        private System.Windows.Forms.ComboBox cboMedium;
        private System.Windows.Forms.ComboBox cboPhone;
        private System.Windows.Forms.ComboBox cboEmail;
        private System.Windows.Forms.ComboBox cboZIP;
        private System.Windows.Forms.ComboBox cboAddress;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.ComboBox cboCity;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cboNetProfit;
        private System.Windows.Forms.ComboBox cboShippingCost;
        private System.Windows.Forms.ComboBox cboMaterialsCost;
        private System.Windows.Forms.ComboBox cboOrderTotal;
        private System.Windows.Forms.ComboBox cboDatePurchased;
        private System.Windows.Forms.ComboBox cboSaleNumber;
        private System.Windows.Forms.ComboBox cboLastName;
        private System.Windows.Forms.ComboBox cboFirstName;
        private System.Windows.Forms.ComboBox cboUsername;
        private System.Windows.Forms.ComboBox cboRaffleNumber;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox gbControls;
        private System.Windows.Forms.Button btnOpenSales;
        private System.Windows.Forms.Button btnOpenRecipies;
        private System.Windows.Forms.Button btnOpenMaterials;
        private System.Windows.Forms.Button btnOpenCustomers;
        private System.Windows.Forms.Button btnOpenInventory;
        private System.Windows.Forms.Button btnCompleteSale;
        private System.Windows.Forms.Button btnCancelSale;
        private System.Windows.Forms.Button btnCreateSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Active;
        private System.Windows.Forms.DataGridViewComboBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePurchasedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialsCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netProfitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raffleNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raffleEligibleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtSaleID;
    }
}

