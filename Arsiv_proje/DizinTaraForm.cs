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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Arsiv_proje
{
    public partial class DizinTaraForm : Form
    {
        public DizinTaraForm()
        {
            InitializeComponent();
        }


        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RCC06P7;Initial Catalog=Arsiv_proje;Integrated Security=True");



        private void Form5_Load(object sender, EventArgs e)
        {
            
            conn.ConnectionString = "Data Source=DESKTOP-RCC06P7;Initial Catalog=Arsiv_proje;Integrated Security=True";
            SqlCommand cmd1 = new SqlCommand("select *from OdaTable",conn);
            SqlDataAdapter da1=new SqlDataAdapter(cmd1);
            DataTable dt1=new DataTable();
            da1.Fill(dt1);
            cb_oda.DisplayMember = "OAd";
            cb_oda.ValueMember = "OId";
            cb_oda.DataSource = dt1;
            cb_bol.Enabled = false;
            cb_raf.Enabled = false;
            cb_kla.Enabled = false;
            cb_do.Enabled = false;
            cb_evrk.Enabled = false;
            
            
        }

        private void cb_oda_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_bol.Enabled = true;
            SqlCommand cmd = new SqlCommand("select * from BolumTable where OId="+ cb_oda.SelectedValue, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_bol.DisplayMember = "BlmAd";
            cb_bol.ValueMember = "BlmId";
            cb_bol.DataSource = dt;
        }

        private void cb_bol_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_raf.Enabled = true;
            SqlCommand cmd = new SqlCommand("select * from RafTable where BlmId=" + cb_bol.SelectedValue.ToString(), conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_raf.DisplayMember = "RafAd";
            cb_raf.ValueMember = "RafId";
            cb_raf.DataSource = dt;
        }
        private void cb_raf_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_kla.Enabled = true;
            SqlCommand cmd = new SqlCommand("select * from KlasorTable where RafId=" + cb_raf.SelectedValue.ToString(), conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_kla.DisplayMember = "KlsAd";
            cb_kla.ValueMember = "KlsId";
            cb_kla.DataSource = dt;
        }

        private void cb_kla_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_do.Enabled = true;
            SqlCommand cmd = new SqlCommand("select * from DosyaTable where KlsId=" + cb_raf.SelectedValue.ToString(), conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_do.DisplayMember = "DsyAd";
            cb_do.ValueMember = "DsyId";
            cb_do.DataSource = dt;
        }

        private void cb_do_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_evrk.Enabled = true;
            SqlCommand cmd = new SqlCommand("select * from EvrakTable where DsyId=" + cb_do.SelectedValue.ToString(), conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_evrk.DisplayMember = "EvrkAd";
            cb_evrk.ValueMember = "EvrkId";
            cb_evrk.DataSource = dt;
        }

        private void btn_yazdir_Click(object sender, EventArgs e)
        {
            lbl_acik.Text = ("Evrak için erişim kodunuz: "+ cb_oda.Text + cb_bol.Text + cb_raf.Text + cb_kla.Text + cb_do.Text + cb_evrk.Text);
        }
    }
}
