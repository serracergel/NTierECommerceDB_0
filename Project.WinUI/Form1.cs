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
            //if (lstProducts.SelectedIndex > -1)
            //{
            //    txtProductName.Text = secilen.ProductName;
            //    txtUnitPrice.Text = secilen.UnitPrice.ToString();
            //}
        }

        Product secilen;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            secilen = lstProducts.SelectedItem as Product;
            //algilamiyo ve once secim yapiniz hataasi aliyoruz
            if (lstProducts.SelectedIndex<-1)
            {
                
                _pRep.Destroy(secilen);
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
                if (rdDessert1.Checked == true || rdDessert2.Checked == true)
                {
                    Product p = new Product
                    {
                        ProductName = txtProductName.Text,
                        UnitPrice = Convert.ToDecimal(txtUnitPrice.Text)//Format exception
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

            if//update metodunda nullreference aliyorum    
            {
                Product p = new Product();
                p.ProductName = txtProductName.Text;
                p.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);

                _pRep.Update(p);
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
