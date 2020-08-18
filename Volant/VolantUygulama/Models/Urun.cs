using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VolantUygulama.Models
{
    public class Urun
    {
        public String urunAd;
        public String urunAciklama;
        private static int urunId=0;

        public Urun(String urunAd,String urunAciklama)
        {
            urunId++;
            this.urunAciklama = urunAciklama;
            this.urunAd = urunAd;
        }
    }
}