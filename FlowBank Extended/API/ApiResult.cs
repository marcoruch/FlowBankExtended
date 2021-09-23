using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowBank_Extended.API
{
    public class ApiResult<TData>
    {
        public TData Data { get; set; }
        public ApiResultCode ResultCode { get; set; }
        public string Message { get; set; }

        public ApiResult(TData data, ApiResultCode resultCode = ApiResultCode.Ok, string message = "")
        {
            Data = data;
            ResultCode = resultCode;
            Message = message;
        }
    }
}
