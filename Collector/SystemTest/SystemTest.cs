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
					new Quote("GD"),
                },
            };
            f.GetQuotes();
	        foreach (Quote q in f.Quotes)
	        {
		          DatabaseSeeder.DatabaseSeeder.CreateInsertObject(q);
	        }
        }

		[Test]
		public void CanInsertHistoricalQuote()
		{
			var f = new ViewModel();
			
			f.GetHistoricalQuotes("GD");
			foreach (HistoricalQuote q in f.HistoricalQuotes)
			{
				DatabaseSeeder.DatabaseSeeder.CreateInsertObject(q);
			}
		}
    }
}