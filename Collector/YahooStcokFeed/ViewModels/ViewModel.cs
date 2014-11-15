using System.Collections.ObjectModel;
using System.Windows;
using YahooStockFeed.Helpers;
using YahooStockFeed.Models;

namespace YahooStockFeed.ViewModels
{
    public class ViewModel : DependencyObject
    {
	    public ViewModel()
	    {
		    Quotes = new ObservableCollection<Quote>();
		    HistoricalQuotes = new ObservableCollection<HistoricalQuote>();
	    }
        public ObservableCollection<Quote> Quotes { get; set; }

	    public ObservableCollection<HistoricalQuote> HistoricalQuotes { get; set; }

	    public void GetQuotes()
        {
            YahooStockEngine.Fetch(Quotes);
        }

		public void GetHistoricalQuotes(string ticker)
		{
			YahooStockEngine.FetchHistorical(HistoricalQuotes, ticker);
		}
    }
}