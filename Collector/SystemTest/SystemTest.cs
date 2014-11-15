using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using YahooStockFeed.Models;
using YahooStockFeed.ViewModels;

namespace SystemTest
{
    [TestClass]
    public class SystemTest
    {
        [Test]
        public void CanInsertQuote()
        {
            var f = new ViewModel
            {
                Quotes = new ObservableCollection<Quote>
                {
                    new Quote("AAPL"),
                },
            };
            f.GetQuotes();
            DatabaseSeeder.DatabaseSeeder.CreateInsertObject(f.Quotes.First());
        }
    }
}