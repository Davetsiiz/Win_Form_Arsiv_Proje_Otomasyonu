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
    public partial class DosDuzForm : Form
    {
        public DosDuzForm()
        {
            InitializeComponent();
        }
        string srg = "select DosyaTable.DsyId,.DosyaTable.DsyAD,DosyaTable.KlsId  from OdaTable inner join BolumTable on OdaTable.OID=BolumTable.OId inner join RafTable on bolumTable.BlmId=RafTable.RafId inner join KlasorTable on RafTable.RafId=KlasorTable.RafId inner join DosyaTable on KlasorTable.KlsId=DosyaTable.KlsId";

        private void DosDuzForm_Load(object sender, EventArgs e)
        {

            Dataconn.conn.ConnectionString = "Data Source=DESKTOP-RCC06P7;Initial Catalog=Arsiv_proje;Integrated Security=True";
            cb_oda.DataSource = ListData.Conne("select OAd,OId from OdaTable");
            cb_oda.DisplayMember = "OAd";
            cb_oda.ValueMember = "OId";
        }

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

        private void btn_do_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            int.TryParse(cb_do.SelectedValue.ToString(), out val);
            dataGridView1.DataSource = ListData.Conne(srg + " where DosyaTable.DsyId=" + val);
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {

            if (txt_do.Text != "")
            {
                Dataconn.conn.Open();
                SqlCommand ekle = new SqlCommand("insert into DosyaTable(DsyAd,KlsId) values (@v1,@v2)", Dataconn.conn);
                ekle.Parameters.AddWithValue("@v1", txt_do.Text);
                ekle.Parameters.AddWithValue("@v2", Convert.ToInt32(cb_kla.SelectedValue.ToString()));
                ekle.ExecuteNonQuery();
                Dataconn.conn.Close();
                txt_do.Clear();
                dataGridView1.DataSource = ListData.Conne("select DsyAd,DsyId,KlsId from DosyaTable where DsyAd='" + txt_do.Text + "'");
                txt_do.Clear();
                MessageBox.Show("Veri Ekleme Başarılı..");
              
            }
            else
                MessageBox.Show("Yeni Oda Adı Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ListData.Conne(srg);
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int dsyid;
            int.TryParse(cb_do.SelectedValue.ToString(), out dsyid);
            Dataconn.conn.Open();
            SqlCommand cmd = new SqlCommand("delete DosyaTable  where KlsId=" + dsyid, Dataconn.conn);
            cmd.ExecuteNonQuery();
            Dataconn.conn.Close();
            int val;
            val = Convert.ToInt32(cb_do.SelectedValue.ToString());
            dataGridView1.DataSource = ListData.Conne("Select DsyAd from DosyaTable Where DsyId=" + val);
            MessageBox.Show("Veri Silme Başarılı..");

            cb_do.DataSource = ListData.Conne("select DsyAd,DsyId from DosyaTable ");
            cb_do.DisplayMember = "DsyAd";
            cb_do.ValueMember = "DsyId";
            dataGridView1.DataSource = ListData.Conne(srg + " where DosyaTable.DsyId=" + val);
        }

        private void btn_dgsil_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                {
                    int dsyid;
                    int.TryParse(dataGridView1.Rows[i].Cells[1].Value.ToString(), out dsyid);
                    Dataconn.conn.Open();
                    SqlCommand cmd = new SqlCommand("delete DosyaTable  where DsyId=" + dsyid, Dataconn.conn);
                    cmd.ExecuteNonQuery();
                    Dataconn.conn.Close();

                }
                else
                    MessageBox.Show("Veri Seçilmeli..", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            MessageBox.Show("Veri Silme Başarılı..");
            dataGridView1.DataSource = ListData.Conne("Select OAd from OdaTable");
          
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            int val;
            int.TryParse(cb_do.SelectedValue.ToString(), out val);

            Dataconn.conn.Open();
            SqlCommand cmd = new SqlCommand("Update KlasorTable set KlsAd='" + txt_do.Text + "' where DsyId=" + val, Dataconn.conn);
            cmd.ExecuteNonQuery();
            Dataconn.conn.Close();
            dataGridView1.DataSource = ListData.Conne(srg + " where Dosyatable.DsyId=" + val);
            MessageBox.Show("Güncelleme Başarılı..");
        }

        private void btn_dgguncelle_Click(object sender, EventArgs e)
        {
            string dsyad;
            int dsyid, klsid;
            klsid = Convert.ToInt32(cb_kla.SelectedValue.ToString());
            dsyid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["DsyId"].Value.ToString());
            dsyad = dataGridView1.CurrentRow.Cells["DsyAd"].Value.ToString();
            Dataconn.conn.Open();
            SqlCommand cmd = new SqlCommand("Update DosyaTable set DsyAd='" + dsyad + "' , klsId=" + klsid + " where KlasorTable.KlsId=" + klsid, Dataconn.conn);
            cmd.ExecuteNonQuery();
            Dataconn.conn.Close();
            dataGridView1.DataSource = ListData.Conne("Select DsyAd from DosyaTable");
            MessageBox.Show("Güncelleme Başarılı..");
        }


    }
}
