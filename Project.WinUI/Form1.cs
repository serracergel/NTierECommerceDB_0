using Project.BLL.Patterns.GenericRepository.EFConcRep;
using Project.BLL.Patterns.GenericRepository.EFBaseRep;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.ENTITIES.Models;

namespace Project.WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _cRep = new CategoryRepository();
        }
        CategoryRepository _cRep;
        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category c = new Category
            { 
              Title="Tatlilar"
            };
            _cRep.Add(c);
            Category altKategori = new Category
            {
                CategoryID = c.CategoryID,

            };
            altKategori.Title = "Serbetli Tatlilar";
            _cRep.Add(altKategori);
            
        }

        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKategoriler.SelectedItem != null) lblAltKategori.Text = (cmbKategoriler.SelectedItem as Product).ProductName;
            else lblAltKategori.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>
            {
                new Product{ProductName = "Fıstıklı Baklava",UnitPrice = 200},
                new Product{ProductName = "Cevizli Baklava",UnitPrice = 150},
                new Product{ProductName = "Midye Baklava",UnitPrice = 170},
                new Product{ProductName = "Şöbiyet ",UnitPrice = 175},
                new Product{ProductName = "Kuru Baklava",UnitPrice = 250},
                new Product{ProductName = "Sütlü Nuriye",UnitPrice = 155},
                new Product{ProductName = "Soguk Baklava",UnitPrice = 300},
            };
            cmbKategoriler.DataSource = products;
        }

        private void BtnSepeteEkle_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(lstUrunler.Items);
            f2.ShowDialog();
        }

        private void lstUrunler_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedIndex > -1)
            {
                lblAltKategori.Text = (lstUrunler.SelectedItem as Product).ProductName;
            }
        }
    }
}
