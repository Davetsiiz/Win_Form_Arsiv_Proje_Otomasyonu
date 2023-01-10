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
    public partial class BolAraForm : Form
    {
        public BolAraForm()
        {
            InitializeComponent();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            string val = txt_bol.Text;
            dataGridView1.DataSource = ListData.Conne("select OdaTable.OAd,BolumTable.BlmAd,RafTable.RafAd,KlasorTable.KlsAd,DosyaTable.DsyAd,EvrakTable.EvrkAd,EvrakTable.EvrkTar,GelGidEvrkTable.GelGidEvrakAd from OdaTable inner join BolumTable on OdaTable.OID=BolumTable.OId inner join RafTable on BolumTable.BlmId=RafTable.BlmId inner join KlasorTable on RafTable.RafId=KlasorTable.RafId inner join DosyaTable on KlasorTable.KlsId=DosyaTable.KlsId inner join EvrakTable on DosyaTable.DsyId=EvrakTable.DsyId inner join GelGidEvrkTable on EvrakTable.GelGidEvrkId=GelGidEvrkTable.GelGidEvrkId where BolumTable.BlmAd='" + val + "'");

        }

        private void BolAraForm_Load(object sender, EventArgs e)
        {
            cb_bol.DataSource = ListData.Conne("select blmId,Blmad from BolumTable");
            cb_bol.DisplayMember = "BlmAd";
            cb_bol.ValueMember = "BlmId";
        }

        private void cb_bol_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val1;
            Int32.TryParse(cb_bol.SelectedValue.ToString(), out val1);
            cb_bol.DataSource = ListData.Conne("Select BlmId,BlmAd from BolumTable");
            cb_bol.DisplayMember = "BlmAd";
            cb_bol.ValueMember = "BlmId";
            dataGridView1.DataSource = ListData.Conne("select OdaTable.OAd,BolumTable.BlmAd,RafTable.RafAd,KlasorTable.KlsAd,DosyaTable.DsyAd,EvrakTable.EvrkAd,EvrakTable.EvrkTar,GelGidEvrkTable.GelGidEvrakAd from OdaTable inner join BolumTable on OdaTable.OID=BolumTable.OId inner join RafTable on BolumTable.BlmId=RafTable.BlmId inner join KlasorTable on RafTable.RafId=KlasorTable.RafId inner join DosyaTable on KlasorTable.KlsId=DosyaTable.KlsId inner join EvrakTable on DosyaTable.DsyId=EvrakTable.DsyId inner join GelGidEvrkTable on EvrakTable.GelGidEvrkId=GelGidEvrkTable.GelGidEvrkId where BolumTable.BlmId=" + val1);
        
        }
    }
}
