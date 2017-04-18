using KocaeliUlasim.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace KocaeliUlasim.View
{
    public sealed partial class OtobusSaatleri : Page
    {
        Bus bus = new Bus();
        public static string hatno;


        public OtobusSaatleri()
        {
            this.InitializeComponent();
            listView.ItemsSource = bus.getBusList();
        }


        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {           
            string value = listView.SelectedItem.ToString();
            string[] array = value.Split(' ');
            hatno = array[0].Trim();

            Frame.Navigate(typeof(View.DetailsOtobusSaatleri));
        }

        private void suggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            string filter = sender.Text.ToUpper();
            listView.ItemsSource = bus.getBusList().Where(s => s.ToUpper().Contains(filter));
        }

    }
}
