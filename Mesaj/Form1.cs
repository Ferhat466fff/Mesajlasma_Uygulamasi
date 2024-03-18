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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=Monster;Initial Catalog=Mesajlar;Integrated Security=True");

        private void btn_GİRİS_YAP_Click(object sender, EventArgs e)
        {
            //GİRİŞ YAPMA

            if (string.IsNullOrWhiteSpace(msk_NUMARA.Text) || string.IsNullOrWhiteSpace(txt_SİFRE.Text))
            {//string.boş veya boşluk bırakılmasın
                MessageBox.Show(" Kullanıcı adı veya Şifre boş Geçilemez", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("select  * from TBL_KISILER where NUMARA=@p1 and SIFRE=@p2", baglanti);
                    komut.Parameters.AddWithValue("@p1", msk_NUMARA.Text);
                    komut.Parameters.AddWithValue("@p2", txt_SİFRE.Text);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        Form2 fr = new Form2();
                        fr.numaraa = msk_NUMARA.Text;//from2ye numaraa adlı degisken tanıladık frden numarayı cektık
                        fr.Show();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Kullanıcı adı veya Şifre", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            baglanti.Close();

        }
    }
}
