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
            //tikladigim urunun ismi ve fiyati textboxlarda gozuksun
            if (lstProducts.SelectedIndex > -1)
            {
                secilen = lstProducts.SelectedItem as Product;
                txtProductName.Text = secilen.ProductName;
                txtUnitPrice.Text = secilen.UnitPrice.ToString();
            }
        }

        Product secilen;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            //algilamiyo ve once secim yapiniz hataasi aliyoruz
            if (lstProducts.SelectedIndex<-1)
            {
                
                _pRep.Destroy(secilen);
                secilen = null;
                lstProducts.Items.Remove(secilen);
              
            }
            else
            {
                MessageBox.Show("Lutfen once secim yapiniz");
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //textboxa yazılan ürünleri listboxa ekleme
            try
            {
                if (cmbCategories.SelectedItem != null)
                {
                    Product p = new Product
                    {
                        ProductName = txtProductName.Text,
                        UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),//Format exception
                        CategoryID = (cmbCategories.SelectedItem as Category).ID
                        //categoryid'si olmasi gerkimiyo mu
                        //cateogryid'si radibutonda secilen kategorinin id'si nasil dice
                        //secilen radiobutton diyemiyoruz
                        //CategoryID = (rdDessert1 as Category).ID;
                    };


                    _pRep.Add(p);
                    lstProducts.DataSource = _pRep.GetActives();
                }
                else
                {
                    MessageBox.Show("Lutfen once kategori seciniz");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
           
            

        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if(secilen != null)   
            {
                Product p = new Product();
                p.ProductName = txtProductName.Text;
                p.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);

                _pRep.Update(p);
                secilen = null;
                lstProducts.DataSource = _pRep.GetActives();
            }
            else 
            {
                MessageBox.Show("Güncellemek için bir seçim yapınız");

            }

        }



        //private void ListProducts(int id)
        //{
        //    lstProducts.DataSource = _pRep.GetProductsByCategory(id);
        //}




        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCategories.DataSource = _cRep.GetActives();
            cmbCategories.ValueMember = "ID";

        }

        int id;
        private void cmbCategories_Click(object sender, EventArgs e)
        {
            if (cmbCategories.SelectedIndex >-1) 
            {
                id=Convert.ToInt32( cmbCategories.SelectedValue);
               lstProducts.DataSource= _pRep.Where(x=>x.CategoryID==id).ToList();
            }
        }
    }
}
