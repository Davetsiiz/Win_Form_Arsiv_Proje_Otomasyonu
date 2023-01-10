using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Arsiv_proje
{
    public partial class OdaDuzform : Form
    {
        public OdaDuzform()
        {
            InitializeComponent();
        }

        private void cb_oda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OdaDuzform_Load(object sender, EventArgs e)
        {
            cb_oda.DataSource = ListData.Conne("select OAd,OId from OdaTable");
            cb_oda.DisplayMember = "OAd";
            cb_oda.ValueMember = "OId";
            dataGridView1.DataSource = ListData.Conne("Select OAd from OdaTable");
            dataGridView1.Columns[1].ReadOnly = true;

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (txt_oda.Text != "")
            {
                Dataconn.conn.Open();
                SqlCommand ekle = new SqlCommand("insert into OdaTable(OAd) values (@v1)", Dataconn.conn);
                ekle.Parameters.AddWithValue("@v1", txt_oda.Text);
                ekle.ExecuteNonQuery();
                Dataconn.conn.Close();
                txt_oda.Clear();
                dataGridView1.DataSource = ListData.Conne("Select OAd from OdaTable");
                MessageBox.Show("Veri Ekleme Başarılı..");
                cb_oda.DataSource = ListData.Conne("select OAd,OId from OdaTable");
                cb_oda.DisplayMember = "OAd";
                cb_oda.ValueMember = "OId";
            }
            else
                MessageBox.Show("Yeni Oda Adı Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        private void btn_yenile_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ListData.Conne("Select OAd from OdaTable");
            dataGridView1.Columns[1].ReadOnly = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            int val;
            int.TryParse(cb_oda.SelectedValue.ToString(), out val);

            Dataconn.conn.Open();
            SqlCommand cmd = new SqlCommand("Update OdaTable set OAd='" + txt_oda.Text + "' where OId=" + val, Dataconn.conn);
            cmd.ExecuteNonQuery();
            Dataconn.conn.Close();
            dataGridView1.DataSource = ListData.Conne("Select OAd from OdaTable");
            MessageBox.Show("Güncelleme Başarılı..");
        }

        private void btn_dgguncelle_Click(object sender, EventArgs e)
        {
            string odad;
            int odaid;
            odaid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["OId"].Value.ToString());
            odad = dataGridView1.CurrentRow.Cells["OAd"].Value.ToString();
            Dataconn.conn.Open();
            SqlCommand cmd = new SqlCommand("Update OdaTable set OAd='" + odad + "' where OId=" + odaid, Dataconn.conn);
            cmd.ExecuteNonQuery();
            Dataconn.conn.Close();
            dataGridView1.DataSource = ListData.Conne("Select OAd from OdaTable");
            MessageBox.Show("Güncelleme Başarılı..");
            cb_oda.DataSource = ListData.Conne("select OAd,OId from OdaTable");
            cb_oda.DisplayMember = "OAd";
            cb_oda.ValueMember = "OId";

        }

        

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int odaid;
            int.TryParse(cb_oda.SelectedValue.ToString(), out odaid);
            Dataconn.conn.Open();
            SqlCommand cmd = new SqlCommand("delete OdaTable  where OId=" + odaid, Dataconn.conn);
            cmd.ExecuteNonQuery();
            Dataconn.conn.Close();
            dataGridView1.DataSource = ListData.Conne("Select OAd from OdaTable");
            MessageBox.Show("Veri Silme Başarılı..");
            cb_oda.DataSource = ListData.Conne("select OAd,OId from OdaTable");
            cb_oda.DisplayMember = "OAd";
            cb_oda.ValueMember = "OId";
        }

        private void btn_dgsil_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                {
                    int odaid;
                    int.TryParse(dataGridView1.Rows[i].Cells[1].Value.ToString(), out odaid);
                    Dataconn.conn.Open();
                    SqlCommand cmd = new SqlCommand("delete OdaTable  where OId=" + odaid, Dataconn.conn);
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


    }
}


