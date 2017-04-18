using KocaeliUlasim.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Calls;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace KocaeliUlasim.View
{
    public sealed partial class StartScreen : Page
    {
        Controller control = new Controller();


        public StartScreen()
        {
            this.InitializeComponent();
        }


        private void grid_1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(View.OtobusSaatleri));
        }

        private void grid_2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(View.Duraklar));
        }

        private void grid_3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //Frame.Navigate(typeof(View.VapurSeferleri));
            control.Message("Vapur Seferleri bilgileri yakında..", "Bildirim");
        }

        private void grid_4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //Frame.Navigate(typeof(View.Akcaray));
            control.Message("Akçaray pek yakında..","Bildirim");
        }

        private void grid_5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(View.Duyurular));
        }

        private void grid_6_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ApiInformation.IsApiContractPresent("Windows.ApplicationModel.Calls.CallsPhoneContract", 1, 0))
            {
                PhoneCallManager.ShowPhoneCallUI("4441141", "Kocaeli Çağrı Merkezi");
            }
        }

        private async void grid_7_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("mailto:ulasim@kocaeli.bel.tr "));
        }

        private async void grid_8_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("mailto:onurantmil@gmail.com"));
        }

    }
}
