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
    public partial class LoginForm : Form
    {
        public static SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RCC06P7;Initial Catalog=Arsiv_proje;Integrated Security=True");

        public LoginForm()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            GirisForm fo2 = new GirisForm();
            fo2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KayitForm fo4=new KayitForm();
            fo4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hizmet sağlayıcınızı arayınız.\n \t0(850)1234567");
        }
    }
}
