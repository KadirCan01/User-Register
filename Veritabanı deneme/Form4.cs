using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Veritabanı_deneme
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void LİSTELE_Click(object sender, EventArgs e)
        {
            UserAdress ae = new UserAdress();
            DataSet veriSeti2 = ae.UserAdressList();
            dataGridView2.DataSource = veriSeti2.Tables["Tablo2"];
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                txbadres.Text = selectedRow.Cells["Adres"].Value.ToString();
               
                
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.");
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {

            string adres = txbadres.Text;
           


            UserAdress ax = new UserAdress();
            bool isSuccess = ax.UserUpdate(adres);


            if (isSuccess)
            {
                MessageBox.Show("Kayıt güncellendi.");
            }
            else
            {
                MessageBox.Show("Kayıt güncellenirken bir hata oluştu.");
            }
        }

       
    }
}
