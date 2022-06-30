using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KDSProje
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();


            

            
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=KDS Proje;Integrated Security=SSPI");







        int soruNo = 1;
        int skor = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            textSoruNo.Text = soruNo.ToString();
            textSkor.Text = skor.ToString();

           
            



        }

        private void textSoruNo_TextChanged(object sender, EventArgs e)
        {
            if (textSoruNo.Text == "") foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Sorular where soruID like  '" +textSoruNo.Text + "'  ", baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while(reader.Read())
            {
                
                textSoruNo.Text = reader["soruNO"].ToString();
                textSoru.Text = reader["soruTEXT"].ToString();
                

            }
            baglanti.Close();
        }

        
        private void ileriButton_Click(object sender, EventArgs e)
        {
            soruNo++;
            if(soruNo>=10)
            {
                soruNo = 10;
                skor = 10;
                cevapEvet.Enabled = false;
                cevapHayir.Enabled = false;
                
            }
            else
            {
                cevapEvet.Enabled = true;
                cevapHayir.Enabled = true;
            }
            textSoruNo.Text = soruNo.ToString();



            if (soruNo == 1 && cevapEvet.Checked == true)
            {
                skor++;
                textSkor.Text = skor.ToString();

            }

            if (soruNo == 2 && cevapEvet.Checked == true)
            {
                skor++;
                textSkor.Text = skor.ToString();

            }
            

            if (soruNo == 3 && cevapEvet.Checked == true)
            {
                skor++;
                textSkor.Text = skor.ToString();

            }

            if (soruNo == 4 && cevapEvet.Checked == true)
            {
                skor++;
                textSkor.Text = skor.ToString();

            }

            if (soruNo == 5 && cevapEvet.Checked == true)
            {
                skor++; ;
                textSkor.Text = skor.ToString();

            }

            if (soruNo == 6 && cevapEvet.Checked == true)
            {
                skor++; ;
                textSkor.Text = skor.ToString();

            }

            if (soruNo == 7 && cevapEvet.Checked == true)
            {
                skor++; ;
                textSkor.Text = skor.ToString();

            }

            if (soruNo == 8 && cevapEvet.Checked == true)
            {
                skor++; ;
                textSkor.Text = skor.ToString();

            }

            if (soruNo == 9 && cevapEvet.Checked == true)
            {
                skor++; ;
                textSkor.Text = skor.ToString();

            }

            if (soruNo == 10 && cevapEvet.Checked == true)
            {
                skor++; ;
                textSkor.Text = skor.ToString();

            }

            if(soruNo==10)
            {
                MessageBox.Show("Test bitmiştir, Sonuçlarınıza bakabilirsiniz.");
            }
            
           
            






        }

        private void geriButton_Click(object sender, EventArgs e)
        {
            soruNo--;
            skor--;
            if (soruNo <=0)
            {
                soruNo = 1;
                skor = 0;
                  

                cevapEvet.Enabled = false;
                cevapHayir.Enabled = false;
            }
            else
            {
                cevapEvet.Enabled = true;
                cevapHayir.Enabled = true;

            }
            textSoruNo.Text = soruNo.ToString();
            textSkor.Text = skor.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add("TC No: " + textTC.Text + "  Adiniz : " + textAd.Text + "  Soyadiniz: " + "  Cinsiyetiniz: " + textCinsiyet.Text);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
