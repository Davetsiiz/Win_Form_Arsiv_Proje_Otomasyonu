namespace Arsiv_proje
{
    partial class form_gana
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_gana));
            this.cb_evrk = new System.Windows.Forms.ComboBox();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ch_sec = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.cob_kata = new System.Windows.Forms.ComboBox();
            this.cob_istu = new System.Windows.Forms.ComboBox();
            this.txt_oda = new System.Windows.Forms.TextBox();
            this.txt_Bol = new System.Windows.Forms.TextBox();
            this.btn_kisi = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txt_kla = new System.Windows.Forms.TextBox();
            this.txt_raf = new System.Windows.Forms.TextBox();
            this.txt_evrk = new System.Windows.Forms.TextBox();
            this.txt_do = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_ana = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_evrk
            // 
            this.cb_evrk.FormattingEnabled = true;
            this.cb_evrk.Location = new System.Drawing.Point(455, 149);
            this.cb_evrk.Name = "cb_evrk";
            this.cb_evrk.Size = new System.Drawing.Size(121, 21);
            this.cb_evrk.TabIndex = 23;
            this.cb_evrk.SelectedIndexChanged += new System.EventHandler(this.cb_evrk_SelectedIndexChanged);
            // 
            // cb_do
            // 
            this.cb_do.FormattingEnabled = true;
            this.cb_do.Location = new System.Drawing.Point(455, 122);
            this.cb_do.Name = "cb_do";
            this.cb_do.Size = new System.Drawing.Size(121, 21);
            this.cb_do.TabIndex = 22;
            this.cb_do.SelectedIndexChanged += new System.EventHandler(this.cb_do_SelectedIndexChanged);
            // 
            // cb_kla
            // 
            this.cb_kla.FormattingEnabled = true;
            this.cb_kla.Location = new System.Drawing.Point(455, 95);
            this.cb_kla.Name = "cb_kla";
            this.cb_kla.Size = new System.Drawing.Size(121, 21);
            this.cb_kla.TabIndex = 21;
            this.cb_kla.SelectedIndexChanged += new System.EventHandler(this.cb_kla_SelectedIndexChanged);
            // 
            // cb_raf
            // 
            this.cb_raf.FormattingEnabled = true;
            this.cb_raf.Location = new System.Drawing.Point(455, 68);
            this.cb_raf.Name = "cb_raf";
            this.cb_raf.Size = new System.Drawing.Size(121, 21);
            this.cb_raf.TabIndex = 20;
            this.cb_raf.SelectedIndexChanged += new System.EventHandler(this.cb_raf_SelectedIndexChanged);
            // 
            // cb_bol
            // 
            this.cb_bol.FormattingEnabled = true;
            this.cb_bol.Location = new System.Drawing.Point(455, 41);
            this.cb_bol.Name = "cb_bol";
            this.cb_bol.Size = new System.Drawing.Size(121, 21);
            this.cb_bol.TabIndex = 19;
            this.cb_bol.SelectedIndexChanged += new System.EventHandler(this.cb_bol_SelectedIndexChanged);
            // 
            // cb_oda
            // 
            this.cb_oda.FormattingEnabled = true;
            this.cb_oda.Location = new System.Drawing.Point(455, 14);
            this.cb_oda.Name = "cb_oda";
            this.cb_oda.Size = new System.Drawing.Size(121, 21);
            this.cb_oda.TabIndex = 18;
            this.cb_oda.SelectedIndexChanged += new System.EventHandler(this.cb_oda_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(377, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Evrak No";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(375, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Dosya No";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(373, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Klasör No";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(389, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Raf No";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(376, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Bölüm No";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(386, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Oda No";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ch_sec});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(915, 189);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ch_sec
            // 
            this.ch_sec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ch_sec.HeaderText = "Seç";
            this.ch_sec.Name = "ch_sec";
            this.ch_sec.Width = 32;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Location = new System.Drawing.Point(119, 108);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(121, 32);
            this.btn_kaydet.TabIndex = 27;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Visible = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // cob_kata
            // 
            this.cob_kata.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cob_kata.FormattingEnabled = true;
            this.cob_kata.Items.AddRange(new object[] {
            "Oda Düzenle",
            "Bölüm Düzenle",
            "Raf Düzenle",
            "Klasör Düzenle",
            "Dosya Düzenle",
            "Evrak Düzenle"});
            this.cob_kata.Location = new System.Drawing.Point(119, 36);
            this.cob_kata.Name = "cob_kata";
            this.cob_kata.Size = new System.Drawing.Size(121, 26);
            this.cob_kata.TabIndex = 28;
            this.cob_kata.SelectedIndexChanged += new System.EventHandler(this.cob_kata_SelectedIndexChanged);
            // 
            // cob_istu
            // 
            this.cob_istu.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cob_istu.FormattingEnabled = true;
            this.cob_istu.Items.AddRange(new object[] {
            "Ara",
            "Ekle",
            "Erişim Kodu",
            "Güncelle",
            "Sil"});
            this.cob_istu.Location = new System.Drawing.Point(119, 68);
            this.cob_istu.Name = "cob_istu";
            this.cob_istu.Size = new System.Drawing.Size(121, 26);
            this.cob_istu.TabIndex = 29;
            // 
            // txt_oda
            // 
            this.txt_oda.Location = new System.Drawing.Point(582, 14);
            this.txt_oda.Name = "txt_oda";
            this.txt_oda.Size = new System.Drawing.Size(100, 20);
            this.txt_oda.TabIndex = 30;
            // 
            // txt_Bol
            // 
            this.txt_Bol.Location = new System.Drawing.Point(582, 39);
            this.txt_Bol.Name = "txt_Bol";
            this.txt_Bol.Size = new System.Drawing.Size(100, 20);
            this.txt_Bol.TabIndex = 31;
            // 
            // btn_kisi
            // 
            this.btn_kisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_kisi.BackColor = System.Drawing.Color.Transparent;
            this.btn_kisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kisi.ImageKey = "guest.png";
            this.btn_kisi.ImageList = this.ımageList1;
            this.btn_kisi.Location = new System.Drawing.Point(802, 128);
            this.btn_kisi.Name = "btn_kisi";
            this.btn_kisi.Size = new System.Drawing.Size(101, 51);
            this.btn_kisi.TabIndex = 32;
            this.btn_kisi.Text = "Kullanıcı Bilgileri";
            this.btn_kisi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_kisi.UseVisualStyleBackColor = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "guest.png");
            this.ımageList1.Images.SetKeyName(1, "63633.ico");
            this.ımageList1.Images.SetKeyName(2, "istockphoto-1142888921-170667a.jpg");
            // 
            // txt_kla
            // 
            this.txt_kla.Location = new System.Drawing.Point(582, 95);
            this.txt_kla.Name = "txt_kla";
            this.txt_kla.Size = new System.Drawing.Size(100, 20);
            this.txt_kla.TabIndex = 34;
            // 
            // txt_raf
            // 
            this.txt_raf.Location = new System.Drawing.Point(582, 65);
            this.txt_raf.Name = "txt_raf";
            this.txt_raf.Size = new System.Drawing.Size(100, 20);
            this.txt_raf.TabIndex = 33;
            // 
            // txt_evrk
            // 
            this.txt_evrk.Location = new System.Drawing.Point(582, 149);
            this.txt_evrk.Name = "txt_evrk";
            this.txt_evrk.Size = new System.Drawing.Size(100, 20);
            this.txt_evrk.TabIndex = 36;
            // 
            // txt_do
            // 
            this.txt_do.Location = new System.Drawing.Point(582, 123);
            this.txt_do.Name = "txt_do";
            this.txt_do.Size = new System.Drawing.Size(100, 20);
            this.txt_do.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(35, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 18);
            this.label7.TabIndex = 37;
            this.label7.Text = "İşlem Türü ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(54, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 18);
            this.label8.TabIndex = 38;
            this.label8.Text = "Katagori";
            // 
            // btn_ana
            // 
            this.btn_ana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ana.BackColor = System.Drawing.Color.Transparent;
            this.btn_ana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ana.ImageKey = "63633.ico";
            this.btn_ana.ImageList = this.ımageList1;
            this.btn_ana.Location = new System.Drawing.Point(802, 8);
            this.btn_ana.Name = "btn_ana";
            this.btn_ana.Size = new System.Drawing.Size(101, 51);
            this.btn_ana.TabIndex = 39;
            this.btn_ana.Text = "Ana Sayfa";
            this.btn_ana.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ana.UseVisualStyleBackColor = false;
            // 
            // form_gana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(915, 385);
            this.Controls.Add(this.btn_ana);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_evrk);
            this.Controls.Add(this.txt_do);
            this.Controls.Add(this.txt_kla);
            this.Controls.Add(this.txt_raf);
            this.Controls.Add(this.btn_kisi);
            this.Controls.Add(this.txt_Bol);
            this.Controls.Add(this.txt_oda);
            this.Controls.Add(this.cob_istu);
            this.Controls.Add(this.cob_kata);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cb_evrk);
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
            this.Name = "form_gana";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_evrk;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ch_sec;
        private System.Windows.Forms.ComboBox cob_kata;
        private System.Windows.Forms.ComboBox cob_istu;
        private System.Windows.Forms.TextBox txt_oda;
        private System.Windows.Forms.TextBox txt_Bol;
        private System.Windows.Forms.Button btn_kisi;
        public System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.TextBox txt_kla;
        private System.Windows.Forms.TextBox txt_raf;
        private System.Windows.Forms.TextBox txt_evrk;
        private System.Windows.Forms.TextBox txt_do;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_ana;
    }
}