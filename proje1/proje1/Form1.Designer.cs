namespace proje1
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
            this.klncprl = new System.Windows.Forms.Label();
            this.klncadi = new System.Windows.Forms.Label();
            this.parola = new System.Windows.Forms.TextBox();
            this.kullaniciadi = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // klncprl
            // 
            this.klncprl.AutoSize = true;
            this.klncprl.BackColor = System.Drawing.Color.Transparent;
            this.klncprl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.klncprl.ForeColor = System.Drawing.SystemColors.GrayText;
            this.klncprl.Location = new System.Drawing.Point(118, 233);
            this.klncprl.Name = "klncprl";
            this.klncprl.Size = new System.Drawing.Size(57, 20);
            this.klncprl.TabIndex = 14;
            this.klncprl.Text = "Parola";
            // 
            // klncadi
            // 
            this.klncadi.AutoSize = true;
            this.klncadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.klncadi.ForeColor = System.Drawing.SystemColors.GrayText;
            this.klncadi.Location = new System.Drawing.Point(118, 202);
            this.klncadi.Name = "klncadi";
            this.klncadi.Size = new System.Drawing.Size(101, 20);
            this.klncadi.TabIndex = 13;
            this.klncadi.Text = "Kullanıcı Adı";
            // 
            // parola
            // 
            this.parola.Location = new System.Drawing.Point(228, 230);
            this.parola.Name = "parola";
            this.parola.PasswordChar = '*';
            this.parola.Size = new System.Drawing.Size(299, 22);
            this.parola.TabIndex = 12;
            // 
            // kullaniciadi
            // 
            this.kullaniciadi.Location = new System.Drawing.Point(228, 199);
            this.kullaniciadi.Name = "kullaniciadi";
            this.kullaniciadi.Size = new System.Drawing.Size(299, 22);
            this.kullaniciadi.TabIndex = 11;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.checkBox1.Location = new System.Drawing.Point(137, 269);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 22);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Beni Hatırla";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(137, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(390, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "GİRİŞ YAP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.Location = new System.Drawing.Point(137, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(390, 42);
            this.button2.TabIndex = 19;
            this.button2.Text = "HESABINIZ YOK MU?HEMEN KAYDOLUN";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proje1.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(277, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 509);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.klncprl);
            this.Controls.Add(this.klncadi);
            this.Controls.Add(this.parola);
            this.Controls.Add(this.kullaniciadi);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label klncprl;
        private System.Windows.Forms.Label klncadi;
        private System.Windows.Forms.TextBox parola;
        private System.Windows.Forms.TextBox kullaniciadi;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

