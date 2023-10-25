using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project.WinUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(ListBox.ObjectCollection products)
        {
            InitializeComponent();
            foreach (Product item in products)
            {
                LstSiparisler.Items.Add(item);
            }

        }
        private void BtnSepet_Click(object sender, EventArgs e)
        {
            if (LstSiparisler.SelectedIndex > -1) 
            {
                MessageBox.Show("Siparişiniz Onaylandı.");
            }
        }
    }
}
