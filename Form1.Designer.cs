
namespace english_learn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDogruSayisi = new System.Windows.Forms.Label();
            this.lblCevap = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtTurkce = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.btnPas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "İngilizce : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Türkçe : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Süre : ";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Font = new System.Drawing.Font("Dubai", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSure.Location = new System.Drawing.Point(412, 32);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(45, 32);
            this.lblSure.TabIndex = 3;
            this.lblSure.Text = "120";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kelime : ";
            // 
            // lblDogruSayisi
            // 
            this.lblDogruSayisi.AutoSize = true;
            this.lblDogruSayisi.Font = new System.Drawing.Font("Dubai", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogruSayisi.Location = new System.Drawing.Point(412, 75);
            this.lblDogruSayisi.Name = "lblDogruSayisi";
            this.lblDogruSayisi.Size = new System.Drawing.Size(25, 32);
            this.lblDogruSayisi.TabIndex = 5;
            this.lblDogruSayisi.Text = "0";
            // 
            // lblCevap
            // 
            this.lblCevap.AutoSize = true;
            this.lblCevap.Location = new System.Drawing.Point(392, 133);
            this.lblCevap.Name = "lblCevap";
            this.lblCevap.Size = new System.Drawing.Size(28, 23);
            this.lblCevap.TabIndex = 6;
            this.lblCevap.Text = "...";
            this.lblCevap.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtTurkce
            // 
            this.txtTurkce.Location = new System.Drawing.Point(113, 76);
            this.txtTurkce.Name = "txtTurkce";
            this.txtTurkce.Size = new System.Drawing.Size(202, 31);
            this.txtTurkce.TabIndex = 7;
            this.txtTurkce.TextChanged += new System.EventHandler(this.txtTurkce_TextChanged);
            // 
            // txtEnglish
            // 
            this.txtEnglish.Enabled = false;
            this.txtEnglish.Location = new System.Drawing.Point(113, 33);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(202, 31);
            this.txtEnglish.TabIndex = 8;
            // 
            // btnPas
            // 
            this.btnPas.Location = new System.Drawing.Point(189, 121);
            this.btnPas.Name = "btnPas";
            this.btnPas.Size = new System.Drawing.Size(51, 35);
            this.btnPas.TabIndex = 9;
            this.btnPas.Text = "Pas";
            this.btnPas.UseVisualStyleBackColor = true;
            this.btnPas.Click += new System.EventHandler(this.btnPas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(492, 178);
            this.Controls.Add(this.btnPas);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.txtTurkce);
            this.Controls.Add(this.lblCevap);
            this.Controls.Add(this.lblDogruSayisi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.Text = "Türkçesi Ne ?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDogruSayisi;
        private System.Windows.Forms.Label lblCevap;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtTurkce;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.Button btnPas;
    }
}

