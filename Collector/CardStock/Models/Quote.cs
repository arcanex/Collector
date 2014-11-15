using System;
using System.ComponentModel;

namespace YahooStockFeed.Models
{
    public class Quote : INotifyPropertyChanged
    {
        private decimal? _ask;
        private decimal? _averageDailyVolume;
        private decimal? _bid;
        private decimal? _bookValue;
        private decimal? _change;
        private decimal? _changeFromTwoHundredDayMovingAverage;
        private decimal? _changeFromYearHigh;
        private decimal? _changeFromYearLow;
        private decimal? _changeInPercent;
        private decimal? _changePercent;
        private decimal? _dailyHigh;
        private decimal? _dailyLow;
        private DateTime? _dividendPayDate;
        private decimal? _dividendShare;
        private decimal? _dividendYield;
        private decimal? _earningsShare;
        private decimal? _ebitda;
        private decimal? _epsEstimateCurrentYear;
        private decimal? _epsEstimateNextQuarter;
        private decimal? _epsEstimateNextYear;
        private DateTime? _exDividendDate;
        private decimal? _fiftyDayMovingAverage;
        private DateTime? _lastTradeDate;
        private decimal? _lastTradePrice;
        private DateTime _lastUpdate;
        private decimal? _marketCapitalization;
        private string _name;
        private decimal? _oneYearPriceTarget;
        private decimal? _open;
        private decimal? _peRatio;
        private decimal? _pegRatio;
        private decimal? _percentChangeFromFiftyDayMovingAverage;
        private decimal? _percentChangeFromTwoHundredDayMovingAverage;
        private decimal? _percentChangeFromYearHigh;
        private decimal? _percentChangeFromYearLow;
        private decimal? _previousClose;
        private decimal? _priceBook;
        private decimal? _priceEpsEstimateCurrentYear;
        private decimal? _priceEpsEstimateNextYear;
        private decimal? _priceSales;
        private decimal? _shortRatio;
        private string _stockExchange;
        private string _symbol;
        private decimal? _twoHunderedDayMovingAverage;
        private decimal? _volume;
        private decimal? _yearlyHigh;
        private decimal? _yearlyLow;

        public Quote(string ticker)
        {
            _symbol = ticker;
        }


        public DateTime LastUpdate
        {
            get { return _lastUpdate; }
            set
            {
                _lastUpdate = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("LastUpdate"));
            }
        }


        public string StockExchange
        {
            get { return _stockExchange; }
            set
            {
                _stockExchange = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("StockExchange"));
            }
        }


        public decimal? Volume
        {
            get { return _volume; }
            set
            {
                _volume = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Volume"));
            }
        }

        public decimal? PeRatio
        {
            get { return _peRatio; }
            set
            {
                _peRatio = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("PeRatio"));
            }
        }

        public decimal? PercentChangeFromTwoHundredDayMovingAverage
        {
            get { return _percentChangeFromTwoHundredDayMovingAverage; }
            set
            {
                _percentChangeFromTwoHundredDayMovingAverage = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("PercentChangeFromTwoHundredDayMovingAverage"));
            }
        }

        public DateTime? DividendPayDate
        {
            get { return _dividendPayDate; }
            set
            {
                _dividendPayDate = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("DividendPayDate"));
            }
        }

        public decimal? DividendYield
        {
            get { return _dividendYield; }
            set
            {
                _dividendYield = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("DividendYield"));
            }
        }


        public decimal? OneYearPriceTarget
        {
            get { return _oneYearPriceTarget; }
            set
            {
                _oneYearPriceTarget = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("OneYearPriceTarget"));
            }
        }

        public decimal? ShortRatio
        {
            get { return _shortRatio; }
            set
            {
                _shortRatio = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("ShortRatio"));
            }
        }


        public decimal? PriceEpsEstimateNextYear
        {
            get { return _priceEpsEstimateNextYear; }
            set
            {
                _priceEpsEstimateNextYear = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("PriceEpsEstimateNextYear"));
            }
        }


        public decimal? PriceEpsEstimateCurrentYear
        {
            get { return _priceEpsEstimateCurrentYear; }
            set
            {
                _priceEpsEstimateCurrentYear = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("PriceEpsEstimateCurrentYear"));
            }
        }


        public decimal? PegRatio
        {
            get { return _pegRatio; }
            set
            {
                _pegRatio = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("PegRatio"));
            }
        }


        public DateTime? ExDividendDate
        {
            get { return _exDividendDate; }
            set
            {
                _exDividendDate = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("ExDividendDate"));
            }
        }


        public decimal? PriceBook
        {
            get { return _priceBook; }
            set
            {
                _priceBook = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("PriceBook"));
            }
        }


        public decimal? PriceSales
        {
            get { return _priceSales; }
            set
            {
                _priceSales = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("PriceSales"));
            }
        }


        public decimal? ChangeInPercent
        {
            get { return _changeInPercent; }
            set
            {
                _changeInPercent = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("ChangeInPercent"));
            }
        }


        public decimal? PreviousClose
        {
            get { return _previousClose; }
            set
            {
                _previousClose = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("PreviousClose"));
            }
        }


        public decimal? Open
        {
            get { return _open; }
            set
            {
                _open = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Open"));
            }
        }


        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Name"));
            }
        }


        public decimal? PercentChangeFromFiftyDayMovingAverage
        {
            get { return _percentChangeFromFiftyDayMovingAverage; }
            set
            {
                _percentChangeFromFiftyDayMovingAverage = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("PercentChangeFromFiftyDayMovingAverage"));
            }
        }


        public decimal? ChangeFromTwoHundredDayMovingAverage
        {
            get { return _changeFromTwoHundredDayMovingAverage; }
            set
            {
                _changeFromTwoHundredDayMovingAverage = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("ChangeFromTwoHundredDayMovingAverage"));
            }
        }


        public decimal? TwoHunderedDayMovingAverage
        {
            get { return _twoHunderedDayMovingAverage; }
            set
            {
                _twoHunderedDayMovingAverage = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("TwoHunderedDayMovingAverage"));
            }
        }


        public decimal? FiftyDayMovingAverage
        {
            get { return _fiftyDayMovingAverage; }
            set
            {
                _fiftyDayMovingAverage = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("FiftyDayMovingAverage"));
            }
        }


        public decimal? LastTradePrice
        {
            get { return _lastTradePrice; }
            set
            {
                _lastTradePrice = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("LastTradePrice"));
            }
        }


        public decimal? PercentChangeFromYearHigh
        {
            get { return _percentChangeFromYearHigh; }
            set
            {
                _percentChangeFromYearHigh = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("PercentChangeFromYearHigh"));
            }
        }


        public decimal? ChangeFromYearHigh
        {
            get { return _changeFromYearHigh; }
            set
            {
                _changeFromYearHigh = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("ChangeFromYearHigh"));
            }
        }


        public decimal? PercentChangeFromYearLow
        {
            get { return _percentChangeFromYearLow; }
            set
            {
                _percentChangeFromYearLow = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("PercentChangeFromYearLow"));
            }
        }


        public decimal? ChangeFromYearLow
        {
            get { return _changeFromYearLow; }
            set
            {
                _changeFromYearLow = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("ChangeFromYearLow"));
            }
        }


        public decimal? Ebitda
        {
            get { return _ebitda; }
            set
            {
                _ebitda = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Ebitda"));
            }
        }


        public decimal? MarketCapitalization
        {
            get { return _marketCapitalization; }
            set
            {
                _marketCapitalization = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("MarketCapitalization"));
            }
        }


        public decimal? YearlyHigh
        {
            get { return _yearlyHigh; }
            set
            {
                _yearlyHigh = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("YearlyHigh"));
            }
        }


        public decimal? YearlyLow
        {
            get { return _yearlyLow; }
            set
            {
                _yearlyLow = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("YearlyLow"));
            }
        }


        public decimal? DailyHigh
        {
            get { return _dailyHigh; }
            set
            {
                _dailyHigh = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("DailyHigh"));
            }
        }


        public decimal? DailyLow
        {
            get { return _dailyLow; }
            set
            {
                _dailyLow = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("DailyLow"));
            }
        }


        public decimal? EpsEstimateNextQuarter
        {
            get { return _epsEstimateNextQuarter; }
            set
            {
                _epsEstimateNextQuarter = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("EpsEstimateNextQuarter"));
            }
        }


        public decimal? EpsEstimateNextYear
        {
            get { return _epsEstimateNextYear; }
            set
            {
                _epsEstimateNextYear = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("EpsEstimateNextYear"));
            }
        }


        public decimal? EpsEstimateCurrentYear
        {
            get { return _epsEstimateCurrentYear; }
            set
            {
                _epsEstimateCurrentYear = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("EpsEstimateCurrentYear"));
            }
        }


        public decimal? EarningsShare
        {
            get { return _earningsShare; }
            set
            {
                _earningsShare = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("EarningsShare"));
            }
        }


        public DateTime? LastTradeDate
        {
            get { return _lastTradeDate; }
            set
            {
                _lastTradeDate = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("LastTradeDate"));
            }
        }


        public decimal? DividendShare
        {
            get { return _dividendShare; }
            set
            {
                _dividendShare = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("DividendShare"));
            }
        }


        public decimal? Change
        {
            get { return _change; }
            set
            {
                _change = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Change"));
            }
        }


        public decimal? ChangePercent
        {
            get { return _changePercent; }
            set
            {
                _changePercent = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("ChangePercent"));
            }
        }


        public decimal? BookValue
        {
            get { return _bookValue; }
            set
            {
                _bookValue = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("BookValue"));
            }
        }


        public decimal? Ask
        {
            get { return _ask; }
            set
            {
                _ask = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Ask"));
            }
        }


        public decimal? Bid
        {
            get { return _bid; }
            set
            {
                _bid = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Bid"));
            }
        }


        public decimal? AverageDailyVolume
        {
            get { return _averageDailyVolume; }
            set
            {
                _averageDailyVolume = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("AverageDailyVolume"));
            }
        }


        public string Symbol
        {
            get { return _symbol; }
            set
            {
                _symbol = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Symbol"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}