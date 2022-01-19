using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;

namespace Bitcoin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getRatesBtn_Click(object sender, EventArgs e)
        {
            if (currencyMenu.SelectedItem.ToString() == "EUR")
            {
                resultLbl.Visible = true;
                Result.Visible = true;

                BitcoinRate resultRates = GetRates();
                int userCoins = Int32.Parse(amountOfBtc.Text);                               
                float currentRate = resultRates.bpi.EUR.rate_float;
                float btcResult = userCoins * currentRate;
                Result.Text = $"{btcResult} {resultRates.bpi.EUR.code}";
            }
            else if (currencyMenu.SelectedItem.ToString() == "USD")
            {
                resultLbl.Visible = true;
                Result.Visible = true;

                BitcoinRate resultRates = GetRates();               
                int userCoins = Int32.Parse(amountOfBtc.Text);
                float currentRate = resultRates.bpi.USD.rate_float;
                float btcResult = userCoins * currentRate;
                Result.Text = $"{btcResult} {resultRates.bpi.USD.code}";
            }
            else if (currencyMenu.SelectedItem.ToString() == "GBP")
            {
                resultLbl.Visible = true;
                Result.Visible = true;

                BitcoinRate resultRates = GetRates();
                int userCoins = Int32.Parse(amountOfBtc.Text);
                float currentRate = resultRates.bpi.GBP.rate_float;
                float btcResult = userCoins * currentRate;
                Result.Text = $"{btcResult} {resultRates.bpi.GBP.code}";
            }
        }
        public static BitcoinRate GetRates()
        {
            string url = "https://api.coindesk.com/v1/bpi/currentprice.json";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            request.Method = "GET";
            BitcoinRate bitcoin;

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            using (var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
                bitcoin = JsonConvert.DeserializeObject<BitcoinRate>(response);
            }
            return bitcoin;
        }
    }
}
