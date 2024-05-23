namespace PROJE
{
    partial class Ogrenciler
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
            this.lblOgrenciler = new System.Windows.Forms.Label();
            this.btnGeri2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOgrenciler
            // 
            this.lblOgrenciler.AutoSize = true;
            this.lblOgrenciler.Font = new System.Drawing.Font("Elephant", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOgrenciler.Location = new System.Drawing.Point(12, 57);
            this.lblOgrenciler.Name = "lblOgrenciler";
            this.lblOgrenciler.Size = new System.Drawing.Size(332, 47);
            this.lblOgrenciler.TabIndex = 2;
            this.lblOgrenciler.Text = "ÖĞRENCİLER";
            // 
            // btnGeri2
            // 
            this.btnGeri2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeri2.Location = new System.Drawing.Point(1587, 640);
            this.btnGeri2.Name = "btnGeri2";
            this.btnGeri2.Size = new System.Drawing.Size(204, 78);
            this.btnGeri2.TabIndex = 4;
            this.btnGeri2.Text = "Geri";
            this.btnGeri2.UseVisualStyleBackColor = true;
            this.btnGeri2.Click += new System.EventHandler(this.btnGeri2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Location = new System.Drawing.Point(20, 107);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(345, 291);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Ogrenciler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1803, 730);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnGeri2);
            this.Controls.Add(this.lblOgrenciler);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ogrenciler";
            this.Text = "Öğrenciler";
            this.Load += new System.EventHandler(this.Ogrenciler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOgrenciler;
        private System.Windows.Forms.Button btnGeri2;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}