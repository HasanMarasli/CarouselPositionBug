
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHZ.MBL.DelailulHayrat.MAUI
{
    public class gunler
    {

        public String Metin { get; set; }        // Sayfanın İçeriği
        public int MevcutGun { get; set; }       //  1 = Pazartesi     2 = Salı        3 = Çarşamba    4 = Perşembe     5 = Cuma    6 = Cumartesi       7 = Pazar
        public int SayfaNo { get; set; }         //  Kitap Üzerinde Bulunduğun Sayfa

    }


}
