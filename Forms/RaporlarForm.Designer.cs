namespace SOHATS
{
    partial class RaporlarForm
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
            this.lblBaslangicTarihi = new System.Windows.Forms.Label();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.lblBitisTarihi = new System.Windows.Forms.Label();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.rbTaburcuOlmus = new System.Windows.Forms.RadioButton();
            this.rbTaburcuOlmamis = new System.Windows.Forms.RadioButton();
            this.rbHepsi = new System.Windows.Forms.RadioButton();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.dgvSonuclar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonuclar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslangicTarihi
            // 
            this.lblBaslangicTarihi.AutoSize = true;
            this.lblBaslangicTarihi.Location = new System.Drawing.Point(15, 18);
            this.lblBaslangicTarihi.Name = "lblBaslangicTarihi";
            this.lblBaslangicTarihi.Size = new System.Drawing.Size(89, 15);
            this.lblBaslangicTarihi.TabIndex = 0;
            this.lblBaslangicTarihi.Text = "Başlangıç tarihi";
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBaslangic.Location = new System.Drawing.Point(110, 15);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(100, 23);
            this.dtpBaslangic.TabIndex = 1;
            // 
            // lblBitisTarihi
            // 
            this.lblBitisTarihi.AutoSize = true;
            this.lblBitisTarihi.Location = new System.Drawing.Point(230, 18);
            this.lblBitisTarihi.Name = "lblBitisTarihi";
            this.lblBitisTarihi.Size = new System.Drawing.Size(58, 15);
            this.lblBitisTarihi.TabIndex = 2;
            this.lblBitisTarihi.Text = "Bitiş tarihi";
            // 
            // dtpBitis
            // 
            this.dtpBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBitis.Location = new System.Drawing.Point(300, 15);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(100, 23);
            this.dtpBitis.TabIndex = 3;
            // 
            // rbTaburcuOlmus
            // 
            this.rbTaburcuOlmus.AutoSize = true;
            this.rbTaburcuOlmus.Location = new System.Drawing.Point(430, 15);
            this.rbTaburcuOlmus.Name = "rbTaburcuOlmus";
            this.rbTaburcuOlmus.Size = new System.Drawing.Size(102, 19);
            this.rbTaburcuOlmus.TabIndex = 4;
            this.rbTaburcuOlmus.Text = "Taburcu olmuş";
            this.rbTaburcuOlmus.UseVisualStyleBackColor = true;
            // 
            // rbTaburcuOlmamis
            // 
            this.rbTaburcuOlmamis.AutoSize = true;
            this.rbTaburcuOlmamis.Location = new System.Drawing.Point(540, 15);
            this.rbTaburcuOlmamis.Name = "rbTaburcuOlmamis";
            this.rbTaburcuOlmamis.Size = new System.Drawing.Size(118, 19);
            this.rbTaburcuOlmamis.TabIndex = 5;
            this.rbTaburcuOlmamis.Text = "Taburcu olmamış";
            this.rbTaburcuOlmamis.UseVisualStyleBackColor = true;
            // 
            // rbHepsi
            // 
            this.rbHepsi.AutoSize = true;
            this.rbHepsi.Checked = true;
            this.rbHepsi.Location = new System.Drawing.Point(670, 15);
            this.rbHepsi.Name = "rbHepsi";
            this.rbHepsi.Size = new System.Drawing.Size(54, 19);
            this.rbHepsi.TabIndex = 6;
            this.rbHepsi.TabStop = true;
            this.rbHepsi.Text = "Hepsi";
            this.rbHepsi.UseVisualStyleBackColor = true;
            // 
            // btnSorgula
            // 
            this.btnSorgula.Location = new System.Drawing.Point(430, 50);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(70, 25);
            this.btnSorgula.TabIndex = 7;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.BtnSorgula_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(510, 50);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(70, 25);
            this.btnTemizle.TabIndex = 8;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(590, 50);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(70, 25);
            this.btnYazdir.TabIndex = 9;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.BtnYazdir_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(800, 50);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(70, 25);
            this.btnCikis.TabIndex = 10;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // dgvSonuclar
            // 
            this.dgvSonuclar.AllowUserToAddRows = false;
            this.dgvSonuclar.AllowUserToDeleteRows = false;
            this.dgvSonuclar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSonuclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSonuclar.Location = new System.Drawing.Point(15, 90);
            this.dgvSonuclar.Name = "dgvSonuclar";
            this.dgvSonuclar.ReadOnly = true;
            this.dgvSonuclar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSonuclar.Size = new System.Drawing.Size(855, 400);
            this.dgvSonuclar.TabIndex = 11;
            // 
            // RaporlarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.dgvSonuclar);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.rbHepsi);
            this.Controls.Add(this.rbTaburcuOlmamis);
            this.Controls.Add(this.rbTaburcuOlmus);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.lblBitisTarihi);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.lblBaslangicTarihi);
            this.Name = "RaporlarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SOHATS Raporlar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonuclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblBaslangicTarihi;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.Label lblBitisTarihi;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.RadioButton rbTaburcuOlmus;
        private System.Windows.Forms.RadioButton rbTaburcuOlmamis;
        private System.Windows.Forms.RadioButton rbHepsi;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.DataGridView dgvSonuclar;
    }
}
