namespace Arsiv_proje
{
    partial class EvrakEkleme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvrakEkleme));
            this.cb_do = new System.Windows.Forms.ComboBox();
            this.cb_kla = new System.Windows.Forms.ComboBox();
            this.cb_raf = new System.Windows.Forms.ComboBox();
            this.cb_bol = new System.Windows.Forms.ComboBox();
            this.cb_oda = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_evrkno = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_yazdir = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_do
            // 
            this.cb_do.FormattingEnabled = true;
            this.cb_do.Location = new System.Drawing.Point(385, 58);
            this.cb_do.Name = "cb_do";
            this.cb_do.Size = new System.Drawing.Size(121, 21);
            this.cb_do.TabIndex = 22;
            this.cb_do.SelectedIndexChanged += new System.EventHandler(this.cb_do_SelectedIndexChanged);
            // 
            // cb_kla
            // 
            this.cb_kla.FormattingEnabled = true;
            this.cb_kla.Location = new System.Drawing.Point(385, 20);
            this.cb_kla.Name = "cb_kla";
            this.cb_kla.Size = new System.Drawing.Size(121, 21);
            this.cb_kla.TabIndex = 21;
            this.cb_kla.SelectedIndexChanged += new System.EventHandler(this.cb_kla_SelectedIndexChanged);
            // 
            // cb_raf
            // 
            this.cb_raf.FormattingEnabled = true;
            this.cb_raf.Location = new System.Drawing.Point(125, 84);
            this.cb_raf.Name = "cb_raf";
            this.cb_raf.Size = new System.Drawing.Size(121, 21);
            this.cb_raf.TabIndex = 20;
            this.cb_raf.SelectedIndexChanged += new System.EventHandler(this.cb_raf_SelectedIndexChanged);
            // 
            // cb_bol
            // 
            this.cb_bol.FormattingEnabled = true;
            this.cb_bol.Location = new System.Drawing.Point(125, 54);
            this.cb_bol.Name = "cb_bol";
            this.cb_bol.Size = new System.Drawing.Size(121, 21);
            this.cb_bol.TabIndex = 19;
            this.cb_bol.SelectedIndexChanged += new System.EventHandler(this.cb_bol_SelectedIndexChanged);
            // 
            // cb_oda
            // 
            this.cb_oda.FormattingEnabled = true;
            this.cb_oda.Location = new System.Drawing.Point(125, 20);
            this.cb_oda.Name = "cb_oda";
            this.cb_oda.Size = new System.Drawing.Size(121, 21);
            this.cb_oda.TabIndex = 18;
            this.cb_oda.SelectedIndexChanged += new System.EventHandler(this.cb_oda_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.IndianRed;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(293, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Evrak No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(292, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Dosya No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(290, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Klasör No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(46, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Raf No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Bölüm No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(44, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Oda No";
            // 
            // txt_evrkno
            // 
            this.txt_evrkno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_evrkno.Location = new System.Drawing.Point(385, 93);
            this.txt_evrkno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_evrkno.Name = "txt_evrkno";
            this.txt_evrkno.Size = new System.Drawing.Size(121, 23);
            this.txt_evrkno.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 132);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(759, 122);
            this.dataGridView1.TabIndex = 24;
            // 
            // btn_yazdir
            // 
            this.btn_yazdir.Location = new System.Drawing.Point(560, 87);
            this.btn_yazdir.Name = "btn_yazdir";
            this.btn_yazdir.Size = new System.Drawing.Size(121, 30);
            this.btn_yazdir.TabIndex = 25;
            this.btn_yazdir.Text = "Yazdır";
            this.btn_yazdir.UseVisualStyleBackColor = true;
            this.btn_yazdir.Click += new System.EventHandler(this.btn_yazdir_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(600, 18);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(528, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "Tarih";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Location = new System.Drawing.Point(531, 58);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(84, 17);
            this.radioButton1.TabIndex = 28;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Gelen Evrak";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Location = new System.Drawing.Point(650, 58);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 17);
            this.radioButton2.TabIndex = 29;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Giden Evrak";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // EvrakEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(759, 254);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_yazdir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_evrkno);
            this.Controls.Add(this.cb_do);
            this.Controls.Add(this.cb_kla);
            this.Controls.Add(this.cb_raf);
            this.Controls.Add(this.cb_bol);
            this.Controls.Add(this.cb_oda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EvrakEkleme";
            this.Text = "Tarih Aralıklı Evrak Arama";
            this.Load += new System.EventHandler(this.EvrakEkleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_do;
        private System.Windows.Forms.ComboBox cb_kla;
        private System.Windows.Forms.ComboBox cb_raf;
        private System.Windows.Forms.ComboBox cb_bol;
        private System.Windows.Forms.ComboBox cb_oda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_evrkno;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_yazdir;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}