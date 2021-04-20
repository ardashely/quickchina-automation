namespace stok_programi
{
    partial class login_sc_arda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_sc_arda));
            this.giris_yap = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.Label();
            this.k_adi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // giris_yap
            // 
            this.giris_yap.Location = new System.Drawing.Point(225, 142);
            this.giris_yap.Name = "giris_yap";
            this.giris_yap.Size = new System.Drawing.Size(174, 47);
            this.giris_yap.TabIndex = 9;
            this.giris_yap.Text = "Giris Yap";
            this.giris_yap.UseVisualStyleBackColor = true;
            this.giris_yap.UseWaitCursor = true;
            this.giris_yap.Click += new System.EventHandler(this.giris_yap_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Dubai", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox2.Location = new System.Drawing.Point(225, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 25);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Dubai", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox1.Location = new System.Drawing.Point(225, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 25);
            this.textBox1.TabIndex = 7;
            // 
            // sifre
            // 
            this.sifre.AutoSize = true;
            this.sifre.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.sifre.Location = new System.Drawing.Point(39, 85);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(54, 32);
            this.sifre.TabIndex = 6;
            this.sifre.Text = "Sifre:";
            // 
            // k_adi
            // 
            this.k_adi.AutoSize = true;
            this.k_adi.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.k_adi.Location = new System.Drawing.Point(39, 46);
            this.k_adi.Name = "k_adi";
            this.k_adi.Size = new System.Drawing.Size(110, 32);
            this.k_adi.TabIndex = 5;
            this.k_adi.Text = "Kullanıcı adı:";
            // 
            // login_sc_arda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(439, 234);
            this.Controls.Add(this.giris_yap);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.k_adi);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "login_sc_arda";
            this.Text = "Giriş Page";
            this.Load += new System.EventHandler(this.login_sc_arda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button giris_yap;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label sifre;
        private System.Windows.Forms.Label k_adi;
    }
}