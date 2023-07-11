using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Xml.Linq;
using Veritabanı_deneme;
using System.Data.SQLite;

namespace Veritabanı_Deneme
{
    public partial class Form2 : Form
    {
        private readonly OleDbConnection _connection;

        public object HashPasswordtbpassword { get; private set; }

        public Form2()
        {
            InitializeComponent();
            _connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb");
        }

        private string HashPassword(string password)
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

        public void button1_Click(object sender, EventArgs e)
        {

            string ad = tbname.Text;
            string soyad = tblastname.Text;
            string birthday = tbbirthday.Text;
            string email = tbemail.Text;
            string password = HashPassword(tbpassword.Text);
            string age = tbage.Text;
            
            


            
            Userdef kullanici = new Userdef();
            kullanici.Name = ad;
            kullanici.LastName = soyad;
            kullanici.Birthday = birthday;
            kullanici.Email = email;
            kullanici.Password = password;
            kullanici.Age = age;
            

            VeritabanıCRUD op = new VeritabanıCRUD();
            int etkilenenSatirSayisi = op.RegisterUser(kullanici);
            

            if (etkilenenSatirSayisi > 0)
            {
                MessageBox.Show("Kayıt başarıyla eklendi.");

            }
            else
            {
                MessageBox.Show("Kayıt eklenirken bir hata oluştu.");
            }


            if (IsInputValid())
            {
               if (IsEmailAlreadyRegistered(tbemail.Text))
               {
                 MessageBox.Show("Bu e-posta adresi zaten kayıtlı!");                  
                    return;
               }              
            }
           else
            {
               MessageBox.Show("Boş alanları doldurunuz!");
            }
            string encryptedPassword = HashPassword(tbpassword.Text);



            ClearInputFields();
        }

        private bool IsInputValid()
        {
            return !string.IsNullOrWhiteSpace(tbname.Text) &&
                   !string.IsNullOrWhiteSpace(tblastname.Text) &&
                   !string.IsNullOrWhiteSpace(tbbirthday.Text) &&
                   !string.IsNullOrWhiteSpace(tbemail.Text) &&
                   !string.IsNullOrWhiteSpace(tbpassword.Text) &&
                   !string.IsNullOrWhiteSpace(tbage.Text);
        }

        private bool IsEmailAlreadyRegistered(string email)
        {
            _connection.Open();

            string query = "SELECT COUNT(*) FROM Tablo1 WHERE email = @Email";
            using (OleDbCommand command = new OleDbCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@Email", email);
                int count = (int)command.ExecuteScalar();

                _connection.Close();

                return count > 1;
            }
        }
        private void ClearInputFields()
        {
            tbname.Text = string.Empty;
            tblastname.Text = string.Empty;
            tbbirthday.Text = string.Empty;
            tbemail.Text = string.Empty;
            tbpassword.Text = string.Empty;
            tbage.Text = string.Empty;
        }

        private void tbpassword_TextChanged(object sender, EventArgs e)
        {
            tbpassword.PasswordChar = '*';
        }

    }
}