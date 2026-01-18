namespace SOHATS
{
    partial class HastaAramaForm
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
            this.dgvHastalar = new System.Windows.Forms.DataGridView();
            this.btnSec = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHastalar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArama
            // 
            this.lblArama.AutoSize = true;
            this.lblArama.Location = new System.Drawing.Point(20, 20);
            this.lblArama.Name = "lblArama";
            this.lblArama.Size = new System.Drawing.Size(44, 15);
            this.lblArama.TabIndex = 0;
            this.lblArama.Text = "Arama:";
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(70, 17);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(200, 23);
            this.txtArama.TabIndex = 1;
            this.txtArama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtArama_KeyDown);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(280, 15);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(70, 25);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // dgvHastalar
            // 
            this.dgvHastalar.AllowUserToAddRows = false;
            this.dgvHastalar.AllowUserToDeleteRows = false;
            this.dgvHastalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHastalar.Location = new System.Drawing.Point(20, 55);
            this.dgvHastalar.Name = "dgvHastalar";
            this.dgvHastalar.ReadOnly = true;
            this.dgvHastalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHastalar.Size = new System.Drawing.Size(645, 350);
            this.dgvHastalar.TabIndex = 3;
            this.dgvHastalar.DoubleClick += new System.EventHandler(this.DgvHastalar_DoubleClick);
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(500, 420);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(70, 28);
            this.btnSec.TabIndex = 4;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.BtnSec_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(580, 420);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(70, 28);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // HastaAramaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.dgvHastalar);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.lblArama);
            this.Name = "HastaAramaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SOHATS - Hasta Arama";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHastalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblArama;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DataGridView dgvHastalar;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Button btnKapat;
    }
}
