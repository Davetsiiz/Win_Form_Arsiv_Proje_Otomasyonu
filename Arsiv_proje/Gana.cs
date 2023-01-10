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
    public partial class form_gana : Form
    {
      
        public form_gana()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RCC06P7;Initial Catalog=Arsiv_proje;Integrated Security=True");

        private void Form7_Load(object sender, EventArgs e)
        {

            conn.ConnectionString = "Data Source=DESKTOP-RCC06P7;Initial Catalog=Arsiv_proje;Integrated Security=True";
            cb_oda.DataSource = ListData.Conne("select OAd,OId from OdaTable");
            cb_oda.DisplayMember = "OAd";
            cb_oda.ValueMember = "OId";
            cb_oda.Enabled = false; 
            cb_bol.Enabled = false; 
            cb_raf.Enabled = false; 
            cb_kla.Enabled = false; 
            cb_do.Enabled =  false; 
            cb_evrk.Enabled =false;

            txt_oda.Enabled = false;
            txt_Bol.Enabled = false;
            txt_raf.Enabled = false;
            txt_kla.Enabled = false;
            txt_do.Enabled = false;
            txt_evrk.Enabled = false;


            cob_kata.DataSource=ListData.Conne("select Ka_ID,Ka_AD from KatagoriTable");
            cob_kata.DisplayMember = "Ka_AD";
            cob_kata.ValueMember = "Ka_ID";

            cob_istu.DataSource = ListData.Conne("select I_ID,I_AD from IslemTable");
            cob_istu.DisplayMember = "I_AD";
            cob_istu.ValueMember = "I_ID";



        }
        private void cob_kata_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cob_istu.SelectedIndex == 0) 
            {
                if (cob_kata.SelectedIndex == 5)
                {
                    cb_oda.Enabled = true;
                    cb_bol.Enabled = true;
                    cb_raf.Enabled = true;
                    cb_kla.Enabled = true;
                    cb_do.Enabled = true;
                    cb_evrk.Enabled = true;
                }
                else if(cob_kata.SelectedIndex == 4)
                {
                    cb_oda.Enabled = true;
                    cb_bol.Enabled = true;
                    cb_raf.Enabled = true;
                    cb_kla.Enabled = true;
                    cb_do.Enabled = true;
                    cb_evrk.Enabled = false;
                }
                else if (cob_kata.SelectedIndex == 3)
                {
                    cb_oda.Enabled = true;
                    cb_bol.Enabled = true;
                    cb_raf.Enabled = true;
                    cb_kla.Enabled = true;
                    cb_do.Enabled = false;
                    cb_evrk.Enabled = false;

                }
                else if (cob_kata.SelectedIndex == 2)
                {
                    cb_oda.Enabled = true;
                    cb_bol.Enabled = true;
                    cb_raf.Enabled = true;
                    cb_kla.Enabled = false;
                    cb_do.Enabled = false;
                    cb_evrk.Enabled = false;

                }
                else if (cob_kata.SelectedIndex == 1)
                {
                    cb_oda.Enabled = true;
                    cb_bol.Enabled = true;
                    cb_raf.Enabled = false;
                    cb_kla.Enabled = false;
                    cb_do.Enabled = false;
                    cb_evrk.Enabled = false;

                }
                else if (cob_kata.SelectedIndex == 0)
                {
                    cb_oda.Enabled = true;
                    cb_bol.Enabled = false;
                    cb_raf.Enabled = false;
                    cb_kla.Enabled = false;
                    cb_do.Enabled = false;
                    cb_evrk.Enabled = false;

                }

            }
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
           
            
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

        private void cb_do_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(cb_do.SelectedValue.ToString(), out val);
            string cmd = "Select EvrkId,EvrkAd from EvrakTable where DsyId =" + val;
            cb_evrk.DataSource = ListData.Conne(cmd);
            cb_evrk.ValueMember = "EvrkId";
            cb_evrk.DisplayMember = "EvrkAd";
        }

        private void cb_evrk_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(cb_evrk.SelectedValue.ToString(), out val);
            dataGridView1.DataSource = ListData.Conne("select OdaTable.OAd,BolumTable.BlmAd,RafTable.RafAd,KlasorTable.KlsAd,DosyaTable.DsyAd,EvrakTable.EvrkAd,EvrakTable.EvrkTar,GelGidEvrkTable.GelGidEvrakAd from OdaTable  inner join BolumTable on OdaTable.OID=BolumTable.OId  inner join RafTable on BolumTable.BlmId=RafTable.BlmId  inner join KlasorTable on RafTable.RafId=KlasorTable.RafId  inner join DosyaTable on KlasorTable.KlsId=DosyaTable.KlsId  inner join EvrakTable on DosyaTable.DsyId=EvrakTable.DsyId  inner join GelGidEvrkTable on EvrakTable.GelGidEvrkId=GelGidEvrkTable.GelGidEvrkId where EvrkId=" + val);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                row.Cells["ch_sec"].Value = Convert.ToBoolean(row.Cells["ch_sec"].EditedFormattedValue);
                if (Convert.ToBoolean(row.Cells["ch_sec"].Value)==true)
                {

                   

                    
                }
                else if(Convert.ToBoolean(row.Cells["ch_sec"].Value) == false)
                {
   
                }
            }
        }

        
    }
}
