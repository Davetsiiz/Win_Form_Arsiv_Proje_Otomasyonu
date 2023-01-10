namespace Arsiv_proje
{
    partial class DosDuzForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DosDuzForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_yenile = new System.Windows.Forms.Button();
            this.btn_dgguncelle = new System.Windows.Forms.Button();
            this.btn_dgsil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ch_sec = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cb_kla = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_raf = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_do = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_bol = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_oda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_do = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_yenile);
            this.groupBox1.Controls.Add(this.btn_dgguncelle);
            this.groupBox1.Controls.Add(this.btn_dgsil);
            this.groupBox1.Controls.Add(this.btn_guncelle);
            this.groupBox1.Controls.Add(this.btn_ekle);
            this.groupBox1.Controls.Add(this.btn_sil);
            this.groupBox1.Location = new System.Drawing.Point(377, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 90);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlem";
            // 
            // btn_yenile
            // 
            this.btn_yenile.Location = new System.Drawing.Point(11, 48);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(75, 23);
            this.btn_yenile.TabIndex = 40;
            this.btn_yenile.Text = "Yenile";
            this.btn_yenile.UseVisualStyleBackColor = true;
            this.btn_yenile.Click += new System.EventHandler(this.btn_yenile_Click);
            // 
            // btn_dgguncelle
            // 
            this.btn_dgguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dgguncelle.Location = new System.Drawing.Point(179, 49);
            this.btn_dgguncelle.Name = "btn_dgguncelle";
            this.btn_dgguncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_dgguncelle.TabIndex = 1;
            this.btn_dgguncelle.Text = "DG Güncelle";
            this.btn_dgguncelle.UseVisualStyleBackColor = true;
            this.btn_dgguncelle.Click += new System.EventHandler(this.btn_dgguncelle_Click);
            // 
            // btn_dgsil
            // 
            this.btn_dgsil.Location = new System.Drawing.Point(92, 49);
            this.btn_dgsil.Name = "btn_dgsil";
            this.btn_dgsil.Size = new System.Drawing.Size(75, 23);
            this.btn_dgsil.TabIndex = 39;
            this.btn_dgsil.Text = "DG Sil";
            this.btn_dgsil.UseVisualStyleBackColor = true;
            this.btn_dgsil.Click += new System.EventHandler(this.btn_dgsil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(179, 19);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_guncelle.TabIndex = 0;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(11, 20);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 35;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(92, 20);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 36;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ch_sec});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(724, 189);
            this.dataGridView1.TabIndex = 48;
            // 
            // ch_sec
            // 
            this.ch_sec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ch_sec.HeaderText = "Seç";
            this.ch_sec.Name = "ch_sec";
            this.ch_sec.Width = 32;
            // 
            // cb_kla
            // 
            this.cb_kla.FormattingEnabled = true;
            this.cb_kla.Location = new System.Drawing.Point(72, 101);
            this.cb_kla.Name = "cb_kla";
            this.cb_kla.Size = new System.Drawing.Size(121, 21);
            this.cb_kla.TabIndex = 40;
            this.cb_kla.SelectedIndexChanged += new System.EventHandler(this.cb_kla_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 39;
            this.label4.Text = "Klasör No";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_raf
            // 
            this.cb_raf.FormattingEnabled = true;
            this.cb_raf.Location = new System.Drawing.Point(72, 74);
            this.cb_raf.Name = "cb_raf";
            this.cb_raf.Size = new System.Drawing.Size(121, 21);
            this.cb_raf.TabIndex = 38;
            this.cb_raf.SelectedIndexChanged += new System.EventHandler(this.cb_raf_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cb_do);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cb_kla);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cb_raf);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cb_bol);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cb_oda);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_do);
            this.groupBox2.Location = new System.Drawing.Point(12, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 163);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kategori";
            // 
            // cb_do
            // 
            this.cb_do.FormattingEnabled = true;
            this.cb_do.Location = new System.Drawing.Point(72, 128);
            this.cb_do.Name = "cb_do";
            this.cb_do.Size = new System.Drawing.Size(121, 21);
            this.cb_do.TabIndex = 42;
            this.cb_do.SelectedIndexChanged += new System.EventHandler(this.btn_do_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 41;
            this.label5.Text = "Dosya No";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 37;
            this.label3.Text = "Raf No";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_bol
            // 
            this.cb_bol.FormattingEnabled = true;
            this.cb_bol.Location = new System.Drawing.Point(72, 46);
            this.cb_bol.Name = "cb_bol";
            this.cb_bol.Size = new System.Drawing.Size(121, 21);
            this.cb_bol.TabIndex = 36;
            this.cb_bol.SelectedIndexChanged += new System.EventHandler(this.cb_bol_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Bölüm No";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_oda
            // 
            this.cb_oda.FormattingEnabled = true;
            this.cb_oda.Location = new System.Drawing.Point(72, 19);
            this.cb_oda.Name = "cb_oda";
            this.cb_oda.Size = new System.Drawing.Size(121, 21);
            this.cb_oda.TabIndex = 32;
            this.cb_oda.SelectedIndexChanged += new System.EventHandler(this.cb_oda_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Oda No";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_do
            // 
            this.txt_do.Location = new System.Drawing.Point(213, 128);
            this.txt_do.Name = "txt_do";
            this.txt_do.Size = new System.Drawing.Size(121, 20);
            this.txt_do.TabIndex = 34;
            // 
            // DosDuzForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(724, 381);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DosDuzForm";
            this.Text = "Dosya Düzenleme";
            this.Load += new System.EventHandler(this.DosDuzForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_yenile;
        private System.Windows.Forms.Button btn_dgguncelle;
        private System.Windows.Forms.Button btn_dgsil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ch_sec;
        private System.Windows.Forms.ComboBox cb_kla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_raf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_do;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_bol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_oda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_do;
    }
}