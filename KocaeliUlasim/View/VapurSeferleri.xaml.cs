using HtmlAgilityPack;
using KocaeliUlasim.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
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
    public sealed partial class VapurSeferleri : Page
    {
        Vapur vapur = new Vapur();
        private string kalkısIskeleId;
        private string varisIskeleId;


        public VapurSeferleri()
        {
            this.InitializeComponent();

            for(int i = 0; i < vapur.getVapurList().Length;i++)
            {
                comboBox1.Items.Add(vapur.getVapurList()[i]);
                comboBox2.Items.Add(vapur.getVapurList()[i]);
            }

        }


        private async void FindClock()
        {
            CookieContainer Cookies = new CookieContainer();
            HttpClientHandler Handler = new HttpClientHandler() { CookieContainer = Cookies };
            HttpClient Client = new HttpClient(Handler);
            await Client.GetAsync("http://kocaeli.bel.tr/vapursaatleri.aspx");


            Dictionary<string, string> value = new Dictionary<string, string>();
            value.Add("ctl00$ContentPlaceHolder1$ddlKalkisIskele", kalkısIskeleId);
            value.Add("ctl00$ContentPlaceHolder1$ddlVarisIskele", varisIskeleId);
            value.Add("ctl00$ContentPlaceHolder1$ddlHatfaIci", "1");
            value.Add("ctl00$ContentPlaceHolder1$btnSorgula", "SORGULA");


            var result = await Client.PostAsync("http://kocaeli.bel.tr/vapursaatleri.aspx", new FormUrlEncodedContent(value));
            string html = await result.Content.ReadAsStringAsync();

            HtmlDocument htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            HtmlNode parent = htmlDocument.DocumentNode.Descendants("table").First(o => o.GetAttributeValue("id", "") == "ctl00_ContentPlaceHolder1_grid");

        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string value = (comboBox1.SelectedItem).ToString();
            kalkısIskeleId = vapur.getId(value);

           // if (kalkısIskeleId != 0) FindClock();
        }

        private void comboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string value = (comboBox2.SelectedItem).ToString();
            varisIskeleId = vapur.getId(value);

            FindClock();
        }

    }
}
