using System;
using System.Collections.Generic;
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
    public partial class KitapEkle : Form
    {
        AnaEkran anaEkran;
        public KitapEkle(AnaEkran parametredenGelenAnaEkran)
        {
            InitializeComponent();
            anaEkran = parametredenGelenAnaEkran;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap(textBox1.Text, comboBox1.Text);
            anaEkran.kitapEkle(kitap);

            anaEkran.Show();
            this.Close();
        }
        private void KitapEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaEkran.Show();
        }
        private void KitapEkle_Load(object sender, EventArgs e)
        {
            object[] yazarlar = new object[] {"Canan Tan","Amin Maalouf","Albert Camus","Lale Müldür","Cemal Süreya","Orhan Pamuk","Minâ Urgan","Peyami Safa","Ray Bradbury","Çiğdem Anad","Ayşe Kulin","Elif Şafak","William Shakespeare","Oya Uysal","Nuray Tekin",
             "Reha İsvan","Tomris Uyar","Stefan Zweig","Gülseren Budayıcıoğlu", "Sabahattin Ali","Zülfü Livaneli","Yaşar Kemal","Doğan Cüceloğlu","Ahmet Ümit","Dilek Zaptçıoğlu","Dostoyevski","Varol Yaşaroğlu","Yılmaz Özdil",
             "Necip Fazıl Kısakürek","Esin Afşar","Oğuz Atay","Nazan Bekiroğlu","Anton Çehov","Hatice Kübra Tongar","Cahit Zarifoğlu","Şermin Yaşar","Ahmet Hamdi Tanpınar","Sait Faik Abasıyanık","Feride Çiçekoğlu","Victor Hugo",
             "Peyami Safa","Sevgi Soysal","Adalet Ağaoğlu","İskender Pala","George Orwell","Güzin Dino","Cengiz Aytmatov","İpek Şahbenderoğlu","İlber Ortaylı","Mustafa Kutlu","Paulo Coelho",
             "Pelin Buzluk","Franz Kafka","Jose Saramago","John Steinbeck","Jale Baysal","Karin Karakaşlı","J.K. Rowling","Lev Nikolayeviç Tolstoy","Gabriel Garcia Marquez","Başak Sayan","Ülkü Karaosmanoğlu","Vivet Kanetti"
            };
            comboBox1.Items.AddRange(yazarlar);
            comboBox1.Text = "Lütfen Yazar Seçin";

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                collection.Add(comboBox1.Items[i].ToString());
            }
            comboBox1.AutoCompleteCustomSource = collection;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void button9_Click(object sender, EventArgs e)
        {
            YazarEklemeEkranı yazarEklemeEkranı = new YazarEklemeEkranı();
            yazarEklemeEkranı.Show();
        }
    }
}
