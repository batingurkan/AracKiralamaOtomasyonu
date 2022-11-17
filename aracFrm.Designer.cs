namespace AracKiralama
{
    partial class aracFrm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.modelCmb = new System.Windows.Forms.ComboBox();
            this.plakaTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.durumCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vitesCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yakıtCb = new System.Windows.Forms.ComboBox();
            this.kilometreTb = new System.Windows.Forms.Label();
            this.markaCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.durumuTb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ücretiTb = new System.Windows.Forms.Label();
            this.ucretTb = new System.Windows.Forms.TextBox();
            this.kmTb = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.aracSilBtn = new System.Windows.Forms.Button();
            this.aracGüncelleBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.modelCmb);
            this.groupBox1.Controls.Add(this.plakaTb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.durumCb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.vitesCb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.yakıtCb);
            this.groupBox1.Controls.Add(this.kilometreTb);
            this.groupBox1.Controls.Add(this.markaCb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.durumuTb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ücretiTb);
            this.groupBox1.Controls.Add(this.ucretTb);
            this.groupBox1.Controls.Add(this.kmTb);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 404);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // modelCmb
            // 
            this.modelCmb.FormattingEnabled = true;
            this.modelCmb.Location = new System.Drawing.Point(151, 117);
            this.modelCmb.Name = "modelCmb";
            this.modelCmb.Size = new System.Drawing.Size(208, 24);
            this.modelCmb.TabIndex = 6;
            // 
            // plakaTb
            // 
            this.plakaTb.Location = new System.Drawing.Point(151, 28);
            this.plakaTb.Name = "plakaTb";
            this.plakaTb.Size = new System.Drawing.Size(210, 22);
            this.plakaTb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaka :";
            // 
            // durumCb
            // 
            this.durumCb.FormattingEnabled = true;
            this.durumCb.Items.AddRange(new object[] {
            "Dolu",
            "Boş"});
            this.durumCb.Location = new System.Drawing.Point(152, 316);
            this.durumCb.Name = "durumCb";
            this.durumCb.Size = new System.Drawing.Size(209, 24);
            this.durumCb.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Marka :";
            // 
            // vitesCb
            // 
            this.vitesCb.FormattingEnabled = true;
            this.vitesCb.Items.AddRange(new object[] {
            "Otomatik",
            "Yarı Otomatik",
            "Manuel"});
            this.vitesCb.Location = new System.Drawing.Point(152, 214);
            this.vitesCb.Name = "vitesCb";
            this.vitesCb.Size = new System.Drawing.Size(209, 24);
            this.vitesCb.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Model :";
            // 
            // yakıtCb
            // 
            this.yakıtCb.FormattingEnabled = true;
            this.yakıtCb.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "Lpg"});
            this.yakıtCb.Location = new System.Drawing.Point(151, 161);
            this.yakıtCb.Name = "yakıtCb";
            this.yakıtCb.Size = new System.Drawing.Size(209, 24);
            this.yakıtCb.TabIndex = 4;
            // 
            // kilometreTb
            // 
            this.kilometreTb.AutoSize = true;
            this.kilometreTb.Location = new System.Drawing.Point(14, 267);
            this.kilometreTb.Name = "kilometreTb";
            this.kilometreTb.Size = new System.Drawing.Size(69, 16);
            this.kilometreTb.TabIndex = 0;
            this.kilometreTb.Text = "Kilometre :";
            // 
            // markaCb
            // 
            this.markaCb.FormattingEnabled = true;
            this.markaCb.Items.AddRange(new object[] {
            "Bmw",
            "Mercedes",
            "Peugeot",
            "Citroen"});
            this.markaCb.Location = new System.Drawing.Point(152, 70);
            this.markaCb.Name = "markaCb";
            this.markaCb.Size = new System.Drawing.Size(209, 24);
            this.markaCb.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yakıt :";
            // 
            // durumuTb
            // 
            this.durumuTb.AutoSize = true;
            this.durumuTb.Location = new System.Drawing.Point(15, 316);
            this.durumuTb.Name = "durumuTb";
            this.durumuTb.Size = new System.Drawing.Size(59, 16);
            this.durumuTb.TabIndex = 0;
            this.durumuTb.Text = "Durumu :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Vites :";
            // 
            // ücretiTb
            // 
            this.ücretiTb.AutoSize = true;
            this.ücretiTb.Location = new System.Drawing.Point(15, 369);
            this.ücretiTb.Name = "ücretiTb";
            this.ücretiTb.Size = new System.Drawing.Size(48, 16);
            this.ücretiTb.TabIndex = 0;
            this.ücretiTb.Text = "Ücreti :";
            // 
            // ucretTb
            // 
            this.ucretTb.Location = new System.Drawing.Point(152, 363);
            this.ucretTb.Name = "ucretTb";
            this.ucretTb.Size = new System.Drawing.Size(210, 22);
            this.ucretTb.TabIndex = 1;
            // 
            // kmTb
            // 
            this.kmTb.Location = new System.Drawing.Point(152, 264);
            this.kmTb.Name = "kmTb";
            this.kmTb.Size = new System.Drawing.Size(210, 22);
            this.kmTb.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 440);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1147, 303);
            this.dataGridView2.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::AracKiralama.Properties.Resources.ext;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(1035, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 67);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // aracSilBtn
            // 
            this.aracSilBtn.BackColor = System.Drawing.Color.Red;
            this.aracSilBtn.Location = new System.Drawing.Point(1035, 349);
            this.aracSilBtn.Name = "aracSilBtn";
            this.aracSilBtn.Size = new System.Drawing.Size(124, 67);
            this.aracSilBtn.TabIndex = 8;
            this.aracSilBtn.Text = "Araç Sil";
            this.aracSilBtn.UseVisualStyleBackColor = false;
            this.aracSilBtn.Click += new System.EventHandler(this.aracSilBtn_Click);
            // 
            // aracGüncelleBtn
            // 
            this.aracGüncelleBtn.BackColor = System.Drawing.Color.Gold;
            this.aracGüncelleBtn.Location = new System.Drawing.Point(811, 349);
            this.aracGüncelleBtn.Name = "aracGüncelleBtn";
            this.aracGüncelleBtn.Size = new System.Drawing.Size(124, 67);
            this.aracGüncelleBtn.TabIndex = 9;
            this.aracGüncelleBtn.Text = "Araç Güncelle";
            this.aracGüncelleBtn.UseVisualStyleBackColor = false;
            // 
            // aracFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AracKiralama.Properties.Resources.sakarya_tayfun_arac_kiralama_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1167, 751);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.aracSilBtn);
            this.Controls.Add(this.aracGüncelleBtn);
            this.Name = "aracFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "aracFrm";
            this.Load += new System.EventHandler(this.aracFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox plakaTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox durumCb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox vitesCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox yakıtCb;
        private System.Windows.Forms.Label kilometreTb;
        private System.Windows.Forms.ComboBox markaCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label durumuTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ücretiTb;
        private System.Windows.Forms.TextBox ucretTb;
        private System.Windows.Forms.TextBox kmTb;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button aracSilBtn;
        private System.Windows.Forms.Button aracGüncelleBtn;
        private System.Windows.Forms.ComboBox modelCmb;
    }
}