using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arsiv_proje
{
    public partial class BolduzForm : Form
    {
        public BolduzForm()
        {
            InitializeComponent();
        }
        string srg = "select BolumTable.BlmId,OdaTable.OAd, BolumTable.BlmAd  from OdaTable inner join BolumTable on OdaTable.OID=BolumTable.OId ";
        private void BolduzForm_Load(object sender, EventArgs e)
        {
            cb_oda.DataSource = ListData.Conne("select OAd,OId from OdaTable");
            cb_oda.DisplayMember = "OAd";
            cb_oda.ValueMember = "OId";
            dataGridView1.DataSource = ListData.Conne(srg);
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
        }


        private void cb_oda_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(cb_oda.SelectedValue.ToString(), out val);
            string cmd = "Select BlmId,BlmAd from BolumTable where OId =" + val;
            
            cb_bol.DataSource = ListData.Conne(cmd);
            cb_bol.ValueMember = "BlmId";
            cb_bol.DisplayMember = "BlmAd";
            cb_bol.Enabled = true;
            dataGridView1.DataSource = ListData.Conne(srg + " where OdaTable.OId=" + val);


        }

        private void cb_bol_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val,valoda;

            Int32.TryParse(cb_bol.SelectedValue.ToString(), out val);
            Int32.TryParse(cb_oda.SelectedValue.ToString(), out valoda);
            cb_bol.DataSource = ListData.Conne("Select BlmId,BlmAd from BolumTable where OID="+valoda);
            cb_bol.DisplayMember = "BlmAd";
            cb_bol.ValueMember = "BlmId";
            dataGridView1.DataSource = ListData.Conne(srg+" where Odatable.OID = "+valoda);

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (txt_bol.Text != "")
            {
                Dataconn.conn.Open();
                SqlCommand ekle = new SqlCommand("insert into BolumTable(BlmAd,OId) values (@v1,@v2)", Dataconn.conn);
                ekle.Parameters.AddWithValue("@v1", txt_bol.Text);
                ekle.Parameters.AddWithValue("@v2", Convert.ToInt32(cb_oda.SelectedValue.ToString()));
                ekle.ExecuteNonQuery();
                Dataconn.conn.Close();
                txt_bol.Clear();
                dataGridView1.DataSource = ListData.Conne("Select OdaTable.OAd,BlmAd from BolumTable inner join OdaTable on Bolumtable.OId=OdaTable.OId");
                MessageBox.Show("Veri Ekleme Başarılı..");
               
            }
            else
                MessageBox.Show("Yeni Oda Adı Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ListData.Conne(srg);
            //dataGridView1.Columns[1].ReadOnly = true;
        }

        

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            int val;
            int.TryParse(cb_bol.SelectedValue.ToString(), out val);

            Dataconn.conn.Open();
            SqlCommand cmd = new SqlCommand("Update BolumTable set BlmAd='" + txt_bol.Text + "' where BlmId=" + val, Dataconn.conn);
            cmd.ExecuteNonQuery();
            Dataconn.conn.Close();
            dataGridView1.DataSource = ListData.Conne("Select OdaTable.OAd,BlmAd from BolumTable inner join OdaTable on Bolumtable.OId=OdaTable.OId where Bolumtable.BlmId="+val);
            MessageBox.Show("Güncelleme Başarılı..");
        }

        private void btn_dgsil_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                {
                    int blmid;
                    int.TryParse(dataGridView1.Rows[i].Cells[1].Value.ToString(), out blmid);
                    Dataconn.conn.Open();
                    SqlCommand cmd = new SqlCommand("delete BolumTable  where BlmId=" + blmid, Dataconn.conn);
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

        private void btn_dgguncelle_Click(object sender, EventArgs e)
        {
            string blmad;
            int blmid,odid;
            odid = Convert.ToInt32(cb_oda.SelectedValue.ToString());
            blmid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["BlmId"].Value.ToString());
            blmad = dataGridView1.CurrentRow.Cells["BlmAd"].Value.ToString();
            Dataconn.conn.Open();
            SqlCommand cmd = new SqlCommand("Update BolumTable set BlmAd='" + blmad + "' , OId="+odid+" where BolumTable.BlmId=" + blmid, Dataconn.conn);
            cmd.ExecuteNonQuery();
            Dataconn.conn.Close();
            dataGridView1.DataSource = ListData.Conne("Select BlmAd from BolumTable");
            MessageBox.Show("Güncelleme Başarılı..");
            cb_bol.DataSource = ListData.Conne("Select BlmId,BlmAd from BolumTable inner join OdaTable on Bolumtable.OId=OdaTable.OId");
            cb_bol.DisplayMember = "BlmAd";
            cb_bol.ValueMember = "BlmId";
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {

            int bolid;
            int.TryParse(cb_bol.SelectedValue.ToString(), out bolid);
            Dataconn.conn.Open();
            SqlCommand cmd = new SqlCommand("delete BolumTable  where BlmId=" + bolid, Dataconn.conn);
            cmd.ExecuteNonQuery();
            Dataconn.conn.Close();
            int val;
            val = Convert.ToInt32(cb_oda.SelectedValue.ToString());
            dataGridView1.DataSource = ListData.Conne("Select BlmAd from BolumTable Where OId="+val);
            MessageBox.Show("Veri Silme Başarılı..");
            
            cb_bol.DataSource = ListData.Conne("select BlmAd,BlmId from BolumTable ");
            cb_bol.DisplayMember = "BlmAd";
            cb_bol.ValueMember = "BlmId";
        }


    }
}
