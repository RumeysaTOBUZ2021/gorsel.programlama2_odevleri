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
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }
        public void kitapEkle(string kitapAdi)
        {
            listBox1.Items.Add(kitapAdi);
        }
        public void yazarEkle(string yazarAdi)
        {
            listBox2.Items.Add(yazarAdi);
        }
        public void kitapDuzenle(string duzenlenmisKitapAdi)
        {
            listBox1.Items[listBox1.SelectedIndex] = duzenlenmisKitapAdi;
        }
        public void yazarDuzenle(string duzenlenmisYazarAdi)
        {
            listBox2.Items[listBox2.SelectedIndex] = duzenlenmisYazarAdi;
        }
        private void AnaEkran_Load(object sender, EventArgs e)
        {

        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            KitapEklemeEkranı kitapEklemeEkrani = new KitapEklemeEkranı(this);
            kitapEklemeEkrani.Show();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            KitapDüzenlemeEkranı kitapduzenlemeEkrani = new KitapDüzenlemeEkranı(this);
            kitapduzenlemeEkrani.Show();
            string yazarAdi = listBox2.Items[listBox1.SelectedIndex].ToString();
            string kitapAdi = listBox1.Items[listBox2.SelectedIndex].ToString();

            kitapduzenlemeEkrani.kitapdznl(kitapAdi);
            kitapduzenlemeEkrani.yazardznl(yazarAdi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
                if (MessageBox.Show("Silmek istediğinizden emin misiniz?", "Emin misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    int index = listBox1.SelectedIndex;
                    listBox1.Items.RemoveAt(index);
                    listBox2.Items.RemoveAt(index);
                }
            
        }
    }
}
