namespace PROJE
{
    partial class BPYS
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
            this.lblBPBPYS = new System.Windows.Forms.Label();
            this.btnAkadm = new System.Windows.Forms.Button();
            this.btnBtrPrj = new System.Windows.Forms.Button();
            this.btnGnlLst = new System.Windows.Forms.Button();
            this.btnOgr = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBPBPYS
            // 
            this.lblBPBPYS.AutoSize = true;
            this.lblBPBPYS.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBPBPYS.Location = new System.Drawing.Point(476, 297);
            this.lblBPBPYS.Name = "lblBPBPYS";
            this.lblBPBPYS.Size = new System.Drawing.Size(767, 39);
            this.lblBPBPYS.TabIndex = 0;
            this.lblBPBPYS.Text = "Bilgisayar Programcılığı Bitirme Projeleri Yönetim Sistemi";
            // 
            // btnAkadm
            // 
            this.btnAkadm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAkadm.Location = new System.Drawing.Point(483, 351);
            this.btnAkadm.Name = "btnAkadm";
            this.btnAkadm.Size = new System.Drawing.Size(165, 52);
            this.btnAkadm.TabIndex = 1;
            this.btnAkadm.Text = "Akademisyenler";
            this.btnAkadm.UseVisualStyleBackColor = true;
            this.btnAkadm.Click += new System.EventHandler(this.btnAkadm_Click);
            // 
            // btnBtrPrj
            // 
            this.btnBtrPrj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBtrPrj.Location = new System.Drawing.Point(483, 451);
            this.btnBtrPrj.Name = "btnBtrPrj";
            this.btnBtrPrj.Size = new System.Drawing.Size(165, 52);
            this.btnBtrPrj.TabIndex = 1;
            this.btnBtrPrj.Text = "Bitirme Projeleri";
            this.btnBtrPrj.UseVisualStyleBackColor = true;
            this.btnBtrPrj.Click += new System.EventHandler(this.btnBtrPrj_Click);
            // 
            // btnGnlLst
            // 
            this.btnGnlLst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGnlLst.Location = new System.Drawing.Point(1078, 451);
            this.btnGnlLst.Name = "btnGnlLst";
            this.btnGnlLst.Size = new System.Drawing.Size(165, 52);
            this.btnGnlLst.TabIndex = 1;
            this.btnGnlLst.Text = "Genel Liste";
            this.btnGnlLst.UseVisualStyleBackColor = true;
            this.btnGnlLst.Click += new System.EventHandler(this.btnGnlLst_Click);
            // 
            // btnOgr
            // 
            this.btnOgr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOgr.Location = new System.Drawing.Point(1078, 351);
            this.btnOgr.Name = "btnOgr";
            this.btnOgr.Size = new System.Drawing.Size(165, 52);
            this.btnOgr.TabIndex = 1;
            this.btnOgr.Text = "Öğrenciler";
            this.btnOgr.UseVisualStyleBackColor = true;
            this.btnOgr.Click += new System.EventHandler(this.btnOgr_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikis.Location = new System.Drawing.Point(807, 392);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(113, 52);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // BPYS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1635, 846);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGnlLst);
            this.Controls.Add(this.btnBtrPrj);
            this.Controls.Add(this.btnOgr);
            this.Controls.Add(this.btnAkadm);
            this.Controls.Add(this.lblBPBPYS);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BPYS";
            this.Text = "BPYS";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBPBPYS;
        private System.Windows.Forms.Button btnAkadm;
        private System.Windows.Forms.Button btnBtrPrj;
        private System.Windows.Forms.Button btnGnlLst;
        private System.Windows.Forms.Button btnOgr;
        private System.Windows.Forms.Button btnCikis;
    }
}