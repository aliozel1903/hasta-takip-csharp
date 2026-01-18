namespace SOHATS
{
    partial class DosyaAramaYardimiForm
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
            this.lblArama = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.dgvSonuclar = new System.Windows.Forms.DataGridView();
            this.btnSec = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonuclar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArama
            // 
            this.lblArama.AutoSize = true;
            this.lblArama.Location = new System.Drawing.Point(20, 20);
            this.lblArama.Name = "lblArama";
            this.lblArama.Size = new System.Drawing.Size(120, 15);
            this.lblArama.TabIndex = 0;
            this.lblArama.Text = "Ad/Soyad/TC ile Ara:";
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(150, 17);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(200, 23);
            this.txtArama.TabIndex = 1;
            this.txtArama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtArama_KeyDown);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(360, 15);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(70, 27);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // dgvSonuclar
            // 
            this.dgvSonuclar.AllowUserToAddRows = false;
            this.dgvSonuclar.AllowUserToDeleteRows = false;
            this.dgvSonuclar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSonuclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSonuclar.Location = new System.Drawing.Point(20, 60);
            this.dgvSonuclar.MultiSelect = false;
            this.dgvSonuclar.Name = "dgvSonuclar";
            this.dgvSonuclar.ReadOnly = true;
            this.dgvSonuclar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSonuclar.Size = new System.Drawing.Size(645, 280);
            this.dgvSonuclar.TabIndex = 3;
            this.dgvSonuclar.DoubleClick += new System.EventHandler(this.DgvSonuclar_DoubleClick);
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(490, 360);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(80, 30);
            this.btnSec.TabIndex = 4;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.BtnSec_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(585, 360);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(80, 30);
            this.btnIptal.TabIndex = 5;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.BtnIptal_Click);
            // 
            // DosyaAramaYardimiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.dgvSonuclar);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.lblArama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DosyaAramaYardimiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dosya Arama Yardımı";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonuclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblArama;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DataGridView dgvSonuclar;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Button btnIptal;
    }
}
