namespace PROJE
{
    partial class GenelListe
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
            this.lblGenLis = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnGeri5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGenLis
            // 
            this.lblGenLis.AutoSize = true;
            this.lblGenLis.Font = new System.Drawing.Font("Elephant", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenLis.Location = new System.Drawing.Point(12, 27);
            this.lblGenLis.Name = "lblGenLis";
            this.lblGenLis.Size = new System.Drawing.Size(328, 47);
            this.lblGenLis.TabIndex = 2;
            this.lblGenLis.Text = "GENEL LİSTE";
            // 
            // dataGridView3
            // 
            this.dataGridView3.Location = new System.Drawing.Point(20, 77);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1144, 291);
            this.dataGridView3.TabIndex = 6;
            this.dataGridView3.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellDoubleClick);

            // 
            // btnGeri5
            // 
            this.btnGeri5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeri5.Location = new System.Drawing.Point(1602, 643);
            this.btnGeri5.Name = "btnGeri5";
            this.btnGeri5.Size = new System.Drawing.Size(204, 78);
            this.btnGeri5.TabIndex = 20;
            this.btnGeri5.Text = "Geri";
            this.btnGeri5.UseVisualStyleBackColor = true;
            this.btnGeri5.Click += new System.EventHandler(this.btnGeri5_Click);
            // 
            // GenelListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1818, 733);
            this.Controls.Add(this.btnGeri5);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.lblGenLis);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenelListe";
            this.Text = "Genel Liste";
            this.Load += new System.EventHandler(this.GenelListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGenLis;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnGeri5;
    }
}