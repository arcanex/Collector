﻿using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using Utility;
using YahooStockFeed.Models;

namespace YahooStockFeed.Helpers
{
    public class YahooStockEngine
    {
        private const string BaseUrl =
            "http://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20yahoo.finance.quotes%20where%20symbol%20in%20({0})&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys";

		private const string HistoricalBaseUrl =
			"http://query.yahooapis.com/v1/public/yql?q=Select%20*%20from%20yahoo.finance.historicaldata%20where%20symbol%20%3D%20%22{0}%22%20and%20startDate%20%3D%20%222009-09-11%22%20and%20endDate%20%3D%20%222010-03-10%22&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys";

        public static void Fetch(ObservableCollection<Quote> quotes)
        {
            string symbolList = String.Join("%2C", quotes.Select(w => "%22" + w.Symbol + "%22").ToArray());
            string url = string.Format(BaseUrl, symbolList);

            XDocument doc = XDocument.Load(url);
            Parse(quotes, doc);
        }

	    public static void FetchHistorical(ObservableCollection<HistoricalQuote> quotes, string ticker)
	    {
		    string url = string.Format(HistoricalBaseUrl, ticker);

			    XDocument doc = XDocument.Load(url);
			    ParseHistorical(quotes, doc);
		    
	    }

	    private static void ParseHistorical(ObservableCollection<HistoricalQuote> quotes, XDocument doc)
	    {
		    if (doc.Root != null)
		    {
			    XElement results = doc.Root.Element("results");

				foreach (XElement node in results.Elements("quote"))
				{
			    var hq = new HistoricalQuote
			    {
					Symbol = node.Attribute("Symbol").Value,
					Date = GetDateTime(node.Element("Date").Value),
					Open = GetDecimal(node.Element("Open").Value),
					High = GetDecimal(node.Element("High").Value),
					Low = GetDecimal(node.Element("Low").Value),
					Close = GetDecimal(node.Element("Close").Value),
					Volume = GetDecimal(node.Element("Volume").Value),
					AdjClose = GetDecimal(node.Element("Adj_Close").Value),
			    };
			    quotes.Add(hq);

			    new Logger().Log(hq);
		    }
	    }
	    }

	    private static void Parse(ObservableCollection<Quote> quotes, XDocument doc)
        {
            if (doc.Root != null)
            {
                XElement results = doc.Root.Element("results");

                foreach (Quote quote in quotes)
                {
                    try
                    {
                        XElement q = results.Elements("quote").First(w => w.Attribute("symbol").Value == quote.Symbol);

                        quote.Ask = GetDecimal(q.Element("Ask").Value);
                        quote.Bid = GetDecimal(q.Element("Bid").Value);
                        quote.AverageDailyVolume = GetDecimal(q.Element("AverageDailyVolume").Value);
                        quote.BookValue = GetDecimal(q.Element("BookValue").Value);
                        quote.Change = GetDecimal(q.Element("Change").Value);
                        quote.DividendShare = GetDecimal(q.Element("DividendShare").Value);
                        quote.LastTradeDate =
                            GetDateTime(q.Element("LastTradeDate") + " " + q.Element("LastTradeTime").Value);
                        quote.EarningsShare = GetDecimal(q.Element("EarningsShare").Value);
                        quote.EpsEstimateCurrentYear = GetDecimal(q.Element("EPSEstimateCurrentYear").Value);
                        quote.EpsEstimateNextYear = GetDecimal(q.Element("EPSEstimateNextYear").Value);
                        quote.EpsEstimateNextQuarter = GetDecimal(q.Element("EPSEstimateNextQuarter").Value);
                        quote.DailyLow = GetDecimal(q.Element("DaysLow").Value);
                        quote.DailyHigh = GetDecimal(q.Element("DaysHigh").Value);
                        quote.YearlyLow = GetDecimal(q.Element("YearLow").Value);
                        quote.YearlyHigh = GetDecimal(q.Element("YearHigh").Value);
                        quote.MarketCapitalization = GetDecimal(q.Element("MarketCapitalization").Value);
                        quote.Ebitda = GetDecimal(q.Element("EBITDA").Value);
                        quote.ChangeFromYearLow = GetDecimal(q.Element("ChangeFromYearLow").Value);
                        quote.PercentChangeFromYearLow = GetDecimal(q.Element("PercentChangeFromYearLow").Value);
                        quote.ChangeFromYearHigh = GetDecimal(q.Element("ChangeFromYearHigh").Value);
                        quote.LastTradePrice = GetDecimal(q.Element("LastTradePriceOnly").Value);
                        quote.PercentChangeFromYearHigh = GetDecimal(q.Element("PercebtChangeFromYearHigh").Value);
                        //missspelling in yahoo for field name
                        quote.FiftyDayMovingAverage = GetDecimal(q.Element("FiftydayMovingAverage").Value);
                        quote.TwoHunderedDayMovingAverage = GetDecimal(q.Element("TwoHundreddayMovingAverage").Value);
                        quote.ChangeFromTwoHundredDayMovingAverage =
                            GetDecimal(q.Element("ChangeFromTwoHundreddayMovingAverage").Value);
                        quote.PercentChangeFromTwoHundredDayMovingAverage =
                            GetDecimal(q.Element("PercentChangeFromTwoHundreddayMovingAverage").Value);
                        quote.PercentChangeFromFiftyDayMovingAverage =
                            GetDecimal(q.Element("PercentChangeFromFiftydayMovingAverage").Value);
                        quote.Name = q.Element("Name").Value;
                        quote.Open = GetDecimal(q.Element("Open").Value);
                        quote.PreviousClose = GetDecimal(q.Element("PreviousClose").Value);
                        quote.ChangeInPercent = GetDecimal(q.Element("ChangeinPercent").Value);
                        quote.PriceSales = GetDecimal(q.Element("PriceSales").Value);
                        quote.PriceBook = GetDecimal(q.Element("PriceBook").Value);
                        quote.ExDividendDate = GetDateTime(q.Element("ExDividendDate").Value);
                        quote.PeRatio = GetDecimal(q.Element("PERatio").Value);
                        quote.DividendPayDate = GetDateTime(q.Element("DividendPayDate").Value);
                        quote.PegRatio = GetDecimal(q.Element("PEGRatio").Value);
                        quote.PriceEpsEstimateCurrentYear = GetDecimal(q.Element("PriceEPSEstimateCurrentYear").Value);
                        quote.PriceEpsEstimateNextYear = GetDecimal(q.Element("PriceEPSEstimateNextYear").Value);
                        quote.ShortRatio = GetDecimal(q.Element("ShortRatio").Value);
                        quote.OneYearPriceTarget = GetDecimal(q.Element("OneyrTargetPrice").Value);
                        quote.Volume = GetDecimal(q.Element("Volume").Value);
                        quote.StockExchange = q.Element("StockExchange").Value;

                        quote.LastUpdate = DateTime.Now;

                        new Logger().Log(quote);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
            }
        }

        private static decimal? GetDecimal(string input)
        {
            if (input == null) return null;

            input = input.Replace("%", "");

            decimal value;

            if (Decimal.TryParse(input, out value)) return value;
            return null;
        }

        private static DateTime? GetDateTime(string input)
        {
            if (input == null) return null;

            DateTime value;

            if (DateTime.TryParse(input, out value)) return value;
            return null;
        }
    }
}