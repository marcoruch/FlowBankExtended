using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowBank_Extended.API.Entities.Symbol
{
    public class Summary
    {
        [JsonProperty("currencies")]
        public List<Currency> Currencies { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("freeMoney")]
        public string FreeMoney { get; set; }

        [JsonProperty("netAssetValue")]
        public double NetAssetValue { get; set; }

        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("moneyUsedForMargin")]
        public string MoneyUsedForMargin { get; set; }

        [JsonProperty("marginUtilization")]
        public string MarginUtilization { get; set; }

        [JsonProperty("positions")]
        public List<Position> Positions { get; set; }

        [JsonProperty("sessionDate")]
        public object SessionDateAsString { get; set; }
        [JsonIgnore]
        public DateTime SessionDate { get
            {
                return DateTime.ParseExact((string)SessionDateAsString, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None);
            } 
        }
        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class Currency
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("convertedValue")]
        public string ConvertedValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class Position
    {
        [JsonProperty("convertedPnl")]
        public string ConvertedPnl { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("pnl")]
        public string Pnl { get; set; }

        [JsonProperty("symbolId")]
        public string SymbolId { get; set; }

        [JsonProperty("convertedValue")]
        public string ConvertedValue { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("symbolType")]
        public SymbolType SymbolType { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("averagePrice")]
        public string AveragePrice { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

}
