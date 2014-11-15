using System;
using System.Data;
using DatabaseSeeder.Models;
using Npgsql;
using YahooStockFeed.Models;

namespace DatabaseSeeder
{
    public class DatabaseSeeder
    {
        private static readonly NpgsqlConnection Connection;

        static DatabaseSeeder()
        {
            Connection =
                new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=1!Marines; Database=seed;");
            Connection.Open();
        }

        public static void Select()
        {
            try
            {
                var command = new NpgsqlCommand("select version()", Connection);
                var serverversion = (String) command.ExecuteScalar();
                Console.WriteLine(@"PostgreSQL server version: {0}", serverversion);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void CreateInsertObject(Quote obj)
        {
            var ds = new DataSet();

            string commandString = "insert into quote(";
            commandString += QuoteTable.Ask + ',';
            commandString += QuoteTable.Averagedailyvolume + ',';
            commandString += QuoteTable.Bid + ',';
            commandString += QuoteTable.BookValue + ',';
            commandString += QuoteTable.Change + ',';
            commandString += QuoteTable.ChangeFromTwoHundredDayMovingAverage + ',';
            commandString += QuoteTable.ChangeFromYearHigh + ',';
            commandString += QuoteTable.ChangeFromYearLow + ',';
            commandString += QuoteTable.ChangeInPercent + ',';
            commandString += QuoteTable.ChangePercent + ',';
            commandString += QuoteTable.DailyHigh + ',';
            commandString += QuoteTable.DailyLow + ',';
            commandString += QuoteTable.DividendPayDate + ',';
            commandString += QuoteTable.DividendShare + ',';
            commandString += QuoteTable.DividendYield + ',';
            commandString += QuoteTable.EarningsShare + ',';
            commandString += QuoteTable.Ebitda + ',';
            commandString += QuoteTable.EpsEstimateCurrentYear + ',';
            commandString += QuoteTable.EpsEstimateNextQuarter + ',';
            commandString += QuoteTable.EpsEstimateNextYear + ',';
            commandString += QuoteTable.ExDividendDate + ',';
            commandString += QuoteTable.FiftyDayMovingAverage + ',';
            commandString += QuoteTable.LastTradeDate + ',';
            commandString += QuoteTable.LastTradePrice + ',';
            commandString += QuoteTable.LastUpdate + ',';
            commandString += QuoteTable.MarketCapitalization + ',';
            commandString += QuoteTable.Name + ',';
            commandString += QuoteTable.OneYearPriceTarget + ',';
            commandString += QuoteTable.Open + ',';
            commandString += QuoteTable.PeRatio + ',';
            commandString += QuoteTable.PegRatio + ',';
            commandString += QuoteTable.PercentChangeFromFiftyDayMovingAverage + ',';
            commandString += QuoteTable.PercentChangeFromTwoHundredDayMovingAverage + ',';
            commandString += QuoteTable.PercentChangeFromYearHigh + ',';
            commandString += QuoteTable.PercentChangeFromYearLow + ',';
            commandString += QuoteTable.PreviousClose + ',';
            commandString += QuoteTable.PriceBook + ',';
            commandString += QuoteTable.PriceEpsEstimateCurrentYear + ',';
            commandString += QuoteTable.PriceEpsEstimateNextYear + ',';
            commandString += QuoteTable.PriceSales + ',';
            commandString += QuoteTable.ShortRatio + ',';
            commandString += QuoteTable.StockExchange + ',';
            commandString += QuoteTable.Symbol + ',';
            commandString += QuoteTable.TwoHunderedDayMovingAverage + ',';
            commandString += QuoteTable.Volume + ',';
            commandString += QuoteTable.YearlyHigh + ',';
            commandString += QuoteTable.YearlyLow;
            commandString += ") values (";
            commandString += ':' + QuoteTable.Ask + ',';
            commandString += ':' + QuoteTable.Averagedailyvolume + ',';
            commandString += ':' + QuoteTable.Bid + ',';
            commandString += ':' + QuoteTable.BookValue + ',';
            commandString += ':' + QuoteTable.Change + ',';
            commandString += ':' + QuoteTable.ChangeFromTwoHundredDayMovingAverage + ',';
            commandString += ':' + QuoteTable.ChangeFromYearHigh + ',';
            commandString += ':' + QuoteTable.ChangeFromYearLow + ',';
            commandString += ':' + QuoteTable.ChangeInPercent + ',';
            commandString += ':' + QuoteTable.ChangePercent + ',';
            commandString += ':' + QuoteTable.DailyHigh + ',';
            commandString += ':' + QuoteTable.DailyLow + ',';
            commandString += ':' + QuoteTable.DividendPayDate + ',';
            commandString += ':' + QuoteTable.DividendShare + ',';
            commandString += ':' + QuoteTable.DividendYield + ',';
            commandString += ':' + QuoteTable.EarningsShare + ',';
            commandString += ':' + QuoteTable.Ebitda + ',';
            commandString += ':' + QuoteTable.EpsEstimateCurrentYear + ',';
            commandString += ':' + QuoteTable.EpsEstimateNextQuarter + ',';
            commandString += ':' + QuoteTable.EpsEstimateNextYear + ',';
            commandString += ':' + QuoteTable.ExDividendDate + ',';
            commandString += ':' + QuoteTable.FiftyDayMovingAverage + ',';
            commandString += ':' + QuoteTable.LastTradeDate + ',';
            commandString += ':' + QuoteTable.LastTradePrice + ',';
            commandString += ':' + QuoteTable.LastUpdate + ',';
            commandString += ':' + QuoteTable.MarketCapitalization + ',';
            commandString += ':' + QuoteTable.Name + ',';
            commandString += ':' + QuoteTable.OneYearPriceTarget + ',';
            commandString += ':' + QuoteTable.Open + ',';
            commandString += ':' + QuoteTable.PeRatio + ',';
            commandString += ':' + QuoteTable.PegRatio + ',';
            commandString += ':' + QuoteTable.PercentChangeFromFiftyDayMovingAverage + ',';
            commandString += ':' + QuoteTable.PercentChangeFromTwoHundredDayMovingAverage + ',';
            commandString += ':' + QuoteTable.PercentChangeFromYearHigh + ',';
            commandString += ':' + QuoteTable.PercentChangeFromYearLow + ',';
            commandString += ':' + QuoteTable.PreviousClose + ',';
            commandString += ':' + QuoteTable.PriceBook + ',';
            commandString += ':' + QuoteTable.PriceEpsEstimateCurrentYear + ',';
            commandString += ':' + QuoteTable.PriceEpsEstimateNextYear + ',';
            commandString += ':' + QuoteTable.PriceSales + ',';
            commandString += ':' + QuoteTable.ShortRatio + ',';
            commandString += ':' + QuoteTable.StockExchange + ',';
            commandString += ':' + QuoteTable.Symbol + ',';
            commandString += ':' + QuoteTable.TwoHunderedDayMovingAverage + ',';
            commandString += ':' + QuoteTable.Volume + ',';
            commandString += ':' + QuoteTable.YearlyHigh + ',';
            commandString += ':' + QuoteTable.YearlyLow;
            commandString += ")";

            var da = new NpgsqlDataAdapter("select * from quote", Connection)
            {
                InsertCommand = new NpgsqlCommand(commandString, Connection)
            };

            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.Ask, DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.Averagedailyvolume, DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.Bid, DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.BookValue, DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.Change, DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.ChangeFromTwoHundredDayMovingAverage,
                DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.ChangeFromYearHigh, DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.ChangeFromYearLow, DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.ChangeInPercent, DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.ChangePercent, DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.DailyHigh, DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.DailyLow, DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.DividendPayDate, DbType.DateTime));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.DividendShare, DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.DividendYield, DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.EarningsShare, DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.Ebitda, DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.EpsEstimateCurrentYear, DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.EpsEstimateNextQuarter, DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.EpsEstimateNextYear, DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.ExDividendDate, DbType.DateTime));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.FiftyDayMovingAverage, DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.LastTradeDate, DbType.DateTime));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.LastTradePrice, DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.LastUpdate, DbType.DateTime));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.MarketCapitalization, DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.Name, DbType.String));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.OneYearPriceTarget, DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.Open, DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.PeRatio, DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.PegRatio, DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.PercentChangeFromFiftyDayMovingAverage,
                DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.PercentChangeFromTwoHundredDayMovingAverage,
                DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.PercentChangeFromYearHigh, DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.PercentChangeFromYearLow, DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.PreviousClose, DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.PriceBook, DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.PriceEpsEstimateCurrentYear, DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.PriceEpsEstimateNextYear, DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.PriceSales, DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.ShortRatio, DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.StockExchange, DbType.String));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.Symbol, DbType.String));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.TwoHunderedDayMovingAverage, DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.Volume, DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.YearlyHigh, DbType.Single));
            da.InsertCommand.Parameters.Add(new NpgsqlParameter(QuoteTable.YearlyLow, DbType.Single));

            foreach (NpgsqlParameter p in da.InsertCommand.Parameters)
            {
                p.Direction = ParameterDirection.Input;
            }

            da.InsertCommand.Parameters[0].SourceColumn = QuoteTable.Ask;
            da.InsertCommand.Parameters[1].SourceColumn = QuoteTable.Averagedailyvolume;
            da.InsertCommand.Parameters[2].SourceColumn = QuoteTable.Bid;
            da.InsertCommand.Parameters[3].SourceColumn = QuoteTable.BookValue;
            da.InsertCommand.Parameters[4].SourceColumn = QuoteTable.Change;
            da.InsertCommand.Parameters[5].SourceColumn = QuoteTable.ChangeFromTwoHundredDayMovingAverage;
            da.InsertCommand.Parameters[6].SourceColumn = QuoteTable.ChangeFromYearHigh;
            da.InsertCommand.Parameters[7].SourceColumn = QuoteTable.ChangeFromYearLow;
            da.InsertCommand.Parameters[8].SourceColumn = QuoteTable.ChangeInPercent;
            da.InsertCommand.Parameters[9].SourceColumn = QuoteTable.ChangePercent;
            da.InsertCommand.Parameters[10].SourceColumn = QuoteTable.DailyHigh;
            da.InsertCommand.Parameters[11].SourceColumn = QuoteTable.DailyLow;
            da.InsertCommand.Parameters[12].SourceColumn = QuoteTable.DividendPayDate;
            da.InsertCommand.Parameters[13].SourceColumn = QuoteTable.DividendShare;
            da.InsertCommand.Parameters[14].SourceColumn = QuoteTable.DividendYield;
            da.InsertCommand.Parameters[15].SourceColumn = QuoteTable.EarningsShare;
            da.InsertCommand.Parameters[16].SourceColumn = QuoteTable.Ebitda;
            da.InsertCommand.Parameters[17].SourceColumn = QuoteTable.EpsEstimateCurrentYear;
            da.InsertCommand.Parameters[18].SourceColumn = QuoteTable.EpsEstimateNextQuarter;
            da.InsertCommand.Parameters[19].SourceColumn = QuoteTable.EpsEstimateNextYear;
            da.InsertCommand.Parameters[20].SourceColumn = QuoteTable.ExDividendDate;
            da.InsertCommand.Parameters[21].SourceColumn = QuoteTable.FiftyDayMovingAverage;
            da.InsertCommand.Parameters[22].SourceColumn = QuoteTable.LastTradeDate;
            da.InsertCommand.Parameters[23].SourceColumn = QuoteTable.LastTradePrice;
            da.InsertCommand.Parameters[24].SourceColumn = QuoteTable.LastUpdate;
            da.InsertCommand.Parameters[25].SourceColumn = QuoteTable.MarketCapitalization;
            da.InsertCommand.Parameters[26].SourceColumn = QuoteTable.Name;
            da.InsertCommand.Parameters[27].SourceColumn = QuoteTable.OneYearPriceTarget;
            da.InsertCommand.Parameters[28].SourceColumn = QuoteTable.Open;
            da.InsertCommand.Parameters[29].SourceColumn = QuoteTable.PeRatio;
            da.InsertCommand.Parameters[30].SourceColumn = QuoteTable.PegRatio;
            da.InsertCommand.Parameters[31].SourceColumn = QuoteTable.PercentChangeFromFiftyDayMovingAverage;
            da.InsertCommand.Parameters[32].SourceColumn = QuoteTable.PercentChangeFromTwoHundredDayMovingAverage;
            da.InsertCommand.Parameters[33].SourceColumn = QuoteTable.PercentChangeFromYearHigh;
            da.InsertCommand.Parameters[34].SourceColumn = QuoteTable.PercentChangeFromYearLow;
            da.InsertCommand.Parameters[35].SourceColumn = QuoteTable.PreviousClose;
            da.InsertCommand.Parameters[36].SourceColumn = QuoteTable.PriceBook;
            da.InsertCommand.Parameters[37].SourceColumn = QuoteTable.PriceEpsEstimateCurrentYear;
            da.InsertCommand.Parameters[38].SourceColumn = QuoteTable.PriceEpsEstimateNextYear;
            da.InsertCommand.Parameters[39].SourceColumn = QuoteTable.PriceSales;
            da.InsertCommand.Parameters[40].SourceColumn = QuoteTable.ShortRatio;
            da.InsertCommand.Parameters[41].SourceColumn = QuoteTable.StockExchange;
            da.InsertCommand.Parameters[42].SourceColumn = QuoteTable.Symbol;
            da.InsertCommand.Parameters[43].SourceColumn = QuoteTable.TwoHunderedDayMovingAverage;
            da.InsertCommand.Parameters[44].SourceColumn = QuoteTable.Volume;
            da.InsertCommand.Parameters[45].SourceColumn = QuoteTable.YearlyHigh;
            da.InsertCommand.Parameters[46].SourceColumn = QuoteTable.YearlyLow;

            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            DataRow dr = dt.NewRow();

            MapFields(dr, QuoteTable.Ask, obj.Ask);
            MapFields(dr, QuoteTable.Averagedailyvolume, obj.AverageDailyVolume);
            MapFields(dr, QuoteTable.Bid, obj.Bid);
            MapFields(dr, QuoteTable.BookValue, obj.BookValue);
            MapFields(dr, QuoteTable.Change, obj.Change);
            MapFields(dr, QuoteTable.ChangeFromTwoHundredDayMovingAverage, obj.ChangeFromTwoHundredDayMovingAverage);
            MapFields(dr, QuoteTable.ChangeFromYearHigh, obj.ChangeFromYearHigh);
            MapFields(dr, QuoteTable.ChangeFromYearLow, obj.ChangeFromYearLow);
            MapFields(dr, QuoteTable.ChangeInPercent, obj.ChangeInPercent);
            MapFields(dr, QuoteTable.ChangePercent, obj.ChangePercent);
            MapFields(dr, QuoteTable.DailyHigh, obj.DailyHigh);
            MapFields(dr, QuoteTable.DailyLow, obj.DailyLow);
            MapFields(dr, QuoteTable.DividendPayDate, obj.DividendPayDate);          
            MapFields(dr, QuoteTable.DividendShare, obj.DividendShare);
            MapFields(dr, QuoteTable.DividendYield, obj.DividendYield);
            MapFields(dr, QuoteTable.EarningsShare, obj.EarningsShare);
            MapFields(dr, QuoteTable.Ebitda, obj.Ebitda);
            MapFields(dr, QuoteTable.EpsEstimateCurrentYear, obj.EpsEstimateCurrentYear);
            MapFields(dr, QuoteTable.EpsEstimateNextQuarter, obj.EpsEstimateNextQuarter);
            MapFields(dr, QuoteTable.EpsEstimateNextYear, obj.EpsEstimateNextYear);
            MapFields(dr, QuoteTable.ExDividendDate, obj.ExDividendDate);
            MapFields(dr, QuoteTable.FiftyDayMovingAverage, obj.FiftyDayMovingAverage);
            MapFields(dr, QuoteTable.LastTradeDate, obj.LastTradeDate);
            MapFields(dr, QuoteTable.LastTradePrice, obj.LastTradePrice);
            MapFields(dr, QuoteTable.LastUpdate, obj.LastUpdate);
            MapFields(dr, QuoteTable.MarketCapitalization, obj.MarketCapitalization);
            MapFields(dr, QuoteTable.Name, obj.Name);
            MapFields(dr, QuoteTable.OneYearPriceTarget, obj.OneYearPriceTarget);
            MapFields(dr, QuoteTable.Open, obj.Open);
            MapFields(dr, QuoteTable.PeRatio, obj.PeRatio);
            MapFields(dr, QuoteTable.PegRatio, obj.PegRatio);
            MapFields(dr, QuoteTable.PercentChangeFromFiftyDayMovingAverage, obj.PercentChangeFromFiftyDayMovingAverage);
            MapFields(dr, QuoteTable.PercentChangeFromTwoHundredDayMovingAverage, obj.PercentChangeFromTwoHundredDayMovingAverage);
            MapFields(dr, QuoteTable.PercentChangeFromYearHigh, obj.PercentChangeFromYearHigh);
            MapFields(dr, QuoteTable.PercentChangeFromYearLow, obj.PercentChangeFromYearLow);
            MapFields(dr, QuoteTable.PreviousClose, obj.PreviousClose);
            MapFields(dr, QuoteTable.PriceBook, obj.PriceBook);
            MapFields(dr, QuoteTable.PriceEpsEstimateCurrentYear, obj.PriceEpsEstimateCurrentYear);
            MapFields(dr, QuoteTable.PriceEpsEstimateNextYear, obj.PriceEpsEstimateNextYear);            
            MapFields(dr, QuoteTable.PriceSales, obj.PriceSales);
            MapFields(dr, QuoteTable.ShortRatio, obj.ShortRatio);
            MapFields(dr, QuoteTable.StockExchange, obj.StockExchange);
            MapFields(dr, QuoteTable.Symbol, obj.Symbol);
            MapFields(dr, QuoteTable.TwoHunderedDayMovingAverage, obj.TwoHunderedDayMovingAverage);
            MapFields(dr, QuoteTable.Volume, obj.Volume);
            MapFields(dr, QuoteTable.YearlyHigh, obj.YearlyHigh);
            MapFields(dr, QuoteTable.YearlyLow, obj.YearlyLow);

            dt.Rows.Add(dr);

            DataSet ds2 = ds.GetChanges();

            if (ds2 != null)
            {
                da.Update(ds2);
                ds.Merge(ds2);
            }
            ds.AcceptChanges();
        }

        private static void MapFields(DataRow dr, string index, object value)
        {
            if (value != null)
            {
                dr[index] = value;
            }
            else
            {
                dr[index] = DBNull.Value;
            }
        }

	    public static void CreateInsertObject(HistoricalQuote historicalQuote)
	    {
		    throw new NotImplementedException();
	    }
    }
}