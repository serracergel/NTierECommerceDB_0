﻿using Project.BLL.Patterns.GenericRepository.EFConcRep;
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
           
            
        }

        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbParentCategories.SelectedItem != null) lblChildCategories.Text = (cmbParentCategories.SelectedItem as Product).ProductName;
            //else lblChildCategories.Text = "";
        }
        Category pc;
        private void Form1_Load(object sender, EventArgs e)
        {
          
          
           
         
            //Category cc = new Category
            //{
            //    ParentCategoryID = pc.ID,
            //    Title="Serbetli Tatlilar"
            //};
         
            //_cRep.Add(cc);
            //Category cc2 = new Category
            //{
            //    ParentCategoryID = pc.ID,
            //    Title="Sutlu Tatlilar"
            
            //};
          
            //List<Product> products = new List<Product>
            //{

            //   ,
            //  
            //};
            //cmbParentCategories.DataSource = products;
        }

        private void BtnSepeteEkle_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(lstProducts.Items);
            f2.ShowDialog();
        }

        private void lstUrunler_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedIndex > -1)
            {
                //lblChildCategories.Text = (lstProducts.SelectedItem as Product).ProductName;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (cmbChildCategories.SelectedItem!=null)
            //{
            //    _cRep.Destroy(cmbChildCategories.SelectedItem as Category);
            //}
            
        }

        private void rdDessert1_Click(object sender, EventArgs e)
        {
            List<Product> p = new List<Product>
            {
                new Product{ProductName = "Sütlü Nuriye", UnitPrice = 155, },
                new Product { ProductName = "Soguk Baklava", UnitPrice = 300 }
            };
            
            lstProducts.DataSource=p;
        }
        List<Product> p2;
        private void rdDessert2_Click(object sender, EventArgs e)
        {
            List<Product> p2 = new List<Product>
            {
                new Product{ProductName = "Fıstıklı Baklava",UnitPrice = 200},
                new Product{ProductName = "Cevizli Baklava",UnitPrice = 150},
                new Product{ProductName = "Midye Baklava",UnitPrice = 170},
                new Product{ProductName = "Şöbiyet ",UnitPrice = 175},
                new Product{ProductName = "Kuru Baklava",UnitPrice = 250}
            };

            lstProducts.DataSource = p2;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          //  Product p = new Product
          //  {
          //      ProductName=txtProductName.Text,
          //      UnitPrice=Convert.ToDecimal(txtUnitPrice.Text)
          //  };
          //  p2.Add(p);
          //lstProducts.DataSource=p2 ;
        }
    }
}
