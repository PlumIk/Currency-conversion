using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;




namespace Currency_conversion
{
    internal class FromSite : DataGet
    {
        private List<string> _name = new List<string>();
        private Dictionary<string, double> _value = new Dictionary<string, double>();

        public FromSite()
        {
            var json = new WebClient().DownloadString("https://www.cbr-xml-daily.ru/daily_json.js");
            var example = JsonConvert.DeserializeObject<Example>(json);

            _name.Add(example.Valute.AUD.CharCode);
            _value[example.Valute.AUD.CharCode] = example.Valute.AUD.Value / example.Valute.AUD.Nominal;

            _name.Add(example.Valute.BYN.CharCode);
            _value[example.Valute.BYN.CharCode] = example.Valute.BYN.Value / example.Valute.BYN.Nominal;

            _name.Add(example.Valute.BRL.CharCode);
            _value[example.Valute.BRL.CharCode] = example.Valute.BRL.Value / example.Valute.BRL.Nominal;

            _name.Add(example.Valute.USD.CharCode);
            _value[example.Valute.USD.CharCode] = example.Valute.USD.Value / example.Valute.USD.Nominal;

            _name.Add(example.Valute.EUR.CharCode);
            _value[example.Valute.EUR.CharCode] = example.Valute.EUR.Value / example.Valute.EUR.Nominal;

            _name.Add(example.Valute.KZT.CharCode);
            _value[example.Valute.KZT.CharCode] = example.Valute.KZT.Value / example.Valute.KZT.Nominal;

            _name.Add(example.Valute.JPY.CharCode);
            _value[example.Valute.JPY.CharCode] = example.Valute.JPY.Value / example.Valute.JPY.Nominal;

            _name.Add("RU");
            _value["RU"] = 1;
        }

        public List<string> GetNames()
        {
            return _name;
        }

        public Dictionary<string, double> GetValues()
        {
            return _value;
        }
    }
        
}
