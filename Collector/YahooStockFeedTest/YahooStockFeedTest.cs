using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using YahooStockFeed.Models;
using YahooStockFeed.ViewModels;

namespace YahooStockFeedTest
{
    [TestClass]
    public class YahooStockFeedTest
    {
        [Test]
        public void CanCollect()
        {
            var f = new ViewModel
            {
                Quotes = new ObservableCollection<Quote>
                {
                    new Quote("IBB"),
                    new Quote("IHE"),
                    new Quote("IHF"),
                    new Quote("IJT"),
                    new Quote("XLE"),
                    //new Quote("AAPL"),
                    //new Quote("MSFT"),
                    //new Quote("INTC"),
                    //new Quote("IBM"),
                },
            };
            f.GetQuotes();
        }
    }
}