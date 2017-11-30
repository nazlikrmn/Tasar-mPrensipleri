using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YZM2118_Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Player player = new Player();
        Kontrol kontrol = new Kontrol();
        private void PVideo_Click(object sender, EventArgs e)
        {
            if (player.playerDurum == false)
            {
                textBox1.Text = "Önce Başla'ya tıkla.";
                return;
            }
            if (player.oynatılıyorResim != null)
                player.oynatılıyorResim = null;
            Video video = new Video();
            video.ad = "Kayit1";
            video.ceken = "Kisi2";
            video.kayıtTarihi = new DateTime(2016, 2, 1);
            video.sure = 326;
            video.Imdb = 6;
            
           textBox1.Text=kontrol.Play(video);
            player.oynatılıyor = video;            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (player.playerDurum == false)
            {
                textBox1.Text = "Önce Başla'ya tıkla.";
                return;
            }
            
            if (player.oynatılıyor != null)
            {
                textBox1.Text = kontrol.Stop(player.oynatılıyor);
                player.oynatılıyor = null;
            }
            else if (player.oynatılıyorResim != null && player.oynatılıyor == null)
                textBox1.Text += "\nBir video başlatılmamış";
            else if (player.oynatılıyor == null && player.oynatılıyorResim == null)
                textBox1.Text = "Öncelikle bir play tuşuna tıklayın.";
        }

        private void PResim_Click(object sender, EventArgs e)
        {
            if (player.playerDurum == false)
            {
                textBox1.Text = "Önce Başla'ya tıkla.";
                return;
            }
            if (player.oynatılıyor != null)
                player.oynatılıyor = null;
            Resim resim = new Resim();
            resim.ad = "Resim1";
            resim.ceken = "Kisi1";
            resim.kayıtTarihi = new DateTime(2017, 10, 4);
            resim.RenkDagilimi = "fghjkl";

            textBox1.Text=kontrol.Play(resim);
            player.oynatılıyorResim = resim;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (player.playerDurum == false)
            {
                textBox1.Text = "Önce Başla'ya tıkla.";
                return;
            }
            if (player.oynatılıyorResim != null)
            {
                textBox1.Text = kontrol.Stop(player.oynatılıyorResim);
                player.oynatılıyorResim = null;
            }
            else if (player.oynatılıyor != null && player.oynatılıyorResim == null)
                textBox1.Text += "\nBir resim başlatılmamış";
            else if (player.oynatılıyor == null && player.oynatılıyorResim == null)
                textBox1.Text = "Öncelikle bir play tuşuna tıklayın.";
        }

        private void pVideo2_Click(object sender, EventArgs e)
        {
            if (player.playerDurum == false)
            {
                textBox1.Text = "Önce Başla'ya tıkla.";
                return;
            }
            if (player.oynatılıyorResim != null)
                player.oynatılıyorResim = null;
            Video video1 = new Video();
            video1.ad = "Kayit2";
            video1.ceken = "Kisi3";
            video1.kayıtTarihi = new DateTime(2016, 12, 21);
            video1.sure = 326;
            video1.Imdb = 6;

            textBox1.Text = kontrol.Play(video1);
            player.oynatılıyor = video1;
        }

        private void pResim2_Click(object sender, EventArgs e)
        {
            if (player.playerDurum == false)
            {
                textBox1.Text = "Önce Başla'ya tıkla.";
                return;
            }
            if (player.oynatılıyor != null)
                player.oynatılıyor = null;
            Resim resim1 = new Resim();
            resim1.ad = "Resim2";
            resim1.ceken = "Kisi4";
            resim1.kayıtTarihi = new DateTime(2017, 1, 30);
            resim1.RenkDagilimi = "fghjkl";

            textBox1.Text = kontrol.Play(resim1) ;
            player.oynatılıyorResim = resim1;
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            textBox1.Text = player.Play(); 
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            textBox1.Text = player.Stop();
        }
    }
}
