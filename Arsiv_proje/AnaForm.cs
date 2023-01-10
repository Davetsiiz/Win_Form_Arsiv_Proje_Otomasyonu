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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        

       

        private void button1_Click(object sender, EventArgs e)
        {
            YeniEvrkForm fo6 = new YeniEvrkForm();
            fo6.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            EvrkDuzForm fo7 = new EvrkDuzForm();
            fo7.Show(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EvrkAraForm fo8 = new EvrkAraForm();
            fo8.Show(); 
        }

        
        private void button5_Click(object sender, EventArgs e)
        {
            DizinTaraForm fo5 = new DizinTaraForm();
            fo5.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            KullaniciBilForm form10=new KullaniciBilForm();
            form10.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            KullaniciGunForm fo11 = new KullaniciGunForm();
            fo11.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            KayitForm fo4=new KayitForm();
            fo4.Show();
        }

        

        private void btn_odaduz_Click(object sender, EventArgs e)
        {
            OdaDuzform fo13=new OdaDuzform();
            fo13.Show();
        }

        private void btn_bolduz_Click(object sender, EventArgs e)
        {
            BolduzForm fo14=new BolduzForm();
            fo14.Show();    
        }

        private void btn_rafduz_Click(object sender, EventArgs e)
        {
            RafDuzForm fo15=new RafDuzForm();
            fo15.Show();
        }

        private void btn_kladuz_Click(object sender, EventArgs e)
        {
            KladuzForm fo16 = new KladuzForm();
            fo16.Show();
        }

        private void DosduzForm_Click(object sender, EventArgs e)
        {
            DosDuzForm fo17=new DosDuzForm();
            fo17.Show();
        }

        private void btn_odaara_Click(object sender, EventArgs e)
        {
            OdaAraForm fo18 = new OdaAraForm();
            fo18.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BolAraForm fo19=new BolAraForm();
            fo19.Show();
        }

        private void btn_rafara_Click(object sender, EventArgs e)
        {
            RafAraForm fo20=new RafAraForm();
            fo20.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            KlaaraForm fo21 = new KlaaraForm();
            fo21.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DoaraForm fo22=new DoaraForm();
            fo22.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EvrakEkleme fo23 = new EvrakEkleme();
            fo23.Show();
        }
    }
}
