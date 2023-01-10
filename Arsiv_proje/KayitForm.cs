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


namespace Arsiv_proje
{
    public partial class KayitForm : Form
    {
        public KayitForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RCC06P7;Initial Catalog=Arsiv_proje;Integrated Security=True");
        string cinsiyet;
        string perm = "3";

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool onay=false;
            if (rb_erk.Checked == true)
            {
                cinsiyet = "Erkek";
                onay= true;
            }
            else if (rb_kdn.Checked == true)
            {
                cinsiyet = "Kadın";
                onay = true;
            }
            else
            {
                MessageBox.Show("Cinsiyet Seçimi Yapınız.");
                onay = false;
            }
            if (txt_pass.Text == txt_passche.Text)
            {onay = true;}
            else
            { onay = false;
                MessageBox.Show("Şifreler Eşleşmiyor.");
            }

            if (onay == true)
            {
                conn.Open();
                SqlCommand ekle = new SqlCommand("insert into UserTable(UserNick,UserName,UserSurname,UserPass,UserMail,UserBirth,UserGender,UserOuther) values(@u1,@u2,@u3,@u4,@u5,@u6,@u7,@u8)", conn);
                ekle.Parameters.AddWithValue("@u1", txt_nick.Text);
                ekle.Parameters.AddWithValue("@u2", txt_name.Text);
                ekle.Parameters.AddWithValue("@u3", txt_surname.Text);
                ekle.Parameters.AddWithValue("@u4", txt_pass.Text);
                ekle.Parameters.AddWithValue("@u5", txt_mail.Text);
                ekle.Parameters.AddWithValue("@u6", datp.Text);
                ekle.Parameters.AddWithValue("@u7", cinsiyet.ToString());
                ekle.Parameters.AddWithValue("@u8", Convert.ToInt32(perm));
                ekle.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Sayın " + txt_name.Text.ToString() + " " + txt_surname.Text.ToString() + " " + "kaydınız alınmıştır.");
            }
            else
                MessageBox.Show("Kayıt Tamamlanamadı");


        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
