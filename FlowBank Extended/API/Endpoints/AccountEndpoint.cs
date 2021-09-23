using FlowBank_Extended.API.Entities.Symbol;

using System.Threading.Tasks;

namespace FlowBank_Extended.API.Endpoints
{
    public class AccountEndpoint : EndpointBase, IEndpoint
    {
        public string GetBaseUrl()
        {
            return $"{ApiDataEndpoint}{Version}/accounts";
        }

        public async Task<ApiResult<Account[]>> Get()
        {
            return await new Api().FetchData<Account[]>(GetBaseUrl()).ConfigureAwait(false);
        }
    }
}
