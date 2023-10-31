using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psikoloji_Analiz_Testi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soru;
        int toplam = 0;
        private void btnBasla_Click(object sender, EventArgs e)
        {
            btnİleri.Visible = true;
            btnBasla.Enabled = false;
            btnBasla.Text = "BİTİR";
            soru++;
            if (soru == 1)
            {
                textSoru.Text = "1- Sevgilinizle ya da eşinizle mükemmel bir akşam size aşağıdakilerden hangisini çağrıştırıyor?";
                btnA.Text = "KONSERE GİTMEK";
                btnB.Text = "SİNEMAYA GİTMEK";
                btnC.Text = "SAHİL KENARINDA GEZMEK";
                btnD.Text = "ROMANTİK BİR AKŞAM YEMEĞİ";
                btnE.Text = "ARABAYLA TURLAMAK";
                btnF.Text = "LUNAPARKA GİTMEK";
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;
                btnF.Enabled = true;

            }
            if (soru == 11)
            {
                btnİleri.Visible= false;
                btnA.Text = "Skorunuz: "+ toplam.ToString();
                Font mevcutFont = btnA.Font;                
                Font yeniFont = new Font(mevcutFont.FontFamily, 18, mevcutFont.Style);
                btnA.Font = yeniFont;
                btnB.Visible = false;
                btnC.Visible = false;
                btnD.Visible = false;
                btnE.Visible = false;
                btnF.Visible = false;
                if (toplam >= 10 && toplam <= 20)
                {
                    textSoru.Text = "Siz vahşi ve çılgın birisisiniz eğleneyim derken uçuyorsunuz.";
                }
                else if (toplam >= 21 && toplam <= 30)
                {
                    textSoru.Text = "Siz eğlenceli, arkadaş canlısı ve popülersiniz.";
                }  
                else if (toplam >= 31 && toplam <= 40)
                {
                    textSoru.Text = "Öyle tatlısınızkii sizi sevmemek mümkün değil insanların kaybetmek istemiyeceği türden bir insansınız.";
                }
                else if (toplam >= 41 && toplam <= 50)
                {
                    textSoru.Text = "Siz iflah olmaz bir romantiksiniz şarap, kırmızı güller bunlar sisin yaşam tarzınız.";
                }
                else if (toplam >= 51 && toplam <= 60)
                {
                    textSoru.Text = "Belirgin özelliğiniz hızlı ve mantıklı karar verebilmeniz ve her olay için kafanızın içinde plan olmasıdır.";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnİleri.Visible=false;
        }

        private void btnİleri_Click(object sender, EventArgs e)
        {
            soru++;
            if (soru == 2)
            {
                textSoru.Text = "2- En sevdiğiniz müzik türü nedir?";
                btnA.Text = "POP";
                btnB.Text = "ROCK";
                btnC.Text = "RAP";
                btnD.Text = "ARABESK";
                btnE.Text = "KLASİK";
                btnF.Text = "YABANCI";
                btnA.BackColor = Color.Teal;
                btnB.BackColor = Color.Teal;
                btnC.BackColor = Color.Teal;
                btnD.BackColor = Color.Teal;
                btnE.BackColor = Color.Teal;
                btnF.BackColor = Color.Teal;
                btnA.ForeColor = Color.White;
                btnB.ForeColor = Color.White;
                btnC.ForeColor = Color.White;
                btnD.ForeColor = Color.White;
                btnE.ForeColor = Color.White;
                btnF.ForeColor = Color.White;
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;
                btnF.Enabled = true;
            }
            if (soru == 3)
            {
                textSoru.Text = "3- En çok hangi film türünü seversiniz?";
                btnA.Text = "KORKU";
                btnB.Text = "ROMANTİK";
                btnC.Text = "MACERA";
                btnD.Text = "AKSİYON";
                btnE.Text = "KOMEDİ";
                btnF.Text = "BELGESEL"; 
                btnA.BackColor = Color.Teal;
                btnB.BackColor = Color.Teal;
                btnC.BackColor = Color.Teal;
                btnD.BackColor = Color.Teal;
                btnE.BackColor = Color.Teal;
                btnF.BackColor = Color.Teal;
                btnA.ForeColor = Color.White;
                btnB.ForeColor = Color.White;
                btnC.ForeColor = Color.White;
                btnD.ForeColor = Color.White;
                btnE.ForeColor = Color.White;
                btnF.ForeColor = Color.White;
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;
                btnF.Enabled = true;
            }
            if (soru == 4)
            {
                textSoru.Text = "4- Aşağıdaki mesleklerden birisini seçecek olsanız hangisini seçerdiniz?";
                btnA.Text = "PİLOT";
                btnB.Text = "ÖĞRETMEN";
                btnC.Text = "DOKTOR";
                btnD.Text = "ASKER";
                btnE.Text = "KOMEDYEN";
                btnF.Text = "FUTBOLCU";
                btnA.BackColor = Color.Teal;
                btnB.BackColor = Color.Teal;
                btnC.BackColor = Color.Teal;
                btnD.BackColor = Color.Teal;
                btnE.BackColor = Color.Teal;
                btnF.BackColor = Color.Teal;
                btnA.ForeColor = Color.White;
                btnB.ForeColor = Color.White;
                btnC.ForeColor = Color.White;
                btnD.ForeColor = Color.White;
                btnE.ForeColor = Color.White;
                btnF.ForeColor = Color.White;
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;
                btnF.Enabled = true;
            }
            if (soru == 5)
            {
                textSoru.Text = "5- Bir saat boşluğunuz var bunu aşağıdakilerden hangisi ile değerlendirirsiniz?";
                btnA.Text = "KİTAP OKUYARAK";
                btnB.Text = "UYUYARAK";
                btnC.Text = "OYUN OYNAYARAK";
                btnD.Text = "YEMEK YİYEREK";
                btnE.Text = "TELEVİZYON İZLEYEREK";
                btnF.Text = "GEZEREK";
                btnA.BackColor = Color.Teal;
                btnB.BackColor = Color.Teal;
                btnC.BackColor = Color.Teal;
                btnD.BackColor = Color.Teal;
                btnE.BackColor = Color.Teal;
                btnF.BackColor = Color.Teal;
                btnA.ForeColor = Color.White;
                btnB.ForeColor = Color.White;
                btnC.ForeColor = Color.White;
                btnD.ForeColor = Color.White;
                btnE.ForeColor = Color.White;
                btnF.ForeColor = Color.White;
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;
                btnF.Enabled = true;
            }
            if (soru == 6)
            {
                textSoru.Text = "6- Aşağıdaki renklerden birisini seçiniz?";                
                btnA.Text = "";
                btnB.Text = "";
                btnC.Text = "";
                btnD.Text = "";
                btnE.Text = "";
                btnF.Text = "";
                btnA.BackColor = Color.Yellow;
                btnB.BackColor = Color.Green;
                btnC.BackColor = Color.Pink;
                btnD.BackColor = Color.Red;
                btnE.BackColor = Color.Blue;
                btnF.BackColor = Color.Brown;
                btnA.ForeColor = Color.White;
                btnB.ForeColor = Color.White;
                btnC.ForeColor = Color.White;
                btnD.ForeColor = Color.White;
                btnE.ForeColor = Color.White;
                btnF.ForeColor = Color.White;
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;
                btnF.Enabled = true;
            }
            if (soru == 7)
            {
                textSoru.Text = "7- Şuan önünüzde hangi yiyecek olsa dayanamayıp yersiniz?";
                btnA.Text = "ÇİKOLATA";
                btnB.Text = "HAMBURGER";
                btnC.Text = "PİZZA";
                btnD.Text = "MAKARNA";
                btnE.Text = "PASTA";
                btnF.Text = "SUŞİ";
                btnA.BackColor = Color.Teal;
                btnB.BackColor = Color.Teal;
                btnC.BackColor = Color.Teal;
                btnD.BackColor = Color.Teal;
                btnE.BackColor = Color.Teal;
                btnF.BackColor = Color.Teal;
                btnA.ForeColor = Color.White;
                btnB.ForeColor = Color.White;
                btnC.ForeColor = Color.White;
                btnD.ForeColor = Color.White;
                btnE.ForeColor = Color.White;
                btnF.ForeColor = Color.White;
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;
                btnF.Enabled = true;
            }
            if (soru == 8)
            {
                textSoru.Text = "8- En sevdiğiniz tatil, özel gün ya da bayram hangisidir? ";
                btnA.Text = "23 NİSAN ULUSAL EGEMENLİK VE ÇOCUK BAYRAMI";
                btnB.Text = "HAFTA SONU TATİLİ";
                btnC.Text = "RAMAZAN BAYRAMI";
                btnD.Text = "KURBAN BAYRAMI";
                btnE.Text = "YILBAŞI TATİLİ";
                btnF.Text = "SEVGİLİLER GÜNÜ";
                btnA.BackColor = Color.Teal;
                btnB.BackColor = Color.Teal;
                btnC.BackColor = Color.Teal;
                btnD.BackColor = Color.Teal;
                btnE.BackColor = Color.Teal;
                btnF.BackColor = Color.Teal;
                btnA.ForeColor = Color.White;
                btnB.ForeColor = Color.White;
                btnC.ForeColor = Color.White;
                btnD.ForeColor = Color.White;
                btnE.ForeColor = Color.White;
                btnF.ForeColor = Color.White;
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;
                btnF.Enabled = true;
            }
            if (soru == 9)
            {
                textSoru.Text = "9- Şuan aşağıdakilerden hangisinde olmak isterdin?";
                btnA.Text = "ALMANYA";
                btnB.Text = "NEW YORK";
                btnC.Text = "DUBAİ";
                btnD.Text = "KIBRIS";
                btnE.Text = "İTALYA";
                btnF.Text = "JAPONYA";
                btnA.BackColor = Color.Teal;
                btnB.BackColor = Color.Teal;
                btnC.BackColor = Color.Teal;
                btnD.BackColor = Color.Teal;
                btnE.BackColor = Color.Teal;
                btnF.BackColor = Color.Teal;
                btnA.ForeColor = Color.White;
                btnB.ForeColor = Color.White;
                btnC.ForeColor = Color.White;
                btnD.ForeColor = Color.White;
                btnE.ForeColor = Color.White;
                btnF.ForeColor = Color.White;
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;
                btnF.Enabled = true;
            }
            if (soru == 10)
            {
                textSoru.Text = "10- Genel olarak nasıl insanlarla vakit geçirmekten hoşlanırsın?";
                btnA.Text = "PARTİ CANAVARI BİRİYLE";
                btnB.Text = "SAKİN BİRİYLE";
                btnC.Text = "KOMİK BİRİYLE";
                btnD.Text = "OYUNCU BİRİYLE";
                btnE.Text = "GÜZEL/YAKIŞIKLI BİRİYLE";
                btnF.Text = "AKILLI BİRİYLE";
                btnA.BackColor = Color.Teal;
                btnB.BackColor = Color.Teal;
                btnC.BackColor = Color.Teal;
                btnD.BackColor = Color.Teal;
                btnE.BackColor = Color.Teal;
                btnF.BackColor = Color.Teal;
                btnA.ForeColor = Color.White;
                btnB.ForeColor = Color.White;
                btnC.ForeColor = Color.White;
                btnD.ForeColor = Color.White;
                btnE.ForeColor = Color.White;
                btnF.ForeColor = Color.White;
                btnİleri.Enabled = false;
                btnİleri.Visible = false;
                btnBasla.Enabled = true;
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;
                btnF.Enabled = true;

            }            
        }
        private void btnA_Click(object sender, EventArgs e)
        {
            toplam = toplam + 4;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;
            btnF.Enabled = false;
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            toplam = toplam + 1;
            btnA.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;
            btnF.Enabled = false;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            toplam = toplam + 3;
            btnB.Enabled = false;
            btnA.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;
            btnF.Enabled = false;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            toplam = toplam + 6;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnA.Enabled = false;
            btnE.Enabled = false;
            btnF.Enabled = false;
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            toplam = toplam + 2;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnA.Enabled = false;
            btnF.Enabled = false;
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            toplam = toplam + 5;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;
            btnA.Enabled = false;
        }
    }
}
