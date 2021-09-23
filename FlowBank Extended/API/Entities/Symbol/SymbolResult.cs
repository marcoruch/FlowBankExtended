using Newtonsoft.Json;

namespace FlowBank_Extended.API.Entities.Symbol
{
    public class SymbolResult
    {
        [JsonProperty("optionData")]
        public object OptionData { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("symbolId")]
        public string SymbolId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("underlyingSymbolId")]
        public object UnderlyingSymbolId { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("identifiers")]
        public Identifiers Identifiers { get; set; }

        [JsonProperty("exchange")]
        public string Exchange { get; set; }

        [JsonProperty("symbolType")]
        public string SymbolType { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("minPriceIncrement")]
        public string MinPriceIncrement { get; set; }

        [JsonProperty("ticker")]
        public string Ticker { get; set; }

        [JsonProperty("expiration")]
        public object Expiration { get; set; }

        [JsonProperty("group")]
        public object Group { get; set; }
    }


    public class Identifiers
    {
        [JsonProperty("ISIN")]
        public string ISIN { get; set; }

        [JsonProperty("FIGI")]
        public string FIGI { get; set; }

        [JsonProperty("RIC")]
        public string RIC { get; set; }

        [JsonProperty("SEDOL")]
        public string SEDOL { get; set; }
    }
}
