using System;
using System.ComponentModel;

namespace YahooStockFeed.Models
{
	public class HistoricalQuote : INotifyPropertyChanged
	{
		private string _symbol;
		private DateTime? _date;
		private decimal? _open;
		private decimal? _high;
		private decimal? _low;
		private decimal? _close;
		private decimal? _volume;
		private decimal? _adjClose;
		public event PropertyChangedEventHandler PropertyChanged;

		public HistoricalQuote(string ticker)
		{
			_symbol = ticker;
		}

		public HistoricalQuote()
		{
			_symbol = Symbol;
			_date = Date;
			_open = Open;
			_high = High;
			_low = Low;
			_close = Close;
			_volume = Volume;
			_adjClose = AdjClose;
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

		public DateTime? Date
		{
			get { return _date; }
			set
			{
				_date = value;
				if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Date"));
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

		public decimal? High
		{
			get { return _high; }
			set
			{
				_high = value;
				if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("High"));
			}
		}

		public decimal? Low
		{
			get { return _low; }
			set
			{
				_low = value;
				if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Low"));
			}
		}

		public decimal? Close
		{
			get { return _close; }
			set
			{
				_close = value;
				if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Close"));
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

		public decimal? AdjClose
		{
			get { return _adjClose; }
			set
			{
				_adjClose = value;
				if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("AdjClose"));
			}
		}
	}
}