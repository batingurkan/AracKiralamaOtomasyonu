﻿namespace AracKiralama
{
    partial class musteriFrm
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
            this.musteriGüncelleBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.epostTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tcTb = new System.Windows.Forms.TextBox();
            this.telTb = new System.Windows.Forms.TextBox();
            this.cinsiyet = new System.Windows.Forms.Label();
            this.adTb = new System.Windows.Forms.TextBox();
            this.soyTb = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.musteriSilBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // musteriGüncelleBtn
            // 
            this.musteriGüncelleBtn.BackColor = System.Drawing.Color.Gold;
            this.musteriGüncelleBtn.Location = new System.Drawing.Point(646, 248);
            this.musteriGüncelleBtn.Name = "musteriGüncelleBtn";
            this.musteriGüncelleBtn.Size = new System.Drawing.Size(124, 67);
            this.musteriGüncelleBtn.TabIndex = 24;
            this.musteriGüncelleBtn.Text = "Müşteri Güncelle";
            this.musteriGüncelleBtn.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.epostTb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tcTb);
            this.groupBox1.Controls.Add(this.telTb);
            this.groupBox1.Controls.Add(this.cinsiyet);
            this.groupBox1.Controls.Add(this.adTb);
            this.groupBox1.Controls.Add(this.soyTb);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 303);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // epostTb
            // 
            this.epostTb.Location = new System.Drawing.Point(166, 160);
            this.epostTb.Name = "epostTb";
            this.epostTb.Size = new System.Drawing.Size(210, 22);
            this.epostTb.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tc No :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.comboBox1.Location = new System.Drawing.Point(166, 265);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 24);
            this.comboBox1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Soy Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "E posta :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon No :";
            // 
            // tcTb
            // 
            this.tcTb.Location = new System.Drawing.Point(166, 25);
            this.tcTb.Name = "tcTb";
            this.tcTb.Size = new System.Drawing.Size(210, 22);
            this.tcTb.TabIndex = 13;
            // 
            // telTb
            // 
            this.telTb.Location = new System.Drawing.Point(166, 213);
            this.telTb.Name = "telTb";
            this.telTb.Size = new System.Drawing.Size(210, 22);
            this.telTb.TabIndex = 9;
            // 
            // cinsiyet
            // 
            this.cinsiyet.AutoSize = true;
            this.cinsiyet.Location = new System.Drawing.Point(29, 265);
            this.cinsiyet.Name = "cinsiyet";
            this.cinsiyet.Size = new System.Drawing.Size(60, 16);
            this.cinsiyet.TabIndex = 4;
            this.cinsiyet.Text = "Cinsiyet ;";
            // 
            // adTb
            // 
            this.adTb.Location = new System.Drawing.Point(166, 69);
            this.adTb.Name = "adTb";
            this.adTb.Size = new System.Drawing.Size(210, 22);
            this.adTb.TabIndex = 12;
            // 
            // soyTb
            // 
            this.soyTb.Location = new System.Drawing.Point(166, 114);
            this.soyTb.Name = "soyTb";
            this.soyTb.Size = new System.Drawing.Size(210, 22);
            this.soyTb.TabIndex = 11;
            this.soyTb.TextChanged += new System.EventHandler(this.soyTb_TextChanged);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::AracKiralama.Properties.Resources.ext;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(795, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 67);
            this.button4.TabIndex = 22;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // musteriSilBtn
            // 
            this.musteriSilBtn.BackColor = System.Drawing.Color.Red;
            this.musteriSilBtn.Location = new System.Drawing.Point(795, 248);
            this.musteriSilBtn.Name = "musteriSilBtn";
            this.musteriSilBtn.Size = new System.Drawing.Size(124, 67);
            this.musteriSilBtn.TabIndex = 23;
            this.musteriSilBtn.Text = "Müşteri Sil";
            this.musteriSilBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 343);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(907, 366);
            this.dataGridView1.TabIndex = 27;
            // 
            // musteriFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AracKiralama.Properties.Resources.sakarya_tayfun_arac_kiralama_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(931, 721);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.musteriGüncelleBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.musteriSilBtn);
            this.Name = "musteriFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "musteri";
            this.Load += new System.EventHandler(this.musteriFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button musteriGüncelleBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox epostTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tcTb;
        private System.Windows.Forms.TextBox telTb;
        private System.Windows.Forms.Label cinsiyet;
        private System.Windows.Forms.TextBox adTb;
        private System.Windows.Forms.TextBox soyTb;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button musteriSilBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}