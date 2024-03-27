
namespace Transkript_Ödev2
{
    partial class KayıtSil
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
            this.KayıtSil_dataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.DersKoduSil_textBox = new System.Windows.Forms.TextBox();
            this.VerileriSil_button = new System.Windows.Forms.Button();
            this.VerileriSilİptal_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.KayıtSil_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kayıt silmek için bilgileri doldurun:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KayıtSil_dataGridView
            // 
            this.KayıtSil_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KayıtSil_dataGridView.Location = new System.Drawing.Point(4, 30);
            this.KayıtSil_dataGridView.Name = "KayıtSil_dataGridView";
            this.KayıtSil_dataGridView.RowHeadersWidth = 51;
            this.KayıtSil_dataGridView.RowTemplate.Height = 24;
            this.KayıtSil_dataGridView.Size = new System.Drawing.Size(796, 204);
            this.KayıtSil_dataGridView.TabIndex = 1;
            this.KayıtSil_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KayıtSil_dataGridView_CellContentClick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(12, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ders Kodu:";
            // 
            // DersKoduSil_textBox
            // 
            this.DersKoduSil_textBox.Location = new System.Drawing.Point(120, 283);
            this.DersKoduSil_textBox.Name = "DersKoduSil_textBox";
            this.DersKoduSil_textBox.Size = new System.Drawing.Size(147, 22);
            this.DersKoduSil_textBox.TabIndex = 3;
            // 
            // VerileriSil_button
            // 
            this.VerileriSil_button.BackColor = System.Drawing.Color.Red;
            this.VerileriSil_button.Location = new System.Drawing.Point(321, 267);
            this.VerileriSil_button.Name = "VerileriSil_button";
            this.VerileriSil_button.Size = new System.Drawing.Size(115, 55);
            this.VerileriSil_button.TabIndex = 4;
            this.VerileriSil_button.Text = "Verileri Sil";
            this.VerileriSil_button.UseVisualStyleBackColor = false;
            this.VerileriSil_button.Click += new System.EventHandler(this.VerileriSil_button_Click);
            // 
            // VerileriSilİptal_button
            // 
            this.VerileriSilİptal_button.BackColor = System.Drawing.Color.Chartreuse;
            this.VerileriSilİptal_button.Location = new System.Drawing.Point(503, 268);
            this.VerileriSilİptal_button.Name = "VerileriSilİptal_button";
            this.VerileriSilİptal_button.Size = new System.Drawing.Size(120, 55);
            this.VerileriSilİptal_button.TabIndex = 5;
            this.VerileriSilİptal_button.Text = "İptal";
            this.VerileriSilİptal_button.UseVisualStyleBackColor = false;
            this.VerileriSilİptal_button.Click += new System.EventHandler(this.VerileriSilİptal_button_Click);
            // 
            // KayıtSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VerileriSilİptal_button);
            this.Controls.Add(this.VerileriSil_button);
            this.Controls.Add(this.DersKoduSil_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KayıtSil_dataGridView);
            this.Controls.Add(this.label1);
            this.Name = "KayıtSil";
            this.Text = "KayıtSil";
            ((System.ComponentModel.ISupportInitialize)(this.KayıtSil_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView KayıtSil_dataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DersKoduSil_textBox;
        private System.Windows.Forms.Button VerileriSil_button;
        private System.Windows.Forms.Button VerileriSilİptal_button;
    }
}