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
    public partial class RafDuzForm : Form
    {
        public RafDuzForm()
        {
            InitializeComponent();
        }
        string srg = "select Raftable.RafId,.raftable.RafAD,RafTable.BlmId  from OdaTable inner join BolumTable on OdaTable.OID=BolumTable.OId inner join RafTable on bolumTable.BlmId=RafTable.RafId ";
 private void RafDuzForm_Load(object sender, EventArgs e)
        {

            Dataconn.conn.ConnectionString = "Data Source=DESKTOP-RCC06P7;Initial Catalog=Arsiv_proje;Integrated Security=True";
            cb_oda.DataSource = ListData.Conne("select OAd,OId from OdaTable");
            cb_oda.DisplayMember = "OAd";
            cb_oda.ValueMember = "OId";
            dataGridView1.DataSource = ListData.Conne(srg);
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
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
            dataGridView1.DataSource = ListData.Conne("Select RafId,RafAd from RafTable where BlmId =" + val);
        }

        private void cb_raf_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(cb_raf.SelectedValue.ToString(), out val);
            dataGridView1.DataSource = ListData.Conne(srg + " Where RafTable.RafId=" + val);
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (txt_raf.Text != "")
            {
                Dataconn.conn.Open();
                SqlCommand ekle = new SqlCommand("insert into RafTable(RafAd,blmId) values (@v1,@v2)", Dataconn.conn);
                ekle.Parameters.AddWithValue("@v1", txt_raf.Text);
                ekle.Parameters.AddWithValue("@v2", Convert.ToInt32(cb_bol.SelectedValue.ToString()));
                ekle.ExecuteNonQuery();
                Dataconn.conn.Close();
                txt_raf.Clear();
                dataGridView1.DataSource = ListData.Conne("select RafAd,RafId,blmId from RafTable where RafAd='"+txt_raf.Text+"'");
                txt_raf.Clear();
                MessageBox.Show("Veri Ekleme Başarılı..");
                cb_raf.DataSource = ListData.Conne("select RafAd,RafId,blmId from RafTable");
                cb_raf.DisplayMember = "RafAd";
                cb_raf.ValueMember = "RafId";
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

            int rafid;
            int.TryParse(cb_raf.SelectedValue.ToString(), out rafid);
            Dataconn.conn.Open();
            SqlCommand cmd = new SqlCommand("delete RafTable  where RafId=" + rafid, Dataconn.conn);
            cmd.ExecuteNonQuery();
            Dataconn.conn.Close();
            int val;
            val = Convert.ToInt32(cb_raf.SelectedValue.ToString());
            dataGridView1.DataSource = ListData.Conne("Select RafAd from RafTable Where rafId=" + val);
            MessageBox.Show("Veri Silme Başarılı..");

            cb_raf.DataSource = ListData.Conne("select rafAd,rafId from RafTable ");
            cb_raf.DisplayMember = "RafAd";
            cb_raf.ValueMember = "RafId";
            dataGridView1.DataSource = ListData.Conne(srg);
        }

        private void btn_dgsil_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                {
                    int rafid;
                    int.TryParse(dataGridView1.Rows[i].Cells[1].Value.ToString(), out rafid);
                    Dataconn.conn.Open();
                    SqlCommand cmd = new SqlCommand("delete RafTable  where RafId=" + rafid, Dataconn.conn);
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
            int.TryParse(cb_raf.SelectedValue.ToString(), out val);

            Dataconn.conn.Open();
            SqlCommand cmd = new SqlCommand("Update RafTable set RafAd='" + txt_raf.Text + "' where RafId=" + val, Dataconn.conn);
            cmd.ExecuteNonQuery();
            Dataconn.conn.Close();
            dataGridView1.DataSource = ListData.Conne(srg+" where raftable.rafId=" + val);
            MessageBox.Show("Güncelleme Başarılı..");
        }

        private void btn_dgguncelle_Click(object sender, EventArgs e)
        {

            string rafad;
            int rafid, bolid;
            bolid = Convert.ToInt32(cb_bol.SelectedValue.ToString());
            rafid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["RafId"].Value.ToString());
            rafad = dataGridView1.CurrentRow.Cells["RafAd"].Value.ToString();
            Dataconn.conn.Open();
            SqlCommand cmd = new SqlCommand("Update BolumTable set BlmAd='" + rafad + "' , BlmId=" + bolid + " where BolumTable.BlmId=" + rafid, Dataconn.conn);
            cmd.ExecuteNonQuery();
            Dataconn.conn.Close();
            dataGridView1.DataSource = ListData.Conne("Select RafAd from RafTable");
            MessageBox.Show("Güncelleme Başarılı..");
        //    cb_bol.DataSource = ListData.Conne("Select BlmId,BlmAd from BolumTable inner join OdaTable on Bolumtable.OId=OdaTable.OId");
        //    cb_bol.DisplayMember = "BlmAd";
        //    cb_bol.ValueMember = "BlmId";
        }
    }
}
