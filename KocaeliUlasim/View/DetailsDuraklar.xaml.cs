using HtmlAgilityPack;
using KocaeliUlasim.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
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
    public sealed partial class DetailsDuraklar : Page
    {
        private List<string> NameList = new List<string>();
        private List<string> StateList = new List<string>();
        Controller control = new Controller();


        public DetailsDuraklar()
        {
            this.InitializeComponent();
            header.Text = Duraklar.hatDurak + " Durakları";
            FindStation();
        }


        private async void FindStation()
        {
            try
            {
                progress.IsIndeterminate = true;

                string htmlPage = null;
                using (var client = new HttpClient())
                {
                    htmlPage = await client.GetStringAsync("http://www.kocaeli.bel.tr/OtobusSaatleri.aspx?TypeID=2&HatKodu=" + Duraklar.hatDurak);
                }

                HtmlDocument htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(htmlPage);

                HtmlNode parent1 = htmlDocument.DocumentNode.Descendants("table").FirstOrDefault(o => o.GetAttributeValue("id", "") == "ctl00_ContentPlaceHolder1_GridViewHatDuraklariGidis");
                DownloadData(parent1, list1);

                HtmlNode parent2 = htmlDocument.DocumentNode.Descendants("table").FirstOrDefault(o => o.GetAttributeValue("id", "") == "ctl00_ContentPlaceHolder1_GridViewHatDuraklariDonus");
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
                        FindStation();
                    }

                    #endregion
                }
            }
        }

        private void DownloadData(HtmlNode node, ListView list)
        {
            NameList.Clear();
            StateList.Clear();
            int size = node.ChildNodes.Count;

            for (int i = 2; i < size - 1; i++)
            {
                string data1 = node.ChildNodes[i].ChildNodes[1].InnerText.Trim();
                NameList.Add(WebUtility.HtmlDecode(data1));

                string data2 = node.ChildNodes[i].ChildNodes[2].InnerText.Trim();
                StateList.Add(WebUtility.HtmlDecode(data2));
            }

            list.Items.Clear();
            for (int i = 0; i < size - 3; i++)
            {
                var item = new Station();
                item.Name = NameList.ToArray()[i].ToString();
                item.State = StateList.ToArray()[i].ToString();
                list.Items.Add(item);
            }
        }

    }
}
