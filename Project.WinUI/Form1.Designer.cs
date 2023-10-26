namespace Project.WinUI
{
    partial class Form1
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
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.lblCategories = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnnAddToCart = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.rdDessert1 = new System.Windows.Forms.RadioButton();
            this.rdDessert2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.Location = new System.Drawing.Point(331, 12);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(360, 212);
            this.lstProducts.TabIndex = 1;
            this.lstProducts.Click += new System.EventHandler(this.lstUrunler_Click);
            this.lstProducts.SelectedIndexChanged += new System.EventHandler(this.lstUrunler_SelectedIndexChanged);
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategories.Location = new System.Drawing.Point(36, 111);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(61, 17);
            this.lblCategories.TabIndex = 3;
            this.lblCategories.Text = "Desserts";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(377, 237);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 32);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(377, 275);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 32);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(377, 313);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 32);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnnAddToCart
            // 
            this.btnnAddToCart.Location = new System.Drawing.Point(13, 249);
            this.btnnAddToCart.Name = "btnnAddToCart";
            this.btnnAddToCart.Size = new System.Drawing.Size(134, 32);
            this.btnnAddToCart.TabIndex = 4;
            this.btnnAddToCart.Text = "Add To Cart";
            this.btnnAddToCart.UseVisualStyleBackColor = true;
            this.btnnAddToCart.Click += new System.EventHandler(this.BtnSepeteEkle_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(251, 261);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductName.TabIndex = 6;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(251, 313);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtUnitPrice.TabIndex = 6;
            // 
            // rdDessert1
            // 
            this.rdDessert1.AutoSize = true;
            this.rdDessert1.Location = new System.Drawing.Point(39, 146);
            this.rdDessert1.Name = "rdDessert1";
            this.rdDessert1.Size = new System.Drawing.Size(91, 17);
            this.rdDessert1.TabIndex = 7;
            this.rdDessert1.TabStop = true;
            this.rdDessert1.Text = "Milk Puddings";
            this.rdDessert1.UseVisualStyleBackColor = true;
            this.rdDessert1.Click += new System.EventHandler(this.rdDessert1_Click);
            // 
            // rdDessert2
            // 
            this.rdDessert2.AutoSize = true;
            this.rdDessert2.Location = new System.Drawing.Point(39, 183);
            this.rdDessert2.Name = "rdDessert2";
            this.rdDessert2.Size = new System.Drawing.Size(108, 17);
            this.rdDessert2.TabIndex = 8;
            this.rdDessert2.TabStop = true;
            this.rdDessert2.Text = "Siruped Puddings";
            this.rdDessert2.UseVisualStyleBackColor = true;
            this.rdDessert2.Click += new System.EventHandler(this.rdDessert2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(726, 397);
            this.Controls.Add(this.rdDessert2);
            this.Controls.Add(this.rdDessert1);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnnAddToCart);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.lstProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnnAddToCart;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.RadioButton rdDessert1;
        private System.Windows.Forms.RadioButton rdDessert2;
    }
}

