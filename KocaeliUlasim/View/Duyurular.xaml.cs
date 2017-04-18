using KocaeliUlasim.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Networking.Connectivity;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Web.Syndication;

namespace KocaeliUlasim.View
{
    public sealed partial class Duyurular : Page
    {

        Controller control = new Controller();


        public Duyurular()
        {
            this.InitializeComponent();
            ConnectRSS();
        }


        public async void ConnectRSS()
        {
            try
            {
                progress.IsIndeterminate = true;

                SyndicationClient client = new SyndicationClient();
                Uri RSSuri = new Uri("http://www.kocaeli.bel.tr/Rss.aspx");
                var feeds = await client.RetrieveFeedAsync(RSSuri);

                foreach (var feed in feeds.Items)
                {
                    string str = feed.Title.Text;
                    str = str.Replace("&#34;", "");
                    str = str.Replace("&#39;", "");
                    listTitles.Items.Add(str);
                }

                progress.IsIndeterminate = false;
            }

            catch (Exception)
            {
                progress.IsIndeterminate = false;

                if (NetworkInformation.GetInternetConnectionProfile() == null)
                {
                    control.Message("Herhangi bir ağ bağlantısı bulunamadı. Telefon ayarlarınızı kontrol edin ve yeniden deneyin.", "Bir hata oluştu :(");
                }
            }
        }

        private async void listTitles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SyndicationClient client = new SyndicationClient();
            Uri RSSuri = new Uri("http://www.kocaeli.bel.tr/Rss.aspx");
            var feeds = await client.RetrieveFeedAsync(RSSuri);

            string uriToLaunch = feeds.Items[listTitles.SelectedIndex].Links[0].Uri.ToString();
            var uri = new Uri(uriToLaunch);
            var success = await Windows.System.Launcher.LaunchUriAsync(uri);
        }

    }
}
