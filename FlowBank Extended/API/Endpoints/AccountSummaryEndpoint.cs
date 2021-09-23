using FlowBank_Extended.API.Entities.Symbol;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowBank_Extended.API.Endpoints
{
    public class AccountSummaryEndpoint : EndpointBase, IEndpoint
    {
        public string GetBaseUrl()
        {
            return $"{ApiDataEndpoint}{Version}/summary";
        }

        public async Task<ApiResult<Summary>> GetByAccountNr(string accountNr, string currency)
        {
            var url = $"{GetBaseUrl()}/{accountNr}/{currency}";

            return await new Api().FetchData<Summary>(url).ConfigureAwait(false);
        }

        public async Task<ApiResult<Summary[]>> GetFromToSummaries(string accountNr, string currency, DateTime? from, DateTime to, int skipDays)
        {
            var url = $"{GetBaseUrl()}/{accountNr}/{"{0}"}/{currency}";

            List<Summary> summaries = new List<Summary>();

            if (!from.HasValue)
            {
                DateTime currentDate = to.Date;

                while (true)
                {
                    var summary = new Api().FetchData<Summary>(string.Format(url, currentDate.ToString("yyyy-MM-dd"))).Result;

                    if (summary.ResultCode != ApiResultCode.Ok  || summary.Data.NetAssetValue == 0)
                    {
                        // Didn't find performance
                        break;
                    }

                    summaries.Add(summary.Data);
                    currentDate = currentDate.AddDays(- (skipDays +1));
                }
            }
            else
            {
                foreach (var dateTime in Helpers.EachDay(from.Value, to).Where((x, i) => skipDays == 0 || i % skipDays == 0))
                {
                    await AddSummaryByDateTime(url, summaries, dateTime).ConfigureAwait(false);
                }

                if (!summaries.Any(x => x.SessionDate == to))
                {
                    await AddSummaryByDateTime(url, summaries, to).ConfigureAwait(false);
                }
            }

            return new ApiResult<Summary[]>(summaries.ToArray(), summaries.Count > 0 ? ApiResultCode.Ok : ApiResultCode.Error);
        }

        private static async Task AddSummaryByDateTime(string url, List<Summary> summaries, DateTime item)
        {
            var summary = await new Api().FetchData<Summary>(string.Format(url, item.ToString("yyyy-MM-dd"))).ConfigureAwait(false);

            if (summary.ResultCode == ApiResultCode.Ok && summary.Data.NetAssetValue != 0)
            {
                summaries.Add(summary.Data);
            }
        }
    }
}
