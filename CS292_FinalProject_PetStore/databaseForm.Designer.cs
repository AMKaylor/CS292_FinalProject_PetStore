namespace CS292_FinalProject_PetStore
{
    partial class databaseForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.goToWishlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descriptorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.storeItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.petInfoDataSet1 = new CS292_FinalProject_PetStore.PetInfoDataSet1();
			this.petInfoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.petInfoDataSet = new CS292_FinalProject_PetStore.PetInfoDataSet();
			this.addToWSBtn = new System.Windows.Forms.Button();
			this.storeItemsTableAdapter = new CS292_FinalProject_PetStore.PetInfoDataSet1TableAdapters.StoreItemsTableAdapter();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.descRadioBtn = new System.Windows.Forms.RadioButton();
			this.ascRadioBtn = new System.Windows.Forms.RadioButton();
			this.filterComboBox = new System.Windows.Forms.ComboBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.storeItemsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.petInfoDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.petInfoDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.petInfoDataSet)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.goToWishlistToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(703, 26);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(48, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// goToWishlistToolStripMenuItem
			// 
			this.goToWishlistToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.goToWishlistToolStripMenuItem.Name = "goToWishlistToolStripMenuItem";
			this.goToWishlistToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.goToWishlistToolStripMenuItem.Text = "Go to Wishlist";
			this.goToWishlistToolStripMenuItem.Click += new System.EventHandler(this.goToWishlistToolStripMenuItem_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn,
            this.productTypeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.descriptorDataGridViewTextBoxColumn});
			this.dataGridView1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.storeItemsBindingSource, "ProductName", true));
			this.dataGridView1.DataSource = this.storeItemsBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(262, 43);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 30;
			this.dataGridView1.Size = new System.Drawing.Size(433, 222);
			this.dataGridView1.TabIndex = 5;
			// 
			// productNameDataGridViewTextBoxColumn
			// 
			this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
			this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
			this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
			// 
			// productTypeDataGridViewTextBoxColumn
			// 
			this.productTypeDataGridViewTextBoxColumn.DataPropertyName = "ProductType";
			this.productTypeDataGridViewTextBoxColumn.HeaderText = "ProductType";
			this.productTypeDataGridViewTextBoxColumn.Name = "productTypeDataGridViewTextBoxColumn";
			// 
			// priceDataGridViewTextBoxColumn
			// 
			this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
			dataGridViewCellStyle3.Format = "C2";
			dataGridViewCellStyle3.NullValue = null;
			this.priceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
			this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
			this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			// 
			// descriptorDataGridViewTextBoxColumn
			// 
			this.descriptorDataGridViewTextBoxColumn.DataPropertyName = "Descriptor";
			this.descriptorDataGridViewTextBoxColumn.HeaderText = "Descriptor";
			this.descriptorDataGridViewTextBoxColumn.Name = "descriptorDataGridViewTextBoxColumn";
			// 
			// storeItemsBindingSource
			// 
			this.storeItemsBindingSource.DataMember = "StoreItems";
			this.storeItemsBindingSource.DataSource = this.petInfoDataSet1;
			// 
			// petInfoDataSet1
			// 
			this.petInfoDataSet1.DataSetName = "PetInfoDataSet1";
			this.petInfoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// petInfoDataSetBindingSource
			// 
			this.petInfoDataSetBindingSource.DataSource = this.petInfoDataSet;
			this.petInfoDataSetBindingSource.Position = 0;
			// 
			// petInfoDataSet
			// 
			this.petInfoDataSet.DataSetName = "PetInfoDataSet";
			this.petInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// addToWSBtn
			// 
			this.addToWSBtn.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addToWSBtn.Location = new System.Drawing.Point(434, 271);
			this.addToWSBtn.Name = "addToWSBtn";
			this.addToWSBtn.Size = new System.Drawing.Size(196, 23);
			this.addToWSBtn.TabIndex = 18;
			this.addToWSBtn.Text = "Add to Wishlist";
			this.addToWSBtn.UseVisualStyleBackColor = true;
			// 
			// storeItemsTableAdapter
			// 
			this.storeItemsTableAdapter.ClearBeforeFill = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.descRadioBtn);
			this.groupBox1.Controls.Add(this.ascRadioBtn);
			this.groupBox1.Controls.Add(this.filterComboBox);
			this.groupBox1.Font = new System.Drawing.Font("Poor Richard", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 43);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(226, 179);
			this.groupBox1.TabIndex = 20;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Arrange By";
			// 
			// descRadioBtn
			// 
			this.descRadioBtn.AutoSize = true;
			this.descRadioBtn.BackColor = System.Drawing.Color.Transparent;
			this.descRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.descRadioBtn.Location = new System.Drawing.Point(21, 103);
			this.descRadioBtn.Name = "descRadioBtn";
			this.descRadioBtn.Size = new System.Drawing.Size(82, 17);
			this.descRadioBtn.TabIndex = 22;
			this.descRadioBtn.TabStop = true;
			this.descRadioBtn.Text = "Descending";
			this.descRadioBtn.UseVisualStyleBackColor = false;
			this.descRadioBtn.CheckedChanged += new System.EventHandler(this.filterRadioBtn_CheckedChanged);
			// 
			// ascRadioBtn
			// 
			this.ascRadioBtn.AutoSize = true;
			this.ascRadioBtn.BackColor = System.Drawing.Color.Transparent;
			this.ascRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ascRadioBtn.Location = new System.Drawing.Point(21, 80);
			this.ascRadioBtn.Name = "ascRadioBtn";
			this.ascRadioBtn.Size = new System.Drawing.Size(75, 17);
			this.ascRadioBtn.TabIndex = 21;
			this.ascRadioBtn.TabStop = true;
			this.ascRadioBtn.Text = "Ascending";
			this.ascRadioBtn.UseVisualStyleBackColor = false;
			this.ascRadioBtn.CheckedChanged += new System.EventHandler(this.filterRadioBtn_CheckedChanged);
			// 
			// filterComboBox
			// 
			this.filterComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.filterComboBox.FormattingEnabled = true;
			this.filterComboBox.Location = new System.Drawing.Point(21, 38);
			this.filterComboBox.Name = "filterComboBox";
			this.filterComboBox.Size = new System.Drawing.Size(121, 21);
			this.filterComboBox.TabIndex = 20;
			this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterRadioBtn_CheckedChanged);
			// 
			// databaseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(703, 299);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.addToWSBtn);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "databaseForm";
			this.Text = "databaseForm";
			this.Load += new System.EventHandler(this.databaseForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.storeItemsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.petInfoDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.petInfoDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.petInfoDataSet)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToWishlistToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource petInfoDataSetBindingSource;
        private PetInfoDataSet petInfoDataSet;
        private System.Windows.Forms.Button addToWSBtn;
		private PetInfoDataSet1 petInfoDataSet1;
		private System.Windows.Forms.BindingSource storeItemsBindingSource;
		private PetInfoDataSet1TableAdapters.StoreItemsTableAdapter storeItemsTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn descriptorDataGridViewTextBoxColumn;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton descRadioBtn;
		private System.Windows.Forms.RadioButton ascRadioBtn;
		private System.Windows.Forms.ComboBox filterComboBox;
	}
}