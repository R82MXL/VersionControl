using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebService.MnbServiceReference;
using WebService.Entities;
using System.Xml;
using System.Windows.Forms.DataVisualization.Charting;

namespace WebService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dataGridView1.DataSource = Rates;
            comboBox1.DataSource = Currencies;

            WebServiceCallCurr();
            RefreshData();
        }

        void WebServiceCall()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = comboBox1.SelectedItem.ToString(),
                startDate = dateTimePicker1.Value.ToString(),
                endDate = dateTimePicker2.Value.ToString()
            };

            var response = mnbService.GetExchangeRates(request);
            var result = response.GetExchangeRatesResult;

            XMLProcess(result);
        }

        void WebServiceCallCurr()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();

            var requestcurr = new GetCurrenciesRequestBody();
            var responsecurr = mnbService.GetCurrencies(requestcurr);
            var resultcurr = responsecurr.GetCurrenciesResult;

            XMLProcessCurr(resultcurr);
        }

        BindingList<string> Currencies = new BindingList<string>();

        BindingList<RateData> Rates = new BindingList<RateData>();
        
        void XMLProcess(string result)
        {
            var xml = new XmlDocument();
            xml.LoadXml(result);

            foreach (XmlElement element in xml.DocumentElement)
            {
                var rate = new RateData();
                Rates.Add(rate);

                rate.Date = DateTime.Parse(element.GetAttribute("date"));

                var childElement = (XmlElement)element.ChildNodes[0];
                if (childElement == null)
                    continue;
                rate.Currency = childElement.GetAttribute("curr");

                var unit = decimal.Parse(childElement.GetAttribute("unit"));
                var value = decimal.Parse(childElement.InnerText);
                if (unit != 0)
                    rate.Value = value / unit;
            }
        }

        void XMLProcessCurr(string resultcurr)
        {
            var xml = new XmlDocument();
            xml.LoadXml(resultcurr);

            foreach (XmlElement element in xml.DocumentElement)
            {
                for (int i = 0; i < element.ChildNodes.Count; i++)
                Currencies.Add(element.ChildNodes[i].InnerText);
            }
        }

        void DisplayData()
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

        void RefreshData()
        {
            Rates.Clear();
            WebServiceCall();
            DisplayData();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
