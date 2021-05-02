using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace tomcMatijaSpremanjePrikazFiltriranjeXml
{
    public partial class FormaXMLTransformerUnos : Form
    {
        List<Ucenik> listaUcenika = new List<Ucenik>();
        public FormaXMLTransformerUnos()
        {
            InitializeComponent();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIme.Text) || string.IsNullOrEmpty(txtPrezime.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(cmbRazred.Text))
            {
                MessageBox.Show("Niste unijeli sve podatke", "Greška");
                return;
            }

            Ucenik ucenik = new Ucenik(txtIme.Text, txtPrezime.Text, txtEmail.Text, cmbRazred.Text);
            listaUcenika.Add(ucenik);

            txtIme.Clear();
            txtPrezime.Clear();
            txtEmail.Clear();
            cmbRazred.Text = " ";
        }

        private void btnZavrsi_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(@"D:\Documents\xmlDokument"))
            {
                Directory.CreateDirectory(@"D:\Documents\xmlDokument");
            }

            var dokumentXmlUcenici = new XDocument(new XElement("listaUcenika",
                    from Ucenik in listaUcenika
                    select new XElement("Ucenik",
                        new XAttribute("Ime", Ucenik.Ime),
                        new XAttribute("Prezime", Ucenik.Prezime),
                        new XAttribute("EmailAdresa", Ucenik.Email),
                        new XAttribute("Razred", Ucenik.Razred)
                        )));

            dokumentXmlUcenici.Save("D:/Documents/xmlDokument/Ucenici.xml");

            FormaXMLTransformerPocetna frm = new FormaXMLTransformerPocetna();
            this.Hide();
            DialogResult rez = frm.ShowDialog();
            this.Close();
        }
    }
}
