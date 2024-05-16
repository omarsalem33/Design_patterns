using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class ExchanageRate
    {
        public string BaseCurrency { get; }
        public string TagetCurrency { get; }
        public decimal Rate {  get; }

        public ExchanageRate(string baseCurrency , string tagetCurrency , decimal rate) { 
            BaseCurrency = baseCurrency;
            TagetCurrency = tagetCurrency;
            Rate = rate;
        }
    }
}
