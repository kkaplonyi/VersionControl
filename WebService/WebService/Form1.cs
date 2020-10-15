using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using WebService.Entites;
using WebService.MnbServiceReference;

namespace WebService
{
    public partial class Form1 : Form
    {
        
        
        RichTextBox rtb1 = new RichTextBox();
        RichTextBox rtb2 = new RichTextBox();
        BindingList<RateData> Rates = new BindingList<RateData>();
        BindingList<currs> Currencies = new BindingList<currs>();
        public class currs
        {
            public string curr2 { get; set; }
        }
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = Rates;
            GetCurrs();
            comboBox1.DataSource = Currencies;
            RefreshData();
            Console.WriteLine();
            

        }
        public void RefreshData()
        {
            Rates.Clear();
            GetExchangeRates();
            XMLFunction();
            grafikon();
            
        }
        public void GetCurrs()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();
            var req = new GetCurrenciesRequestBody();
            var resp = mnbService.GetCurrencies(req);
            var result2 = resp.GetCurrenciesResult;

            var xml = new XmlDocument();
            xml.LoadXml(result2);
            foreach (XmlElement element in xml.DocumentElement)
            {
                var curr = new currs();
                
                
                
                curr.curr2 = element.GetAttribute("curr");
                Currencies.Add(curr);

            }
            rtb2.Text = Currencies.ToString();
        }
        
        public void GetExchangeRates()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();
            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = comboBox1.SelectedItem.ToString(),
                startDate = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"),
                endDate = dateTimePicker2.Value.Date.ToString("yyyy-MM-dd")
            };

            var response = mnbService.GetExchangeRates(request);
            var result = response.GetExchangeRatesResult;

            rtb1.Text = result;
        }

        public void XMLFunction()
        {
            var xml = new XmlDocument();
            xml.LoadXml(rtb1.Text.ToString());

            foreach (XmlElement element in xml.DocumentElement)
            {
                var rate = new RateData();
                Rates.Add(rate);

                // Dátum
                rate.Date = DateTime.Parse(element.GetAttribute("date"));

                // Valuta
                var childElement = (XmlElement)element.ChildNodes[0];
                if (childElement == null)
                    continue;
                rate.Currency = childElement.GetAttribute("curr");

                // Érték
                var unit = decimal.Parse(childElement.GetAttribute("unit"));
                var value = decimal.Parse(childElement.InnerText);
                if (unit != 0)
                    rate.Value = value / unit;
            }
        }

        public void grafikon()
        {
            chartRateData.DataSource = Rates;

            var series = chartRateData.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "Date";
            series.YValueMembers = "Value";
            series.BorderWidth = 2;

            var legend = chartRateData.Legends[0];
            legend.Enabled = false;

            var chartArea = chartRateData.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = false;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
