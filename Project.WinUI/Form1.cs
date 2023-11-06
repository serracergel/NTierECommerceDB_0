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
using Project.BLL.Patterns.SingletonPattern;

namespace Project.WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _cRep = new CategoryRepository();
            _pRep = new ProductRepository();

            
        }
        CategoryRepository _cRep;
        ProductRepository _pRep;

        
       


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
        //private void ListProducts(int id)
        //{
        //    lstProducts.DataSource = _pRep.GetProductsByCategory(id);
        //}

        private void rdDessert2_CheckedChanged(object sender, EventArgs e)
        {
            lstProducts.DataSource = _pRep.GetProductsByCategory(22);
        }

       

        private void rdDessert1_CheckedChanged(object sender, EventArgs e)
        {
            lstProducts.DataSource = _pRep.GetProductsByCategory(21);

        }
    }
}
