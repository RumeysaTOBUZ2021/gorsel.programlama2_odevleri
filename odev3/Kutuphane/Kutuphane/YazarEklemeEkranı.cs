using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Kutuphane
{
    public partial class YazarEklemeEkranı : Form
    {
        public YazarEklemeEkranı()
        {
            InitializeComponent();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            object[] yazarlar = new object[] {"Canan Tan","Amin Maalouf","Albert Camus","Lale Müldür","Cemal Süreya","Orhan Pamuk","Minâ Urgan","Peyami Safa","Ray Bradbury","Çiğdem Anad","Ayşe Kulin","Elif Şafak","William Shakespeare","Oya Uysal","Nuray Tekin",
             "Reha İsvan","Tomris Uyar","Stefan Zweig","Gülseren Budayıcıoğlu", "Sabahattin Ali","Zülfü Livaneli","Yaşar Kemal","Doğan Cüceloğlu","Ahmet Ümit","Dilek Zaptçıoğlu","Dostoyevski","Varol Yaşaroğlu","Yılmaz Özdil",
             "Necip Fazıl Kısakürek","Esin Afşar","Oğuz Atay","Nazan Bekiroğlu","Anton Çehov","Hatice Kübra Tongar","Cahit Zarifoğlu","Şermin Yaşar","Ahmet Hamdi Tanpınar","Sait Faik Abasıyanık","Feride Çiçekoğlu","Victor Hugo",
             "Peyami Safa","Sevgi Soysal","Adalet Ağaoğlu","İskender Pala","George Orwell","Güzin Dino","Cengiz Aytmatov","İpek Şahbenderoğlu","İlber Ortaylı","Mustafa Kutlu","Paulo Coelho",
             "Pelin Buzluk","Franz Kafka","Jose Saramago","John Steinbeck","Jale Baysal","Karin Karakaşlı","J.K. Rowling","Lev Nikolayeviç Tolstoy","Gabriel Garcia Marquez","Başak Sayan","Ülkü Karaosmanoğlu","Vivet Kanetti"
            };
            comboBox8.Items.AddRange(yazarlar);
            comboBox8.Text = "Eklenen Yazarı Seçin";
            comboBox8.Items.Insert(0, textBox8.Text);
            textBox8.Clear();
        }
        private void YazarEklemeEkranı_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yazarı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                comboBox8.Items.RemoveAt(comboBox8.SelectedIndex);
            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

    }
}
