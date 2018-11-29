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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToWishlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fliterLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.petInfoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petInfoDataSet = new CS292_FinalProject_PetStore.PetInfoDataSet();
            this.petAccRdioBtn1 = new System.Windows.Forms.RadioButton();
            this.petAccRdioBtn2 = new System.Windows.Forms.RadioButton();
            this.petAccRdioBtn3 = new System.Windows.Forms.RadioButton();
            this.petFoodRdioBtn1 = new System.Windows.Forms.RadioButton();
            this.petFoodRdioBtn2 = new System.Windows.Forms.RadioButton();
            this.petFoodRdioBtn3 = new System.Windows.Forms.RadioButton();
            this.dogsCatsRdioBtn1 = new System.Windows.Forms.RadioButton();
            this.dogsCatsRdioBtn2 = new System.Windows.Forms.RadioButton();
            this.dogsCatsRdioBtn3 = new System.Windows.Forms.RadioButton();
            this.marineRdioBtn2 = new System.Windows.Forms.RadioButton();
            this.marineRdioBtn1 = new System.Windows.Forms.RadioButton();
            this.marineRdioBtn3 = new System.Windows.Forms.RadioButton();
            this.addToWSBtn = new System.Windows.Forms.Button();
            this.marinePanel = new System.Windows.Forms.Panel();
            this.dogsCatsPanel = new System.Windows.Forms.Panel();
            this.petFoodPanel = new System.Windows.Forms.Panel();
            this.petAccPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petInfoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petInfoDataSet)).BeginInit();
            this.marinePanel.SuspendLayout();
            this.dogsCatsPanel.SuspendLayout();
            this.petFoodPanel.SuspendLayout();
            this.petAccPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.goToWishlistToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(622, 26);
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
            // fliterLbl
            // 
            this.fliterLbl.AutoSize = true;
            this.fliterLbl.Font = new System.Drawing.Font("Poor Richard", 21F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fliterLbl.Location = new System.Drawing.Point(27, 43);
            this.fliterLbl.Name = "fliterLbl";
            this.fliterLbl.Size = new System.Drawing.Size(114, 31);
            this.fliterLbl.TabIndex = 4;
            this.fliterLbl.Text = "Filter By: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.petInfoDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(262, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(348, 222);
            this.dataGridView1.TabIndex = 5;
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
            // petAccRdioBtn1
            // 
            this.petAccRdioBtn1.AutoSize = true;
            this.petAccRdioBtn1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petAccRdioBtn1.Location = new System.Drawing.Point(18, 15);
            this.petAccRdioBtn1.Name = "petAccRdioBtn1";
            this.petAccRdioBtn1.Size = new System.Drawing.Size(168, 25);
            this.petAccRdioBtn1.TabIndex = 6;
            this.petAccRdioBtn1.TabStop = true;
            this.petAccRdioBtn1.Text = "petAccRdioBtn1";
            this.petAccRdioBtn1.UseVisualStyleBackColor = true;
            // 
            // petAccRdioBtn2
            // 
            this.petAccRdioBtn2.AutoSize = true;
            this.petAccRdioBtn2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petAccRdioBtn2.Location = new System.Drawing.Point(18, 75);
            this.petAccRdioBtn2.Name = "petAccRdioBtn2";
            this.petAccRdioBtn2.Size = new System.Drawing.Size(168, 25);
            this.petAccRdioBtn2.TabIndex = 7;
            this.petAccRdioBtn2.TabStop = true;
            this.petAccRdioBtn2.Text = "petAccRdioBtn2";
            this.petAccRdioBtn2.UseVisualStyleBackColor = true;
            // 
            // petAccRdioBtn3
            // 
            this.petAccRdioBtn3.AutoSize = true;
            this.petAccRdioBtn3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petAccRdioBtn3.Location = new System.Drawing.Point(18, 146);
            this.petAccRdioBtn3.Name = "petAccRdioBtn3";
            this.petAccRdioBtn3.Size = new System.Drawing.Size(168, 25);
            this.petAccRdioBtn3.TabIndex = 8;
            this.petAccRdioBtn3.TabStop = true;
            this.petAccRdioBtn3.Text = "petAccRdioBtn3";
            this.petAccRdioBtn3.UseVisualStyleBackColor = true;
            // 
            // petFoodRdioBtn1
            // 
            this.petFoodRdioBtn1.AutoSize = true;
            this.petFoodRdioBtn1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petFoodRdioBtn1.Location = new System.Drawing.Point(18, 15);
            this.petFoodRdioBtn1.Name = "petFoodRdioBtn1";
            this.petFoodRdioBtn1.Size = new System.Drawing.Size(179, 25);
            this.petFoodRdioBtn1.TabIndex = 9;
            this.petFoodRdioBtn1.TabStop = true;
            this.petFoodRdioBtn1.Text = "petFoodRdioBtn1";
            this.petFoodRdioBtn1.UseVisualStyleBackColor = true;
            // 
            // petFoodRdioBtn2
            // 
            this.petFoodRdioBtn2.AutoSize = true;
            this.petFoodRdioBtn2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petFoodRdioBtn2.Location = new System.Drawing.Point(18, 75);
            this.petFoodRdioBtn2.Name = "petFoodRdioBtn2";
            this.petFoodRdioBtn2.Size = new System.Drawing.Size(179, 25);
            this.petFoodRdioBtn2.TabIndex = 10;
            this.petFoodRdioBtn2.TabStop = true;
            this.petFoodRdioBtn2.Text = "petFoodRdioBtn2";
            this.petFoodRdioBtn2.UseVisualStyleBackColor = true;
            // 
            // petFoodRdioBtn3
            // 
            this.petFoodRdioBtn3.AutoSize = true;
            this.petFoodRdioBtn3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petFoodRdioBtn3.Location = new System.Drawing.Point(18, 146);
            this.petFoodRdioBtn3.Name = "petFoodRdioBtn3";
            this.petFoodRdioBtn3.Size = new System.Drawing.Size(179, 25);
            this.petFoodRdioBtn3.TabIndex = 11;
            this.petFoodRdioBtn3.TabStop = true;
            this.petFoodRdioBtn3.Text = "petFoodRdioBtn3";
            this.petFoodRdioBtn3.UseVisualStyleBackColor = true;
            // 
            // dogsCatsRdioBtn1
            // 
            this.dogsCatsRdioBtn1.AutoSize = true;
            this.dogsCatsRdioBtn1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogsCatsRdioBtn1.Location = new System.Drawing.Point(18, 15);
            this.dogsCatsRdioBtn1.Name = "dogsCatsRdioBtn1";
            this.dogsCatsRdioBtn1.Size = new System.Drawing.Size(189, 25);
            this.dogsCatsRdioBtn1.TabIndex = 12;
            this.dogsCatsRdioBtn1.TabStop = true;
            this.dogsCatsRdioBtn1.Text = "dogsCatsRdioBtn1";
            this.dogsCatsRdioBtn1.UseVisualStyleBackColor = true;
            // 
            // dogsCatsRdioBtn2
            // 
            this.dogsCatsRdioBtn2.AutoSize = true;
            this.dogsCatsRdioBtn2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogsCatsRdioBtn2.Location = new System.Drawing.Point(18, 75);
            this.dogsCatsRdioBtn2.Name = "dogsCatsRdioBtn2";
            this.dogsCatsRdioBtn2.Size = new System.Drawing.Size(189, 25);
            this.dogsCatsRdioBtn2.TabIndex = 13;
            this.dogsCatsRdioBtn2.TabStop = true;
            this.dogsCatsRdioBtn2.Text = "dogsCatsRdioBtn2";
            this.dogsCatsRdioBtn2.UseVisualStyleBackColor = true;
            // 
            // dogsCatsRdioBtn3
            // 
            this.dogsCatsRdioBtn3.AutoSize = true;
            this.dogsCatsRdioBtn3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogsCatsRdioBtn3.Location = new System.Drawing.Point(18, 146);
            this.dogsCatsRdioBtn3.Name = "dogsCatsRdioBtn3";
            this.dogsCatsRdioBtn3.Size = new System.Drawing.Size(189, 25);
            this.dogsCatsRdioBtn3.TabIndex = 14;
            this.dogsCatsRdioBtn3.TabStop = true;
            this.dogsCatsRdioBtn3.Text = "dogsCatsRdioBtn3";
            this.dogsCatsRdioBtn3.UseVisualStyleBackColor = true;
            // 
            // marineRdioBtn2
            // 
            this.marineRdioBtn2.AutoSize = true;
            this.marineRdioBtn2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marineRdioBtn2.Location = new System.Drawing.Point(18, 75);
            this.marineRdioBtn2.Name = "marineRdioBtn2";
            this.marineRdioBtn2.Size = new System.Drawing.Size(168, 25);
            this.marineRdioBtn2.TabIndex = 15;
            this.marineRdioBtn2.TabStop = true;
            this.marineRdioBtn2.Text = "marineRdioBtn2";
            this.marineRdioBtn2.UseVisualStyleBackColor = true;
            // 
            // marineRdioBtn1
            // 
            this.marineRdioBtn1.AutoSize = true;
            this.marineRdioBtn1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marineRdioBtn1.Location = new System.Drawing.Point(18, 15);
            this.marineRdioBtn1.Name = "marineRdioBtn1";
            this.marineRdioBtn1.Size = new System.Drawing.Size(168, 25);
            this.marineRdioBtn1.TabIndex = 16;
            this.marineRdioBtn1.TabStop = true;
            this.marineRdioBtn1.Text = "marineRdioBtn1";
            this.marineRdioBtn1.UseVisualStyleBackColor = true;
            // 
            // marineRdioBtn3
            // 
            this.marineRdioBtn3.AutoSize = true;
            this.marineRdioBtn3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marineRdioBtn3.Location = new System.Drawing.Point(18, 146);
            this.marineRdioBtn3.Name = "marineRdioBtn3";
            this.marineRdioBtn3.Size = new System.Drawing.Size(168, 25);
            this.marineRdioBtn3.TabIndex = 17;
            this.marineRdioBtn3.TabStop = true;
            this.marineRdioBtn3.Text = "marineRdioBtn3";
            this.marineRdioBtn3.UseVisualStyleBackColor = true;
            // 
            // addToWSBtn
            // 
            this.addToWSBtn.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToWSBtn.Location = new System.Drawing.Point(340, 289);
            this.addToWSBtn.Name = "addToWSBtn";
            this.addToWSBtn.Size = new System.Drawing.Size(196, 23);
            this.addToWSBtn.TabIndex = 18;
            this.addToWSBtn.Text = "Add to Wishlist";
            this.addToWSBtn.UseVisualStyleBackColor = true;
            // 
            // marinePanel
            // 
            this.marinePanel.BackColor = System.Drawing.Color.Transparent;
            this.marinePanel.Controls.Add(this.marineRdioBtn1);
            this.marinePanel.Controls.Add(this.marineRdioBtn2);
            this.marinePanel.Controls.Add(this.marineRdioBtn3);
            this.marinePanel.Location = new System.Drawing.Point(12, 72);
            this.marinePanel.Name = "marinePanel";
            this.marinePanel.Size = new System.Drawing.Size(244, 211);
            this.marinePanel.TabIndex = 19;
            // 
            // dogsCatsPanel
            // 
            this.dogsCatsPanel.BackColor = System.Drawing.Color.Transparent;
            this.dogsCatsPanel.Controls.Add(this.dogsCatsRdioBtn1);
            this.dogsCatsPanel.Controls.Add(this.dogsCatsRdioBtn2);
            this.dogsCatsPanel.Controls.Add(this.dogsCatsRdioBtn3);
            this.dogsCatsPanel.Location = new System.Drawing.Point(12, 69);
            this.dogsCatsPanel.Name = "dogsCatsPanel";
            this.dogsCatsPanel.Size = new System.Drawing.Size(244, 211);
            this.dogsCatsPanel.TabIndex = 18;
            // 
            // petFoodPanel
            // 
            this.petFoodPanel.BackColor = System.Drawing.Color.Transparent;
            this.petFoodPanel.Controls.Add(this.petFoodRdioBtn1);
            this.petFoodPanel.Controls.Add(this.petFoodRdioBtn2);
            this.petFoodPanel.Controls.Add(this.petFoodRdioBtn3);
            this.petFoodPanel.Location = new System.Drawing.Point(12, 69);
            this.petFoodPanel.Name = "petFoodPanel";
            this.petFoodPanel.Size = new System.Drawing.Size(244, 211);
            this.petFoodPanel.TabIndex = 20;
            // 
            // petAccPanel
            // 
            this.petAccPanel.BackColor = System.Drawing.Color.Transparent;
            this.petAccPanel.Controls.Add(this.petAccRdioBtn1);
            this.petAccPanel.Controls.Add(this.petAccRdioBtn2);
            this.petAccPanel.Controls.Add(this.petAccRdioBtn3);
            this.petAccPanel.Location = new System.Drawing.Point(12, 72);
            this.petAccPanel.Name = "petAccPanel";
            this.petAccPanel.Size = new System.Drawing.Size(244, 211);
            this.petAccPanel.TabIndex = 20;
            // 
            // databaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(622, 338);
            this.Controls.Add(this.petFoodPanel);
            this.Controls.Add(this.dogsCatsPanel);
            this.Controls.Add(this.petAccPanel);
            this.Controls.Add(this.marinePanel);
            this.Controls.Add(this.addToWSBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.fliterLbl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "databaseForm";
            this.Text = "databaseForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petInfoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petInfoDataSet)).EndInit();
            this.marinePanel.ResumeLayout(false);
            this.marinePanel.PerformLayout();
            this.dogsCatsPanel.ResumeLayout(false);
            this.dogsCatsPanel.PerformLayout();
            this.petFoodPanel.ResumeLayout(false);
            this.petFoodPanel.PerformLayout();
            this.petAccPanel.ResumeLayout(false);
            this.petAccPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToWishlistToolStripMenuItem;
        private System.Windows.Forms.Label fliterLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource petInfoDataSetBindingSource;
        private PetInfoDataSet petInfoDataSet;
        private System.Windows.Forms.RadioButton petAccRdioBtn1;
        private System.Windows.Forms.RadioButton petAccRdioBtn2;
        private System.Windows.Forms.RadioButton petAccRdioBtn3;
        private System.Windows.Forms.RadioButton petFoodRdioBtn1;
        private System.Windows.Forms.RadioButton petFoodRdioBtn2;
        private System.Windows.Forms.RadioButton petFoodRdioBtn3;
        private System.Windows.Forms.RadioButton dogsCatsRdioBtn1;
        private System.Windows.Forms.RadioButton dogsCatsRdioBtn2;
        private System.Windows.Forms.RadioButton dogsCatsRdioBtn3;
        private System.Windows.Forms.RadioButton marineRdioBtn2;
        private System.Windows.Forms.RadioButton marineRdioBtn1;
        private System.Windows.Forms.RadioButton marineRdioBtn3;
        private System.Windows.Forms.Button addToWSBtn;
        private System.Windows.Forms.Panel marinePanel;
        private System.Windows.Forms.Panel dogsCatsPanel;
        private System.Windows.Forms.Panel petFoodPanel;
        private System.Windows.Forms.Panel petAccPanel;
    }
}