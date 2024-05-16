using DesignPatterns.Singleton;

while (true)
{
    Console.WriteLine("Enter base currency");
    var baseCurrency = Console.ReadLine();
    Console.WriteLine("Enter taregt currency");
    var taregtCurrency = Console.ReadLine();
    Console.WriteLine("Enter amount ");
    var rate = decimal.Parse( Console.ReadLine() );

   // var converter = new CurrancyConverter ();
    var exchange = CurrancyConverter.Instance.Convert(baseCurrency, taregtCurrency , rate);
    Console.WriteLine($"{rate} {baseCurrency} = {exchange} {taregtCurrency}");
    Console.WriteLine("----------------------------------------------------");

}