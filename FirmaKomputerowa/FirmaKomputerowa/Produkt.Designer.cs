namespace FirmaKomputerowa
{
    partial class Produkt
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLaptopy = new System.Windows.Forms.Button();
            this.btnPC = new System.Windows.Forms.Button();
            this.btnDrukarki = new System.Windows.Forms.Button();
            this.dgvProdukty = new System.Windows.Forms.DataGridView();
            this.tbSN = new System.Windows.Forms.TextBox();
            this.tbProdukt = new System.Windows.Forms.TextBox();
            this.lblSN = new System.Windows.Forms.Label();
            this.lblProducent = new System.Windows.Forms.Label();
            this.lblTyp = new System.Windows.Forms.Label();
            this.btnDodajProdukt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAll = new System.Windows.Forms.Button();
            this.cbTyp = new System.Windows.Forms.ComboBox();
            this.tbProcessor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRAM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbHDD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSSD = new System.Windows.Forms.TextBox();
            this.lblFormat = new System.Windows.Forms.Label();
            this.lblEkran = new System.Windows.Forms.Label();
            this.tbEkran = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.lblCD = new System.Windows.Forms.Label();
            this.tbCD = new System.Windows.Forms.TextBox();
            this.lblKolor = new System.Windows.Forms.Label();
            this.lblTD = new System.Windows.Forms.Label();
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.cbTD = new System.Windows.Forms.ComboBox();
            this.cbKolor = new System.Windows.Forms.ComboBox();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukty)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLaptopy
            // 
            this.btnLaptopy.Location = new System.Drawing.Point(670, 47);
            this.btnLaptopy.Name = "btnLaptopy";
            this.btnLaptopy.Size = new System.Drawing.Size(102, 35);
            this.btnLaptopy.TabIndex = 0;
            this.btnLaptopy.Text = "Laptopy";
            this.btnLaptopy.UseVisualStyleBackColor = true;
            this.btnLaptopy.Click += new System.EventHandler(this.btnLaptopy_Click);
            // 
            // btnPC
            // 
            this.btnPC.Location = new System.Drawing.Point(563, 47);
            this.btnPC.Name = "btnPC";
            this.btnPC.Size = new System.Drawing.Size(101, 35);
            this.btnPC.TabIndex = 1;
            this.btnPC.Text = "PC";
            this.btnPC.UseVisualStyleBackColor = true;
            this.btnPC.Click += new System.EventHandler(this.btnPC_Click);
            // 
            // btnDrukarki
            // 
            this.btnDrukarki.Location = new System.Drawing.Point(778, 47);
            this.btnDrukarki.Name = "btnDrukarki";
            this.btnDrukarki.Size = new System.Drawing.Size(100, 35);
            this.btnDrukarki.TabIndex = 2;
            this.btnDrukarki.Text = "Drukarki";
            this.btnDrukarki.UseVisualStyleBackColor = true;
            this.btnDrukarki.Click += new System.EventHandler(this.btnDrukarki_Click);
            // 
            // dgvProdukty
            // 
            this.dgvProdukty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdukty.Location = new System.Drawing.Point(29, 96);
            this.dgvProdukty.Name = "dgvProdukty";
            this.dgvProdukty.RowHeadersWidth = 47;
            this.dgvProdukty.Size = new System.Drawing.Size(849, 434);
            this.dgvProdukty.TabIndex = 3;
            this.dgvProdukty.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdukty_CellContentClick);
            // 
            // tbSN
            // 
            this.tbSN.Location = new System.Drawing.Point(1054, 79);
            this.tbSN.Name = "tbSN";
            this.tbSN.Size = new System.Drawing.Size(172, 29);
            this.tbSN.TabIndex = 4;
            // 
            // tbProdukt
            // 
            this.tbProdukt.Location = new System.Drawing.Point(1054, 114);
            this.tbProdukt.Name = "tbProdukt";
            this.tbProdukt.Size = new System.Drawing.Size(172, 29);
            this.tbProdukt.TabIndex = 5;
            // 
            // lblSN
            // 
            this.lblSN.AutoSize = true;
            this.lblSN.Location = new System.Drawing.Point(909, 82);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(130, 22);
            this.lblSN.TabIndex = 7;
            this.lblSN.Text = "Numer seryjny";
            // 
            // lblProducent
            // 
            this.lblProducent.AutoSize = true;
            this.lblProducent.Location = new System.Drawing.Point(909, 117);
            this.lblProducent.Name = "lblProducent";
            this.lblProducent.Size = new System.Drawing.Size(97, 22);
            this.lblProducent.TabIndex = 8;
            this.lblProducent.Text = "Producent";
            // 
            // lblTyp
            // 
            this.lblTyp.AutoSize = true;
            this.lblTyp.Location = new System.Drawing.Point(909, 47);
            this.lblTyp.Name = "lblTyp";
            this.lblTyp.Size = new System.Drawing.Size(119, 22);
            this.lblTyp.TabIndex = 9;
            this.lblTyp.Text = "Typ produktu";
            // 
            // btnDodajProdukt
            // 
            this.btnDodajProdukt.Location = new System.Drawing.Point(1054, 413);
            this.btnDodajProdukt.Name = "btnDodajProdukt";
            this.btnDodajProdukt.Size = new System.Drawing.Size(172, 35);
            this.btnDodajProdukt.TabIndex = 10;
            this.btnDodajProdukt.Text = "Dodaj Produkt";
            this.btnDodajProdukt.UseVisualStyleBackColor = true;
            this.btnDodajProdukt.Click += new System.EventHandler(this.btnDodajProdukt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Filtruj";
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(457, 47);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(100, 35);
            this.btnAll.TabIndex = 14;
            this.btnAll.Text = "Wszystko";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // cbTyp
            // 
            this.cbTyp.FormattingEnabled = true;
            this.cbTyp.Items.AddRange(new object[] {
            "PC",
            "LAPTOP",
            "DRUKARKA"});
            this.cbTyp.Location = new System.Drawing.Point(1054, 44);
            this.cbTyp.Name = "cbTyp";
            this.cbTyp.Size = new System.Drawing.Size(172, 29);
            this.cbTyp.TabIndex = 15;
            this.cbTyp.SelectedIndexChanged += new System.EventHandler(this.cbTyp_SelectedIndexChanged);
            // 
            // tbProcessor
            // 
            this.tbProcessor.Location = new System.Drawing.Point(1054, 184);
            this.tbProcessor.Name = "tbProcessor";
            this.tbProcessor.Size = new System.Drawing.Size(172, 29);
            this.tbProcessor.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(909, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Processor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(909, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "Pamięć RAM";
            // 
            // tbRAM
            // 
            this.tbRAM.Location = new System.Drawing.Point(1054, 219);
            this.tbRAM.Name = "tbRAM";
            this.tbRAM.Size = new System.Drawing.Size(172, 29);
            this.tbRAM.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(909, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "Dysk HDD";
            // 
            // tbHDD
            // 
            this.tbHDD.Location = new System.Drawing.Point(1054, 289);
            this.tbHDD.Name = "tbHDD";
            this.tbHDD.Size = new System.Drawing.Size(172, 29);
            this.tbHDD.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(909, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 22);
            this.label5.TabIndex = 21;
            this.label5.Text = "Dysk SSD";
            // 
            // tbSSD
            // 
            this.tbSSD.Location = new System.Drawing.Point(1054, 254);
            this.tbSSD.Name = "tbSSD";
            this.tbSSD.Size = new System.Drawing.Size(172, 29);
            this.tbSSD.TabIndex = 20;
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(909, 187);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(140, 22);
            this.lblFormat.TabIndex = 31;
            this.lblFormat.Text = "Format Papieru";
            // 
            // lblEkran
            // 
            this.lblEkran.AutoSize = true;
            this.lblEkran.Location = new System.Drawing.Point(909, 327);
            this.lblEkran.Name = "lblEkran";
            this.lblEkran.Size = new System.Drawing.Size(58, 22);
            this.lblEkran.TabIndex = 29;
            this.lblEkran.Text = "Ekran";
            // 
            // tbEkran
            // 
            this.tbEkran.Location = new System.Drawing.Point(1054, 324);
            this.tbEkran.Name = "tbEkran";
            this.tbEkran.Size = new System.Drawing.Size(172, 29);
            this.tbEkran.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(909, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 22);
            this.label8.TabIndex = 27;
            this.label8.Text = "Cena";
            // 
            // tbCena
            // 
            this.tbCena.Location = new System.Drawing.Point(1054, 359);
            this.tbCena.Name = "tbCena";
            this.tbCena.Size = new System.Drawing.Size(172, 29);
            this.tbCena.TabIndex = 26;
            // 
            // lblCD
            // 
            this.lblCD.AutoSize = true;
            this.lblCD.Location = new System.Drawing.Point(909, 327);
            this.lblCD.Name = "lblCD";
            this.lblCD.Size = new System.Drawing.Size(124, 22);
            this.lblCD.TabIndex = 25;
            this.lblCD.Text = "Prędkość CD";
            // 
            // tbCD
            // 
            this.tbCD.Location = new System.Drawing.Point(1054, 324);
            this.tbCD.Name = "tbCD";
            this.tbCD.Size = new System.Drawing.Size(172, 29);
            this.tbCD.TabIndex = 24;
            // 
            // lblKolor
            // 
            this.lblKolor.AutoSize = true;
            this.lblKolor.Location = new System.Drawing.Point(909, 257);
            this.lblKolor.Name = "lblKolor";
            this.lblKolor.Size = new System.Drawing.Size(89, 22);
            this.lblKolor.TabIndex = 34;
            this.lblKolor.Text = "Kolorowa";
            // 
            // lblTD
            // 
            this.lblTD.AutoSize = true;
            this.lblTD.Location = new System.Drawing.Point(909, 222);
            this.lblTD.Name = "lblTD";
            this.lblTD.Size = new System.Drawing.Size(111, 22);
            this.lblTD.TabIndex = 36;
            this.lblTD.Text = "Typ drukarki";
            // 
            // cbFormat
            // 
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Items.AddRange(new object[] {
            "A2",
            "A3",
            "A4",
            "A5"});
            this.cbFormat.Location = new System.Drawing.Point(1054, 184);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(172, 29);
            this.cbFormat.TabIndex = 37;
            // 
            // cbTD
            // 
            this.cbTD.Items.AddRange(new object[] {
            "laser",
            "tusz"});
            this.cbTD.Location = new System.Drawing.Point(1054, 219);
            this.cbTD.Name = "cbTD";
            this.cbTD.Size = new System.Drawing.Size(172, 29);
            this.cbTD.TabIndex = 38;
            // 
            // cbKolor
            // 
            this.cbKolor.Items.AddRange(new object[] {
            "TAK",
            "NIE"});
            this.cbKolor.Location = new System.Drawing.Point(1054, 254);
            this.cbKolor.Name = "cbKolor";
            this.cbKolor.Size = new System.Drawing.Size(172, 29);
            this.cbKolor.TabIndex = 39;
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(1054, 495);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(172, 35);
            this.btnUsun.TabIndex = 40;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Location = new System.Drawing.Point(1054, 454);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(172, 35);
            this.btnEdytuj.TabIndex = 44;
            this.btnEdytuj.Text = "Edytuj";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // Produkt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 562);
            this.Controls.Add(this.btnEdytuj);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.cbKolor);
            this.Controls.Add(this.cbTD);
            this.Controls.Add(this.cbFormat);
            this.Controls.Add(this.lblTD);
            this.Controls.Add(this.lblKolor);
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.lblEkran);
            this.Controls.Add(this.tbEkran);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbCena);
            this.Controls.Add(this.lblCD);
            this.Controls.Add(this.tbCD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbHDD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSSD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbRAM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbProcessor);
            this.Controls.Add(this.cbTyp);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajProdukt);
            this.Controls.Add(this.lblTyp);
            this.Controls.Add(this.lblProducent);
            this.Controls.Add(this.lblSN);
            this.Controls.Add(this.tbProdukt);
            this.Controls.Add(this.tbSN);
            this.Controls.Add(this.dgvProdukty);
            this.Controls.Add(this.btnDrukarki);
            this.Controls.Add(this.btnPC);
            this.Controls.Add(this.btnLaptopy);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Produkt";
            this.Text = "Produkty";
            this.Load += new System.EventHandler(this.Produkt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLaptopy;
        private System.Windows.Forms.Button btnPC;
        private System.Windows.Forms.Button btnDrukarki;
        private System.Windows.Forms.DataGridView dgvProdukty;
        private System.Windows.Forms.TextBox tbSN;
        private System.Windows.Forms.TextBox tbProdukt;
        private System.Windows.Forms.Label lblSN;
        private System.Windows.Forms.Label lblProducent;
        private System.Windows.Forms.Label lblTyp;
        private System.Windows.Forms.Button btnDodajProdukt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.ComboBox cbTyp;
        private System.Windows.Forms.TextBox tbProcessor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRAM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbHDD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSSD;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.Label lblEkran;
        private System.Windows.Forms.TextBox tbEkran;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCena;
        private System.Windows.Forms.Label lblCD;
        private System.Windows.Forms.TextBox tbCD;
        private System.Windows.Forms.Label lblKolor;
        private System.Windows.Forms.Label lblTD;
        private System.Windows.Forms.ComboBox cbFormat;
        private System.Windows.Forms.ComboBox cbTD;
        private System.Windows.Forms.ComboBox cbKolor;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnEdytuj;
    }
}

