namespace CS292_FinalProject_PetStore
{
    partial class frmPetInc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPetAccessories = new System.Windows.Forms.Button();
            this.btnPetFood = new System.Windows.Forms.Button();
            this.btnDogsCats = new System.Windows.Forms.Button();
            this.btnMarineLife = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.btnMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuWishlist = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to our new tablet application!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "To get started, click one of the following buttons:";
            // 
            // btnPetAccessories
            // 
            this.btnPetAccessories.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPetAccessories.Location = new System.Drawing.Point(25, 196);
            this.btnPetAccessories.Name = "btnPetAccessories";
            this.btnPetAccessories.Size = new System.Drawing.Size(217, 99);
            this.btnPetAccessories.TabIndex = 2;
            this.btnPetAccessories.Text = "Pet Accessories";
            this.btnPetAccessories.UseVisualStyleBackColor = true;
            this.btnPetAccessories.Click += new System.EventHandler(this.btnPetAccessories_Click);
            // 
            // btnPetFood
            // 
            this.btnPetFood.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPetFood.Location = new System.Drawing.Point(248, 196);
            this.btnPetFood.Name = "btnPetFood";
            this.btnPetFood.Size = new System.Drawing.Size(215, 99);
            this.btnPetFood.TabIndex = 3;
            this.btnPetFood.Text = "Pet Food";
            this.btnPetFood.UseVisualStyleBackColor = true;
            this.btnPetFood.Click += new System.EventHandler(this.btnPetFood_Click);
            // 
            // btnDogsCats
            // 
            this.btnDogsCats.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDogsCats.Location = new System.Drawing.Point(25, 301);
            this.btnDogsCats.Name = "btnDogsCats";
            this.btnDogsCats.Size = new System.Drawing.Size(217, 99);
            this.btnDogsCats.TabIndex = 4;
            this.btnDogsCats.Text = "Dogs && Cats";
            this.btnDogsCats.UseVisualStyleBackColor = true;
            this.btnDogsCats.Click += new System.EventHandler(this.btnDogsCats_Click);
            // 
            // btnMarineLife
            // 
            this.btnMarineLife.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarineLife.Location = new System.Drawing.Point(248, 301);
            this.btnMarineLife.Name = "btnMarineLife";
            this.btnMarineLife.Size = new System.Drawing.Size(215, 99);
            this.btnMarineLife.TabIndex = 5;
            this.btnMarineLife.Text = "Marine Life";
            this.btnMarineLife.UseVisualStyleBackColor = true;
            this.btnMarineLife.Click += new System.EventHandler(this.btnMarineLife_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(455, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "SALE! 40% OFF ON ALL DOG FOOD!";
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuExit,
            this.btnMenuWishlist});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(494, 26);
            this.menuStripMain.TabIndex = 7;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // btnMenuExit
            // 
            this.btnMenuExit.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuExit.Name = "btnMenuExit";
            this.btnMenuExit.Size = new System.Drawing.Size(48, 22);
            this.btnMenuExit.Text = "Exit";
            this.btnMenuExit.Click += new System.EventHandler(this.btnMenuExit_Click);
            // 
            // btnMenuWishlist
            // 
            this.btnMenuWishlist.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuWishlist.Name = "btnMenuWishlist";
            this.btnMenuWishlist.Size = new System.Drawing.Size(124, 22);
            this.btnMenuWishlist.Text = "Go to Wishlist";
            this.btnMenuWishlist.Click += new System.EventHandler(this.btnMenuWishlist_Click);
            // 
            // frmPetInc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(494, 414);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMarineLife);
            this.Controls.Add(this.btnDogsCats);
            this.Controls.Add(this.btnPetFood);
            this.Controls.Add(this.btnPetAccessories);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "frmPetInc";
            this.Text = "Pet Inc.";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPetAccessories;
        private System.Windows.Forms.Button btnPetFood;
        private System.Windows.Forms.Button btnDogsCats;
        private System.Windows.Forms.Button btnMarineLife;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem btnMenuExit;
        private System.Windows.Forms.ToolStripMenuItem btnMenuWishlist;
    }
}

