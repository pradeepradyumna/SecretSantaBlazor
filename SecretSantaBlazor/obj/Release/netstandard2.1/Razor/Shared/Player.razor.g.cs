#pragma checksum "D:\Projects\MyWorkspace\gitSecretSantaBlazor\SecretSantaBlazor\SecretSantaBlazor\Shared\Player.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7e9b78911c2acfef786032f63953ba9212e6c73"
// <auto-generated/>
#pragma warning disable 1591
namespace SecretSantaBlazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\MyWorkspace\gitSecretSantaBlazor\SecretSantaBlazor\SecretSantaBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\MyWorkspace\gitSecretSantaBlazor\SecretSantaBlazor\SecretSantaBlazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\MyWorkspace\gitSecretSantaBlazor\SecretSantaBlazor\SecretSantaBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\MyWorkspace\gitSecretSantaBlazor\SecretSantaBlazor\SecretSantaBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\MyWorkspace\gitSecretSantaBlazor\SecretSantaBlazor\SecretSantaBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\MyWorkspace\gitSecretSantaBlazor\SecretSantaBlazor\SecretSantaBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\MyWorkspace\gitSecretSantaBlazor\SecretSantaBlazor\SecretSantaBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\MyWorkspace\gitSecretSantaBlazor\SecretSantaBlazor\SecretSantaBlazor\_Imports.razor"
using SecretSantaBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\MyWorkspace\gitSecretSantaBlazor\SecretSantaBlazor\SecretSantaBlazor\_Imports.razor"
using SecretSantaBlazor.Shared;

#line default
#line hidden
#nullable disable
    public partial class Player : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Player</h3>\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "id", "tblCustomers");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddAttribute(4, "cellpadding", "0");
            __builder.AddAttribute(5, "cellspacing", "0");
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.AddMarkupContent(7, "<thead>\r\n        <tr>\r\n            <th style=\"width:150px\">Name</th>\r\n            <th style=\"width:150px\">Country</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "tr");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "td");
#nullable restore
#line 15 "D:\Projects\MyWorkspace\gitSecretSantaBlazor\SecretSantaBlazor\SecretSantaBlazor\Shared\Player.razor"
__builder.AddContent(13, Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "td");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "type", "button");
            __builder.AddAttribute(18, "value", "Remove");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "D:\Projects\MyWorkspace\gitSecretSantaBlazor\SecretSantaBlazor\SecretSantaBlazor\Shared\Player.razor"
                                                              Remove

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.AddMarkupContent(23, "<tfoot>\r\n        <tr>\r\n            <td><input type=\"text\" id=\"txtName\"></td>\r\n            <td><input type=\"button\" id=\"btnAdd\" value=\"Add\"></td>\r\n        </tr>\r\n    </tfoot>\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "D:\Projects\MyWorkspace\gitSecretSantaBlazor\SecretSantaBlazor\SecretSantaBlazor\Shared\Player.razor"
       
    private List<string> Names = new List<string>();

    // Demonstrates how a parent component can supply parameters
    [Parameter]
    public string Name { get; set; }
    private void Remove()
    {
        
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
