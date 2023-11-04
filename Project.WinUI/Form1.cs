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
           
            
        }
        Category pc;
        private void Form1_Load(object sender, EventArgs e)
        {

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
            //listboxtan seçileni siler
            lstProducts.Items.Remove(lstProducts.SelectedItem);

        }

        private void rdDessert1_Click(object sender, EventArgs e)
        {
            List<Product> p = new List<Product>//kategory ıd 21
            {
               
            };
            
            lstProducts.DataSource=p;
        }
        List<Product> p2;
        private void rdDessert2_Click(object sender, EventArgs e)
        {
            List<Product> p2 = new List<Product>//kategori ıd 22 denilecek
            {
               
            };

            lstProducts.DataSource = p2;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //textboxa yazılan ürünleri listboxa ekleme
            Product p = new Product
            {
                ProductName = txtProductName.Text,
                UnitPrice = Convert.ToDecimal(txtUnitPrice.Text)
            };

            lstProducts.Items.Add(p);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            //üste yazıyor yeni veri gibi ekliyor ????
            if (lstProducts.SelectedIndex > -1)
            {
                int index = lstProducts.SelectedIndex;
                lstProducts.Items.Remove(lstProducts.SelectedItems);
                lstProducts.Items.Insert(index, txtUnitPrice.Text);
               
              
            }
            else {
                MessageBox.Show("Güncellemek için bir seçim yapınız");

            }

        }
    }
}
