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
        private List<string> _shortName = new List<string>();
        private Dictionary<string, double> _value = new Dictionary<string, double>();
        private Dictionary<string, string> _names = new Dictionary<string, string>();

        public FromSite()
        {
            try
            {
                var json = new WebClient().DownloadString("https://www.cbr-xml-daily.ru/daily_json.js");
                var example = JsonConvert.DeserializeObject<Example>(json);

                _shortName.Add(example.Valute.AUD.CharCode);
                _value[example.Valute.AUD.CharCode] = example.Valute.AUD.Value / example.Valute.AUD.Nominal;
                _names[example.Valute.AUD.CharCode] = $"{example.Valute.AUD.Name} ({example.Valute.AUD.CharCode})";

                _shortName.Add(example.Valute.BYN.CharCode);
                _value[example.Valute.BYN.CharCode] = example.Valute.BYN.Value / example.Valute.BYN.Nominal;
                _names[example.Valute.BYN.CharCode] = $"{example.Valute.BYN.Name} ({example.Valute.BYN.CharCode})";

                _shortName.Add(example.Valute.BRL.CharCode);
                _value[example.Valute.BRL.CharCode] = example.Valute.BRL.Value / example.Valute.BRL.Nominal;
                _names[example.Valute.BRL.CharCode] = $"{example.Valute.BRL.Name} ({example.Valute.BRL.CharCode})";

                _shortName.Add(example.Valute.USD.CharCode);
                _value[example.Valute.USD.CharCode] = example.Valute.USD.Value / example.Valute.USD.Nominal;
                _names[example.Valute.USD.CharCode] = $"{example.Valute.USD.Name} ({example.Valute.USD.CharCode})";

                _shortName.Add(example.Valute.EUR.CharCode);
                _value[example.Valute.EUR.CharCode] = example.Valute.EUR.Value / example.Valute.EUR.Nominal;
                _names[example.Valute.EUR.CharCode] = $"{example.Valute.EUR.Name} ({example.Valute.EUR.CharCode})";

                _shortName.Add(example.Valute.KZT.CharCode);
                _value[example.Valute.KZT.CharCode] = example.Valute.KZT.Value / example.Valute.KZT.Nominal;
                _names[example.Valute.KZT.CharCode] = $"{example.Valute.KZT.Name} ({example.Valute.KZT.CharCode})";

                _shortName.Add(example.Valute.JPY.CharCode);
                _value[example.Valute.JPY.CharCode] = example.Valute.JPY.Value / example.Valute.JPY.Nominal;
                _names[example.Valute.JPY.CharCode] = $"{example.Valute.JPY.Name} ({example.Valute.JPY.CharCode})";
            }
            catch (Exception) { }
            finally
            {
                _shortName.Add("RU");
                _value["RU"] = 1;
                _names["RU"] = $"Российский рубль (RU)";
            }
        }

        public Dictionary<string, string> GetNames()
        {
            return _names;
        }

        public List<string> GetShortNames()
        {
            return _shortName;
        }

        public Dictionary<string, double> GetValues()
        {
            return _value;
        }
    }
        
}
