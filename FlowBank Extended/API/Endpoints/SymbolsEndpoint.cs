using FlowBank_Extended.API.Entities.Symbol;

using System.Threading.Tasks;

namespace FlowBank_Extended.API.Endpoints
{
    public class SymbolsEndpoint : EndpointBase, IEndpoint
    {
        public string GetBaseUrl()
        {
            return $"{ApiDataEndpoint}{Version}/symbols";
        }

        public async Task<ApiResult<SymbolResult[]>> Get()
        {
            return await new Api().FetchData<SymbolResult[]>(GetBaseUrl()).ConfigureAwait(false);
        }

        public async Task<ApiResult<SymbolResult>> GetById(string symbol)
        {
            var url = $"{GetBaseUrl()}/{symbol}";

            return await new Api().FetchData<SymbolResult>(url).ConfigureAwait(false);
        }
    }
}
