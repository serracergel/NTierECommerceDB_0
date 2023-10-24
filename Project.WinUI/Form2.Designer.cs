namespace Project.WinUI
{
    partial class Form2
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
            this.LstSiparisler = new System.Windows.Forms.ListBox();
            this.BtnSepet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstSiparisler
            // 
            this.LstSiparisler.FormattingEnabled = true;
            this.LstSiparisler.Location = new System.Drawing.Point(38, 35);
            this.LstSiparisler.Name = "LstSiparisler";
            this.LstSiparisler.Size = new System.Drawing.Size(323, 186);
            this.LstSiparisler.TabIndex = 0;
            // 
            // BtnSepet
            // 
            this.BtnSepet.Location = new System.Drawing.Point(244, 266);
            this.BtnSepet.Name = "BtnSepet";
            this.BtnSepet.Size = new System.Drawing.Size(117, 29);
            this.BtnSepet.TabIndex = 1;
            this.BtnSepet.Text = "Sepeti Onayla";
            this.BtnSepet.UseVisualStyleBackColor = true;
            this.BtnSepet.Click += new System.EventHandler(this.BtnSepet_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(411, 339);
            this.Controls.Add(this.BtnSepet);
            this.Controls.Add(this.LstSiparisler);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstSiparisler;
        private System.Windows.Forms.Button BtnSepet;
    }
}