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
            this.cmbKategoriler = new System.Windows.Forms.ComboBox();
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.lblKategoriler = new System.Windows.Forms.Label();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.LblAciklama = new System.Windows.Forms.Label();
            this.BtnSepeteEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(15, 69);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(121, 21);
            this.cmbKategoriler.TabIndex = 0;
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.Location = new System.Drawing.Point(377, 58);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(310, 173);
            this.lstUrunler.TabIndex = 1;
            // 
            // nmrAdet
            // 
            this.nmrAdet.Location = new System.Drawing.Point(179, 70);
            this.nmrAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(50, 20);
            this.nmrAdet.TabIndex = 2;
            this.nmrAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblKategoriler
            // 
            this.lblKategoriler.AutoSize = true;
            this.lblKategoriler.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategoriler.Location = new System.Drawing.Point(12, 44);
            this.lblKategoriler.Name = "lblKategoriler";
            this.lblKategoriler.Size = new System.Drawing.Size(78, 17);
            this.lblKategoriler.TabIndex = 3;
            this.lblKategoriler.Text = "Kategoriler";
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(377, 249);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(91, 32);
            this.BtnEkle.TabIndex = 4;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(482, 249);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(91, 32);
            this.BtnSil.TabIndex = 4;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(588, 249);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(91, 32);
            this.BtnGuncelle.TabIndex = 4;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            // 
            // LblAciklama
            // 
            this.LblAciklama.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblAciklama.Location = new System.Drawing.Point(12, 179);
            this.LblAciklama.Name = "LblAciklama";
            this.LblAciklama.Size = new System.Drawing.Size(302, 102);
            this.LblAciklama.TabIndex = 5;
            // 
            // BtnSepeteEkle
            // 
            this.BtnSepeteEkle.Location = new System.Drawing.Point(15, 325);
            this.BtnSepeteEkle.Name = "BtnSepeteEkle";
            this.BtnSepeteEkle.Size = new System.Drawing.Size(134, 32);
            this.BtnSepeteEkle.TabIndex = 4;
            this.BtnSepeteEkle.Text = "Sepete Ekle";
            this.BtnSepeteEkle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(726, 397);
            this.Controls.Add(this.LblAciklama);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnSepeteEkle);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.lblKategoriler);
            this.Controls.Add(this.nmrAdet);
            this.Controls.Add(this.lstUrunler);
            this.Controls.Add(this.cmbKategoriler);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKategoriler;
        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.NumericUpDown nmrAdet;
        private System.Windows.Forms.Label lblKategoriler;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Label LblAciklama;
        private System.Windows.Forms.Button BtnSepeteEkle;
    }
}

