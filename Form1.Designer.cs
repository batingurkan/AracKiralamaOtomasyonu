namespace AracKiralama
{
    partial class anasayfaFrm
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
            this.sozBtn = new System.Windows.Forms.Button();
            this.musteriBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.musteriekleBtn = new System.Windows.Forms.Button();
            this.aracekleBtn = new System.Windows.Forms.Button();
            this.aracBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sozBtn
            // 
            this.sozBtn.BackColor = System.Drawing.Color.White;
            this.sozBtn.BackgroundImage = global::AracKiralama.Properties.Resources.sözleşme;
            this.sozBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sozBtn.Location = new System.Drawing.Point(984, 539);
            this.sozBtn.Name = "sozBtn";
            this.sozBtn.Size = new System.Drawing.Size(137, 165);
            this.sozBtn.TabIndex = 3;
            this.sozBtn.Text = "Sözleşme";
            this.sozBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sozBtn.UseVisualStyleBackColor = false;
            this.sozBtn.Click += new System.EventHandler(this.sozBtn_Click);
            // 
            // musteriBtn
            // 
            this.musteriBtn.BackColor = System.Drawing.Color.White;
            this.musteriBtn.BackgroundImage = global::AracKiralama.Properties.Resources.download;
            this.musteriBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.musteriBtn.Location = new System.Drawing.Point(25, 540);
            this.musteriBtn.Name = "musteriBtn";
            this.musteriBtn.Size = new System.Drawing.Size(111, 164);
            this.musteriBtn.TabIndex = 4;
            this.musteriBtn.Text = "Müşteriler";
            this.musteriBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.musteriBtn.UseVisualStyleBackColor = false;
            this.musteriBtn.Click += new System.EventHandler(this.musteriBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Red;
            this.closeBtn.BackgroundImage = global::AracKiralama.Properties.Resources.ext;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeBtn.Location = new System.Drawing.Point(967, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(154, 58);
            this.closeBtn.TabIndex = 5;
            this.closeBtn.UseVisualStyleBackColor = false;
            // 
            // musteriekleBtn
            // 
            this.musteriekleBtn.BackColor = System.Drawing.Color.White;
            this.musteriekleBtn.BackgroundImage = global::AracKiralama.Properties.Resources.businessman_add;
            this.musteriekleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.musteriekleBtn.Location = new System.Drawing.Point(25, 350);
            this.musteriekleBtn.Name = "musteriekleBtn";
            this.musteriekleBtn.Size = new System.Drawing.Size(111, 157);
            this.musteriekleBtn.TabIndex = 8;
            this.musteriekleBtn.Text = "Müşteri Eke";
            this.musteriekleBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.musteriekleBtn.UseVisualStyleBackColor = false;
            this.musteriekleBtn.Click += new System.EventHandler(this.musteriekleBtn_Click);
            // 
            // aracekleBtn
            // 
            this.aracekleBtn.BackColor = System.Drawing.Color.White;
            this.aracekleBtn.BackgroundImage = global::AracKiralama.Properties.Resources.araba;
            this.aracekleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.aracekleBtn.Location = new System.Drawing.Point(25, 21);
            this.aracekleBtn.Name = "aracekleBtn";
            this.aracekleBtn.Size = new System.Drawing.Size(111, 129);
            this.aracekleBtn.TabIndex = 7;
            this.aracekleBtn.Text = "Araç Ekle";
            this.aracekleBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.aracekleBtn.UseVisualStyleBackColor = false;
            this.aracekleBtn.Click += new System.EventHandler(this.aracekleBtn_Click_1);
            // 
            // aracBtn
            // 
            this.aracBtn.BackColor = System.Drawing.Color.White;
            this.aracBtn.BackgroundImage = global::AracKiralama.Properties.Resources.download;
            this.aracBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.aracBtn.Location = new System.Drawing.Point(25, 178);
            this.aracBtn.Name = "aracBtn";
            this.aracBtn.Size = new System.Drawing.Size(111, 145);
            this.aracBtn.TabIndex = 6;
            this.aracBtn.Text = "Araçlar";
            this.aracBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.aracBtn.UseVisualStyleBackColor = false;
            this.aracBtn.Click += new System.EventHandler(this.aracBtn_Click);
            // 
            // anasayfaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AracKiralama.Properties.Resources.sakarya_tayfun_arac_kiralama_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1133, 732);
            this.Controls.Add(this.musteriekleBtn);
            this.Controls.Add(this.aracekleBtn);
            this.Controls.Add(this.sozBtn);
            this.Controls.Add(this.musteriBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.aracBtn);
            this.Name = "anasayfaFrm";
            this.Text = "Araç Kiralama";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sozBtn;
        private System.Windows.Forms.Button musteriBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button aracBtn;
        private System.Windows.Forms.Button aracekleBtn;
        private System.Windows.Forms.Button musteriekleBtn;
    }
}

