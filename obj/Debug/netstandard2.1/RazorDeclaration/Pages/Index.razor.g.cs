// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SecretSantaBlazor.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 269 "D:\Projects\MyWorkspace\gitSecretSantaBlazor\SecretSantaBlazor\SecretSantaBlazor\Pages\Index.razor"
       
    private string Name = string.Empty;

    private List<string> Names = new List<string>();

    private void Enter(KeyboardEventArgs e)
    {
        if (string.IsNullOrEmpty(Name))
            return;

        if (e.Code == "Enter" || e.Key == "13")
        {
            Names.Add(Name);

            Name = string.Empty;

            SecretList();
        }
    }

    private void Remove(string name)
    {
        Names.Remove(name);

        SecretList();
    }


    private List<SantaChild> SecretSantas = new List<SantaChild>();

    private void SecretList()
    {
        // reset everytime
        SecretSantas = new List<SantaChild>();

        var rnd = new Random();

        // make temp collection
        List<string> participants = new List<string>();
        participants.AddRange(Names);

        // randomize
        var result = participants.OrderBy(item => rnd.Next());

        var arr = result.ToArray();

        // Players - Player and Secret Santa

        for (int i = 0; i < arr.Length; i++)
        {
            if (i == arr.Length - 1)
                SecretSantas.Add(new SantaChild() { Santa = arr[arr.Length - 1], Child = arr[0] });
            else
                SecretSantas.Add(new SantaChild() { Santa = arr[i], Child = arr[i + 1] });
        }
    }

    private class SantaChild
    {
        public string Santa { get; set; }
        public string Child { get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
