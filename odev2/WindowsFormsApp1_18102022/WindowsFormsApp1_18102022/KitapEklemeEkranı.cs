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
    public partial class KitapEklemeEkranı : Form
    {
        AnaEkran anaEkran;
        public KitapEklemeEkranı(AnaEkran parametredenGelenAnaEkran)
        {
            InitializeComponent();
            anaEkran = parametredenGelenAnaEkran;
        }

        private void KitapEklemeEkranı_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            anaEkran.kitapEkle(textBox1.Text);
            anaEkran.yazarEkle(textBox2.Text);
            anaEkran.Show();
            this.Close();
        }
    }
}
