using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowBank_Extended.API.Entities.Symbol
{
    public enum SymbolType
    {
        FX_SPOT, 
        CURRENCY, 
        INDEX, 
        STOCK, 
        BOND, 
        FUND, 
        FUTURE, 
        OPTION, 
        CFD, 
        CALENDAR_SPREAD
    }
}
