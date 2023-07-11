using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace Veritabanı_deneme
{
    public class UserAdress
    {
        //private readonly DataGridView dataGridView2;
        public SQLiteCommand SQLiteCommand { get; private set; }
        public int UserAdressRegister(Userdef w)
        {
            using (SQLiteConnection connection = new SQLiteConnection(VeritabanıConnection.connect))
            {
                connection.Open();
                
                using (SQLiteCommand command = new SQLiteCommand("INSERT INTO Tablo2 (Adres,UserId) VALUES (@Adres,@UserId)", connection))
                {
                    command.Parameters.AddWithValue("@Adres", w.Adres);           
                    command.Parameters.AddWithValue("@UserId", w.UserId);           
                              
                    return command.ExecuteNonQuery();

                }
            }         
        }
        public DataSet UserAdressList()
        {
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT Tablo1.UserId,Tablo1.Name,Tablo1.LastName,Tablo2.Adres FROM Tablo1 FULL JOIN Tablo2 ON Tablo1.UserId=Tablo2.UserId", VeritabanıConnection.connect);
            DataSet veriSeti2 = new DataSet();
            adapter.Fill(veriSeti2, "Tablo2");
            return veriSeti2;
        }
        internal bool UserUpdate(string adres)
        {
            string query = " UPDATE Tablo2 SET Adres = @Adres WHERE Id=Id ";
            SQLiteCommand command = new SQLiteCommand(query, VeritabanıConnection.connect);
            command.Parameters.AddWithValue("@Adres", adres);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }

            int rowsAffected1 = command.ExecuteNonQuery();
            command.Connection.Close();

            return rowsAffected1 > 0;
        } 
        //public int YeniAdres(Userdef w)
        //{
        //    using (SQLiteConnection connection = new SQLiteConnection(VeritabanıConnection.connect))
        //    {
        //        connection.Open();
        //        SQLiteCommand command1 = new SQLiteCommand("INSERT INTO Tablo2(UserId) SELECT UserId FROM Tablo1;",connection);
        //        using (SQLiteCommand command = new SQLiteCommand("INSERT INTO Tablo2 (Adres) VALUES (@Adres)", connection))
        //        {
        //            command.Parameters.AddWithValue("@Adres", w.Adres);

        //            return command.ExecuteNonQuery();

        //        }
        //    }
        //}

    }
}
