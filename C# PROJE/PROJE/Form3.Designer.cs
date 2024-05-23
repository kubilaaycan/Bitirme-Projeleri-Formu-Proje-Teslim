namespace PROJE
{
    partial class BaskentAkadm
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
            this.lblAkadm = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAkadm
            // 
            this.lblAkadm.AutoSize = true;
            this.lblAkadm.Font = new System.Drawing.Font("Elephant", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAkadm.Location = new System.Drawing.Point(12, 23);
            this.lblAkadm.Name = "lblAkadm";
            this.lblAkadm.Size = new System.Drawing.Size(1019, 47);
            this.lblAkadm.TabIndex = 1;
            this.lblAkadm.Text = "BAŞKENT ÜNİVERSİTESİ AKADEMİSYENLER";
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeri.Location = new System.Drawing.Point(1370, 637);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(204, 78);
            this.btnGeri.TabIndex = 2;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(20, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 291);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BaskentAkadm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1586, 727);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lblAkadm);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaskentAkadm";
            this.Text = "Akademisyenler";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAkadm;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}