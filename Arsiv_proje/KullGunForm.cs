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
    public partial class KullaniciGunForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RCC06P7;Initial Catalog=Arsiv_proje;Integrated Security=True");
        public KullaniciGunForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select UserName,UserSurname,UserPass,UserMail,UserBirth,UserGender from UserTable where UserNick='" + txt_ki.Text + "'", conn);
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
                txt_date.Text = dr["UserBirth"].ToString();
                if (dr["UserGender"].ToString() == "ERKEK")
                {
                    rb_erk.Checked = true;
                }
                else if (dr["UserGender"].ToString() == "KADIN")
                {
                    rb_kdn.Checked = true;
                }
            }
            conn.Close();
        }

        private void btn_gun_Click(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}
