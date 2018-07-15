namespace KisiKayitOtomasyon
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
            this.components = new System.ComponentModel.Container();
            this.EkleButton = new System.Windows.Forms.Button();
            this.SoyIsimText = new System.Windows.Forms.TextBox();
            this.AraButton = new System.Windows.Forms.Button();
            this.IsimText = new System.Windows.Forms.TextBox();
            this.IsimLabel = new System.Windows.Forms.Label();
            this.SoyIsimLabel = new System.Windows.Forms.Label();
            this.KimlikNoText = new System.Windows.Forms.TextBox();
            this.KimlikNoLabel = new System.Windows.Forms.Label();
            this.DogumYiliLabel = new System.Windows.Forms.Label();
            this.KullaniciList = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ListeleButton = new System.Windows.Forms.Button();
            this.DogumYili = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DogumYili)).BeginInit();
            this.SuspendLayout();
            // 
            // EkleButton
            // 
            this.EkleButton.Location = new System.Drawing.Point(59, 174);
            this.EkleButton.Name = "EkleButton";
            this.EkleButton.Size = new System.Drawing.Size(75, 23);
            this.EkleButton.TabIndex = 5;
            this.EkleButton.Text = "Ekle";
            this.EkleButton.UseVisualStyleBackColor = true;
            this.EkleButton.Click += new System.EventHandler(this.EkleButton_click);
            // 
            // SoyIsimText
            // 
            this.SoyIsimText.Location = new System.Drawing.Point(72, 49);
            this.SoyIsimText.Name = "SoyIsimText";
            this.SoyIsimText.Size = new System.Drawing.Size(100, 20);
            this.SoyIsimText.TabIndex = 1;
            this.SoyIsimText.Tag = "";
            // 
            // AraButton
            // 
            this.AraButton.Location = new System.Drawing.Point(59, 145);
            this.AraButton.Name = "AraButton";
            this.AraButton.Size = new System.Drawing.Size(75, 23);
            this.AraButton.TabIndex = 4;
            this.AraButton.Text = "Ara";
            this.AraButton.UseVisualStyleBackColor = true;
            this.AraButton.Click += new System.EventHandler(this.AraButton_Click);
            // 
            // IsimText
            // 
            this.IsimText.AccessibleDescription = "";
            this.IsimText.AccessibleName = "";
            this.IsimText.BackColor = System.Drawing.SystemColors.HighlightText;
            this.IsimText.Location = new System.Drawing.Point(72, 23);
            this.IsimText.Name = "IsimText";
            this.IsimText.Size = new System.Drawing.Size(100, 20);
            this.IsimText.TabIndex = 0;
            this.IsimText.Tag = "";
            // 
            // IsimLabel
            // 
            this.IsimLabel.AutoSize = true;
            this.IsimLabel.Location = new System.Drawing.Point(9, 26);
            this.IsimLabel.Name = "IsimLabel";
            this.IsimLabel.Size = new System.Drawing.Size(25, 13);
            this.IsimLabel.TabIndex = 4;
            this.IsimLabel.Text = "İsim";
            // 
            // SoyIsimLabel
            // 
            this.SoyIsimLabel.AutoSize = true;
            this.SoyIsimLabel.Location = new System.Drawing.Point(9, 52);
            this.SoyIsimLabel.Name = "SoyIsimLabel";
            this.SoyIsimLabel.Size = new System.Drawing.Size(46, 13);
            this.SoyIsimLabel.TabIndex = 5;
            this.SoyIsimLabel.Text = "Soy İsim";
            // 
            // KimlikNoText
            // 
            this.KimlikNoText.Location = new System.Drawing.Point(72, 75);
            this.KimlikNoText.MaxLength = 11;
            this.KimlikNoText.Name = "KimlikNoText";
            this.KimlikNoText.Size = new System.Drawing.Size(100, 20);
            this.KimlikNoText.TabIndex = 2;
            // 
            // KimlikNoLabel
            // 
            this.KimlikNoLabel.AutoSize = true;
            this.KimlikNoLabel.Location = new System.Drawing.Point(9, 78);
            this.KimlikNoLabel.Name = "KimlikNoLabel";
            this.KimlikNoLabel.Size = new System.Drawing.Size(51, 13);
            this.KimlikNoLabel.TabIndex = 7;
            this.KimlikNoLabel.Text = "Kimlik No";
            // 
            // DogumYiliLabel
            // 
            this.DogumYiliLabel.AutoSize = true;
            this.DogumYiliLabel.Location = new System.Drawing.Point(9, 104);
            this.DogumYiliLabel.Name = "DogumYiliLabel";
            this.DogumYiliLabel.Size = new System.Drawing.Size(57, 13);
            this.DogumYiliLabel.TabIndex = 9;
            this.DogumYiliLabel.Text = "Doğum Yılı";
            // 
            // KullaniciList
            // 
            this.KullaniciList.FormattingEnabled = true;
            this.KullaniciList.Location = new System.Drawing.Point(205, 23);
            this.KullaniciList.Name = "KullaniciList";
            this.KullaniciList.Size = new System.Drawing.Size(207, 225);
            this.KullaniciList.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kayıtlı Kullanıcılar";
            // 
            // ListeleButton
            // 
            this.ListeleButton.Location = new System.Drawing.Point(271, 254);
            this.ListeleButton.Name = "ListeleButton";
            this.ListeleButton.Size = new System.Drawing.Size(75, 23);
            this.ListeleButton.TabIndex = 6;
            this.ListeleButton.Text = "Listele";
            this.ListeleButton.UseVisualStyleBackColor = true;
            this.ListeleButton.Click += new System.EventHandler(this.ListeleButton_Click);
            // 
            // DogumYili
            // 
            this.DogumYili.Location = new System.Drawing.Point(72, 104);
            this.DogumYili.Maximum = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.DogumYili.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.DogumYili.Name = "DogumYili";
            this.DogumYili.Size = new System.Drawing.Size(100, 20);
            this.DogumYili.TabIndex = 3;
            this.DogumYili.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 452);
            this.Controls.Add(this.DogumYili);
            this.Controls.Add(this.ListeleButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.KullaniciList);
            this.Controls.Add(this.DogumYiliLabel);
            this.Controls.Add(this.KimlikNoLabel);
            this.Controls.Add(this.KimlikNoText);
            this.Controls.Add(this.SoyIsimLabel);
            this.Controls.Add(this.IsimLabel);
            this.Controls.Add(this.IsimText);
            this.Controls.Add(this.AraButton);
            this.Controls.Add(this.SoyIsimText);
            this.Controls.Add(this.EkleButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DogumYili)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EkleButton;
        private System.Windows.Forms.TextBox SoyIsimText;
        private System.Windows.Forms.Button AraButton;
        private System.Windows.Forms.TextBox IsimText;
        private System.Windows.Forms.Label IsimLabel;
        private System.Windows.Forms.Label SoyIsimLabel;
        private System.Windows.Forms.TextBox KimlikNoText;
        private System.Windows.Forms.Label KimlikNoLabel;
        private System.Windows.Forms.Label DogumYiliLabel;
        private System.Windows.Forms.ListBox KullaniciList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ListeleButton;
        private System.Windows.Forms.NumericUpDown DogumYili;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

