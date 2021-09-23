
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace FlowBank_Extended.API
{
    public class Api
    {
        private readonly HttpClient _httpClient = new HttpClient();

        private static readonly string WebToken = System.Configuration.ConfigurationManager.AppSettings.Get("Bearer");

        public Api()
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", WebToken);
        }

        public async Task<ApiResult<TData>> FetchData<TData>(string url)
        {
            var task = await _httpClient.GetAsync(url).ConfigureAwait(false);

            try
            {
                task.EnsureSuccessStatusCode();

                var payload = task.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<TData>(await payload.ConfigureAwait(false),
                                                                       new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });

                return new ApiResult<TData>(data);
            }
            catch (Exception e1)
            {
                return new ApiResult<TData>(default, ApiResultCode.Error, e1.Message);
            }
        }
    }
}
