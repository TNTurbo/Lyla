namespace LylaUI
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvCrafts = new System.Windows.Forms.DataGridView();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laborDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retiredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iteminventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sysDataSet = new LylaUI.sysDataSet();
            this.txtRetired = new System.Windows.Forms.TextBox();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRetireItem = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnOpenRecipies = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNewItem = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtItemNumber = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvRecipies = new System.Windows.Forms.DataGridView();
            this.itemIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemMaterialID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationmaterialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProfit = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaterialCost = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtQuality = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLabor = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtItemQuantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGeneration = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.iteminventoryTableAdapter = new LylaUI.sysDataSetTableAdapters.iteminventoryTableAdapter();
            this.creationmaterialsTableAdapter = new LylaUI.sysDataSetTableAdapters.creationmaterialsTableAdapter();
            this.materialsTableAdapter = new LylaUI.sysDataSetTableAdapters.materialsTableAdapter();
            this.btnRefreshItemList = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrafts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iteminventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysDataSet)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creationmaterialsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvCrafts);
            this.splitContainer1.Panel1.Controls.Add(this.txtRetired);
            this.splitContainer1.Panel1.Controls.Add(this.txtItemID);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(924, 502);
            this.splitContainer1.SplitterDistance = 377;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvCrafts
            // 
            this.dgvCrafts.AllowUserToAddRows = false;
            this.dgvCrafts.AllowUserToDeleteRows = false;
            this.dgvCrafts.AllowUserToResizeRows = false;
            this.dgvCrafts.AutoGenerateColumns = false;
            this.dgvCrafts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrafts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn,
            this.itemDataGridViewTextBoxColumn,
            this.generationDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.laborDataGridViewTextBoxColumn,
            this.qualityDataGridViewTextBoxColumn,
            this.materialCostDataGridViewTextBoxColumn,
            this.retiredDataGridViewTextBoxColumn});
            this.dgvCrafts.DataSource = this.iteminventoryBindingSource;
            this.dgvCrafts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCrafts.Location = new System.Drawing.Point(0, 0);
            this.dgvCrafts.MultiSelect = false;
            this.dgvCrafts.Name = "dgvCrafts";
            this.dgvCrafts.ReadOnly = true;
            this.dgvCrafts.RowHeadersVisible = false;
            this.dgvCrafts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCrafts.Size = new System.Drawing.Size(377, 502);
            this.dgvCrafts.TabIndex = 0;
            this.dgvCrafts.CurrentCellChanged += new System.EventHandler(this.dgvCrafts_CurrentCellChanged);
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            this.itemIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            this.itemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // generationDataGridViewTextBoxColumn
            // 
            this.generationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.generationDataGridViewTextBoxColumn.DataPropertyName = "Generation";
            this.generationDataGridViewTextBoxColumn.HeaderText = "Generation";
            this.generationDataGridViewTextBoxColumn.Name = "generationDataGridViewTextBoxColumn";
            this.generationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Visible = false;
            // 
            // laborDataGridViewTextBoxColumn
            // 
            this.laborDataGridViewTextBoxColumn.DataPropertyName = "Labor";
            this.laborDataGridViewTextBoxColumn.HeaderText = "Labor";
            this.laborDataGridViewTextBoxColumn.Name = "laborDataGridViewTextBoxColumn";
            this.laborDataGridViewTextBoxColumn.ReadOnly = true;
            this.laborDataGridViewTextBoxColumn.Visible = false;
            // 
            // qualityDataGridViewTextBoxColumn
            // 
            this.qualityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qualityDataGridViewTextBoxColumn.DataPropertyName = "Quality";
            this.qualityDataGridViewTextBoxColumn.HeaderText = "Quality";
            this.qualityDataGridViewTextBoxColumn.Name = "qualityDataGridViewTextBoxColumn";
            this.qualityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialCostDataGridViewTextBoxColumn
            // 
            this.materialCostDataGridViewTextBoxColumn.DataPropertyName = "MaterialCost";
            this.materialCostDataGridViewTextBoxColumn.HeaderText = "MaterialCost";
            this.materialCostDataGridViewTextBoxColumn.Name = "materialCostDataGridViewTextBoxColumn";
            this.materialCostDataGridViewTextBoxColumn.ReadOnly = true;
            this.materialCostDataGridViewTextBoxColumn.Visible = false;
            // 
            // retiredDataGridViewTextBoxColumn
            // 
            this.retiredDataGridViewTextBoxColumn.DataPropertyName = "Retired";
            this.retiredDataGridViewTextBoxColumn.HeaderText = "Retired";
            this.retiredDataGridViewTextBoxColumn.Name = "retiredDataGridViewTextBoxColumn";
            this.retiredDataGridViewTextBoxColumn.ReadOnly = true;
            this.retiredDataGridViewTextBoxColumn.Visible = false;
            // 
            // iteminventoryBindingSource
            // 
            this.iteminventoryBindingSource.DataMember = "iteminventory";
            this.iteminventoryBindingSource.DataSource = this.sysDataSet;
            // 
            // sysDataSet
            // 
            this.sysDataSet.DataSetName = "sysDataSet";
            this.sysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtRetired
            // 
            this.txtRetired.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iteminventoryBindingSource, "Retired", true));
            this.txtRetired.Enabled = false;
            this.txtRetired.Location = new System.Drawing.Point(204, 223);
            this.txtRetired.Name = "txtRetired";
            this.txtRetired.Size = new System.Drawing.Size(100, 20);
            this.txtRetired.TabIndex = 163;
            // 
            // txtItemID
            // 
            this.txtItemID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iteminventoryBindingSource, "ItemID", true));
            this.txtItemID.Enabled = false;
            this.txtItemID.Location = new System.Drawing.Point(204, 197);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(100, 20);
            this.txtItemID.TabIndex = 162;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.btnShowAll);
            this.groupBox4.Controls.Add(this.btnRefreshItemList);
            this.groupBox4.Controls.Add(this.btnRetireItem);
            this.groupBox4.Controls.Add(this.txtQuantity);
            this.groupBox4.Controls.Add(this.btnOpenRecipies);
            this.groupBox4.Controls.Add(this.btnRemove);
            this.groupBox4.Controls.Add(this.btnAdd);
            this.groupBox4.Controls.Add(this.btnConfirm);
            this.groupBox4.Controls.Add(this.btnEdit);
            this.groupBox4.Controls.Add(this.btnNewItem);
            this.groupBox4.Controls.Add(this.btnCancel);
            this.groupBox4.Location = new System.Drawing.Point(3, 163);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(257, 336);
            this.groupBox4.TabIndex = 156;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Controls";
            // 
            // btnRetireItem
            // 
            this.btnRetireItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRetireItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(208)))), ((int)(((byte)(235)))));
            this.btnRetireItem.Enabled = false;
            this.btnRetireItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetireItem.Location = new System.Drawing.Point(132, 156);
            this.btnRetireItem.Name = "btnRetireItem";
            this.btnRetireItem.Size = new System.Drawing.Size(119, 44);
            this.btnRetireItem.TabIndex = 158;
            this.btnRetireItem.Text = "Retire Item";
            this.btnRetireItem.UseVisualStyleBackColor = false;
            this.btnRetireItem.Click += new System.EventHandler(this.btnRetireItem_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(6, 69);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(245, 31);
            this.txtQuantity.TabIndex = 156;
            // 
            // btnOpenRecipies
            // 
            this.btnOpenRecipies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenRecipies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnOpenRecipies.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenRecipies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenRecipies.ForeColor = System.Drawing.Color.Black;
            this.btnOpenRecipies.Location = new System.Drawing.Point(131, 283);
            this.btnOpenRecipies.Name = "btnOpenRecipies";
            this.btnOpenRecipies.Size = new System.Drawing.Size(120, 44);
            this.btnOpenRecipies.TabIndex = 155;
            this.btnOpenRecipies.Text = "Crafting Recipies";
            this.btnOpenRecipies.UseVisualStyleBackColor = false;
            this.btnOpenRecipies.Click += new System.EventHandler(this.btnOpenRecipies_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(208)))), ((int)(((byte)(235)))));
            this.btnRemove.Enabled = false;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Location = new System.Drawing.Point(131, 19);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(120, 44);
            this.btnRemove.TabIndex = 154;
            this.btnRemove.Text = "Trashed";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(208)))), ((int)(((byte)(235)))));
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(6, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 44);
            this.btnAdd.TabIndex = 153;
            this.btnAdd.Text = "Crafted";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(208)))), ((int)(((byte)(235)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirm.Location = new System.Drawing.Point(6, 106);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(245, 44);
            this.btnConfirm.TabIndex = 160;
            this.btnConfirm.Text = "Done";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(208)))), ((int)(((byte)(235)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Location = new System.Drawing.Point(6, 106);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(245, 44);
            this.btnEdit.TabIndex = 159;
            this.btnEdit.Text = "Modify";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNewItem
            // 
            this.btnNewItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(208)))), ((int)(((byte)(235)))));
            this.btnNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewItem.Location = new System.Drawing.Point(7, 156);
            this.btnNewItem.Name = "btnNewItem";
            this.btnNewItem.Size = new System.Drawing.Size(119, 44);
            this.btnNewItem.TabIndex = 157;
            this.btnNewItem.Text = "New Item";
            this.btnNewItem.UseVisualStyleBackColor = false;
            this.btnNewItem.Click += new System.EventHandler(this.btnNewItem_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(208)))), ((int)(((byte)(235)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(7, 156);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 44);
            this.btnCancel.TabIndex = 161;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.txtItemNumber);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnCalculate);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtProfit);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtMaterialCost);
            this.groupBox2.Location = new System.Drawing.Point(266, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 496);
            this.groupBox2.TabIndex = 156;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculated";
            // 
            // txtItemNumber
            // 
            this.txtItemNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iteminventoryBindingSource, "ItemID", true));
            this.txtItemNumber.Enabled = false;
            this.txtItemNumber.Location = new System.Drawing.Point(111, 17);
            this.txtItemNumber.Name = "txtItemNumber";
            this.txtItemNumber.Size = new System.Drawing.Size(150, 20);
            this.txtItemNumber.TabIndex = 153;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.dgvRecipies);
            this.groupBox3.Location = new System.Drawing.Point(6, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 346);
            this.groupBox3.TabIndex = 152;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Current Recipie";
            // 
            // dgvRecipies
            // 
            this.dgvRecipies.AllowUserToAddRows = false;
            this.dgvRecipies.AllowUserToDeleteRows = false;
            this.dgvRecipies.AllowUserToResizeRows = false;
            this.dgvRecipies.AutoGenerateColumns = false;
            this.dgvRecipies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn1,
            this.MaterialID,
            this.ItemMaterialID,
            this.quantityDataGridViewTextBoxQuantity,
            this.AmountLeft});
            this.dgvRecipies.DataSource = this.creationmaterialsBindingSource;
            this.dgvRecipies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecipies.Location = new System.Drawing.Point(3, 16);
            this.dgvRecipies.MultiSelect = false;
            this.dgvRecipies.Name = "dgvRecipies";
            this.dgvRecipies.ReadOnly = true;
            this.dgvRecipies.RowHeadersVisible = false;
            this.dgvRecipies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecipies.Size = new System.Drawing.Size(254, 327);
            this.dgvRecipies.TabIndex = 1;
            // 
            // itemIDDataGridViewTextBoxColumn1
            // 
            this.itemIDDataGridViewTextBoxColumn1.DataPropertyName = "ItemID";
            this.itemIDDataGridViewTextBoxColumn1.HeaderText = "ItemID";
            this.itemIDDataGridViewTextBoxColumn1.Name = "itemIDDataGridViewTextBoxColumn1";
            this.itemIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.itemIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // MaterialID
            // 
            this.MaterialID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaterialID.DataPropertyName = "MaterialID";
            this.MaterialID.DataSource = this.materialsBindingSource;
            this.MaterialID.DisplayMember = "Material";
            this.MaterialID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.MaterialID.HeaderText = "Material";
            this.MaterialID.Name = "MaterialID";
            this.MaterialID.ReadOnly = true;
            this.MaterialID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaterialID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MaterialID.ValueMember = "MaterialID";
            // 
            // materialsBindingSource
            // 
            this.materialsBindingSource.DataMember = "materials";
            this.materialsBindingSource.DataSource = this.sysDataSet;
            // 
            // ItemMaterialID
            // 
            this.ItemMaterialID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemMaterialID.DataPropertyName = "ItemMaterialID";
            this.ItemMaterialID.HeaderText = "ItemMaterialID";
            this.ItemMaterialID.Name = "ItemMaterialID";
            this.ItemMaterialID.ReadOnly = true;
            this.ItemMaterialID.Visible = false;
            // 
            // quantityDataGridViewTextBoxQuantity
            // 
            this.quantityDataGridViewTextBoxQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantityDataGridViewTextBoxQuantity.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxQuantity.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxQuantity.Name = "quantityDataGridViewTextBoxQuantity";
            this.quantityDataGridViewTextBoxQuantity.ReadOnly = true;
            // 
            // AmountLeft
            // 
            this.AmountLeft.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AmountLeft.HeaderText = "Available";
            this.AmountLeft.Name = "AmountLeft";
            this.AmountLeft.ReadOnly = true;
            // 
            // creationmaterialsBindingSource
            // 
            this.creationmaterialsBindingSource.DataMember = "creationmaterials";
            this.creationmaterialsBindingSource.DataSource = this.sysDataSet;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(208)))), ((int)(((byte)(235)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Location = new System.Drawing.Point(138, 94);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(128, 44);
            this.btnRefresh.TabIndex = 151;
            this.btnRefresh.Text = "Refresh Recipie";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(208)))), ((int)(((byte)(235)))));
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculate.Location = new System.Drawing.Point(7, 94);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(128, 44);
            this.btnCalculate.TabIndex = 150;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 132;
            this.label1.Text = "Item Number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 135;
            this.label9.Text = "Material Cost:";
            // 
            // txtProfit
            // 
            this.txtProfit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iteminventoryBindingSource, "ProfitPerItem", true));
            this.txtProfit.Enabled = false;
            this.txtProfit.Location = new System.Drawing.Point(111, 61);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.Size = new System.Drawing.Size(150, 20);
            this.txtProfit.TabIndex = 149;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(61, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 20);
            this.label12.TabIndex = 134;
            this.label12.Text = "Profit:";
            // 
            // txtMaterialCost
            // 
            this.txtMaterialCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iteminventoryBindingSource, "MaterialCost", true));
            this.txtMaterialCost.Enabled = false;
            this.txtMaterialCost.Location = new System.Drawing.Point(111, 39);
            this.txtMaterialCost.Name = "txtMaterialCost";
            this.txtMaterialCost.Size = new System.Drawing.Size(150, 20);
            this.txtMaterialCost.TabIndex = 148;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtQuality);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtLabor);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtItemQuantity);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtGeneration);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtItem);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 154);
            this.groupBox1.TabIndex = 155;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(36, 127);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 20);
            this.label17.TabIndex = 145;
            this.label17.Text = "Quality:";
            // 
            // txtQuality
            // 
            this.txtQuality.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iteminventoryBindingSource, "Quality", true));
            this.txtQuality.Enabled = false;
            this.txtQuality.Location = new System.Drawing.Point(97, 127);
            this.txtQuality.Name = "txtQuality";
            this.txtQuality.Size = new System.Drawing.Size(150, 20);
            this.txtQuality.TabIndex = 153;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(43, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 20);
            this.label11.TabIndex = 140;
            this.label11.Text = "Labor:";
            // 
            // txtLabor
            // 
            this.txtLabor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iteminventoryBindingSource, "Labor", true));
            this.txtLabor.Enabled = false;
            this.txtLabor.Location = new System.Drawing.Point(97, 105);
            this.txtLabor.Name = "txtLabor";
            this.txtLabor.Size = new System.Drawing.Size(150, 20);
            this.txtLabor.TabIndex = 152;
            // 
            // txtPrice
            // 
            this.txtPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iteminventoryBindingSource, "Price", true));
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(97, 83);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(150, 20);
            this.txtPrice.TabIndex = 151;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(49, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 20);
            this.label15.TabIndex = 136;
            this.label15.Text = "Price:";
            // 
            // txtItemQuantity
            // 
            this.txtItemQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iteminventoryBindingSource, "Quantity", true));
            this.txtItemQuantity.Enabled = false;
            this.txtItemQuantity.Location = new System.Drawing.Point(97, 61);
            this.txtItemQuantity.Name = "txtItemQuantity";
            this.txtItemQuantity.Size = new System.Drawing.Size(150, 20);
            this.txtItemQuantity.TabIndex = 150;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(52, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 135;
            this.label8.Text = "Item:";
            // 
            // txtGeneration
            // 
            this.txtGeneration.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iteminventoryBindingSource, "Generation", true));
            this.txtGeneration.Enabled = false;
            this.txtGeneration.Location = new System.Drawing.Point(97, 39);
            this.txtGeneration.Name = "txtGeneration";
            this.txtGeneration.Size = new System.Drawing.Size(150, 20);
            this.txtGeneration.TabIndex = 149;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 134;
            this.label7.Text = "Generation:";
            // 
            // txtItem
            // 
            this.txtItem.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iteminventoryBindingSource, "Item", true));
            this.txtItem.Enabled = false;
            this.txtItem.Location = new System.Drawing.Point(97, 17);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(150, 20);
            this.txtItem.TabIndex = 148;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 133;
            this.label6.Text = "Quantity:";
            // 
            // iteminventoryTableAdapter
            // 
            this.iteminventoryTableAdapter.ClearBeforeFill = true;
            // 
            // creationmaterialsTableAdapter
            // 
            this.creationmaterialsTableAdapter.ClearBeforeFill = true;
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // btnRefreshItemList
            // 
            this.btnRefreshItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshItemList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(208)))), ((int)(((byte)(235)))));
            this.btnRefreshItemList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefreshItemList.Location = new System.Drawing.Point(7, 283);
            this.btnRefreshItemList.Name = "btnRefreshItemList";
            this.btnRefreshItemList.Size = new System.Drawing.Size(118, 44);
            this.btnRefreshItemList.TabIndex = 154;
            this.btnRefreshItemList.Text = "Refresh Item List";
            this.btnRefreshItemList.UseVisualStyleBackColor = false;
            this.btnRefreshItemList.Click += new System.EventHandler(this.btnRefreshItemList_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(208)))), ((int)(((byte)(235)))));
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowAll.Location = new System.Drawing.Point(8, 233);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(117, 44);
            this.btnShowAll.TabIndex = 162;
            this.btnShowAll.Text = "Show Old Items";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(924, 502);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrafts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iteminventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysDataSet)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creationmaterialsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private sysDataSet sysDataSet;
        private System.Windows.Forms.BindingSource iteminventoryBindingSource;
        private sysDataSetTableAdapters.iteminventoryTableAdapter iteminventoryTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtQuality;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLabor;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtItemQuantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGeneration;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtProfit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaterialCost;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.BindingSource creationmaterialsBindingSource;
        private sysDataSetTableAdapters.creationmaterialsTableAdapter creationmaterialsTableAdapter;
        private System.Windows.Forms.DataGridView dgvRecipies;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private sysDataSetTableAdapters.materialsTableAdapter materialsTableAdapter;
        private System.Windows.Forms.DataGridView dgvCrafts;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn laborDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn retiredDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnOpenRecipies;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnRetireItem;
        private System.Windows.Forms.Button btnNewItem;
        private System.Windows.Forms.TextBox txtItemNumber;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaterialID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemMaterialID;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountLeft;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtRetired;
        private System.Windows.Forms.Button btnRefreshItemList;
        private System.Windows.Forms.Button btnShowAll;
    }
}