using System;
using System.Text;
using System.Security.Cryptography;
using System.Net.Http.Headers;

namespace ExchangeSharp.API.Exchanges.VALR
{
    public class ValrProxy : IValrProxy
    {
        const string BaseUrl = "https://api.valr.com/v1/public/";
        readonly string _accountSid;
        readonly string _secretKey;
        public ValrProxy(string accountSid, string secretKey)
        {
            _accountSid = accountSid;
            _secretKey = secretKey;
        }
        public static string signRequest(string apiKeySecret, string timestamp, string verb, string path, string body = "")
        {
            var payload = timestamp + verb.ToUpper() + path + body;
            byte[] payloadBytes = Encoding.UTF8.GetBytes(payload);
            using (HMACSHA512 hmac = new HMACSHA512(Encoding.UTF8.GetBytes(apiKeySecret)))
            {
                byte[] hash = hmac.ComputeHash(payloadBytes);
                return toHexString(hash);
            }
        }
        private static string toHexString(byte[] hash)
        {
            StringBuilder result = new StringBuilder(hash.Length * 2);
            foreach (var b in hash)
            {
                result.Append(b.ToString("x2"));
            }
            return result.ToString();
        }
        /* Timestamp in milliseconds. 
         * The same timestamp should be used to generate request signature
         * as well as sent along in the X-VALR-TIMESTAMP header of the request
         */
        private static string getTimestamp()
        {
            return DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString();
        }

        public async Task<string> GetVal(string pair)
        {
            //BTCZAR
            string jsonResponse = string.Empty;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.valr.com");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //GET Method
                var response = await client.GetAsync("/v1/public/" + pair + "/orderbook");

                if (response.IsSuccessStatusCode)
                {
                    jsonResponse = await response.Content.ReadAsStringAsync();
                }
                else
                {
                    Console.WriteLine("Internal server Error");
                }
            }
            return jsonResponse;
        }

        public string GetOrderBook(ApiType apiType, string currentcypair)
        {
            // RestClientOptions options = new RestClientOptions { Timeout = 300000 };


            //var test = new RestClient(options);
            //var client = new RestClient(options, String.Format("{0}{1}{2}", BaseUrl, currentcypair, "orderbook"));
            //var request = new RestRequest(Method.Get);
            //IRestResponse response = client.Execute(request);
            //response.Content;
            return string.Empty;
        }

        public string GetOrderBookNonAggregated(ApiType apiType)
        {
            throw new NotImplementedException();
        }

        public string GetCurrencies(ApiType apiType)
        {
            throw new NotImplementedException();
        }

        public string GetCurrencyPairs(ApiType apiType)
        {
            throw new NotImplementedException();
        }

        public string GetOrderTypes(ApiType apiType)
        {
            throw new NotImplementedException();
        }

        public string GetOrderTypesByCurrencyPair(ApiType apiType)
        {
            throw new NotImplementedException();
        }

        public string GetMarketSummary(ApiType apiType)
        {
            throw new NotImplementedException();
        }

        public string GetMarketSummaryCurrencyPair(ApiType apiType)
        {
            throw new NotImplementedException();
        }

        public string GetTradeHistoryFilters(ApiType apiType)
        {
            throw new NotImplementedException();
        }

        public string GetTradeHistoryPaginatedById(ApiType apiType)
        {
            throw new NotImplementedException();
        }

        public string GETServerTime(ApiType apiType)
        {
            throw new NotImplementedException();
        }

        public string GETVALRStatus(ApiType apiType)
        {
            throw new NotImplementedException();
        }
    }
}