namespace currencyconvertor.Models
{
    public class CurrencyConverter
    {
        public double Amount { get; set; }
        public string FromCurrency { get; set; }
        public string ToCurrency { get; set; }
        public double ConvertedAmount { get; set; }
    }
}
