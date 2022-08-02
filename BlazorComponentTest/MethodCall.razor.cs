using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

namespace BlazorComponentTest
{
    public partial class MethodCall
    {

        [Parameter]
        public string ButtonName { get; set; }

        public async Task onbuttonclick()
        {
            var module = await Module;

            await module.InvokeVoidAsync("test");
        }
        
        private Task<IJSObjectReference> _module;
        private Task<IJSObjectReference> Module => _module ??= GetIJSObjectReference(jsRuntime, "js/Script.js");

        internal static Task<IJSObjectReference> GetIJSObjectReference(IJSRuntime jsRuntime, string path)
        {
            string importPath = $"./_content/{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}/{path}?v={Guid.NewGuid()}";

            return jsRuntime.InvokeAsync<IJSObjectReference>("import", importPath).AsTask();
        }
    }
}