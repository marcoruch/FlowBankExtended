using Newtonsoft.Json;

namespace FlowBank_Extended.API.Entities.Symbol
{
    public class Account
    {
        [JsonConstructor]
        public Account(
              [JsonProperty("status")] AccountStatus status,
              [JsonProperty("accountId")] string accountId
          )
        {
            this.Status = status;
            this.AccountId = accountId;
        }

        [JsonProperty("status")]
        public AccountStatus Status { get; }

        [JsonProperty("accountId")]
        public string AccountId { get; }
    }
}
