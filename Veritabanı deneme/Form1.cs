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
using Veritabanı_Deneme;
using System.Security.AccessControl;

namespace Veritabanı_deneme
{


    public partial class Form1 : Form
    {
   


        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        private void OpenForm2()
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm2();


        }
        private void OpenForm3()
        {
            Form3 form3 = new Form3();

            form3.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            OpenForm3();
            
        }

        private void OpenForm4()
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenForm4();
        }
        // solid pren



    }
}

