
namespace Transkript_Ödev2
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
            this.Transkript_dataGridView = new System.Windows.Forms.DataGridView();
            this.KayıtEkle_button = new System.Windows.Forms.Button();
            this.KayıtGüncelle_button = new System.Windows.Forms.Button();
            this.KayıtSil_button = new System.Windows.Forms.Button();
            this.GNOHesapla_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.KayıtGöster_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Transkript_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Transkript_dataGridView
            // 
            this.Transkript_dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Transkript_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Transkript_dataGridView.Location = new System.Drawing.Point(0, 26);
            this.Transkript_dataGridView.Name = "Transkript_dataGridView";
            this.Transkript_dataGridView.RowHeadersWidth = 51;
            this.Transkript_dataGridView.RowTemplate.Height = 24;
            this.Transkript_dataGridView.Size = new System.Drawing.Size(798, 225);
            this.Transkript_dataGridView.TabIndex = 0;
            // 
            // KayıtEkle_button
            // 
            this.KayıtEkle_button.BackColor = System.Drawing.Color.LawnGreen;
            this.KayıtEkle_button.Location = new System.Drawing.Point(82, 86);
            this.KayıtEkle_button.Name = "KayıtEkle_button";
            this.KayıtEkle_button.Size = new System.Drawing.Size(163, 55);
            this.KayıtEkle_button.TabIndex = 1;
            this.KayıtEkle_button.Text = "Kayıt Ekle:";
            this.KayıtEkle_button.UseVisualStyleBackColor = false;
            this.KayıtEkle_button.Click += new System.EventHandler(this.KayıtEkle_button_Click);
            // 
            // KayıtGüncelle_button
            // 
            this.KayıtGüncelle_button.BackColor = System.Drawing.Color.LawnGreen;
            this.KayıtGüncelle_button.Location = new System.Drawing.Point(85, 236);
            this.KayıtGüncelle_button.Name = "KayıtGüncelle_button";
            this.KayıtGüncelle_button.Size = new System.Drawing.Size(160, 55);
            this.KayıtGüncelle_button.TabIndex = 2;
            this.KayıtGüncelle_button.Text = "Kayıt Güncelle:";
            this.KayıtGüncelle_button.UseVisualStyleBackColor = false;
            this.KayıtGüncelle_button.Click += new System.EventHandler(this.KayıtGüncelle_button_Click);
            // 
            // KayıtSil_button
            // 
            this.KayıtSil_button.BackColor = System.Drawing.Color.Red;
            this.KayıtSil_button.Location = new System.Drawing.Point(85, 162);
            this.KayıtSil_button.Name = "KayıtSil_button";
            this.KayıtSil_button.Size = new System.Drawing.Size(160, 55);
            this.KayıtSil_button.TabIndex = 3;
            this.KayıtSil_button.Text = "Kayıt Sil:";
            this.KayıtSil_button.UseVisualStyleBackColor = false;
            this.KayıtSil_button.Click += new System.EventHandler(this.KayıtSil_button_Click);
            // 
            // GNOHesapla_button
            // 
            this.GNOHesapla_button.BackColor = System.Drawing.Color.SkyBlue;
            this.GNOHesapla_button.Location = new System.Drawing.Point(85, 313);
            this.GNOHesapla_button.Name = "GNOHesapla_button";
            this.GNOHesapla_button.Size = new System.Drawing.Size(163, 55);
            this.GNOHesapla_button.TabIndex = 4;
            this.GNOHesapla_button.Text = "GNO Hesapla:";
            this.GNOHesapla_button.UseVisualStyleBackColor = false;
            this.GNOHesapla_button.Click += new System.EventHandler(this.GNOHesapla_button_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Transkript Tablosu:";
            // 
            // KayıtGöster_button
            // 
            this.KayıtGöster_button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.KayıtGöster_button.Location = new System.Drawing.Point(82, 21);
            this.KayıtGöster_button.Name = "KayıtGöster_button";
            this.KayıtGöster_button.Size = new System.Drawing.Size(163, 49);
            this.KayıtGöster_button.TabIndex = 6;
            this.KayıtGöster_button.Text = "Kayıtları Göster:";
            this.KayıtGöster_button.UseVisualStyleBackColor = false;
            this.KayıtGöster_button.Click += new System.EventHandler(this.KayıtGöster_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.KayıtGöster_button);
            this.groupBox1.Controls.Add(this.KayıtEkle_button);
            this.groupBox1.Controls.Add(this.GNOHesapla_button);
            this.groupBox1.Controls.Add(this.KayıtGüncelle_button);
            this.groupBox1.Controls.Add(this.KayıtSil_button);
            this.groupBox1.Location = new System.Drawing.Point(26, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 374);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menü:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox2.Location = new System.Drawing.Point(451, 336);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 250);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Bilgileri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Öğrenci No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Soyad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Bölüm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(63, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(64, 149);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(63, 197);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(144, 22);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "Bilgisayar Mühendisliği";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 715);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Transkript_dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Transkript_dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Transkript_dataGridView;
        private System.Windows.Forms.Button KayıtEkle_button;
        private System.Windows.Forms.Button KayıtGüncelle_button;
        private System.Windows.Forms.Button KayıtSil_button;
        private System.Windows.Forms.Button GNOHesapla_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button KayıtGöster_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

