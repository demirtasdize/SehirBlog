namespace FormSınavı
{
    partial class MekanEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MekanEkle));
            this.lblSehirAdi = new System.Windows.Forms.Label();
            this.txtMekanAdı = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMekanEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSehirAdi
            // 
            this.lblSehirAdi.AutoSize = true;
            this.lblSehirAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSehirAdi.Location = new System.Drawing.Point(140, 9);
            this.lblSehirAdi.Name = "lblSehirAdi";
            this.lblSehirAdi.Size = new System.Drawing.Size(120, 29);
            this.lblSehirAdi.TabIndex = 15;
            this.lblSehirAdi.Text = "Şehir Adı";
            // 
            // txtMekanAdı
            // 
            this.txtMekanAdı.Location = new System.Drawing.Point(108, 56);
            this.txtMekanAdı.Name = "txtMekanAdı";
            this.txtMekanAdı.Size = new System.Drawing.Size(194, 20);
            this.txtMekanAdı.TabIndex = 10;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(108, 86);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(194, 20);
            this.txtTel.TabIndex = 11;
            // 
            // txtAdres
            // 
            this.txtAdres.AllowDrop = true;
            this.txtAdres.Location = new System.Drawing.Point(108, 121);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(194, 54);
            this.txtAdres.TabIndex = 12;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(108, 190);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(194, 38);
            this.txtAciklama.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mekan Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(45, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(55, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Adres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(35, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Açıklama:";
            // 
            // btnMekanEkle
            // 
            this.btnMekanEkle.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnMekanEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMekanEkle.Location = new System.Drawing.Point(218, 245);
            this.btnMekanEkle.Name = "btnMekanEkle";
            this.btnMekanEkle.Size = new System.Drawing.Size(84, 27);
            this.btnMekanEkle.TabIndex = 14;
            this.btnMekanEkle.Text = "Ekle";
            this.btnMekanEkle.UseVisualStyleBackColor = false;
            this.btnMekanEkle.Click += new System.EventHandler(this.btnMekanEkle_Click);
            // 
            // MekanEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(406, 284);
            this.Controls.Add(this.btnMekanEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtMekanAdı);
            this.Controls.Add(this.lblSehirAdi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MekanEkle";
            this.Text = "Mekan Ekle";
            this.Load += new System.EventHandler(this.MekanEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSehirAdi;
        private System.Windows.Forms.TextBox txtMekanAdı;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMekanEkle;
    }
}