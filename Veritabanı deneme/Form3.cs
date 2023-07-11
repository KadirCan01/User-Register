using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.SQLite;

namespace Veritabanı_deneme
{
    public partial class Form3 : Form
    {
        private readonly SQLiteConnection baglanti;
        //private OleDbDataAdapter adapter;
        private readonly DataTable dataTable;

        public Form3()
        {
            InitializeComponent();
            baglanti = new SQLiteConnection("Data source =.\\deneme.db;Versiyon=3");
            dataTable = new DataTable();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            VeritabanıCRUD op = new VeritabanıCRUD();
            DataSet veriSeti = op.VeritabanıList();
            dataGridView1.DataSource = veriSeti.Tables["tablo1"];
        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                txbname.Text = selectedRow.Cells["name"].Value.ToString();
                txblastname.Text = selectedRow.Cells["lastname"].Value.ToString();
                txbbirthday.Text = selectedRow.Cells["birthday"].Value.ToString();
                txbemail.Text = selectedRow.Cells["email"].Value.ToString();
                txbpassword.Text = selectedRow.Cells["password"].Value.ToString();
                txbage.Text = selectedRow.Cells["age"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.");
            }
        }

        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public void button4_Click(object sender, EventArgs e)
        {

            string name = txbname.Text;
            string lastname = txblastname.Text;
            string birthday = txbbirthday.Text;
            string email = txbemail.Text;
            string password = HashPassword(txbpassword.Text);
            string age = txbage.Text;


            VeritabanıCRUD veritabanıCRUD = new VeritabanıCRUD();
            bool isSuccess = veritabanıCRUD.UpdateRecord(name, lastname, birthday, password, age, email);

            if (isSuccess)
            {
                MessageBox.Show("Kayıt güncellendi.");
            }
            else
            {
                MessageBox.Show("Kayıt güncellenirken bir hata oluştu.");
            }

        }

        public void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Seçili satırı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string email = dataGridView1.SelectedRows[0].Cells["email"].Value.ToString(); 
                    VeritabanıCRUD op = new VeritabanıCRUD();
                    bool success = op.DeleteRecordByEmail(email);

                    if (success)
                    {                    
                        dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                        MessageBox.Show("Kayıt başarıyla silindi.");
                    }
                    else
                    {                      
                        MessageBox.Show("Kayıt silinirken bir hata oluştu.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.");
            }




        }



        private void button7_Click(object sender, EventArgs e)
        {
            string ageFilter = "18";
            VeritabanıCRUD.FilterByAgeWithQuery(ageFilter, dataGridView1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string userıd =txbuserıd.Text;
            string adres2 = txbadres2.Text;

            Userdef kullanıcı = new Userdef();
           
            

            kullanıcı.Adres = adres2;
            kullanıcı.UserId = userıd;

            UserAdress qw = new UserAdress();
            int etkilenenSatirSayisi = qw.UserAdressRegister(kullanıcı);
            


           
            if (etkilenenSatirSayisi > 0)
            {
                MessageBox.Show("Kayıt başarıyla eklendi.");

            }
            else
            {
                MessageBox.Show("Kayıt eklenirken bir hata oluştu.");
            }
        }



        //private void FilterByAgeWithQuery(string ageFilter)
        //{
        //    try
        //    {
        //        using (SQLiteConnection connection = new SQLiteConnection("Data source =.\\deneme.db;Versiyon=3"))
        //        using (SQLiteCommand command = connection.CreateCommand())
        //        {
        //            connection.Open();

        //            command.CommandText = "SELECT * FROM Tablo1 WHERE age > @AgeFilter";
        //            command.Parameters.AddWithValue("@AgeFilter", ageFilter);

        //            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
        //            {
        //                DataTable dataTable = new DataTable();
        //                adapter.Fill(dataTable);
        //                dataGridView1.DataSource = dataTable;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Hata: " + ex.Message);
        //    }
        //}
    }
}