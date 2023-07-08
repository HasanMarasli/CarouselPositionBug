using MHZ.MBL.DelailulHayrat.MAUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestDeneme.models
{
    public class IntroScreenViewModel
    {
        public List<gunler> GunlerList { get; set; }
        public int CarouselPosition { get; set; }
        public bool NextButtonVisibility { get; set; }
        public bool EnterButtonVisibility { get; set; }

        public IntroScreenViewModel()
        {
            CarouselPosition = 1;
            NextButtonVisibility = true;
            EnterButtonVisibility = false;

            // Örnek dualarList verilerini oluşturun

            GunlerList = new List<gunler>();
            GunlerList.Add(new gunler { SayfaNo = 1, Metin = "DD.saddsaaaaaaaasdeee.D.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeee", MevcutGun = 1 });
            GunlerList.Add(new gunler { SayfaNo = 2, Metin = "D.D.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeee", MevcutGun = 1 });
            GunlerList.Add(new gunler { SayfaNo = 3, Metin = "D.D.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeee", MevcutGun = 1 });
            GunlerList.Add(new gunler { SayfaNo = 4, Metin = "DD.saddsaaaaaaaasdeee.D.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeee", MevcutGun = 1 });
            GunlerList.Add(new gunler { SayfaNo = 5, Metin = "DD.saddsaaaaaaaasdeee.D.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeee", MevcutGun = 1 });
            GunlerList.Add(new gunler { SayfaNo = 6, Metin = "DD.saddsaaaaaaaasdeee.D.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeee", MevcutGun = 2 });
            GunlerList.Add(new gunler { SayfaNo = 7, Metin = "DD.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeee.", MevcutGun = 2 });
            GunlerList.Add(new gunler { SayfaNo = 8, Metin = "DD.saddsaaaaaaaasdeee.D.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeee", MevcutGun = 2 });
            GunlerList.Add(new gunler { SayfaNo = 9, Metin = "D.D.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeeeD.saddsaaaaaaaasdeee", MevcutGun = 2 });
           

    }

        public void HandlePositionChangedCommand(int position)
        {
            if (position == 47)
            {
                EnterButtonVisibility = true;
                NextButtonVisibility = false;
            }
            else
            {
                EnterButtonVisibility = false;
                NextButtonVisibility = true;
            }
        }

        public void HandleEnterButtonClickCommand(object sender, EventArgs e)
        {
            if (CarouselPosition + 1 < 48)
                CarouselPosition++;
        }

        public void HandleEnterButtonClickCommand()
        {
            //Application.Current.MainPage = new LoginPageView();
        }


        

    }

   
}
