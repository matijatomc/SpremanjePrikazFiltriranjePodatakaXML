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

namespace tomcMatijaSpremanjePrikazFiltriranjeXml
{
    public partial class FormaXMLTransformerFiltriranje : Form
    {
        public FormaXMLTransformerFiltriranje()
        {
            InitializeComponent();
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            var listaUcenika = new XDocument();
            if (string.IsNullOrEmpty(txtIme.Text) && string.IsNullOrEmpty(txtPrezime.Text) && string.IsNullOrEmpty(txtEmail.Text) && string.IsNullOrEmpty(cmbRazred.Text))
            {
                listaUcenika = new XDocument(new XElement("listaUcenika", from ucenik in XElement.Load("D:/Documents/xmlDokument/Ucenici.xml").Elements("Ucenik")
                                                                              select ucenik));
            }
            else
            {
                listaUcenika = new XDocument(new XElement("listaUcenika", from ucenik in XElement.Load("D:/Documents/xmlDokument/Ucenici.xml").Elements("Ucenik")
                                                                              where (!string.IsNullOrEmpty(txtIme.Text) && ucenik.Attribute("Ime").Value == txtIme.Text) || 
                                                                              (!string.IsNullOrEmpty(txtPrezime.Text) && ucenik.Attribute("Prezime").Value == txtPrezime.Text) ||
                                                                              (!string.IsNullOrEmpty(txtEmail.Text) && ucenik.Attribute("EmailAdresa").Value == txtEmail.Text) || 
                                                                              (!string.IsNullOrEmpty(cmbRazred.Text) && ucenik.Attribute("Razred").Value == cmbRazred.Text)
                                                                              select ucenik));
            }

            listaUcenika.Save("D:/Documents/xmlDokument/UceniciFiltrirani.xml");
            this.Close();
        }

        private void btnZavrsi_Click(object sender, EventArgs e)
        {
            var listaUcenika = new XDocument(new XElement("listaUcenika", from ucenik in XElement.Load("D:/Documents/xmlDokument/Ucenici.xml").Elements("Ucenik")
                                                                      select ucenik));
            listaUcenika.Save("D:/Documents/xmlDokument/UceniciFiltrirani.xml");
            this.Close();
        }
    }
}
