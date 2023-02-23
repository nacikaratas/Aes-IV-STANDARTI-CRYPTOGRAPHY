namespace AesSifreleme
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtGizliMetin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbSifreli = new System.Windows.Forms.RichTextBox();
            this.rtbSifresiz = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Kaydet = new System.Windows.Forms.Button();
            this.Sifrele = new System.Windows.Forms.Button();
            this.SifreCoz = new System.Windows.Forms.Button();
            this.veriOku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGizliMetin
            // 
            this.txtGizliMetin.Location = new System.Drawing.Point(192, 12);
            this.txtGizliMetin.Multiline = true;
            this.txtGizliMetin.Name = "txtGizliMetin";
            this.txtGizliMetin.Size = new System.Drawing.Size(557, 86);
            this.txtGizliMetin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gizli Metin:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rtbSifreli
            // 
            this.rtbSifreli.Location = new System.Drawing.Point(38, 177);
            this.rtbSifreli.Name = "rtbSifreli";
            this.rtbSifreli.Size = new System.Drawing.Size(313, 239);
            this.rtbSifreli.TabIndex = 2;
            this.rtbSifreli.Text = "";
            // 
            // rtbSifresiz
            // 
            this.rtbSifresiz.Location = new System.Drawing.Point(460, 177);
            this.rtbSifresiz.Name = "rtbSifresiz";
            this.rtbSifresiz.Size = new System.Drawing.Size(313, 239);
            this.rtbSifresiz.TabIndex = 3;
            this.rtbSifresiz.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(368, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "---->";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(108, 110);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 19);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Gizli Bilgi";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Kaydet
            // 
            this.Kaydet.Location = new System.Drawing.Point(216, 124);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(120, 36);
            this.Kaydet.TabIndex = 6;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.UseVisualStyleBackColor = true;
            // 
            // Sifrele
            // 
            this.Sifrele.Location = new System.Drawing.Point(353, 124);
            this.Sifrele.Name = "Sifrele";
            this.Sifrele.Size = new System.Drawing.Size(120, 36);
            this.Sifrele.TabIndex = 7;
            this.Sifrele.Text = "Şifrele";
            this.Sifrele.UseVisualStyleBackColor = true;
            this.Sifrele.Click += new System.EventHandler(this.Sifrele_Click);
            // 
            // SifreCoz
            // 
            this.SifreCoz.Location = new System.Drawing.Point(493, 124);
            this.SifreCoz.Name = "SifreCoz";
            this.SifreCoz.Size = new System.Drawing.Size(120, 36);
            this.SifreCoz.TabIndex = 8;
            this.SifreCoz.Text = "Şifre Çöz";
            this.SifreCoz.UseVisualStyleBackColor = true;
            this.SifreCoz.Click += new System.EventHandler(this.SifreCoz_Click);
            // 
            // veriOku
            // 
            this.veriOku.Location = new System.Drawing.Point(629, 124);
            this.veriOku.Name = "veriOku";
            this.veriOku.Size = new System.Drawing.Size(120, 36);
            this.veriOku.TabIndex = 9;
            this.veriOku.Text = "Veri Oku";
            this.veriOku.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.veriOku);
            this.Controls.Add(this.SifreCoz);
            this.Controls.Add(this.Sifrele);
            this.Controls.Add(this.Kaydet);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbSifresiz);
            this.Controls.Add(this.rtbSifreli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGizliMetin);
            this.Name = "Form1";
            this.Text = "AES 4 Cryptography ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtGizliMetin;
        private Label label1;
        private RichTextBox rtbSifreli;
        private RichTextBox rtbSifresiz;
        private Label label2;
        private CheckBox checkBox1;
        private Button Kaydet;
        private Button Sifrele;
        private Button SifreCoz;
        private Button veriOku;
    }
}