using currencyconvertor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace currencyconvertor.Controllers
{
    public class CurrencyController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Currencies = new List<string> { "USD", "EUR", "EGP", "PKR" };
            return View();
        }

        [HttpPost]
        public IActionResult Index(CurrencyConverter model)
        {
            var rates = new Dictionary<string, double>
 {
    { "USD", 1.0 },
    { "EUR", 0.91 },
    { "EGP", 48.0 },
    { "PKR", 277.25 }
  };

            model.ConvertedAmount = model.Amount * (rates[model.ToCurrency] / rates[model.FromCurrency]);




            ViewBag.Currencies = rates.Keys.ToList();
            return View(model);
        }
    }

}
