namespace SOHATS
{
    partial class DoktorTanimlariForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblDoktorKodu = new System.Windows.Forms.Label();
            this.txtDoktorKodu = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblUnvan = new System.Windows.Forms.Label();
            this.cmbUnvan = new System.Windows.Forms.ComboBox();
            this.chkAktif = new System.Windows.Forms.CheckBox();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.dgvDoktorlar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoktorlar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDoktorKodu
            // 
            this.lblDoktorKodu.AutoSize = true;
            this.lblDoktorKodu.Location = new System.Drawing.Point(15, 18);
            this.lblDoktorKodu.Name = "lblDoktorKodu";
            this.lblDoktorKodu.Size = new System.Drawing.Size(74, 15);
            this.lblDoktorKodu.TabIndex = 0;
            this.lblDoktorKodu.Text = "Doktor Kodu";
            // 
            // txtDoktorKodu
            // 
            this.txtDoktorKodu.Location = new System.Drawing.Point(100, 15);
            this.txtDoktorKodu.Name = "txtDoktorKodu";
            this.txtDoktorKodu.Size = new System.Drawing.Size(100, 23);
            this.txtDoktorKodu.TabIndex = 1;
            this.txtDoktorKodu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDoktorKodu_KeyDown);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(15, 48);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(21, 15);
            this.lblAd.TabIndex = 2;
            this.lblAd.Text = "Ad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(100, 45);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(150, 23);
            this.txtAd.TabIndex = 3;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(15, 78);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(40, 15);
            this.lblSoyad.TabIndex = 4;
            this.lblSoyad.Text = "Soyad";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(100, 75);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(150, 23);
            this.txtSoyad.TabIndex = 5;
            // 
            // lblUnvan
            // 
            this.lblUnvan.AutoSize = true;
            this.lblUnvan.Location = new System.Drawing.Point(15, 108);
            this.lblUnvan.Name = "lblUnvan";
            this.lblUnvan.Size = new System.Drawing.Size(41, 15);
            this.lblUnvan.TabIndex = 6;
            this.lblUnvan.Text = "Ünvan";
            // 
            // cmbUnvan
            // 
            this.cmbUnvan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnvan.FormattingEnabled = true;
            this.cmbUnvan.Items.AddRange(new object[] { "Dr.", "Uzm. Dr.", "Doç. Dr.", "Prof. Dr." });
            this.cmbUnvan.Location = new System.Drawing.Point(100, 105);
            this.cmbUnvan.Name = "cmbUnvan";
            this.cmbUnvan.Size = new System.Drawing.Size(150, 23);
            this.cmbUnvan.TabIndex = 7;
            // 
            // chkAktif
            // 
            this.chkAktif.AutoSize = true;
            this.chkAktif.Checked = true;
            this.chkAktif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAktif.Location = new System.Drawing.Point(100, 135);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Size = new System.Drawing.Size(49, 19);
            this.chkAktif.TabIndex = 8;
            this.chkAktif.Text = "Aktif";
            this.chkAktif.UseVisualStyleBackColor = true;
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(15, 170);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(70, 25);
            this.btnYeni.TabIndex = 9;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.BtnYeni_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(90, 170);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(70, 25);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.Location = new System.Drawing.Point(165, 170);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(70, 25);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(240, 170);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(70, 25);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(500, 170);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(70, 25);
            this.btnKapat.TabIndex = 13;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // dgvDoktorlar
            // 
            this.dgvDoktorlar.AllowUserToAddRows = false;
            this.dgvDoktorlar.AllowUserToDeleteRows = false;
            this.dgvDoktorlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoktorlar.Location = new System.Drawing.Point(15, 205);
            this.dgvDoktorlar.Name = "dgvDoktorlar";
            this.dgvDoktorlar.ReadOnly = true;
            this.dgvDoktorlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoktorlar.Size = new System.Drawing.Size(555, 200);
            this.dgvDoktorlar.TabIndex = 14;
            this.dgvDoktorlar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDoktorlar_CellDoubleClick);
            // 
            // DoktorTanimlariForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.dgvDoktorlar);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.chkAktif);
            this.Controls.Add(this.cmbUnvan);
            this.Controls.Add(this.lblUnvan);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.txtDoktorKodu);
            this.Controls.Add(this.lblDoktorKodu);
            this.Name = "DoktorTanimlariForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SOHATS - Doktor Tanıtma";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoktorlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblDoktorKodu;
        private System.Windows.Forms.TextBox txtDoktorKodu;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblUnvan;
        private System.Windows.Forms.ComboBox cmbUnvan;
        private System.Windows.Forms.CheckBox chkAktif;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.DataGridView dgvDoktorlar;
    }
}
