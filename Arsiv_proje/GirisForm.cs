using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Arsiv_proje
{
    public partial class GirisForm : Form
    {
       
        

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RCC06P7;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        public GirisForm()
        {
            InitializeComponent();
        }

        
        private void Form2_Enter(object sender, EventArgs e)
        {
            
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Hizmet sağlayıcınızı arayınız.\n \t0(850)1234567");
        }

        public void Form2_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            txt_pass.PasswordChar = char.Parse("*");
            checkBox1.Text = "Göster";



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_pass.PasswordChar.ToString() == "*")
            {
                txt_pass.PasswordChar = char.Parse("\0");
                checkBox1.Text = "Gizle";
            }
            else
            {
                txt_pass.PasswordChar = char.Parse("*");
                checkBox1.Text = "Göster";
            }
        }

        private void brn_giris_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM UserTable where UserNick=@uName AND UserPass=@uPass";
            conn = new SqlConnection("Data Source=DESKTOP-RCC06P7;Initial Catalog=Arsiv_proje;Integrated Security=True");
            cmd = new SqlCommand(sorgu, conn);
            cmd.Parameters.AddWithValue("@uName", txt_ka.Text);
            cmd.Parameters.AddWithValue("@uPass", txt_pass.Text);

            conn.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                Form3 fo3 = new Form3();
                fo3.Show();


            }
            else
            {
                MessageBox.Show("\tKullanıcı Adı veya Şifre Hatalı!\n" +
                    "Şifrenizi hatırlamıyorsanız, Şifremi Unuttum bölümüne gidiniz.");
            }
            conn.Close();

            KullaniciBilForm fo10 = new KullaniciBilForm();
            string KullaniciAdi = txt_ka.Text;
            fo10.kisi = KullaniciAdi;
            
        }
    }
}
