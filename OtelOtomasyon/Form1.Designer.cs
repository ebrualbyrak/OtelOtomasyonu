namespace OtelOtomasyon
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYeniUye = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(12, 12);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(102, 102);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 3;
            this.pb1.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Image = ((System.Drawing.Image)(resources.GetObject("pb2.Image")));
            this.pb2.Location = new System.Drawing.Point(118, 12);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(102, 102);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 3;
            this.pb2.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Image = ((System.Drawing.Image)(resources.GetObject("pb3.Image")));
            this.pb3.Location = new System.Drawing.Point(224, 12);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(102, 102);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 3;
            this.pb3.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.Image = ((System.Drawing.Image)(resources.GetObject("pb4.Image")));
            this.pb4.Location = new System.Drawing.Point(330, 12);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(102, 102);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb4.TabIndex = 3;
            this.pb4.TabStop = false;
            // 
            // pb5
            // 
            this.pb5.Image = ((System.Drawing.Image)(resources.GetObject("pb5.Image")));
            this.pb5.Location = new System.Drawing.Point(436, 12);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(102, 102);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb5.TabIndex = 3;
            this.pb5.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtKullaniciSifre
            // 
            this.txtKullaniciSifre.Location = new System.Drawing.Point(242, 190);
            this.txtKullaniciSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullaniciSifre.Name = "txtKullaniciSifre";
            this.txtKullaniciSifre.PasswordChar = '*';
            this.txtKullaniciSifre.Size = new System.Drawing.Size(132, 22);
            this.txtKullaniciSifre.TabIndex = 6;
            this.txtKullaniciSifre.Tag = "1";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(242, 145);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(132, 22);
            this.txtKullaniciAdi.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(141, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(141, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // btnYeniUye
            // 
            this.btnYeniUye.BackColor = System.Drawing.Color.Azure;
            this.btnYeniUye.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniUye.ForeColor = System.Drawing.Color.Black;
            this.btnYeniUye.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnYeniUye.ImageKey = "Actions-user-group-new-icon.png";
            this.btnYeniUye.Location = new System.Drawing.Point(342, 229);
            this.btnYeniUye.Margin = new System.Windows.Forms.Padding(4);
            this.btnYeniUye.Name = "btnYeniUye";
            this.btnYeniUye.Size = new System.Drawing.Size(104, 60);
            this.btnYeniUye.TabIndex = 11;
            this.btnYeniUye.Text = "Yeni Üye";
            this.btnYeniUye.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYeniUye.UseVisualStyleBackColor = false;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Azure;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.Black;
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCikis.ImageKey = "Delete-icon (1).png";
            this.btnCikis.Location = new System.Drawing.Point(230, 229);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(104, 60);
            this.btnCikis.TabIndex = 9;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.UseVisualStyleBackColor = false;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Azure;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.Black;
            this.btnGiris.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGiris.ImageKey = "Login-in-icon.png";
            this.btnGiris.Location = new System.Drawing.Point(114, 229);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(4);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(108, 60);
            this.btnGiris.TabIndex = 7;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGiris.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(546, 337);
            this.Controls.Add(this.txtKullaniciSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYeniUye);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.ForeColor = System.Drawing.Color.Snow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtKullaniciSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYeniUye;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGiris;
    }
}

