using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorComponentTest
{
    public partial class Component1
    {
        [Parameter]
        public string ariaLabel { get; set; }
        [Parameter]
        public string[] value { get; set; }
        public int ID = 0;

    }
}