namespace ReactTestApp.Server.Models
{
    public class TradingData
    {
        public int OrderId { get; set; }
        public required string StockSymbol { get; set; }
        public DateTime TradeDate { get; set; }
        public decimal OpenPrice { get; set; }
        public decimal HighPrice { get; set; }
        public decimal LowPrice { get; set; }
        public decimal ClosePrice { get; set; }
        public int Volume { get; set; }
        public decimal AdjustedClose { get; set; }
        public long MarketCap { get; set; }
        public decimal PeRatio { get; set; }
        public decimal DividendYield { get; set; }
        public decimal Eps { get; set; }
        public decimal Beta { get; set; }
        public long SharesOutstanding { get; set; }
        public decimal FiftyTwoWeekHigh { get; set; }
        public decimal FiftyTwoWeekLow { get; set; }
        public int AvgDailyVolume { get; set; }
        public string Sector { get; set; }
        public string Industry { get; set; }
        public string Exchange { get; set; }
        public string Country { get; set; }
        public string Currency { get; set; }
        public TimeSpan MarketTime { get; set; }
        public decimal PreviousClose { get; set; }
        public decimal ChangePercent { get; set; }
        public string DayRange { get; set; }
        public string YearRange { get; set; }
        public int AvgVolume3Month { get; set; }
        public int AvgVolume10Day { get; set; }
        public long FloatShares { get; set; }
        public decimal ShortRatio { get; set; }
        public decimal ShortPercent { get; set; }
        public decimal ForwardPe { get; set; }
        public decimal ForwardEps { get; set; }
        public decimal PegRatio { get; set; }
        public decimal PriceSales { get; set; }
        public decimal PriceBook { get; set; }
        public long EnterpriseValue { get; set; }
        public decimal Ebitda { get; set; }
        public decimal Revenue { get; set; }
        public decimal GrossProfit { get; set; }
        public decimal NetIncome { get; set; }
        public decimal Cash { get; set; }
        public decimal Debt { get; set; }
        public decimal QuickRatio { get; set; }
        public decimal CurrentRatio { get; set; }
        public decimal OperatingMargin { get; set; }
    }


}
