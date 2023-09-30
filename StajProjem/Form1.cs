using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StajProjem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secim=comboBox1.SelectedIndex;
            switch (secim)
            {
                case 0:
                    label2.Text = " Koç Burcu:";
                    label3.Text = "Olumlu özellikleri: Enerjik, cesaret verici, durdurulamaz, cesur, adanmış, kahraman, şefkatli";
                    label4.Text= "Olumsuz özellikleri: Kibirli, benmerkezci, itkisel, buyurgan, inatçı, umursamaz, kıskanç";
                    pictureBox1.ImageLocation = "astrolojikoc.jpg";
                    pictureBox1.SizeMode=PictureBoxSizeMode.AutoSize;
                    break;
               
                case 1:
                    label2.Text = " Boğa Burcu:";
                    label3.Text = "Olumlu özellikleri: Sabırlı, düzenli, yardımcı, romantik, özenli, adanmış";
                    label4.Text = "Olumsuz özellikleri: Fazla hoşgörülü, inatçı, tembel, fazla ihtiyatlı";
                    pictureBox1.ImageLocation = "astrolojiboga.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
               
                case 2:
                    label2.Text = " İkizler Burcu:";
                    label3.Text = "Olumlu özellikleri: Etkileyici, özgün, iş bilen, alımlı, akıllı, maceracı";
                    label4.Text = "Olumsuz özellikleri: Vesveseli, dengesiz, iki yüzlü, yargılayıcı, depresif";
                    pictureBox1.ImageLocation = "astrolojiikizler.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;

                case 3:
                    label2.Text = " Yengeç Burcu:";
                    label3.Text = "Olumlu özellikleri: Yardımsever, sabırlı, merhametli, anaç, romantik, yaratıcı";
                    label4.Text = "Olumsuz özellikleri: Dedikoducu, burnu havada, ketum, aşırı duyarlı, fazla rekabetçi";
                    pictureBox1.ImageLocation = "astrolojiyengec.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;

                case 4:
                    label2.Text = " Aslan Burcu:";
                    label3.Text = "Olumlu özellikleri: Cesur, kibar, cömert, sadık, koruyucu, dobra, eğlenceli";
                    label4.Text = "Olumsuz özellikleri: Küstah, müsrif, özensiz, taş kalpli, kıskanç, saldırgan";
                    pictureBox1.ImageLocation = "astrolojiaslan.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;

                case 5:
                    label2.Text = " Başak Burcu:";
                    label3.Text = "Olumlu özellikleri: Adanmış, becerikli, yardımsever, çalışkan, hazırcevap, pratik";
                    label4.Text = "Olumsuz özellikleri: Vaaz verme meraklısı, kendi kendine zarar verme, kendine acıma, şekilci, eleştirel";
                    pictureBox1.ImageLocation = "astrolojibasak.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;

                case 6:
                    label2.Text = " Terazi Burcu:";
                    label3.Text = "Olumlu özellikleri: Çekici, sevimli, adil, cana yakın, paylaşımcı, romantik";
                    label4.Text = "Olumsuz özellikleri: Faydasız, kararsız, aşırı duygusal, manipülatif, şımarık, kuruntulu";
                    pictureBox1.ImageLocation = "astrolojiterazi.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;

                case 7:
                    label2.Text = " Akrep Burcu:";
                    label3.Text = "Olumlu özellikleri: Sabırlı, derinlemesine bilgi sahibi, disiplinli, dikkatli";
                    label4.Text = "Olumsuz özellikleri: Kindar, asıl niyetini gizleyen, herkese karşı güvensiz";
                    pictureBox1.ImageLocation = "astrolojiakrep.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;

                case 8:
                    label2.Text = " Yay Burcu:";
                    label3.Text = "Olumlu özellikleri: Dürüst, tarafsız, iyimser, coşkulu, cesaretlendirici, adanmış";
                    label4.Text = "Olumsuz özellikleri: Tartışmacı, umursamaz, tuhaf, vaaz verme meraklısı, nezaketsiz, kendinden çok emin";
                    pictureBox1.ImageLocation = "astrolojiyay.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;

                case 9:
                    label2.Text = " Oğlak Burcu:";
                    label3.Text = "Olumlu özellikleri: Sadık, ailesine düşkün, çalışkan, adanmış, dürüst, korkusuz";
                    label4.Text = "Olumsuz özellikleri: Kötümser, bağışlamaz, soğuk, maddiyatçı, burnu havada, umutsuz";
                    pictureBox1.ImageLocation = "astrolojioglak.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;

                case 10:
                    label2.Text = " Kova Burcu:";
                    label3.Text = "Olumlu özellikleri: Bağımsız, özgün, insani, açık fikirli, adil, mantıklı";
                    label4.Text = "Olumsuz özellikleri: Tavizsiz, gösterişçi, söz tutmama";
                    pictureBox1.ImageLocation = "astrolojikova.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;

                case 11:
                    label2.Text = " Balık Burcu:";
                    label3.Text = "Olumlu özellikleri: Romantik, yardımsever, bilge, rahatlatıcı, yaratıcı";
                    label4.Text = "Olumsuz özellikleri: Saflık, kendine acıma, gerçeklikten kopukluk, kendine zarar verme, bağımlı";
                    pictureBox1.ImageLocation = "astrolojibalk.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
