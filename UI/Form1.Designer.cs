namespace OBUZ_ILETISIM
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
            this.btnÜrünler = new System.Windows.Forms.Button();
            this.btnTamir = new System.Windows.Forms.Button();
            this.btnKontör = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPersonelGiriş = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnÜrünler
            // 
            this.btnÜrünler.Location = new System.Drawing.Point(41, 69);
            this.btnÜrünler.Name = "btnÜrünler";
            this.btnÜrünler.Size = new System.Drawing.Size(205, 48);
            this.btnÜrünler.TabIndex = 2;
            this.btnÜrünler.Text = "Ürünlerimiz";
            this.btnÜrünler.UseVisualStyleBackColor = true;
            this.btnÜrünler.Click += new System.EventHandler(this.btnÜrünler_Click);
            // 
            // btnTamir
            // 
            this.btnTamir.Location = new System.Drawing.Point(252, 69);
            this.btnTamir.Name = "btnTamir";
            this.btnTamir.Size = new System.Drawing.Size(205, 48);
            this.btnTamir.TabIndex = 3;
            this.btnTamir.Text = "Tamir / İşlem";
            this.btnTamir.UseVisualStyleBackColor = true;
            this.btnTamir.Click += new System.EventHandler(this.btnTamir_Click);
            // 
            // btnKontör
            // 
            this.btnKontör.Location = new System.Drawing.Point(463, 69);
            this.btnKontör.Name = "btnKontör";
            this.btnKontör.Size = new System.Drawing.Size(205, 48);
            this.btnKontör.TabIndex = 4;
            this.btnKontör.Text = "Kontör Yükle";
            this.btnKontör.UseVisualStyleBackColor = true;
            this.btnKontör.Click += new System.EventHandler(this.btnKontör_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "OBUZ İLETİŞİME HOŞGELDİNİZ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(899, 303);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnPersonelGiriş
            // 
            this.btnPersonelGiriş.Location = new System.Drawing.Point(674, 69);
            this.btnPersonelGiriş.Name = "btnPersonelGiriş";
            this.btnPersonelGiriş.Size = new System.Drawing.Size(205, 48);
            this.btnPersonelGiriş.TabIndex = 7;
            this.btnPersonelGiriş.Text = "Personel Giriş";
            this.btnPersonelGiriş.UseVisualStyleBackColor = true;
            this.btnPersonelGiriş.Click += new System.EventHandler(this.btnPersonelGiriş_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 448);
            this.Controls.Add(this.btnPersonelGiriş);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKontör);
            this.Controls.Add(this.btnTamir);
            this.Controls.Add(this.btnÜrünler);
            this.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "OBUZ İLETİŞİM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnÜrünler;
        private System.Windows.Forms.Button btnTamir;
        private System.Windows.Forms.Button btnKontör;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPersonelGiriş;
    }
}

