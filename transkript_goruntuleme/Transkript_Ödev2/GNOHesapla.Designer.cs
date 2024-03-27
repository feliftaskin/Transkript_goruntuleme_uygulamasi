
namespace Transkript_Ödev2
{
    partial class GNOHesapla
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
            this.GNOHesapla_dataGridView = new System.Windows.Forms.DataGridView();
            this.GNOHesapla_button = new System.Windows.Forms.Button();
            this.GNOHesaplaListele_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GNOHesapla_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "GNO hesaplamak için bilgileri girin:";
            // 
            // GNOHesapla_dataGridView
            // 
            this.GNOHesapla_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GNOHesapla_dataGridView.Location = new System.Drawing.Point(3, 20);
            this.GNOHesapla_dataGridView.Name = "GNOHesapla_dataGridView";
            this.GNOHesapla_dataGridView.RowHeadersWidth = 51;
            this.GNOHesapla_dataGridView.RowTemplate.Height = 24;
            this.GNOHesapla_dataGridView.Size = new System.Drawing.Size(798, 198);
            this.GNOHesapla_dataGridView.TabIndex = 1;
            // 
            // GNOHesapla_button
            // 
            this.GNOHesapla_button.BackColor = System.Drawing.Color.LawnGreen;
            this.GNOHesapla_button.Location = new System.Drawing.Point(411, 246);
            this.GNOHesapla_button.Name = "GNOHesapla_button";
            this.GNOHesapla_button.Size = new System.Drawing.Size(150, 68);
            this.GNOHesapla_button.TabIndex = 2;
            this.GNOHesapla_button.Text = "Hesapla";
            this.GNOHesapla_button.UseVisualStyleBackColor = false;
            this.GNOHesapla_button.Click += new System.EventHandler(this.GNOHesapla_button_Click);
            // 
            // GNOHesaplaListele_button
            // 
            this.GNOHesaplaListele_button.BackColor = System.Drawing.Color.LawnGreen;
            this.GNOHesaplaListele_button.Location = new System.Drawing.Point(164, 246);
            this.GNOHesaplaListele_button.Name = "GNOHesaplaListele_button";
            this.GNOHesaplaListele_button.Size = new System.Drawing.Size(146, 68);
            this.GNOHesaplaListele_button.TabIndex = 3;
            this.GNOHesaplaListele_button.Text = "Verileri Listele";
            this.GNOHesaplaListele_button.UseVisualStyleBackColor = false;
            this.GNOHesaplaListele_button.Click += new System.EventHandler(this.GNOHesaplaListele_button_Click);
            // 
            // GNOHesapla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GNOHesaplaListele_button);
            this.Controls.Add(this.GNOHesapla_button);
            this.Controls.Add(this.GNOHesapla_dataGridView);
            this.Controls.Add(this.label1);
            this.Name = "GNOHesapla";
            this.Text = "GNOHesapla";
            ((System.ComponentModel.ISupportInitialize)(this.GNOHesapla_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GNOHesapla_dataGridView;
        private System.Windows.Forms.Button GNOHesapla_button;
        private System.Windows.Forms.Button GNOHesaplaListele_button;
    }
}