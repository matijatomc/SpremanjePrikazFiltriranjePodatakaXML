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
            var listaUcenika = new XDocument(new XElement("listaUcenika", from ucenik in XElement.Load("D:/Documents/xmlDokument/Ucenici.xml").Elements("Ucenik")
                                             where ucenik.Attribute("Ime").Value == txtIme.Text
                                             select ucenik));

            listaUcenika.Save("D:/Documents/xmlDokument/UceniciFiltrirani.xml");
        }
    }
}
