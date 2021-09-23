using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowBank_Extended.API.Endpoints
{
    public class EndpointBase
    {
        public string Version { get; set; }

        public readonly string ApiDataEndpoint = "https://api-live.flowbank.com/md/";
        public readonly string ApiTradingEndpoint = "https://api-live.flowbank.com/trade/";

        public EndpointBase()
        {
            Version = "3.0";
        }

        public EndpointBase(string version)
        {
            Version = version;
        }
    }
}
