using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    
    public class CurrancyConverter
    {
        private IEnumerable<ExchanageRate> _exchanages;

        private CurrancyConverter() {
            LeadExchangeRates();
        }
        private static object _lock = new();
        private static CurrancyConverter _instance;
        public static CurrancyConverter Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new();

                    return _instance;
                }
            }
        }

        private void LeadExchangeRates()
        {
            Thread.Sleep(3000);

            _exchanages = new[]
            {
                new ExchanageRate("USD", "SAR" , 3.75m),
                new ExchanageRate("USD", "EGY" , 56.30m),
                new ExchanageRate("SAR", "EGY" , 11.50m)
            };
        }

        public decimal Convert (string baseCurrenct , string taregtCurrency , decimal amnount)
        {
            var exchangeRate =_exchanages.FirstOrDefault(rate => rate.BaseCurrency == baseCurrenct && rate.TagetCurrency == taregtCurrency) ;
            return amnount * exchangeRate.Rate;
        }
    }
}
