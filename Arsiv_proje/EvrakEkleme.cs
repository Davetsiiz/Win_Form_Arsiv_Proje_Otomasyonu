using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arsiv_proje
{
    public partial class EvrakEkleme : Form
    {
        public EvrakEkleme()
        {
            InitializeComponent();
        }
        int sec;
        //public string val;
        //public string eval;
        //public string date;
        private void cb_oda_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(cb_oda.SelectedValue.ToString(), out val);
            string cmd = "Select BlmId,BlmAd from BolumTable where OId =" + val;
            cb_bol.DataSource = ListData.Conne(cmd);
            cb_bol.ValueMember = "BlmId";
            cb_bol.DisplayMember = "BlmAd";
        }

        private void cb_bol_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(cb_bol.SelectedValue.ToString(), out val);
            string cmd = "Select RafId,RafAd from RafTable where BlmId =" + val;
            cb_raf.DataSource = ListData.Conne(cmd);
            cb_raf.ValueMember = "RafId";
            cb_raf.DisplayMember = "RafAd";
        }

        private void cb_raf_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(cb_raf.SelectedValue.ToString(), out val);
            string cmd = "Select KlsId,KlsAd from KlasorTable where RafId =" + val;
            cb_kla.DataSource = ListData.Conne(cmd);
            cb_kla.ValueMember = "KlsId";
            cb_kla.DisplayMember = "KlsAd";
        }

        private void cb_kla_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(cb_kla.SelectedValue.ToString(), out val);
            string cmd = "Select DsyId,DsyAd from DosyaTable where KlsId =" + val;
            cb_do.DataSource = ListData.Conne(cmd);
            cb_do.ValueMember = "DsyId";
            cb_do.DisplayMember = "DsyAd";
        }

        private void cb_do_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_yazdir_Click(object sender, EventArgs e)
        {

            string val;
            string eval;
            string date;
            if (txt_evrkno != null)
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

                val = txt_evrkno.Text;
                eval = cb_do.SelectedValue.ToString();
                date = dateTimePicker1.Text;
                Dataconn.conn.Open();
                SqlCommand cmd = new SqlCommand("insert into EvrakTable(EvrkAd,EvrkTar,GelGidEvrkId,DsyId) values (@v1,@v2,@v3,@v4)", Dataconn.conn);
                cmd.Parameters.AddWithValue("@v1", txt_evrkno.Text);
                cmd.Parameters.AddWithValue("@v2", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@v3", sec);
                cmd.Parameters.AddWithValue("@v4", cb_do.SelectedValue.ToString());
                cmd.ExecuteNonQuery();
                dataGridView1.DataSource = ListData.Conne("select OdaTable.OAd,BolumTable.BlmAd,RafTable.BlmId,KlasorTable.KlsAd,DosyaTable.DsyAd,EvrakTable.EvrkAd,EvrakTable.EvrkTar,GelGidEvrkTable.GelGidEvrakAd from OdaTable inner join BolumTable on OdaTable.OID=BolumTable.OId inner join RafTable on BolumTable.BlmId=RafTable.BlmId inner join KlasorTable on RafTable.RafId=KlasorTable.RafId inner join DosyaTable on KlasorTable.KlsId=DosyaTable.KlsId inner join EvrakTable on DosyaTable.DsyId=EvrakTable.DsyId inner join GelGidEvrkTable on EvrakTable.GelGidEvrkId=GelGidEvrkTable.GelGidEvrkId where EvrkAD='" + val + "'");
                Dataconn.conn.Close();

            }
            else
                MessageBox.Show("Evrak No Giriniz..");
        }

        private void EvrakEkleme_Load(object sender, EventArgs e)
        {

            Dataconn.conn.ConnectionString = "Data Source=DESKTOP-RCC06P7;Initial Catalog=Arsiv_proje;Integrated Security=True";
            cb_oda.DataSource = ListData.Conne("select OAd,OId from OdaTable");
            cb_oda.DisplayMember = "OAd";
            cb_oda.ValueMember = "OId";
        }
    }
}
