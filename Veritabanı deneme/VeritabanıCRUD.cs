using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Veritabanı_deneme
{
    public class VeritabanıCRUD
    {
        //private readonly DataGridView dataGridView1;

        public SQLiteCommand SQLiteCommand { get; private set; }

        public int RegisterUser(Userdef p)
        {
            using (SQLiteConnection connection = new SQLiteConnection(VeritabanıConnection.connect))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand("INSERT INTO Tablo1 (name, lastname, birthday, email, [password], age) VALUES (@Name, @LastName, @Birthday, @Email, @Password, @Age)", connection))
                {
                    command.Parameters.AddWithValue("@Name", p.Name);
                    command.Parameters.AddWithValue("@LastName", p.LastName);
                    command.Parameters.AddWithValue("@Birthday", p.Birthday);
                    command.Parameters.AddWithValue("@Email", p.Email);
                    command.Parameters.AddWithValue("@Password", p.Password);
                    command.Parameters.AddWithValue("@Age", p.Age);

                    return command.ExecuteNonQuery();
                }
            }
        }
        public DataSet VeritabanıList()
        {
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM tablo1", VeritabanıConnection.connect);
            DataSet veriSeti = new DataSet();
            adapter.Fill(veriSeti, "tablo1");
            return veriSeti;
        }
        public bool DeleteRecordByEmail(string email)
        {
            SQLiteCommand command = new SQLiteCommand("DELETE FROM Tablo1 WHERE email = @Email", VeritabanıConnection.connect);
            command.Parameters.AddWithValue("@Email", email);

            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }

            int rowsAffected = command.ExecuteNonQuery();

            return rowsAffected > 0; ;
        }
        public bool UpdateRecord(string name, string lastname, string birthday, string password, string age, string email)
        {
            string query = " UPDATE Tablo1 SET Name = @name , LastName = @lastname , Birthday = @birthday , Password = @password , Age = @age WHERE Email = @email ";
            SQLiteCommand command = new SQLiteCommand(query, VeritabanıConnection.connect);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@lastname", lastname);
            command.Parameters.AddWithValue("@birthday", birthday);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@age", age);

            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }

            int rowsAffected = command.ExecuteNonQuery();
            command.Connection.Close();

            return rowsAffected > 0;
        }
        public static void FilterByAgeWithQuery(string ageFilter, DataGridView dataGridView)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection("Data source=.\\deneme.db;Version=3"))
                using (SQLiteCommand command = connection.CreateCommand())
                {
                    connection.Open();

                    command.CommandText = "SELECT * FROM Tablo1 WHERE age > @AgeFilter";
                    command.Parameters.AddWithValue("@AgeFilter", ageFilter);

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


    }


}
