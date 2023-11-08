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
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.rdDessert1 = new System.Windows.Forms.RadioButton();
            this.rdDessert2 = new System.Windows.Forms.RadioButton();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 16;
            this.lstProducts.Location = new System.Drawing.Point(441, 15);
            this.lstProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(479, 260);
            this.lstProducts.TabIndex = 1;
            this.lstProducts.Click += new System.EventHandler(this.lstUrunler_Click);
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategories.Location = new System.Drawing.Point(48, 137);
            this.lblCategories.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(79, 22);
            this.lblCategories.TabIndex = 3;
            this.lblCategories.Text = "Desserts";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(503, 292);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 39);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(503, 338);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 39);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(503, 385);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 39);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(335, 321);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(132, 22);
            this.txtProductName.TabIndex = 6;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(335, 385);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(132, 22);
            this.txtUnitPrice.TabIndex = 6;
            // 
            // rdDessert1
            // 
            this.rdDessert1.AutoSize = true;
            this.rdDessert1.Location = new System.Drawing.Point(16, 183);
            this.rdDessert1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdDessert1.Name = "rdDessert1";
            this.rdDessert1.Size = new System.Drawing.Size(112, 20);
            this.rdDessert1.TabIndex = 7;
            this.rdDessert1.TabStop = true;
            this.rdDessert1.Text = "Milk Puddings";
            this.rdDessert1.UseVisualStyleBackColor = true;
            // 
            // rdDessert2
            // 
            this.rdDessert2.AutoSize = true;
            this.rdDessert2.Location = new System.Drawing.Point(16, 234);
            this.rdDessert2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdDessert2.Name = "rdDessert2";
            this.rdDessert2.Size = new System.Drawing.Size(135, 20);
            this.rdDessert2.TabIndex = 8;
            this.rdDessert2.TabStop = true;
            this.rdDessert2.Text = "Siruped Puddings";
            this.rdDessert2.UseVisualStyleBackColor = true;
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(30, 110);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(121, 24);
            this.cmbCategories.TabIndex = 9;
            this.cmbCategories.Click += new System.EventHandler(this.cmbCategories_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(968, 489);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.rdDessert2);
            this.Controls.Add(this.rdDessert1);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.lstProducts);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.RadioButton rdDessert1;
        private System.Windows.Forms.RadioButton rdDessert2;
        private System.Windows.Forms.ComboBox cmbCategories;
    }
}

