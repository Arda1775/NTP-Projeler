namespace RandomDizi
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
            this.btnOlustur = new System.Windows.Forms.Button();
            this.btnKopyala = new System.Windows.Forms.Button();
            this.ListeAsil = new System.Windows.Forms.ListBox();
            this.ListeKopya = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(26, 77);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(93, 34);
            this.btnOlustur.TabIndex = 0;
            this.btnOlustur.Text = "Dizi Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // btnKopyala
            // 
            this.btnKopyala.Location = new System.Drawing.Point(276, 77);
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(93, 34);
            this.btnKopyala.TabIndex = 1;
            this.btnKopyala.Text = "Dizi Kopyala";
            this.btnKopyala.UseVisualStyleBackColor = true;
            this.btnKopyala.Click += new System.EventHandler(this.btnKopyala_Click);
            // 
            // ListeAsil
            // 
            this.ListeAsil.FormattingEnabled = true;
            this.ListeAsil.Location = new System.Drawing.Point(125, 24);
            this.ListeAsil.Name = "ListeAsil";
            this.ListeAsil.Size = new System.Drawing.Size(127, 186);
            this.ListeAsil.TabIndex = 2;
            // 
            // ListeKopya
            // 
            this.ListeKopya.FormattingEnabled = true;
            this.ListeKopya.Location = new System.Drawing.Point(375, 24);
            this.ListeKopya.Name = "ListeKopya";
            this.ListeKopya.Size = new System.Drawing.Size(127, 186);
            this.ListeKopya.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 309);
            this.Controls.Add(this.ListeKopya);
            this.Controls.Add(this.ListeAsil);
            this.Controls.Add(this.btnKopyala);
            this.Controls.Add(this.btnOlustur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Button btnKopyala;
        private System.Windows.Forms.ListBox ListeAsil;
        private System.Windows.Forms.ListBox ListeKopya;
    }
}

