namespace OBUZ_ILETISIM
{
    partial class Tamir
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTamirID = new System.Windows.Forms.TextBox();
            this.txtUrünIsim = new System.Windows.Forms.TextBox();
            this.txtUrünKimlikNo = new System.Windows.Forms.TextBox();
            this.txtUrünMarka = new System.Windows.Forms.TextBox();
            this.txtTamirSebep = new System.Windows.Forms.TextBox();
            this.btnTamirEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtMüşteriTel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Bilgilerini Giriniz ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "TamirID : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Kimlik No : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ürün İsmi : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ürün Marka : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tamir Sebep : ";
            // 
            // txtTamirID
            // 
            this.txtTamirID.Enabled = false;
            this.txtTamirID.Location = new System.Drawing.Point(168, 80);
            this.txtTamirID.Name = "txtTamirID";
            this.txtTamirID.Size = new System.Drawing.Size(234, 34);
            this.txtTamirID.TabIndex = 6;
            // 
            // txtUrünIsim
            // 
            this.txtUrünIsim.Location = new System.Drawing.Point(168, 181);
            this.txtUrünIsim.Name = "txtUrünIsim";
            this.txtUrünIsim.Size = new System.Drawing.Size(234, 34);
            this.txtUrünIsim.TabIndex = 8;
            // 
            // txtUrünKimlikNo
            // 
            this.txtUrünKimlikNo.Location = new System.Drawing.Point(168, 129);
            this.txtUrünKimlikNo.Name = "txtUrünKimlikNo";
            this.txtUrünKimlikNo.Size = new System.Drawing.Size(234, 34);
            this.txtUrünKimlikNo.TabIndex = 9;
            // 
            // txtUrünMarka
            // 
            this.txtUrünMarka.Location = new System.Drawing.Point(168, 235);
            this.txtUrünMarka.Name = "txtUrünMarka";
            this.txtUrünMarka.Size = new System.Drawing.Size(234, 34);
            this.txtUrünMarka.TabIndex = 10;
            // 
            // txtTamirSebep
            // 
            this.txtTamirSebep.Location = new System.Drawing.Point(168, 284);
            this.txtTamirSebep.Name = "txtTamirSebep";
            this.txtTamirSebep.Size = new System.Drawing.Size(234, 34);
            this.txtTamirSebep.TabIndex = 11;
            // 
            // btnTamirEkle
            // 
            this.btnTamirEkle.Location = new System.Drawing.Point(12, 385);
            this.btnTamirEkle.Name = "btnTamirEkle";
            this.btnTamirEkle.Size = new System.Drawing.Size(390, 42);
            this.btnTamirEkle.TabIndex = 12;
            this.btnTamirEkle.Text = "Sıraya Ekle";
            this.btnTamirEkle.UseVisualStyleBackColor = true;
            this.btnTamirEkle.Click += new System.EventHandler(this.btnTamirEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(408, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(657, 347);
            this.dataGridView1.TabIndex = 13;
            // 
            // txtMüşteriTel
            // 
            this.txtMüşteriTel.Location = new System.Drawing.Point(168, 339);
            this.txtMüşteriTel.Name = "txtMüşteriTel";
            this.txtMüşteriTel.Size = new System.Drawing.Size(234, 34);
            this.txtMüşteriTel.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 28);
            this.label7.TabIndex = 14;
            this.label7.Text = "Müşteri Tel : ";
            // 
            // Tamir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 439);
            this.Controls.Add(this.txtMüşteriTel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTamirEkle);
            this.Controls.Add(this.txtTamirSebep);
            this.Controls.Add(this.txtUrünMarka);
            this.Controls.Add(this.txtUrünKimlikNo);
            this.Controls.Add(this.txtUrünIsim);
            this.Controls.Add(this.txtTamirID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Tamir";
            this.Text = "Tamir";
            this.Load += new System.EventHandler(this.Tamir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTamirID;
        private System.Windows.Forms.TextBox txtUrünIsim;
        private System.Windows.Forms.TextBox txtUrünKimlikNo;
        private System.Windows.Forms.TextBox txtUrünMarka;
        private System.Windows.Forms.TextBox txtTamirSebep;
        private System.Windows.Forms.Button btnTamirEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMüşteriTel;
        private System.Windows.Forms.Label label7;
    }
}