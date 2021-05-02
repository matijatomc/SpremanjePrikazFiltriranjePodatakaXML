using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tomcMatijaSpremanjePrikazFiltriranjeXml
{
    public partial class FormaXMLTransformerPocetna : Form
    {
        public FormaXMLTransformerPocetna()
        {
            InitializeComponent();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            FormaXMLTransformerUnos frm = new FormaXMLTransformerUnos();
            this.Hide();
            DialogResult rez = frm.ShowDialog();
            this.Close();
        }

        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            FormaXMLTransformerPregled frm = new FormaXMLTransformerPregled();
            this.Hide();
            DialogResult rez = frm.ShowDialog();
            this.Close();
        }
    }
}
