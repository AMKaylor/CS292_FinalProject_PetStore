namespace CS292_FinalProject_PetStore
{
    partial class wishlistForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wishlistGridView = new System.Windows.Forms.DataGridView();
            this.wishListBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.petInfoDataSet21 = new CS292_FinalProject_PetStore.PetInfoDataSet2();
            this.wishListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petInfoDataSet2 = new CS292_FinalProject_PetStore.PetInfoDataSet2();
            this.wishListTableAdapter = new CS292_FinalProject_PetStore.PetInfoDataSet2TableAdapters.WishListTableAdapter();
            this.btnDelete = new System.Windows.Forms.Button();
            this.wishListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descriptor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wishlistGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wishListBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petInfoDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wishListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petInfoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wishListBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(661, 26);
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
            // wishlistGridView
            // 
            this.wishlistGridView.AllowUserToOrderColumns = true;
            this.wishlistGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wishlistGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.Price,
            this.Descriptor});
            this.wishlistGridView.Location = new System.Drawing.Point(12, 42);
            this.wishlistGridView.Name = "wishlistGridView";
            this.wishlistGridView.ReadOnly = true;
            this.wishlistGridView.Size = new System.Drawing.Size(637, 277);
            this.wishlistGridView.TabIndex = 1;
            // 
            // wishListBindingSource2
            // 
            this.wishListBindingSource2.DataMember = "WishList";
            this.wishListBindingSource2.DataSource = this.petInfoDataSet21;
            // 
            // petInfoDataSet21
            // 
            this.petInfoDataSet21.DataSetName = "PetInfoDataSet2";
            this.petInfoDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wishListBindingSource
            // 
            this.wishListBindingSource.DataMember = "WishList";
            this.wishListBindingSource.DataSource = this.petInfoDataSet2;
            // 
            // petInfoDataSet2
            // 
            this.petInfoDataSet2.DataSetName = "PetInfoDataSet2";
            this.petInfoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wishListTableAdapter
            // 
            this.wishListTableAdapter.ClearBeforeFill = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(283, 327);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 35);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete selected Item";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // wishListBindingSource1
            // 
            this.wishListBindingSource1.DataMember = "WishList";
            this.wishListBindingSource1.DataSource = this.petInfoDataSet2;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Price.DefaultCellStyle = dataGridViewCellStyle1;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Descriptor
            // 
            this.Descriptor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descriptor.HeaderText = "Descriptor";
            this.Descriptor.Name = "Descriptor";
            this.Descriptor.ReadOnly = true;
            // 
            // wishlistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(661, 374);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.wishlistGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "wishlistForm";
            this.Text = "wishlistForm";
            this.Load += new System.EventHandler(this.wishlistForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wishlistGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wishListBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petInfoDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wishListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petInfoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wishListBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.DataGridView wishlistGridView;
		private PetInfoDataSet2 petInfoDataSet2;
		private System.Windows.Forms.BindingSource wishListBindingSource;
		private PetInfoDataSet2TableAdapters.WishListTableAdapter wishListTableAdapter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.BindingSource wishListBindingSource1;
        private PetInfoDataSet2 petInfoDataSet21;
        private System.Windows.Forms.BindingSource wishListBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descriptor;
    }
}