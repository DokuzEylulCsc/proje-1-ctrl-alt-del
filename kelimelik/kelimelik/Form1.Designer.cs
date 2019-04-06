namespace kelimelik
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_YeniOyun = new System.Windows.Forms.Button();
            this.Btn_Kolay = new System.Windows.Forms.Button();
            this.Btn_Orta = new System.Windows.Forms.Button();
            this.Btn_Zor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 26);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsminiz : ";
            // 
            // Btn_YeniOyun
            // 
            this.Btn_YeniOyun.Location = new System.Drawing.Point(93, 140);
            this.Btn_YeniOyun.Name = "Btn_YeniOyun";
            this.Btn_YeniOyun.Size = new System.Drawing.Size(112, 53);
            this.Btn_YeniOyun.TabIndex = 2;
            this.Btn_YeniOyun.Text = "Yeni Oyun";
            this.Btn_YeniOyun.UseVisualStyleBackColor = true;
            this.Btn_YeniOyun.Click += new System.EventHandler(this.Btn_YeniOyun_Click);
            // 
            // Btn_Kolay
            // 
            this.Btn_Kolay.BackColor = System.Drawing.Color.Lime;
            this.Btn_Kolay.Location = new System.Drawing.Point(26, 222);
            this.Btn_Kolay.Name = "Btn_Kolay";
            this.Btn_Kolay.Size = new System.Drawing.Size(79, 42);
            this.Btn_Kolay.TabIndex = 3;
            this.Btn_Kolay.Text = "Kolay";
            this.Btn_Kolay.UseVisualStyleBackColor = false;
            this.Btn_Kolay.Click += new System.EventHandler(this.Btn_Kolay_Click);
            // 
            // Btn_Orta
            // 
            this.Btn_Orta.Location = new System.Drawing.Point(111, 222);
            this.Btn_Orta.Name = "Btn_Orta";
            this.Btn_Orta.Size = new System.Drawing.Size(79, 42);
            this.Btn_Orta.TabIndex = 4;
            this.Btn_Orta.Text = "Orta";
            this.Btn_Orta.UseVisualStyleBackColor = true;
            this.Btn_Orta.Click += new System.EventHandler(this.Btn_Orta_Click);
            // 
            // Btn_Zor
            // 
            this.Btn_Zor.Location = new System.Drawing.Point(196, 222);
            this.Btn_Zor.Name = "Btn_Zor";
            this.Btn_Zor.Size = new System.Drawing.Size(79, 42);
            this.Btn_Zor.TabIndex = 5;
            this.Btn_Zor.Text = "Zor";
            this.Btn_Zor.UseVisualStyleBackColor = true;
            this.Btn_Zor.Click += new System.EventHandler(this.Btn_Zor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 61);
            this.label2.TabIndex = 6;
            this.label2.Text = "KELİMELİK";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(163)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(306, 299);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Zor);
            this.Controls.Add(this.Btn_Orta);
            this.Controls.Add(this.Btn_Kolay);
            this.Controls.Add(this.Btn_YeniOyun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Form1";
            this.Text = "GirisPenceresi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_YeniOyun;
        private System.Windows.Forms.Button Btn_Kolay;
        private System.Windows.Forms.Button Btn_Orta;
        private System.Windows.Forms.Button Btn_Zor;
        private System.Windows.Forms.Label label2;
    }
}

