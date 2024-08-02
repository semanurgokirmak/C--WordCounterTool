namespace KelimeSay
{
    partial class KelimeForm
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
            this.pnlVeri = new System.Windows.Forms.Panel();
            this.btnListe = new System.Windows.Forms.Button();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.tbMetin = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tsBar = new System.Windows.Forms.ToolStrip();
            this.btnKapat = new System.Windows.Forms.ToolStripButton();
            this.btnYeni = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BilgiGoster = new System.Windows.Forms.ToolTip(this.components);
            this.pnlListe = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lvListe = new System.Windows.Forms.ListView();
            this.Kelime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Boyut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlGoster = new System.Windows.Forms.Panel();
            this.tbKelime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlVeri.SuspendLayout();
            this.tsBar.SuspendLayout();
            this.pnlListe.SuspendLayout();
            this.pnlGoster.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlVeri
            // 
            this.pnlVeri.Controls.Add(this.btnListe);
            this.pnlVeri.Controls.Add(this.BtnHesapla);
            this.pnlVeri.Controls.Add(this.tbMetin);
            this.pnlVeri.Controls.Add(this.label1);
            this.pnlVeri.Location = new System.Drawing.Point(12, 68);
            this.pnlVeri.Name = "pnlVeri";
            this.pnlVeri.Size = new System.Drawing.Size(342, 369);
            this.pnlVeri.TabIndex = 0;
            // 
            // btnListe
            // 
            this.btnListe.BackgroundImage = global::KelimeSay.Properties.Resources.gorev;
            this.btnListe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListe.Location = new System.Drawing.Point(280, 311);
            this.btnListe.Name = "btnListe";
            this.btnListe.Size = new System.Drawing.Size(48, 48);
            this.btnListe.TabIndex = 3;
            this.btnListe.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BilgiGoster.SetToolTip(this.btnListe, "Kelime Listele");
            this.btnListe.UseVisualStyleBackColor = true;
            this.btnListe.Click += new System.EventHandler(this.btnListe_Click);
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.BackgroundImage = global::KelimeSay.Properties.Resources.bilgi;
            this.BtnHesapla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHesapla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHesapla.Location = new System.Drawing.Point(132, 311);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(48, 48);
            this.BtnHesapla.TabIndex = 2;
            this.BtnHesapla.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BilgiGoster.SetToolTip(this.BtnHesapla, "Kelime Say");
            this.BtnHesapla.UseVisualStyleBackColor = true;
            this.BtnHesapla.Click += new System.EventHandler(this.BtnHesapla_Click);
            // 
            // tbMetin
            // 
            this.tbMetin.Location = new System.Drawing.Point(8, 36);
            this.tbMetin.Name = "tbMetin";
            this.tbMetin.Size = new System.Drawing.Size(320, 269);
            this.tbMetin.TabIndex = 1;
            this.tbMetin.Text = "";
            this.tbMetin.Click += new System.EventHandler(this.tbMetin_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Metin Giriniz:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsBar
            // 
            this.tsBar.BackColor = System.Drawing.SystemColors.Control;
            this.tsBar.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.tsBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnKapat,
            this.btnYeni,
            this.toolStripSeparator1});
            this.tsBar.Location = new System.Drawing.Point(0, 0);
            this.tsBar.Name = "tsBar";
            this.tsBar.Size = new System.Drawing.Size(784, 55);
            this.tsBar.TabIndex = 1;
            this.tsBar.Text = "Tool Bar";
            // 
            // btnKapat
            // 
            this.btnKapat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnKapat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKapat.Image = global::KelimeSay.Properties.Resources.kapat;
            this.btnKapat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(52, 52);
            this.btnKapat.Text = "toolStripButton1";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYeni.Image = global::KelimeSay.Properties.Resources.yenile;
            this.btnYeni.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(52, 52);
            this.btnYeni.Text = "toolStripButton2";
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // pnlListe
            // 
            this.pnlListe.Controls.Add(this.label3);
            this.pnlListe.Controls.Add(this.lvListe);
            this.pnlListe.Location = new System.Drawing.Point(360, 68);
            this.pnlListe.Name = "pnlListe";
            this.pnlListe.Size = new System.Drawing.Size(414, 480);
            this.pnlListe.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kelime Listesi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvListe
            // 
            this.lvListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Kelime,
            this.Boyut});
            this.lvListe.HideSelection = false;
            this.lvListe.Location = new System.Drawing.Point(8, 36);
            this.lvListe.Name = "lvListe";
            this.lvListe.Size = new System.Drawing.Size(400, 423);
            this.lvListe.TabIndex = 0;
            this.lvListe.UseCompatibleStateImageBehavior = false;
            this.lvListe.View = System.Windows.Forms.View.Details;
            // 
            // Kelime
            // 
            this.Kelime.Text = "Kelime";
            this.Kelime.Width = 300;
            // 
            // Boyut
            // 
            this.Boyut.Text = "Boyut";
            this.Boyut.Width = 100;
            // 
            // pnlGoster
            // 
            this.pnlGoster.Controls.Add(this.tbKelime);
            this.pnlGoster.Controls.Add(this.label2);
            this.pnlGoster.Location = new System.Drawing.Point(12, 447);
            this.pnlGoster.Name = "pnlGoster";
            this.pnlGoster.Size = new System.Drawing.Size(342, 101);
            this.pnlGoster.TabIndex = 3;
            // 
            // tbKelime
            // 
            this.tbKelime.Location = new System.Drawing.Point(8, 56);
            this.tbKelime.Name = "tbKelime";
            this.tbKelime.Size = new System.Drawing.Size(320, 24);
            this.tbKelime.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(8, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "En Uzun Kelime :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // KelimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.pnlGoster);
            this.Controls.Add(this.pnlListe);
            this.Controls.Add(this.tsBar);
            this.Controls.Add(this.pnlVeri);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KelimeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelime ve Harf Sayısı";
            this.Load += new System.EventHandler(this.KelimeForm_Load);
            this.pnlVeri.ResumeLayout(false);
            this.tsBar.ResumeLayout(false);
            this.tsBar.PerformLayout();
            this.pnlListe.ResumeLayout(false);
            this.pnlGoster.ResumeLayout(false);
            this.pnlGoster.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlVeri;
        private System.Windows.Forms.ToolStrip tsBar;
        private System.Windows.Forms.ToolStripButton btnKapat;
        private System.Windows.Forms.ToolStripButton btnYeni;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button BtnHesapla;
        private System.Windows.Forms.RichTextBox tbMetin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListe;
        private System.Windows.Forms.ToolTip BilgiGoster;
        private System.Windows.Forms.Panel pnlListe;
        private System.Windows.Forms.Panel pnlGoster;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvListe;
        private System.Windows.Forms.TextBox tbKelime;
        private System.Windows.Forms.ColumnHeader Kelime;
        private System.Windows.Forms.ColumnHeader Boyut;
    }
}

