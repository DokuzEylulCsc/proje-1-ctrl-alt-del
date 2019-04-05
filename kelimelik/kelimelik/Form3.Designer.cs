namespace kelimelik
{
    partial class Form3
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
            this.Btn_Bitir = new System.Windows.Forms.Button();
            this.Btn_TekrarOyna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Bitir
            // 
            this.Btn_Bitir.Location = new System.Drawing.Point(31, 54);
            this.Btn_Bitir.Name = "Btn_Bitir";
            this.Btn_Bitir.Size = new System.Drawing.Size(200, 48);
            this.Btn_Bitir.TabIndex = 0;
            this.Btn_Bitir.Text = "Bitir ve İstatistik Goster";
            this.Btn_Bitir.UseVisualStyleBackColor = true;
            // 
            // Btn_TekrarOyna
            // 
            this.Btn_TekrarOyna.Location = new System.Drawing.Point(31, 123);
            this.Btn_TekrarOyna.Name = "Btn_TekrarOyna";
            this.Btn_TekrarOyna.Size = new System.Drawing.Size(200, 46);
            this.Btn_TekrarOyna.TabIndex = 1;
            this.Btn_TekrarOyna.Text = "Tekrar Oyna";
            this.Btn_TekrarOyna.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(272, 234);
            this.Controls.Add(this.Btn_TekrarOyna);
            this.Controls.Add(this.Btn_Bitir);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Bitir;
        private System.Windows.Forms.Button Btn_TekrarOyna;
    }
}