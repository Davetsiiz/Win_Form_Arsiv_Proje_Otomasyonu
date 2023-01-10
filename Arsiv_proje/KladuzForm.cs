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
    public partial class KladuzForm : Form
    {
        public KladuzForm()
        {
            InitializeComponent();
        }

        string srg = "select KlasorTable.KlsId,.KlasorTable.KlsAD,KlasorTable.RafId  from OdaTable inner join BolumTable on OdaTable.OID=BolumTable.OId inner join RafTable on bolumTable.BlmId=RafTable.RafId inner join KlasorTable on RafTable.RafId=KlasorTable.RafId";
        private void KladuzForm_Load(object sender, EventArgs e)
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
            int.TryParse(cb_kla.SelectedValue.ToString(),out val);
            dataGridView1.DataSource = ListData.Conne(srg + " where KlasorTable.KlsId=" + val);
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {

            if (txt_kla.Text != "")
            {
                Dataconn.conn.Open();
                SqlCommand ekle = new SqlCommand("insert into KlasorTable(KlsAd,RafId) values (@v1,@v2)", Dataconn.conn);
                ekle.Parameters.AddWithValue("@v1", txt_kla.Text);
                ekle.Parameters.AddWithValue("@v2", Convert.ToInt32(cb_raf.SelectedValue.ToString()));
                ekle.ExecuteNonQuery();
                Dataconn.conn.Close();
                txt_kla.Clear();
                dataGridView1.DataSource = ListData.Conne("select KlsAd,KlsId,RafId from KlasorTable where KlsAd='" + txt_kla.Text + "'");
                txt_kla.Clear();
                MessageBox.Show("Veri Ekleme Başarılı..");
                cb_kla.DataSource = ListData.Conne("select KlsAd,KlsId,RafId from KlasorTable");
                cb_kla.DisplayMember = "KlsAd";
                cb_kla.ValueMember = "KlsId";
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
            int klsid;
            int.TryParse(cb_kla.SelectedValue.ToString(), out klsid);
            Dataconn.conn.Open();
            SqlCommand cmd = new SqlCommand("delete KlasorTable  where KlsId=" + klsid, Dataconn.conn);
            cmd.ExecuteNonQuery();
            Dataconn.conn.Close();
            int val;
            val = Convert.ToInt32(cb_kla.SelectedValue.ToString());
            dataGridView1.DataSource = ListData.Conne("Select KlsAd from KlasorTable Where KlsId=" + val);
            MessageBox.Show("Veri Silme Başarılı..");

            cb_kla.DataSource = ListData.Conne("select KlsAd,KlsId from KlasorTable ");
            cb_kla.DisplayMember = "KlsAd";
            cb_kla.ValueMember = "klsId";
            dataGridView1.DataSource = ListData.Conne(srg + " where KlasorTable.KlsId=" + val);
        }

        private void btn_dgsil_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                {
                    int klaid;
                    int.TryParse(dataGridView1.Rows[i].Cells[1].Value.ToString(), out klaid);
                    Dataconn.conn.Open();
                    SqlCommand cmd = new SqlCommand("delete KlasorTable  where KlsId=" + klaid, Dataconn.conn);
                    cmd.ExecuteNonQuery();
                    Dataconn.conn.Close();

                }
                else
                    MessageBox.Show("Veri Seçilmeli..", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            MessageBox.Show("Veri Silme Başarılı..");
            dataGridView1.DataSource = ListData.Conne("Select OAd from OdaTable");
            cb_oda.DataSource = ListData.Conne("select OAd,OId from OdaTable");
            cb_oda.DisplayMember = "OAd";
            cb_oda.ValueMember = "OId";
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            int val;
            int.TryParse(cb_kla.SelectedValue.ToString(), out val);

            Dataconn.conn.Open();
            SqlCommand cmd = new SqlCommand("Update KlasorTable set KlsAd='" + txt_kla.Text + "' where KlsId=" + val, Dataconn.conn);
            cmd.ExecuteNonQuery();
            Dataconn.conn.Close();
            dataGridView1.DataSource = ListData.Conne(srg + " where Klasortable.KlsId=" + val);
            MessageBox.Show("Güncelleme Başarılı..");
        }

        private void btn_dgguncelle_Click(object sender, EventArgs e)
        {
            
            string klsad;
            int Klsid, rafid;
            rafid = Convert.ToInt32(cb_raf.SelectedValue.ToString());
            Klsid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["KlsId"].Value.ToString());
            klsad = dataGridView1.CurrentRow.Cells["KlsAd"].Value.ToString();
            Dataconn.conn.Open();
            SqlCommand cmd = new SqlCommand("Update KlasorTable set KlsAd='" + klsad + "' , rafId=" + rafid + " where raftable.rafid=" + rafid, Dataconn.conn);
            cmd.ExecuteNonQuery();
            Dataconn.conn.Close();
            dataGridView1.DataSource = ListData.Conne("Select KlsAd from KlasorTable");
            MessageBox.Show("Güncelleme Başarılı..");
        }
    }
}
