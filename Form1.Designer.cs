namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblvize = new System.Windows.Forms.Label();
            this.lblfinal = new System.Windows.Forms.Label();
            this.txtvize = new System.Windows.Forms.TextBox();
            this.txtfinal = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.lblortalama = new System.Windows.Forms.Label();
            this.lblharf1 = new System.Windows.Forms.Label();
            this.lblort = new System.Windows.Forms.Label();
            this.lblharf = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vize Final Ortalama Hesaplama";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn);
            this.panel1.Controls.Add(this.txtfinal);
            this.panel1.Controls.Add(this.txtvize);
            this.panel1.Controls.Add(this.lblfinal);
            this.panel1.Controls.Add(this.lblvize);
            this.panel1.Location = new System.Drawing.Point(6, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblharf);
            this.panel2.Controls.Add(this.lblort);
            this.panel2.Controls.Add(this.lblharf1);
            this.panel2.Controls.Add(this.lblortalama);
            this.panel2.Location = new System.Drawing.Point(6, 151);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 100);
            this.panel2.TabIndex = 1;
            // 
            // lblvize
            // 
            this.lblvize.AutoSize = true;
            this.lblvize.Location = new System.Drawing.Point(39, 12);
            this.lblvize.Name = "lblvize";
            this.lblvize.Size = new System.Drawing.Size(56, 13);
            this.lblvize.TabIndex = 0;
            this.lblvize.Text = "Vize Notu:";
            // 
            // lblfinal
            // 
            this.lblfinal.AutoSize = true;
            this.lblfinal.Location = new System.Drawing.Point(37, 40);
            this.lblfinal.Name = "lblfinal";
            this.lblfinal.Size = new System.Drawing.Size(58, 13);
            this.lblfinal.TabIndex = 1;
            this.lblfinal.Text = "Final Notu:";
            // 
            // txtvize
            // 
            this.txtvize.Location = new System.Drawing.Point(123, 5);
            this.txtvize.Name = "txtvize";
            this.txtvize.Size = new System.Drawing.Size(100, 20);
            this.txtvize.TabIndex = 2;
            this.txtvize.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtfinal
            // 
            this.txtfinal.Location = new System.Drawing.Point(123, 33);
            this.txtfinal.Name = "txtfinal";
            this.txtfinal.Size = new System.Drawing.Size(100, 20);
            this.txtfinal.TabIndex = 3;
            // 
            // btn
            // 
            this.btn.ForeColor = System.Drawing.Color.Black;
            this.btn.Location = new System.Drawing.Point(137, 59);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 4;
            this.btn.Text = "HESAPLA";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lblortalama
            // 
            this.lblortalama.AutoSize = true;
            this.lblortalama.Location = new System.Drawing.Point(43, 15);
            this.lblortalama.Name = "lblortalama";
            this.lblortalama.Size = new System.Drawing.Size(52, 13);
            this.lblortalama.TabIndex = 1;
            this.lblortalama.Text = "Ortalama:";
            // 
            // lblharf1
            // 
            this.lblharf1.AutoSize = true;
            this.lblharf1.Location = new System.Drawing.Point(39, 41);
            this.lblharf1.Name = "lblharf1";
            this.lblharf1.Size = new System.Drawing.Size(56, 13);
            this.lblharf1.TabIndex = 2;
            this.lblharf1.Text = "Harf Notu:";
            // 
            // lblort
            // 
            this.lblort.AutoSize = true;
            this.lblort.Location = new System.Drawing.Point(120, 15);
            this.lblort.Name = "lblort";
            this.lblort.Size = new System.Drawing.Size(19, 13);
            this.lblort.TabIndex = 3;
            this.lblort.Text = "60";
            // 
            // lblharf
            // 
            this.lblharf.AutoSize = true;
            this.lblharf.Location = new System.Drawing.Point(120, 41);
            this.lblharf.Name = "lblharf";
            this.lblharf.Size = new System.Drawing.Size(21, 13);
            this.lblharf.TabIndex = 4;
            this.lblharf.Text = "CC";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 286);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtfinal;
        private System.Windows.Forms.TextBox txtvize;
        private System.Windows.Forms.Label lblfinal;
        private System.Windows.Forms.Label lblvize;
        private System.Windows.Forms.Label lblharf;
        private System.Windows.Forms.Label lblort;
        private System.Windows.Forms.Label lblharf1;
        private System.Windows.Forms.Label lblortalama;
        private System.Windows.Forms.Button btn;
    }
}

