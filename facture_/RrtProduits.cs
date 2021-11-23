using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace facture_
{
    public partial class frmEnrProd : Form
    {
        public List<RprtProduit> produits= new List<RprtProduit>();
        public frmEnrProd()
        {
            InitializeComponent();
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            this.produits.Add(new RprtProduit(textref.Text, textProd.Text, double.Parse(textPrix.Text), double.Parse(textQte.Text)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Previews frm = new Previews(this.produits);
            frm.Show();
            this.Close();

        }

        private void textProd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
