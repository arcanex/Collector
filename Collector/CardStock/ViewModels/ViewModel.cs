using System.Collections.ObjectModel;
using System.Windows;
using YahooStockFeed.Helpers;
using YahooStockFeed.Models;

namespace YahooStockFeed.ViewModels
{
    public class ViewModel : DependencyObject
    {
        public ObservableCollection<Quote> Quotes { get; set; }

        public void GetQuotes()
        {
            YahooStockEngine.Fetch(Quotes);
        }
    }
}