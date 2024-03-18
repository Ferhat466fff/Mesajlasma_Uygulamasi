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

namespace Mesaj
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string numaraa;
        SqlConnection baglanti = new SqlConnection("Data Source=Monster;Initial Catalog=Mesajlar;Integrated Security=True");

        void gelenkutusu()
        {   //Gelen Kutusu 

            SqlCommand komut = new SqlCommand("select k.AD+''+k.SOYAD,k.AD,t.BASLIK,t.ICERIK from TBLMESAJLAR t\r\nINNER JOIN TBL_KISILER k ON t.MESAJID=k.ID  where ALICI=" + numaraa, baglanti);//girilen numaranın karsılıgındaki mesajlar gelsin
            //ınner joın ıle listeledim numaraya gore ad-soyad-baslık vs gelmis oldu
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void gidennkutusu()
        {   //Gelen Kutusu 

            SqlCommand komut2 = new SqlCommand("select k.AD+''+k.SOYAD,k.AD,t.BASLIK,t.ICERIK from TBLMESAJLAR t\r\nINNER JOIN TBL_KISILER k ON t.MESAJID=k.ID where GÖNDEREN=" + numaraa, baglanti);//girilen numaranın karsılıgındaki mesajlar gelsin
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }

        private void Form2_Load(object sender, EventArgs e)
        {   //Label numara cekme 
            lbl_NUMARA.Text = numaraa;

            gelenkutusu();
            gidennkutusu();


            //Ad-Soyad Çekme(Numaraya göre)
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select AD,SOYAD from TBL_KISILER where NUMARA=" + numaraa, baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {//dr[0}ad dr[1]soyad
                lbl_ad_soyad.Text = dr[0].ToString() + " "+dr[1].ToString();
            }
            baglanti.Close();




        }

        private void btn_GÖNDER_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO TBLMESAJLAR (GÖNDEREN,ALICI,BASLIK,ICERIK)VALUES (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", numaraa);
            komut.Parameters.AddWithValue("@p2", msk_ALICI.Text);
            komut.Parameters.AddWithValue("@p3", txt_BAŞLIK.Text);
            komut.Parameters.AddWithValue("@p4", rhc_MESAJ.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Mesajınız İletildi ");
            gidennkutusu();
        }
    }
}
