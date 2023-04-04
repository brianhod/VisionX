using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeSharp.API.Exchanges.VALR
{
    public enum ApiType
    {
        Public = 1,
        Private = 2
    }
    internal interface IValrProxy
    {
        public string GetOrderBook(ApiType apiType, string currentcypair);
        public string GetOrderBookNonAggregated(ApiType apiType);
        public string GetCurrencies(ApiType apiType);
        public string GetCurrencyPairs(ApiType apiType);
        public string GetOrderTypes(ApiType apiType);
        public string GetOrderTypesByCurrencyPair(ApiType apiType);
        public string GetMarketSummary(ApiType apiType);
        public string GetMarketSummaryCurrencyPair(ApiType apiType);
        public string GetTradeHistoryFilters(ApiType apiType);
        public string GetTradeHistoryPaginatedById(ApiType apiType);
        public string GETServerTime(ApiType apiType);
        public string GETVALRStatus(ApiType apiType);
    }
}
