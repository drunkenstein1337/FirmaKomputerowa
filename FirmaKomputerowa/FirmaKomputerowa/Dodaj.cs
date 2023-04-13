using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirmaKomputerowa
{
    public partial class Dodaj : Form
    {

        FirmaKomputerowaEntities db = new FirmaKomputerowaEntities();
        public Dodaj()
        {
            InitializeComponent();
            initdgvProdukty();
        }

        private void initdgvProdukty()
        {
            dgv1.DataSource = db.Drukarki.SqlQuery("SELECT * FROM Drukarki INNER JOIN Produkty ON Drukarki.SN = Produkty.SN").ToList();
            //this.dgv1.Columns["Drukarki"].Visible = false;
            //dgv1.Columns["Laptopy"].Visible = false;
            //dgv1.Columns["PC"].Visible = false;
            //dgv1.Columns["SN"].HeaderText = "Numer Seryjny";
            //dgv1.Columns["Typ"].HeaderText = "Typ produktu";

            dgv1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
