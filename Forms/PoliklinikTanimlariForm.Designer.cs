namespace SOHATS
{
    partial class PoliklinikTanimlariForm
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
            this.lblPoliklinikAdi = new System.Windows.Forms.Label();
            this.txtPoliklinikAdi = new System.Windows.Forms.TextBox();
            this.chkGecerli = new System.Windows.Forms.CheckBox();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.dgvPoliklinikler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoliklinikler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPoliklinikAdi
            // 
            this.lblPoliklinikAdi.AutoSize = true;
            this.lblPoliklinikAdi.Location = new System.Drawing.Point(20, 23);
            this.lblPoliklinikAdi.Name = "lblPoliklinikAdi";
            this.lblPoliklinikAdi.Size = new System.Drawing.Size(77, 15);
            this.lblPoliklinikAdi.TabIndex = 0;
            this.lblPoliklinikAdi.Text = "Poliklinik Adı";
            // 
            // txtPoliklinikAdi
            // 
            this.txtPoliklinikAdi.Location = new System.Drawing.Point(110, 20);
            this.txtPoliklinikAdi.Name = "txtPoliklinikAdi";
            this.txtPoliklinikAdi.Size = new System.Drawing.Size(200, 23);
            this.txtPoliklinikAdi.TabIndex = 1;
            this.txtPoliklinikAdi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPoliklinikAdi_KeyDown);
            // 
            // chkGecerli
            // 
            this.chkGecerli.AutoSize = true;
            this.chkGecerli.Checked = true;
            this.chkGecerli.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGecerli.Location = new System.Drawing.Point(110, 55);
            this.chkGecerli.Name = "chkGecerli";
            this.chkGecerli.Size = new System.Drawing.Size(117, 19);
            this.chkGecerli.TabIndex = 2;
            this.chkGecerli.Text = "Geçerli / Geçersiz";
            this.chkGecerli.UseVisualStyleBackColor = true;
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(20, 95);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(65, 25);
            this.btnYeni.TabIndex = 3;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.BtnYeni_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(90, 95);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(65, 25);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.Location = new System.Drawing.Point(160, 95);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(65, 25);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(230, 95);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(65, 25);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(310, 95);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(60, 25);
            this.btnKapat.TabIndex = 7;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // dgvPoliklinikler
            // 
            this.dgvPoliklinikler.AllowUserToAddRows = false;
            this.dgvPoliklinikler.AllowUserToDeleteRows = false;
            this.dgvPoliklinikler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPoliklinikler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoliklinikler.Location = new System.Drawing.Point(20, 130);
            this.dgvPoliklinikler.Name = "dgvPoliklinikler";
            this.dgvPoliklinikler.ReadOnly = true;
            this.dgvPoliklinikler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPoliklinikler.Size = new System.Drawing.Size(350, 170);
            this.dgvPoliklinikler.TabIndex = 8;
            this.dgvPoliklinikler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPoliklinikler_CellDoubleClick);
            // 
            // PoliklinikTanimlariForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.dgvPoliklinikler);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.chkGecerli);
            this.Controls.Add(this.txtPoliklinikAdi);
            this.Controls.Add(this.lblPoliklinikAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PoliklinikTanimlariForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SOHATS - Poliklinik Tanıtma";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoliklinikler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPoliklinikAdi;
        private System.Windows.Forms.TextBox txtPoliklinikAdi;
        private System.Windows.Forms.CheckBox chkGecerli;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.DataGridView dgvPoliklinikler;
    }
}
