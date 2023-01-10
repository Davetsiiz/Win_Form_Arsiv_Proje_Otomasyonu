using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arsiv_proje
{
    public partial class KullaniciBilForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RCC06P7;Initial Catalog=Arsiv_proje;Integrated Security=True");
        public KullaniciBilForm()
        {
            InitializeComponent();
        }
        public string kisi;
        private void Form10_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_gtr_Click(object sender, EventArgs e)
        {
            conn.Open();
            txt_isim.Enabled = false;
            txt_soy.Enabled = false;
            txt_sifre.Enabled = false;
            txt_mail.Enabled = false;
            txt_dogumt.Enabled = false;
            txt_cins.Enabled = false;
            SqlCommand cmd = new SqlCommand("select UserName,UserSurname,UserPass,UserMail,UserBirth,UserGender from UserTable where UserNick='" + kisi + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_isim.Text = dr["UserName"].ToString();
                txt_soy.Text = dr["UserSurname"].ToString();
                txt_sifre.Text = dr["UserPass"].ToString();
                txt_mail.Text = dr["UserMail"].ToString();
                txt_dogumt.Text = dr["UserBirth"].ToString();
                txt_cins.Text = dr["UserGender"].ToString();

            }

            conn.Close();
        }
    }
}
