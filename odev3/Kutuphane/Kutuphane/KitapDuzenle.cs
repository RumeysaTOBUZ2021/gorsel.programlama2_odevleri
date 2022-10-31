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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kutuphane
{
    public partial class KitapDuzenle : Form
    {
        AnaEkran anaEkran;

        public KitapDuzenle(AnaEkran parametredenGelenAnaEkran, Kitap kitap)
        {
            InitializeComponent();
            anaEkran = parametredenGelenAnaEkran;

            textBox1.Text = kitap.Ad;
            comboBox2.Text = kitap.Yazar;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap(textBox1.Text, comboBox2.Text);
            anaEkran.kitapDuzenle(kitap);
            anaEkran.Show();
            this.Close();
        }
        private void KitapDuzenle_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaEkran.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
        }
        private void KitapDuzenle_Load(object sender, EventArgs e)
        {
             object[] yazarlar = new object[] {"Canan Tan","Amin Maalouf","Albert Camus","Lale Müldür","Cemal Süreya","Orhan Pamuk","Minâ Urgan","Peyami Safa","Ray Bradbury","Çiğdem Anad","Ayşe Kulin","Elif Şafak","William Shakespeare","Oya Uysal","Nuray Tekin",
             "Reha İsvan","Tomris Uyar","Stefan Zweig","Gülseren Budayıcıoğlu", "Sabahattin Ali","Zülfü Livaneli","Yaşar Kemal","Doğan Cüceloğlu","Ahmet Ümit","Dilek Zaptçıoğlu","Dostoyevski","Varol Yaşaroğlu","Yılmaz Özdil",
             "Necip Fazıl Kısakürek","Esin Afşar","Oğuz Atay","Nazan Bekiroğlu","Anton Çehov","Hatice Kübra Tongar","Cahit Zarifoğlu","Şermin Yaşar","Ahmet Hamdi Tanpınar","Sait Faik Abasıyanık","Feride Çiçekoğlu","Victor Hugo",
             "Peyami Safa","Sevgi Soysal","Adalet Ağaoğlu","İskender Pala","George Orwell","Güzin Dino","Cengiz Aytmatov","İpek Şahbenderoğlu","İlber Ortaylı","Mustafa Kutlu","Paulo Coelho",
             "Pelin Buzluk","Franz Kafka","Jose Saramago","John Steinbeck","Jale Baysal","Karin Karakaşlı","J.K. Rowling","Lev Nikolayeviç Tolstoy","Gabriel Garcia Marquez","Başak Sayan","Ülkü Karaosmanoğlu","Vivet Kanetti"
             };
            comboBox2.Items.AddRange(yazarlar);

            comboBox2.Text = "Lütfen Yazar Seçin";

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            for (int i = 0; i < comboBox2.Items.Count; i++)
            {
                collection.Add(comboBox2.Items[i].ToString());
            }
            comboBox2.AutoCompleteCustomSource = collection;
            comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox2.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    }
}
