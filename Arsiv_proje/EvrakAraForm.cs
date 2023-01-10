using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arsiv_proje
{
    public partial class EvrkAraForm : Form
    {
        public EvrkAraForm()
        {
            InitializeComponent();
        }
        
        private void EvrkAraForm_Load(object sender, EventArgs e)
        {

            cb_evrk.DataSource = ListData.Conne("select EvrkId,evrkAd from EvrakTable");
            cb_evrk.DisplayMember = "EvrkAd";
            cb_evrk.ValueMember = "EvrkId";
        }

      


      

        private void cb_dos_SelectedIndexChanged(object sender, EventArgs e)
        {

            int val1;
            Int32.TryParse(cb_evrk.SelectedValue.ToString(), out val1);
            cb_evrk.DataSource = ListData.Conne("select EvrkId,EvrkAd from EvrakTable");
            cb_evrk.DisplayMember = "EvrkAd";
            cb_evrk.ValueMember = "EvrkId";
            dataGridView1.DataSource = ListData.Conne("select OdaTable.OAd,BolumTable.BlmAd,RafTable.RafAd,KlasorTable.KlsAd,DosyaTable.DsyAd,EvrakTable.EvrkAd,EvrakTable.EvrkTar,GelGidEvrkTable.GelGidEvrakAd from OdaTable inner join BolumTable on OdaTable.OID=BolumTable.OId inner join RafTable on BolumTable.BlmId=RafTable.BlmId inner join KlasorTable on RafTable.RafId=KlasorTable.RafId inner join DosyaTable on KlasorTable.KlsId=DosyaTable.KlsId inner join EvrakTable on DosyaTable.DsyId=EvrakTable.DsyId inner join GelGidEvrkTable on EvrakTable.GelGidEvrkId=GelGidEvrkTable.GelGidEvrkId where EvrakTable.EvrkId=" + val1);

        }

        private void btn_ara_Click_1(object sender, EventArgs e)
        {
            string val = txt_evrk.Text;
            dataGridView1.DataSource = ListData.Conne("select OdaTable.OAd,BolumTable.BlmAd,RafTable.RafAd,KlasorTable.KlsAd,DosyaTable.DsyAd,EvrakTable.EvrkAd,EvrakTable.EvrkTar,GelGidEvrkTable.GelGidEvrakAd from OdaTable inner join BolumTable on OdaTable.OID=BolumTable.OId inner join RafTable on BolumTable.BlmId=RafTable.BlmId inner join KlasorTable on RafTable.RafId=KlasorTable.RafId inner join DosyaTable on KlasorTable.KlsId=DosyaTable.KlsId inner join EvrakTable on DosyaTable.DsyId=EvrakTable.DsyId inner join GelGidEvrkTable on EvrakTable.GelGidEvrkId=GelGidEvrkTable.GelGidEvrkId where EvrakTable.EvrkAd='" + val + "'");

        }
    }
}
