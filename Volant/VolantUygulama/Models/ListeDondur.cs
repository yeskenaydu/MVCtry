using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VolantUygulama.Models
{
    public class ListeDondur
    {
        Urun urun1 = new Urun("Muz", "Meyve bitmiş.");
        Urun urun2 = new Urun("Süt", "Sütlaç istersen alabilirsin");
        Urun urun3 = new Urun("Domates", "Küçük olanlardan al kahvaltılık istiyorum.");
        Urun urun4 = new Urun("Magnum", "Diyetin ödül günü alabilirsin.");
        UrunListe urunler = new UrunListe();
        public ListeDondur()
        {
            urunler.urunListesi.Add(urun1);
            urunler.urunListesi.Add(urun2);
            urunler.urunListesi.Add(urun3);
            urunler.urunListesi.Add(urun4);

        }

        public IEnumerable<Urun> dondur()
        {
            var dondurulecekListe = from eleman in urunler.urunListesi
                                    orderby eleman.urunAd
                                    select eleman;
            return dondurulecekListe;
        }
    }
}