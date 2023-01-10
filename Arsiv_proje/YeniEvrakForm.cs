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
    public partial class YeniEvrkForm : Form
    {
        public YeniEvrkForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RCC06P7;Initial Catalog=Arsiv_proje;Integrated Security=True");
        int sec;

        private void Form6_Load(object sender, EventArgs e)
        {

            conn.ConnectionString = "Data Source=DESKTOP-RCC06P7;Initial Catalog=Arsiv_proje;Integrated Security=True";
            SqlCommand cmd1 = new SqlCommand("select *from OdaTable", conn);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            cb_oda.DisplayMember = "OAd";
            cb_oda.ValueMember = "OId";
            cb_oda.DataSource = dt1;
            txt_bol.Enabled = false;
            txt_raf.Enabled = false;
            txt_kla.Enabled = false;
            txt_do.Enabled = false;
            txt_evrk.Enabled = false;
            dateTimePicker1.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_bol.Enabled = true;
        }
        private void txt_bol_TextChanged(object sender, EventArgs e)
        {
            txt_raf.Enabled = true;
        }
        private void txt_raf_TextChanged(object sender, EventArgs e)
        {
            txt_kla.Enabled = true;
        }

        private void txt_kla_TextChanged(object sender, EventArgs e)
        {
            txt_do.Enabled = true;
        }

        private void txt_do_TextChanged(object sender, EventArgs e)
        {
            txt_evrk.Enabled = true;
        }

        private void txt_evrk_TextChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                sec = 1;
            }
            else if (radioButton2.Checked)
            {
                sec = 2;
            }
            else
                MessageBox.Show("Evrak Tipini Seçiniz.");

            SqlCommand cmd2 = new SqlCommand("insert into BolumTable(BlmAd,OId) values(@b1,@b2)"
                + "insert into RafTable(RafAd) values(@c1)"
                + "insert into KlasorTable(KlsAd) values(@d1)"
                + "insert into DosyaTable(DsyAd) values(@e1)"
                + "insert into EvrakTable(EvrkAd,EvrkTar,GelGidEvrkId) values(@f1,@f2,@f3)", conn);
            SqlCommand cmd3 = new SqlCommand("insert into RafTable(RafAd,BlmID) values(@c1,@c2)", conn);
            SqlCommand cmd4 = new SqlCommand("insert into KlasorTable(KlsAd) values(@d1)", conn);
            SqlCommand cmd5 = new SqlCommand("insert into DosyaTable(DsyAd) values(@e1)", conn);
            SqlCommand cmd6 = new SqlCommand("insert into EvrakTable(EvrkAd,EvrkTar,GelGidEvrkId) values(@f1,@f2,@f3)", conn);
            cmd2.Parameters.AddWithValue("@b1", txt_bol.Text);
            cmd2.Parameters.AddWithValue("@b2", cb_oda.SelectedValue.ToString());
            cmd2.Parameters.AddWithValue("@c1", txt_raf.Text);
            cmd2.Parameters.AddWithValue("@d1", txt_kla.Text);
            cmd2.Parameters.AddWithValue("@e1", txt_do.Text);
            cmd2.Parameters.AddWithValue("@f1", txt_evrk.Text);
            cmd2.Parameters.AddWithValue("@f2", dateTimePicker1.Text);
            cmd2.Parameters.AddWithValue("@f3", sec);
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            cmd4.ExecuteNonQuery();
            cmd5.ExecuteNonQuery();
            cmd6.ExecuteNonQuery();
            conn.Open();
            
            SqlCommand cmd = new SqlCommand("select OdaTable.OAd,BolumTable.BlmAd,RafTable.BlmId,KlasorTable.KlsAd,DosyaTable.DsyAd,EvrakTable.EvrkAd,EvrakTable.EvrkTar,GelGidEvrkTable.GelGidEvrakAd from OdaTable inner join BolumTable on OdaTable.OID=BolumTable.OId inner join RafTable on BolumTable.BlmId=RafTable.BlmId inner join KlasorTable on RafTable.RafId=KlasorTable.RafId inner join DosyaTable on KlasorTable.KlsId=DosyaTable.KlsId inner join EvrakTable on DosyaTable.DsyId=EvrakTable.DsyId inner join GelGidEvrkTable on EvrakTable.GelGidEvrkId=GelGidEvrkTable.GelGidEvrkId",conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //cmd.ExecuteNonQuery();
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
