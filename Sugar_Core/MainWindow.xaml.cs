using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Newtonsoft.Json.Linq;


namespace Sugar_Core
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            ParseJSON();

        }

        private void ParseJSON()
        {
            string URL = "https://sugarmate.io/api/v1/4uuv8v/latest.json";
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(URL);

                dynamic stuff = JObject.Parse(json);

                //Affectation 
                string value = stuff.value;
                string time = stuff.time;
                string trend_symbol = stuff.trend_symbol;
                string trend_words = stuff.trend_words;
                string mmol = stuff.mmol;
                string full = stuff.full;


                //Affect Value to Textbox
                tbxValue.Text = value;
                tbxTime.Text = time;
                tbxTrendSymbol.Text = trend_symbol;
                tbxtrend_words.Text = trend_words;
                tbxmmol.Text = mmol;
                tbxfull.Text = full;
            }


        }

    }
}
