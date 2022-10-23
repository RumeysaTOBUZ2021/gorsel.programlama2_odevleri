using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_18102022
{
    public partial class KitapDüzenlemeEkranı : Form
    {
        AnaEkran anaEkran;
        public KitapDüzenlemeEkranı(AnaEkran parametredenGelenAnaEkran)
        {
            InitializeComponent();
            anaEkran = parametredenGelenAnaEkran;
        }

        private void KitapDüzenlemeEkranı_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            anaEkran.kitapDuzenle(textBox1.Text);
            anaEkran.yazarDuzenle(textBox2.Text);
            this.Close();
        }
        public void kitapdznl(string prm)
        {
            textBox1.Text = prm;
        }
        public void yazardznl(string prm)
        {
            textBox2.Text = prm;
            textBox2.Focus();
            textBox2.Select(textBox2.Text.ToString().Length, 0);
            textBox2.Text = prm;
        }
    }
}
