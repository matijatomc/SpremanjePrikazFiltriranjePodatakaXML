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
    public partial class FormaXMLTransformerPregled : Form
    {
        public FormaXMLTransformerPregled()
        {
            InitializeComponent();
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            var listaUcenika = from ucenik in XElement.Load("D:/Documents/xmlDokument/Ucenici.xml").Elements("Ucenik").Attributes()
                       select ucenik;
            richTextBox1.Clear();
            foreach (var item in listaUcenika)
            {
                richTextBox1.Text += item.ToString() + " \n";
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            FormaXMLTransformerPocetna frm = new FormaXMLTransformerPocetna();
            this.Hide();
            DialogResult rez = frm.ShowDialog();
            this.Close();
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaXMLTransformerFiltriranje frm = new FormaXMLTransformerFiltriranje();
            frm.ShowDialog();
            this.Show();
            var listaUcenika = from ucenik in XElement.Load("D:/Documents/xmlDokument/UceniciFiltrirani.xml").Elements("Ucenik").Attributes()
                               select ucenik;
            richTextBox1.Clear();
            foreach (var item in listaUcenika)
            {
                richTextBox1.Text += item.ToString() + " \n";
            }
        }
    }
}
