using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Server.Client.Utils
{
    public class FileUtil
    {
        private readonly IJSRuntime _jsRunTime;
        public FileUtil(IJSRuntime jsRuntime)
        {
            _jsRunTime = jsRuntime;
        }
        public Task SaveAs(string filename, byte[] data)
            => _jsRunTime.InvokeAsync<object>(
                "saveAsFile",
                filename,
                Convert.ToBase64String(data));
    }
}
