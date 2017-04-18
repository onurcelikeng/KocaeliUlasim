using HtmlAgilityPack;
using KocaeliUlasim.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
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

namespace KocaeliUlasim.View
{
    public sealed partial class DetailsOtobusSaatleri : Page
    {
        private List<string> haftaici = new List<string>();
        private List<string> cumartesi = new List<string>();
        private List<string> pazar = new List<string>();
        Controller control = new Controller();


        public DetailsOtobusSaatleri()
        {
            this.InitializeComponent();

            header.Text = OtobusSaatleri.hatno + " Saatleri";
            FindClock();
        }


        private async void FindClock()
        {
            try
            {
                progress.IsIndeterminate = true;

                string htmlPage = null;
                using (var client = new HttpClient())
                {
                    htmlPage = await client.GetStringAsync("http://www.kocaeli.bel.tr/OtobusSaatleri.aspx?HatKodu=" + OtobusSaatleri.hatno);
                }

                HtmlDocument htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(htmlPage);

                HtmlNode parent1 = htmlDocument.DocumentNode.Descendants("table").FirstOrDefault(o => o.GetAttributeValue("id", "") == "ctl00_ContentPlaceHolder1_GridViewHatSaatleriGidis");
                DownloadData(parent1, list1);

                HtmlNode parent2 = htmlDocument.DocumentNode.Descendants("table").FirstOrDefault(o => o.GetAttributeValue("id", "") == "ctl00_ContentPlaceHolder1_GridViewHatSaatleriDonus");
                DownloadData(parent2, list2);

                progress.IsIndeterminate = false;
            }

            catch (Exception)
            {
                progress.IsIndeterminate = false;

                if (NetworkInformation.GetInternetConnectionProfile() == null)
                {
                    control.Message("Herhangi bir ağ bağlantısı bulunamadı. Telefon ayarlarınızı kontrol edin ve yeniden deneyin.", "Bir hata oluştu :(");
                }

                else
                {
                    #region Control (Again)

                    var newMessage = new MessageDialog("Bağlantı zaman aşımına uğradı. Tekrar denemek ister misiniz?", "Bir hata oluştu :(");
                    var button_OK = new UICommand("Evet");
                    var button_CANCEL = new UICommand("Hayır");

                    newMessage.Commands.Add(button_OK);
                    newMessage.Commands.Add(button_CANCEL);
                    IUICommand result = await newMessage.ShowAsync();

                    if (result != null && result.Label == "Evet")
                    {
                        FindClock();
                    }

                    #endregion
                }
            }
        }

        private void DownloadData(HtmlNode node, ListView list)
        {
            #region Add to List

            haftaici.Clear();
            cumartesi.Clear();
            pazar.Clear();
            int size = node.ChildNodes.Count;

            for (int i = 2; i < size - 1; i++)
            {
                string data1 = node.ChildNodes[i].ChildNodes[2].InnerText;
                haftaici.Add(data1);

                string data2 = node.ChildNodes[i].ChildNodes[3].InnerText;
                cumartesi.Add(data2);

                string data3 = node.ChildNodes[i].ChildNodes[4].InnerText;
                pazar.Add(data3);
            }

            #endregion

            #region Add to ListView

            list.Items.Clear();
            for (int i = 0; i < size - 3; i++)
            {
                var item = new DataList();
                item.haftaici = haftaici.ToArray()[i].ToString().Replace("&nbsp;", "");
                item.cumartesi = cumartesi.ToArray()[i].ToString().Replace("&nbsp;", "");
                item.pazar = pazar.ToArray()[i].ToString().Replace("&nbsp;", "");
                list.Items.Add(item);
            }

            #endregion
        }

        private void appBar2_Click(object sender, RoutedEventArgs e)
        {
            Duraklar.hatDurak = OtobusSaatleri.hatno;
            Frame.Navigate(typeof(View.DetailsDuraklar));
        }

    }
}
