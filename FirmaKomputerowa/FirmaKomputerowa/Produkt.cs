using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.AxHost;

namespace FirmaKomputerowa
{
    public partial class Produkt : Form
    {

        FirmaKomputerowaEntities db = new FirmaKomputerowaEntities();
        bool wszystko = true;

        public Produkt()
        {
            InitializeComponent();
            show();
            cbTyp.SelectedIndex = 0;
            initdgvProdukty();
        }

        private void initdgvProdukty()
        {

            dgvProdukty.DataSource = db.Produkty.ToList();
            this.dgvProdukty.Columns["Drukarki"].Visible = false;
            dgvProdukty.Columns["ProduktyID"].Visible = false;
            dgvProdukty.Columns["Laptopy"].Visible = false;
            dgvProdukty.Columns["PC"].Visible = false;
            dgvProdukty.Columns["SN"].HeaderText = "Numer Seryjny";
            dgvProdukty.Columns["SN"].DisplayIndex = 0;
            dgvProdukty.Columns["Typ"].HeaderText = "Typ produktu";

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            initdgvProdukty();
            wszystko = true;
        }

        private void btnLaptopy_Click(object sender, EventArgs e)
        {
            var queryLaptopy = (from p in db.Produkty
                                join d in db.Laptopy on p.SN equals d.SN
                                select new
                                {
                                    Numer_seryjny = p.SN,
                                    Producent = p.Producent,
                                    Processor = d.Procesor,
                                    Ram = d.Pamiec_RAM,
                                    SSD = d.Dysk_SSD,
                                    HDD = d.Dysk_HDD,
                                    Ekran = d.Ekran,
                                    Cena = d.Cena
                                }).ToList();
            dgvProdukty.DataSource = queryLaptopy;
            dgvProdukty.Columns["Numer_seryjny"].HeaderText = "Numer seryjny";
            dgvProdukty.Columns["Ram"].HeaderText = "Pamięć RAM";
            wszystko = false;

        }

        private void btnDrukarki_Click(object sender, EventArgs e)
        {
            var queryDrukarki = (from p in db.Produkty
                                 join d in db.Drukarki on p.SN equals d.SN
                                 select new
                                 {
                                     Numer_seryjny = p.SN,
                                     Producent = p.Producent,
                                     Format_Papieru = d.Format_papieru,
                                     Typ = d.Typ_Drukarki,
                                     Kolor = d.Kolor,
                                     Cena = d.Cena
                                 }).ToList();
            dgvProdukty.DataSource = queryDrukarki;
            dgvProdukty.Columns["Format_Papieru"].HeaderText = "Format papieru";
            dgvProdukty.Columns["Numer_seryjny"].HeaderText = "Numer seryjny";
            //dgvProdukty.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            wszystko = false;
        }

        private void btnPC_Click(object sender, EventArgs e)
        {
            var queryPC = (from p in db.Produkty
                           join d in db.PC on p.SN equals d.SN
                           select new
                           {
                               Numer_seryjny = p.SN,
                               Producent = p.Producent,
                               Processor = d.Procesor,
                               Ram = d.Pamiec_RAM,
                               SSD = d.Dysk_SSD,
                               HDD = d.Dysk_HDD,
                               CD = d.Predkosc_CD,
                               Cena = d.Cena
                           }).ToList();
            dgvProdukty.DataSource = queryPC;
            dgvProdukty.Columns["Numer_seryjny"].HeaderText = "Numer seryjny";
            dgvProdukty.Columns["CD"].HeaderText = "Predkość CD";
            //dgvProdukty.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            wszystko = false;
        }

        private void btnDodajProdukt_Click(object sender, EventArgs e)
        {
            Produkty dodaj = new Produkty();

            int serial;
            

            if (int.TryParse(tbSN.Text, out serial) && string.IsNullOrEmpty(tbProdukt.Text) == false)
            {
                if (db.Produkty.Any(o => o.SN == serial))
                {
                    MessageBox.Show("Rekord o podanym numerze seryjnym już istnieje xdd");
                    return;
                }
                    
                try
                {
                    dodaj.SN = Int32.Parse(tbSN.Text);
                    dodaj.Producent = tbProdukt.Text;


                    if (cbTyp.SelectedIndex == 0)
                    {
                        dodaj.Typ = "PC";
                        PC dodaj0 = new PC
                        {
                            SN = Int32.Parse(tbSN.Text),
                            Procesor = Math.Round(float.Parse(tbProcessor.Text), 1),
                            Pamiec_RAM = Int32.Parse(tbRAM.Text),
                            Dysk_SSD = Int32.Parse(tbSSD.Text),
                            Dysk_HDD = Int32.Parse(tbHDD.Text),
                            Predkosc_CD = tbCD.Text,
                            Cena = Int32.Parse(tbCena.Text),
                        };
                        db.PC.Add(dodaj0);
                        db.Produkty.Add(dodaj);
                    }
                    else if (cbTyp.SelectedIndex == 1)
                    {
                        dodaj.Typ = "LAPTOP";
                        Laptopy dodaj1 = new Laptopy
                        {
                            SN = Int32.Parse(tbSN.Text),
                            Procesor = Math.Round(float.Parse(tbProcessor.Text), 1),
                            Pamiec_RAM = Int32.Parse(tbRAM.Text),
                            Dysk_SSD = Int32.Parse(tbSSD.Text),
                            Dysk_HDD = Int32.Parse(tbHDD.Text),
                            Ekran = Int32.Parse(tbEkran.Text),
                            Cena = Int32.Parse(tbCena.Text),
                        };
                        db.Laptopy.Add(dodaj1);
                        db.Produkty.Add(dodaj);
                    }
                    else if (cbTyp.SelectedIndex == 2)
                    {
                        dodaj.Typ = "DRUKARKA";
                        Drukarki dodaj2 = new Drukarki
                        {
                            SN = Int32.Parse(tbSN.Text),
                            Format_papieru = cbFormat.Text,
                            Typ_Drukarki = cbTD.Text,
                            Cena = Int32.Parse(tbCena.Text),
                        };
                        if (cbKolor.SelectedIndex == 1)
                            dodaj2.Kolor = false;
                        else
                            dodaj2.Kolor = true;

                        db.Drukarki.Add(dodaj2);
                        db.Produkty.Add(dodaj);

                    }

                    db.SaveChanges();
                    initdgvProdukty();
                    MessageBox.Show("Dodano pomyślnie");
                }
                catch
                {
                    MessageBox.Show("Wprowadzono błędne dane");
                };
            }
            else { MessageBox.Show("Wprowadzono błędne dane"); }
        }

        private void dgvProdukty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (wszystko)
            {


                int dataSN = Int32.Parse(dgvProdukty.Rows[e.RowIndex].Cells[1].Value.ToString());
                string dataTyp = dgvProdukty.Rows[e.RowIndex].Cells[3].Value.ToString();

                switch (dataTyp.ToString())
                {
                    case "PC":
                        cbTyp.SelectedIndex = 0;

                        var queryPC = (from p in db.Produkty
                                       join d in db.PC on p.SN equals d.SN
                                       where p.SN == dataSN
                                       select new
                                       {
                                           Numer_seryjny = p.SN,
                                           Producent = p.Producent,
                                           Processor = d.Procesor,
                                           Ram = d.Pamiec_RAM,
                                           SSD = d.Dysk_SSD,
                                           HDD = d.Dysk_HDD,
                                           CD = d.Predkosc_CD,
                                           Cena = d.Cena
                                       }).ToList();
                        // dgvProdukty.DataSource = queryPC;
                        //dgvProdukty.Columns["Numer_seryjny"].HeaderText = "Numer seryjny";
                        // dgvProdukty.Columns["CD"].HeaderText = "Predkość CD";

                        foreach (var item in queryPC)
                        {
                            tbSN.Text = item.Numer_seryjny.ToString();
                            tbProdukt.Text = item.Producent.ToString();
                            tbProcessor.Text = item.Processor.ToString();
                            tbRAM.Text = item.Ram.ToString();
                            tbSSD.Text = item.SSD.ToString();
                            tbHDD.Text = item.HDD.ToString();
                            tbCD.Text = item.CD.ToString();
                            tbCena.Text = item.Cena.ToString();
                        }


                        break;

                    case "LAPTOP":
                        cbTyp.SelectedIndex = 1;


                        var queryLaptopy = (from p in db.Produkty
                                            join d in db.Laptopy on p.SN equals d.SN
                                            where p.SN == dataSN
                                            select new
                                            {
                                                Numer_seryjny = p.SN,
                                                Producent = p.Producent,
                                                Processor = d.Procesor,
                                                Ram = d.Pamiec_RAM,
                                                SSD = d.Dysk_SSD,
                                                HDD = d.Dysk_HDD,
                                                Ekran = d.Ekran,
                                                Cena = d.Cena
                                            }).ToList();
                        // dgvProdukty.DataSource = queryLaptopy;
                        // dgvProdukty.Columns["Numer_seryjny"].HeaderText = "Numer seryjny";
                        //dgvProdukty.Columns["Ram"].HeaderText = "Pamięć RAM";


                        foreach (var item in queryLaptopy)
                        {
                            tbSN.Text = item.Numer_seryjny.ToString();
                            tbProdukt.Text = item.Producent.ToString();
                            tbProcessor.Text = item.Processor.ToString();
                            tbRAM.Text = item.Ram.ToString();
                            tbSSD.Text = item.SSD.ToString();
                            tbHDD.Text = item.HDD.ToString();
                            tbEkran.Text = item.Ekran.ToString();
                            tbCena.Text = item.Cena.ToString();
                        }


                        break;

                    case "DRUKARKA":
                        cbTyp.SelectedIndex = 2;

                        var queryDrukarki = (from p in db.Produkty
                                             join d in db.Drukarki on p.SN equals d.SN
                                             where p.SN == dataSN
                                             select new
                                             {
                                                 Numer_seryjny = p.SN,
                                                 Producent = p.Producent,
                                                 Format_Papieru = d.Format_papieru,
                                                 Typ = d.Typ_Drukarki,
                                                 Kolor = d.Kolor,
                                                 Cena = d.Cena
                                             }).ToList();



                        foreach (var item in queryDrukarki)
                        {
                            tbSN.Text = item.Numer_seryjny.ToString();
                            tbProdukt.Text = item.Producent.ToString();
                            cbFormat.Text = item.Format_Papieru.ToString();
                            cbTD.Text = item.Typ.ToString();
                            tbCena.Text = item.Cena.ToString();
                            if (item.Kolor)
                                cbKolor.Text = "TAK";
                            else
                                cbKolor.Text = "NIE";
                        }

                        break;
                }

            }

        }

        private void Produkt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dodaj secondForm = new Dodaj();
            secondForm.Show();

        }

        private void cbTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbTyp.SelectedIndex)
            {
                case 0:
                    show();
                    lblEkran.Visible = false;
                    lblCD.Visible = true;
                    tbEkran.Visible = false;
                    tbCD.Visible = true;
                    break;

                case 1:
                    show();
                    lblEkran.Visible = true;
                    lblCD.Visible = false;
                    tbEkran.Visible = true;
                    tbCD.Visible = false;
                    break;

                case 2:

                    hide();
                    lblEkran.Visible = false;
                    lblCD.Visible = false;
                    tbEkran.Visible = false;
                    tbCD.Visible = false;
                    break;
            }
        }


        private void hide()
        {
            lblFormat.Visible = true;
            lblKolor.Visible = true;
            lblTD.Visible = true;
            cbFormat.Visible = true;
            cbKolor.Visible = true;
            cbTD.Visible = true;

            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            tbProcessor.Visible = false;
            tbHDD.Visible = false;
            tbSSD.Visible = false;
        }

        private void show()
        {
            lblFormat.Visible = false;
            lblKolor.Visible = false;
            lblTD.Visible = false;
            cbFormat.Visible = false;
            cbKolor.Visible = false;
            cbTD.Visible = false;


            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            tbProcessor.Visible = true;
            tbHDD.Visible = true;
            tbSSD.Visible = true;
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            int selectedIndex = 0;
            int.TryParse(tbSN.Text, out selectedIndex);

            if (db.Produkty.Any(o => o.SN == selectedIndex))
            {


                if (selectedIndex != 0)
                {
                    {
                        using (var context = new FirmaKomputerowaEntities())
                        {
                            var itemToRemove = context.Produkty.SingleOrDefault(d => d.SN == selectedIndex);
                            var itemToRemove0 = context.PC.SingleOrDefault(d => d.SN == selectedIndex);
                            var itemToRemove1 = context.Drukarki.SingleOrDefault(d => d.SN == selectedIndex);
                            var itemToRemove2 = context.Laptopy.SingleOrDefault(d => d.SN == selectedIndex);
                            if (itemToRemove != null)
                            {
                                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć rekord?", " ", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    if (itemToRemove0 != null)
                                    {
                                        context.PC.Attach(itemToRemove0);
                                        context.PC.Remove(itemToRemove0);
                                        context.SaveChanges();
                                    }
                                    if (itemToRemove1 != null)
                                    {
                                        context.Drukarki.Attach(itemToRemove1);
                                        context.Drukarki.Remove(itemToRemove1);
                                        context.SaveChanges();
                                    }
                                    if (itemToRemove2 != null)
                                    {
                                        context.Laptopy.Attach(itemToRemove2);
                                        context.Laptopy.Remove(itemToRemove2);
                                        context.SaveChanges();
                                    }
                                    context.Produkty.Attach(itemToRemove);
                                    context.Produkty.Remove(itemToRemove);
                                    context.SaveChanges();

                                    try
                                    {
                                        db.SaveChanges();
                                        initdgvProdukty();
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Błąd");
                                    };

                                }
                            }
                            else { MessageBox.Show("Brak rekordu o podanym numerze seryjnym"); };
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Rekord o podanym numerze seryjnym nie istnieje xdd");
                return;
            }
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            Produkty dodaj = new Produkty();

            int serial;

            if (int.TryParse(tbSN.Text, out serial) && string.IsNullOrEmpty(tbProdukt.Text) == false)
            {
                try
                {

                    if (cbTyp.SelectedIndex == 0)
                    {
                        dodaj.Typ = "PC";
                        PC dodaj0 = new PC
                        {
                            SN = Int32.Parse(tbSN.Text),
                            Procesor = Math.Round(float.Parse(tbProcessor.Text), 1),
                            Pamiec_RAM = Int32.Parse(tbRAM.Text),
                            Dysk_SSD = Int32.Parse(tbSSD.Text),
                            Dysk_HDD = Int32.Parse(tbHDD.Text),
                            Predkosc_CD = tbCD.Text,
                            Cena = Int32.Parse(tbCena.Text),
                        };
                        db.PC.Add(dodaj0);
                        db.Produkty.Add(dodaj);

                        using (var context = new FirmaKomputerowaEntities())
                        {
                            var item = context.PC.SingleOrDefault(d => d.SN == serial);

                            item.Procesor = dodaj0.Procesor;
                            item.Pamiec_RAM = dodaj0.Pamiec_RAM;
                            item.Dysk_SSD = dodaj0.Dysk_SSD;
                            item.Dysk_HDD = dodaj0.Dysk_HDD;
                            item.Predkosc_CD = dodaj0.Predkosc_CD;
                            item.Cena = dodaj0.Cena;
                            context.SaveChanges();
                            MessageBox.Show("Zmiany zostały wprowadzone");
                        }

                    }
                    else if (cbTyp.SelectedIndex == 1)
                    {
                        dodaj.Typ = "LAPTOP";
                        Laptopy dodaj1 = new Laptopy
                        {
                            SN = Int32.Parse(tbSN.Text),
                            Procesor = Math.Round(float.Parse(tbProcessor.Text), 1),
                            Pamiec_RAM = Int32.Parse(tbRAM.Text),
                            Dysk_SSD = Int32.Parse(tbSSD.Text),
                            Dysk_HDD = Int32.Parse(tbHDD.Text),
                            Ekran = Int32.Parse(tbEkran.Text),
                            Cena = Int32.Parse(tbCena.Text),
                        };
                        using (var context = new FirmaKomputerowaEntities())
                        {
                            var item = context.Laptopy.SingleOrDefault(d => d.SN == serial);

                            item.Procesor = dodaj1.Procesor;
                            item.Pamiec_RAM = dodaj1.Pamiec_RAM;
                            item.Dysk_SSD = dodaj1.Dysk_SSD;
                            item.Dysk_HDD = dodaj1.Dysk_HDD;
                            item.Ekran = dodaj1.Ekran;
                            item.Cena = dodaj1.Cena;
                            context.SaveChanges();
                            MessageBox.Show("Zmiany zostały wprowadzone");
                        }
                    }
                    else if (cbTyp.SelectedIndex == 2)
                    {
                        dodaj.Typ = "DRUKARKA";
                        Drukarki dodaj2 = new Drukarki
                        {
                            SN = Int32.Parse(tbSN.Text),
                            Format_papieru = cbFormat.Text,
                            Typ_Drukarki = cbTD.Text,
                            Cena = Int32.Parse(tbCena.Text),
                        };
                        if (cbKolor.SelectedIndex == 1)
                            dodaj2.Kolor = false;
                        else
                            dodaj2.Kolor = true;

                        using (var context = new FirmaKomputerowaEntities())
                        {
                            var item = context.Drukarki.SingleOrDefault(d => d.SN == serial);

                            item.Format_papieru = dodaj2.Format_papieru;
                            item.Typ_Drukarki = dodaj2.Typ_Drukarki; 
                            item.Cena = dodaj2.Cena;   
                            item.Kolor = dodaj2.Kolor;
                            context.SaveChanges();
                            MessageBox.Show("Zmiany zostały wprowadzone");
                        }

                    }
                    db.SaveChanges();
                    initdgvProdukty();
                }
                catch
                {

                };
            }
            else { MessageBox.Show("Wprowadzono błędne dane"); }

        }
    }
}
