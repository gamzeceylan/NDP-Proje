using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ndpProje
{
    class Atik :  IAtikKutusu,IAtik
    {
        public double camHacmi = 0, organikHacmi = 0, metalHacmi = 0, kagitHacmi = 0, toplamPuan = 0;
        public double bosaltmaPuani;
        public double doluHacim, hacim, dolulukOrani, kapasite;
   
        public int rastgeleSayi, saniye;

        public double Hacim //formda atanan hacim değerini döndürüyor
        {
            get => hacim;
          
            set
            {
                hacim = value;
            }

        }
        public double BosaltmaPuani() //atik kutusu boşaltıldığında bosaltma punanını toplma puana eklyor
        {
               toplamPuan += bosaltmaPuani;
                return toplamPuan;
        }

        public bool Ekle(Atik atik) //kutu hacminin tamamen dolup dolmadığını kontrol ediyor ve eğer true
        {                          //dönerse kutu hacmini atiğin hacmi kadar arttırıyor 
            if (atik.doluHacim <= atik.kapasite)
            {
                atik.DoluHacim();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Bosalt(Atik atik)  //kutu hacminin %75 ten fazla dolduğunda mı boşaltıldığında kontrol ediyor ve eğer true 
        {                          //dönerse kutu hacmini atiğin hacmi kadar arttırıyor         
            if (atik.doluHacim + atik.hacim ==(atik.kapasite * 75) / 100)
           {
                atik.BosaltmaPuani();
                return true;
           }
           else
           {
                return false;
           }
        }
    
        public double Kapasite //formda her kutunun kapasite değerini döndürüyor
        {
            get => kapasite;
         
            set
            {
                kapasite = value;
            }
        }       
        
        public double DolulukOrani //kutunun doluluk oranını döndürüyor
        {
            get
            {
                dolulukOrani = (doluHacim*100) / kapasite;
                return dolulukOrani;
            }
        }

        public double DoluHacim () //eklenen atik hacmini mevcut dolu hacme eklyor
        { 
            doluHacim += hacim;
            return doluHacim;
        }

        public int RastgeleAtik //resimler dizisinin rastgele atık üretilmesi için dizi içine rastgele değer üretiyor
        {
            get
            {
                Random rstgl = new Random();
                rastgeleSayi = rstgl.Next(0, 8);
                return rastgeleSayi;
            }
           
        }
        public int Sure //saniye değerini döndürüyor
        {
            get => saniye;
            
        }
    }
}
