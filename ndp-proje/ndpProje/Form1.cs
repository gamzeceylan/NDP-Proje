/******************************************************
 *       NESNEYE DAYALI PROGRAMLAMA PROJE ÖDEVİ       *
 *                                                    *
 *            ÖĞRENCİ ADI-SOYADI : GAMZE CEYLAN       *
 *            ÖĞRENCİ NUMARASI : B191210008           *      
 *            ÖĞRENCİ GRUBU : 1/C                     *
 *                                                    *          
 ******************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ndpProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        enum AtikTurleri 
        {
            bardak,camsise,dergi,domates,gazete,kolakutusu,metalkutusu,salatalik
        }

        AtikTurleri atikTuru;
        readonly Atik atik = new Atik();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            labelPuan.Text = "0";
            label3.Text = "0";
            timer1.Interval = 1000;
        }

        private void RastgeleResim(object sender, EventArgs e) //Bu metod image klasöründen rastegele resim getiriyor
        {
            string[] resimler = Directory.GetFiles(@"image"); //image klasöründeki resimler diziye atanıyor
            atikTuru = (AtikTurleri)atik.RastgeleAtik; //AtikTurleri yapısından rstgele bir atık belirliyor
            pictureBox1.ImageLocation = resimler[atik.rastgeleSayi]; //picturebox a rastgele resim geliyor
        }

        private void ToplamPuanYazidr (object sender,EventArgs e) //her atık kutuya eklendiğinde toplam puan hesaplanıyor
        {
            atik.toplamPuan += atik.Hacim;
            labelPuan.Text = atik.toplamPuan.ToString();
        }

        private void SaniyeEkle (object sender, EventArgs e) //her atık kutusu boşaltığında 3 saniye ekliyor
        {
            atik.saniye += 3;
            label3.Text = atik.saniye.ToString();
        }

        private void BtnYeniOyun_Click(object sender, EventArgs e)
        {
            //yeni oyuna basıldığında butonlar aktif hale geliyor
            BtnYeniOyun.Enabled = false;
            BtnCikis.Enabled = true;
            BtnOrganik.Enabled = true;
            BtnBosaltOrganik.Enabled = true;
            BtnKagit.Enabled = true;
            BtnBosaltKagit.Enabled = true;
            BtnCam.Enabled = true;
            BtnBosaltCam.Enabled = true;
            BtnMetal.Enabled = true;
            BtnBosaltMetal.Enabled = true;
            BtnCikis.Enabled = true;

            //eğer önceki oyundan kutuda atık kalmışsa kutular temizleniyor
            LstbxCam.Items.Clear();
            LstbxKagit.Items.Clear();
            LstbxMetal.Items.Clear();
            LstbxOrganik.Items.Clear();
            
            //progresssBarların ilk değerleri 0 atanıyor
            progressBarCam.Value = 0;
            progressBarKagit.Value = 0;
            progressBarMetal.Value = 0;
            progressBarOrganik.Value = 0;

            atik.toplamPuan = 0;
            labelPuan.Text = "0";

            RastgeleResim(this, new EventArgs());
            atik.saniye = 60;
            timer1.Start();

        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close(); //çıkış butonuna basıldığında uygulamadan çıkılıyor
            Application.Exit();
        }

        private void BtnOrganik_Click(object sender, EventArgs e)
        {
            atik.Kapasite = 700;
            atik.doluHacim = atik.organikHacmi;

            switch (atikTuru) //atık türüne göre bloga giriyor
            {
                case AtikTurleri.domates: //atık domatesse bu bloga giriyor

                    atik.Hacim = 150;

                    if (atik.DolulukOrani <= 100) //kutunun doluluk oranı %100 e ulaşmamışsa kutuya atığı ekliyor, atığın hacmine
                    {                           //göre toplam puanı hesaplıyor ve rastgele resim üretiyor
                        LstbxOrganik.Items.Add("Domates" + "(" + atik.Hacim + ")");
                        atik.Ekle(atik);
                        atik.organikHacmi += atik.Hacim;

                        progressBarOrganik.Step = 150;
                        progressBarOrganik.PerformStep();

                        ToplamPuanYazidr(this, new EventArgs());
                        RastgeleResim(this, new EventArgs());
                    }
                    break;

                case AtikTurleri.salatalik: //atık salatalıksa bu bloga giriyor

                    atik.Hacim = 120;

                    if (atik.DolulukOrani <= 100)//kutunun doluluk oranı %100 e ulaşmamışsa kutuya atığı ekliyor, atığın hacmine
                    {                           //göre toplam puanı hesaplıyor ve rastgele resim üretiyor

                        LstbxOrganik.Items.Add("Salatalık" + "(" + atik.Hacim + ")");
                        atik.Ekle(atik);
                        atik.organikHacmi += atik.Hacim;

                        progressBarOrganik.Step = 120;
                        progressBarOrganik.PerformStep();

                        ToplamPuanYazidr(this, new EventArgs());
                        RastgeleResim(this, new EventArgs());
                    }
                    break;
            }
        }
        private void BtnKagit_Click(object sender, EventArgs e)
        {
            atik.Kapasite = 1200;
            atik.doluHacim = atik.kagitHacmi;

            switch (atikTuru) //atık türüne göre bloga giriyor
            {
                case AtikTurleri.dergi: //atık dergiyse bu bloga giriyor
                    atik.Hacim = 200;

                    if (atik.DolulukOrani <= 100)//kutunun doluluk oranı %100 e ulaşmamışsa kutuya atığı ekliyor, atığın hacmine
                    {                           //göre toplam puanı hesaplıyor ve rastgele resim üretiyor

                        LstbxKagit.Items.Add("Dergi" + "(" + atik.Hacim + ")");
                        atik.Ekle(atik);
                        atik.kagitHacmi += atik.hacim;

                        progressBarKagit.Step = 200;
                        progressBarKagit.PerformStep();

                        ToplamPuanYazidr(this, new EventArgs());
                        RastgeleResim(this, new EventArgs());
                    }
                break;

                case AtikTurleri.gazete: //atık gazeteyse bu bloga giriyor

                    atik.Hacim = 250;

                    if (atik.DolulukOrani <= 100)//kutunun doluluk oranı %100 e ulaşmamışsa kutuya atığı ekliyor, atığın hacmine
                    {                           //göre toplam puanı hesaplıyor ve rastgele resim üretiyor

                        LstbxKagit.Items.Add("Gazete" + "(" + atik.Hacim + ")");
                        atik.Ekle(atik);
                        atik.kagitHacmi += atik.hacim;

                        progressBarKagit.Step = 250;
                        progressBarKagit.PerformStep();

                        ToplamPuanYazidr(this, new EventArgs());
                        RastgeleResim(this, new EventArgs());
                    }
                 break;
            }
        }

        private void BtnCam_Click(object sender, EventArgs e)
        {
            atik.Kapasite = 2200;
            atik.doluHacim = atik.camHacmi;
      
            switch(atikTuru) //atık türüne göre bloga giriyor
            {
                case AtikTurleri.bardak: //atık bardaksa bu bloga giriyor

                    atik.Hacim = 250;

                    if (atik.DolulukOrani <= 100)//kutunun doluluk oranı %100 e ulaşmamışsa kutuya atığı ekliyor, atığın hacmine
                    {                           //göre toplam puanı hesaplıyor ve rastgele resim üretiyor

                        LstbxCam.Items.Add("Bardak" + "(" + atik.Hacim + ")");
                        atik.Ekle(atik);
                        atik.camHacmi += atik.hacim;

                        progressBarCam.Step = 250;
                        progressBarCam.PerformStep();

                        ToplamPuanYazidr(this, new EventArgs());
                        RastgeleResim(this, new EventArgs());
                    }
                break;

                case AtikTurleri.camsise: //atık camsiseyse bu bloga giriyor

                    atik.Hacim = 600;

                    if (atik.DolulukOrani <= 100)//kutunun doluluk oranı %100 e ulaşmamışsa kutuya atığı ekliyor, atığın hacmine
                    {                           //göre toplam puanı hesaplıyor ve rastgele resim üretiyor

                        LstbxCam.Items.Add("Cam Şişe" + "(" + atik.Hacim + ")");
                        atik.Ekle(atik);
                        atik.camHacmi += atik.hacim;

                        progressBarCam.Step = 600;
                        progressBarCam.PerformStep();

                        ToplamPuanYazidr(this, new EventArgs());
                        RastgeleResim(this, new EventArgs());
                    }
                 break;
            }
      
        }

        private void BtnMetal_Click(object sender, EventArgs e)
        {
            atik.Kapasite = 2300;
            atik.doluHacim = atik.metalHacmi;

            switch(atikTuru) //atık türüne göre bloga giriyor
            {
                case AtikTurleri.metalkutusu: //atık metalkutusuysa bu bloga giriyor

                    atik.Hacim = 550;

                    if (atik.DolulukOrani <= 100)//kutunun doluluk oranı %100 e ulaşmamışsa kutuya atığı ekliyor, atığın hacmine
                    {                           //göre toplam puanı hesaplıyor ve rastgele resim üretiyor

                        LstbxMetal.Items.Add("Salça Kutusu" + "(" + atik.Hacim + ")");
                        atik.Ekle(atik);
                        atik.metalHacmi += atik.hacim;

                        progressBarMetal.Step = 550;
                        progressBarMetal.PerformStep();

                        ToplamPuanYazidr(this, new EventArgs());
                        RastgeleResim(this, new EventArgs());
                    }
                  break;

                case AtikTurleri.kolakutusu: //atık kolakutusuysa bu bloga giriyor

                    atik.Hacim = 350;

                    if (atik.DolulukOrani <= 100)//kutunun doluluk oranı %100 e ulaşmamışsa kutuya atığı ekliyor, atığın hacmine
                    {                           //göre toplam puanı hesaplıyor ve rastgele resim üretiyor
                        
                        LstbxMetal.Items.Add("Kola Kutusu" + "(" + atik.Hacim + ")");
                        atik.Ekle(atik);
                        atik.metalHacmi += atik.hacim;

                        progressBarMetal.Step = 350;
                        progressBarMetal.PerformStep();

                        ToplamPuanYazidr(this, new EventArgs());
                        RastgeleResim(this, new EventArgs());
                    }
                break;
            }
         

        }

        private void BtnBosaltOrganik_Click(object sender, EventArgs e)
        {
            atik.Kapasite = 700;
           atik.doluHacim = atik.organikHacmi;

            if (atik.DolulukOrani>=75) //eger atın kutusu %75 ten fazla dolduysa kuturuyu boşaltıyor atık turune göre puan ekliyor
            {                           //ve zaman 3 saniye arttırılıyor            
                atik.bosaltmaPuani = 0;
                atik.Bosalt(atik);
                labelPuan.Text = atik.BosaltmaPuani().ToString();

                atik.organikHacmi = 0;
                LstbxOrganik.Items.Clear();

                SaniyeEkle(this, new EventArgs());
                progressBarOrganik.Value = 0;

            }
        }

        private void BtnBosaltKagit_Click(object sender, EventArgs e)
        {
            atik.Kapasite = 1200;
            atik.doluHacim = atik.kagitHacmi;

            if (atik.DolulukOrani >= 75) //eger atın kutusu %75 ten fazla dolduysa kuturuyu boşaltıyor atık turune göre puan ekliyor
            {                              //ve zaman 3 saniye arttırılıyor
                atik.bosaltmaPuani = 1000;
                atik.Bosalt(atik);
                labelPuan.Text = atik.BosaltmaPuani().ToString();

                atik.kagitHacmi = 0;
                LstbxKagit.Items.Clear();

                SaniyeEkle(this, new EventArgs());
                progressBarKagit.Value = 0;
            }
        }

        private void BtnBosaltCam_Click(object sender, EventArgs e)
        {
            atik.Kapasite = 2200;
            atik.doluHacim = atik.camHacmi;

            if (atik.DolulukOrani >= 75) //eger atın kutusu %75 ten fazla dolduysa kuturuyu boşaltıyor atık turune göre puan ekliyor
            {                              //ve zaman 3 saniye arttırılıyor
                atik.bosaltmaPuani = 600;
                atik.Bosalt(atik);
                labelPuan.Text = atik.BosaltmaPuani().ToString();

                atik.camHacmi = 0;
                LstbxCam.Items.Clear();

                SaniyeEkle(this, new EventArgs());
                progressBarCam.Value = 0;
            }
        }

        private void BtnBosaltMetal_Click(object sender, EventArgs e)
        {
            atik.Kapasite = 2300;
           atik.doluHacim = atik.metalHacmi;

            if (atik.DolulukOrani >= 75) //eger atın kutusu %75 ten fazla dolduysa kuturuyu boşaltıyor atık turune göre puan ekliyor 
            {                             //ve zaman 3 saniye arttırılıyor
                atik.bosaltmaPuani = 800;
                atik.Bosalt(atik);
                labelPuan.Text = atik.BosaltmaPuani().ToString();

                /atik.metalHacmi = 0;
                LstbxMetal.Items.Clear();

                SaniyeEkle(this, new EventArgs());
                progressBarMetal.Value = 0;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            atik.saniye--;
            label3.Text = atik.Sure.ToString();

            if(atik.Sure==0) //eger oyun süresi dolmuşsa butonları pasif hale getiriyor
            {               
                timer1.Stop();

                BtnYeniOyun.Enabled = true;
                BtnOrganik.Enabled = false;
                BtnBosaltOrganik.Enabled = false;
                BtnKagit.Enabled = false;
                BtnBosaltKagit.Enabled = false;
                BtnCam.Enabled = false;
                BtnBosaltCam.Enabled = false;
                BtnMetal.Enabled = false;
                BtnBosaltMetal.Enabled = false;
            }
        }
    }
}
