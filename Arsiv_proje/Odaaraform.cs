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
    public partial class OdaAraForm : Form
    {
        public OdaAraForm()
        {
            InitializeComponent();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            string val=txt_ara.Text;
            dataGridView1.DataSource = ListData.Conne("select OdaTable.OAd,BolumTable.BlmAd,RafTable.RafAd,KlasorTable.KlsAd,DosyaTable.DsyAd,EvrakTable.EvrkAd,EvrakTable.EvrkTar,GelGidEvrkTable.GelGidEvrakAd from OdaTable inner join BolumTable on OdaTable.OID=BolumTable.OId inner join RafTable on BolumTable.BlmId=RafTable.BlmId inner join KlasorTable on RafTable.RafId=KlasorTable.RafId inner join DosyaTable on KlasorTable.KlsId=DosyaTable.KlsId inner join EvrakTable on DosyaTable.DsyId=EvrakTable.DsyId inner join GelGidEvrkTable on EvrakTable.GelGidEvrkId=GelGidEvrkTable.GelGidEvrkId where Oad='" + val + "'");           
        }

        private void OdaAraForm_Load(object sender, EventArgs e)
        {
            cb_oda.DataSource = ListData.Conne("select OAd,OId from OdaTable");
            cb_oda.DisplayMember = "OAd";
            cb_oda.ValueMember = "OId";
        }

        private void cb_oda_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val1;
            Int32.TryParse(cb_oda.SelectedValue.ToString(), out val1);
            cb_oda.DataSource = ListData.Conne("select OAd,OId from OdaTable");
            cb_oda.DisplayMember = "OAd";
            cb_oda.ValueMember = "OId";
            dataGridView1.DataSource = ListData.Conne("select OdaTable.OAd,BolumTable.BlmAd,RafTable.RafAd,KlasorTable.KlsAd,DosyaTable.DsyAd,EvrakTable.EvrkAd,EvrakTable.EvrkTar,GelGidEvrkTable.GelGidEvrakAd from OdaTable inner join BolumTable on OdaTable.OID=BolumTable.OId inner join RafTable on BolumTable.BlmId=RafTable.BlmId inner join KlasorTable on RafTable.RafId=KlasorTable.RafId inner join DosyaTable on KlasorTable.KlsId=DosyaTable.KlsId inner join EvrakTable on DosyaTable.DsyId=EvrakTable.DsyId inner join GelGidEvrkTable on EvrakTable.GelGidEvrkId=GelGidEvrkTable.GelGidEvrkId where OdaTable.OID=" + val1 );

        }
    }
}
