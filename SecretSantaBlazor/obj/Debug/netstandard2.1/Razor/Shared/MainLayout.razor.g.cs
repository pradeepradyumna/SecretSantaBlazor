#pragma checksum "D:\Projects\MyWorkspace\SecretSantaBlazor\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99655411d4addf60b3062df6b59ff86b7a6d210f"
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
#line 1 "D:\Projects\MyWorkspace\SecretSantaBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\MyWorkspace\SecretSantaBlazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\MyWorkspace\SecretSantaBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\MyWorkspace\SecretSantaBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\MyWorkspace\SecretSantaBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\MyWorkspace\SecretSantaBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\MyWorkspace\SecretSantaBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\MyWorkspace\SecretSantaBlazor\_Imports.razor"
using SecretSantaBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\MyWorkspace\SecretSantaBlazor\_Imports.razor"
using SecretSantaBlazor.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "snow");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<div class=\"mytitle\">\r\n        <header>\r\n            <h1>Secret <span style=\"color: red\">Santa</span>  Game is HERE</h1>\r\n        </header>\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddMarkupContent(5, "\r\n        ");
#nullable restore
#line 11 "D:\Projects\MyWorkspace\SecretSantaBlazor\Shared\MainLayout.razor"
__builder.AddContent(6, Body);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenComponent<SecretSantaBlazor.Shared.MyFooter>(9);
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.AddMarkupContent(12, "<style>\r\n\r\n\r\n\r\n    @import url(\"https://fonts.googleapis.com/css?family=Reenie+Beanie\");\r\n\r\n    .mytitle {\r\n        position: relative;\r\n        display: flex;\r\n        flex-flow: column wrap;\r\n        align-items: center;\r\n    }\r\n\r\n        .mytitle header {\r\n            font-size: 6rem;\r\n            /*background-color: lightblue;*/\r\n            padding-top: 30px;\r\n        }\r\n\r\n        .mytitle h1 {\r\n            /* color: #083c5fd3; */\r\n            /*color: rgb(14, 176, 230);*/\r\n            color: white;\r\n            font-size: 6rem;\r\n            font-weight: bold;\r\n        }\r\n\r\n       /* .mytitle santa {\r\n            color: red;\r\n        }*/\r\n\r\n\r\n\r\n    * {\r\n        margin: 0;\r\n        padding: 0;\r\n        box-sizing: border-box;\r\n        font-family: \"Reenie Beanie\", cursive;\r\n    }\r\n\r\n    .main {\r\n        /* background-image: linear-gradient(120deg, #4286b4d3 0%, #0e8a9bd3 100%); */\r\n        background-color: lightblue;\r\n        color: white;\r\n        /* font-family: \"Montserrat\", sans-serif; */\r\n        font-family: \"Reenie Beanie\", cursive;\r\n        min-height: 100vh;\r\n    }\r\n\r\n    /***************************\r\n\r\n                            Snow.\r\n\r\n                            ***************************/\r\n    .snow,\r\n    .snow:before,\r\n    .snow:after {\r\n        /*background: #f31414c5;*/\r\n        background: lightblue;\r\n        background-size: 100%;\r\n        height: 100vh;\r\n        background-repeat: no-repeat;\r\n        overflow: hidden;\r\n        width: 100%;\r\n        position: absolute;\r\n        top: 0;\r\n        left: 0;\r\n        bottom: 0;\r\n        right: 0;\r\n        background-image: radial-gradient( 5px 5px at 34px 172px, rgba(255, 255, 255, 0.9) 50%, rgba(0, 0, 0, 0) ), radial-gradient(4px 4px at 86px 25px, #ffffff 50%, rgba(0, 0, 0, 0)), radial-gradient(5px 5px at 388px 47px, #ffffff 50%, rgba(0, 0, 0, 0)), radial-gradient(3px 3px at 53px 303px, #ffffff 50%, rgba(0, 0, 0, 0)), radial-gradient( 4px 4px at 373px 475px, rgba(255, 255, 255, 0.8) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 4px 4px at 196px 261px, rgba(255, 255, 255, 0.7) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 5px 5px at 434px 424px, rgba(255, 255, 255, 0.7) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 4px 4px at 234px 213px, rgba(255, 255, 255, 0.9) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 4px 4px at 393px 356px, rgba(255, 255, 255, 0.8) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 3px 3px at 537px 497px, rgba(255, 255, 255, 0.8) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 3px 3px at 151px 362px, rgba(255, 255, 255, 0.7) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 6px 6px at 110px 99px, rgba(255, 255, 255, 0.7) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 3px 3px at 270px 111px, rgba(255, 255, 255, 0.7) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 3px 3px at 351px 424px, rgba(255, 255, 255, 0.9) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 5px 5px at 459px 279px, rgba(255, 255, 255, 0.8) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 4px 4px at 584px 126px, rgba(255, 255, 255, 0.9) 50%, rgba(0, 0, 0, 0) ), radial-gradient(6px 6px at 303px 486px, #ffffff 50%, rgba(0, 0, 0, 0)), radial-gradient( 3px 3px at 132px 292px, rgba(255, 255, 255, 0.9) 50%, rgba(0, 0, 0, 0) ), radial-gradient(3px 3px at 120px 162px, #ffffff 50%, rgba(0, 0, 0, 0)), radial-gradient(5px 5px at 396px 460px, #ffffff 50%, rgba(0, 0, 0, 0)), radial-gradient( 5px 5px at 169px 508px, rgba(255, 255, 255, 0.8) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 3px 3px at 177px 298px, rgba(255, 255, 255, 0.7) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 4px 4px at 575px 410px, rgba(255, 255, 255, 0.8) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 6px 6px at 29px 140px, rgba(255, 255, 255, 0.6) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 3px 3px at 82px 378px, rgba(255, 255, 255, 0.7) 50%, rgba(0, 0, 0, 0) ), radial-gradient(4px 4px at 482px 473px, #ffffff 50%, rgba(0, 0, 0, 0)), radial-gradient( 6px 6px at 56px 24px, rgba(255, 255, 255, 0.7) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 3px 3px at 157px 73px, rgba(255, 255, 255, 0.6) 50%, rgba(0, 0, 0, 0) ), radial-gradient(6px 6px at 97px 496px, #ffffff 50%, rgba(0, 0, 0, 0)), radial-gradient( 6px 6px at 240px 225px, rgba(255, 255, 255, 0.9) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 5px 5px at 12px 102px, rgba(255, 255, 255, 0.8) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 5px 5px at 518px 417px, rgba(255, 255, 255, 0.6) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 4px 4px at 323px 155px, rgba(255, 255, 255, 0.8) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 6px 6px at 534px 119px, rgba(255, 255, 255, 0.8) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 3px 3px at 294px 245px, rgba(255, 255, 255, 0.8) 50%, rgba(0, 0, 0, 0) ), radial-gradient(3px 3px at 270px 432px, #ffffff 50%, rgba(0, 0, 0, 0)), radial-gradient( 3px 3px at 406px 292px, rgba(255, 255, 255, 0.7) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 5px 5px at 42px 233px, rgba(255, 255, 255, 0.7) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 4px 4px at 109px 160px, rgba(255, 255, 255, 0.7) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 4px 4px at 158px 359px, rgba(255, 255, 255, 0.7) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 5px 5px at 212px 133px, rgba(255, 255, 255, 0.6) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 4px 4px at 303px 536px, rgba(255, 255, 255, 0.6) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 3px 3px at 513px 314px, rgba(255, 255, 255, 0.7) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 6px 6px at 54px 346px, rgba(255, 255, 255, 0.9) 50%, rgba(0, 0, 0, 0) ), radial-gradient(6px 6px at 127px 115px, #ffffff 50%, rgba(0, 0, 0, 0)), radial-gradient( 3px 3px at 559px 29px, rgba(255, 255, 255, 0.9) 50%, rgba(0, 0, 0, 0) ), radial-gradient(4px 4px at 493px 581px, #ffffff 50%, rgba(0, 0, 0, 0)), radial-gradient( 5px 5px at 339px 414px, rgba(255, 255, 255, 0.8) 50%, rgba(0, 0, 0, 0) ), radial-gradient(3px 3px at 349px 481px, #ffffff 50%, rgba(0, 0, 0, 0)), radial-gradient( 3px 3px at 331px 86px, rgba(255, 255, 255, 0.9) 50%, rgba(0, 0, 0, 0) ), radial-gradient(5px 5px at 497px 385px, #ffffff 50%, rgba(0, 0, 0, 0)), radial-gradient( 3px 3px at 65px 332px, rgba(255, 255, 255, 0.8) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 6px 6px at 432px 593px, rgba(255, 255, 255, 0.8) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 3px 3px at 377px 240px, rgba(255, 255, 255, 0.9) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 4px 4px at 293px 224px, rgba(255, 255, 255, 0.8) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 6px 6px at 455px 336px, rgba(255, 255, 255, 0.7) 50%, rgba(0, 0, 0, 0) ), radial-gradient(3px 3px at 93px 50px, #ffffff 50%, rgba(0, 0, 0, 0)), radial-gradient( 6px 6px at 129px 453px, rgba(255, 255, 255, 0.6) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 4px 4px at 393px 78px, rgba(255, 255, 255, 0.7) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 6px 6px at 364px 75px, rgba(255, 255, 255, 0.8) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 5px 5px at 66px 19px, rgba(255, 255, 255, 0.8) 50%, rgba(0, 0, 0, 0) ), radial-gradient(6px 6px at 254px 199px, #ffffff 50%, rgba(0, 0, 0, 0)), radial-gradient( 5px 5px at 178px 454px, rgba(255, 255, 255, 0.6) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 6px 6px at 499px 280px, rgba(255, 255, 255, 0.6) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 6px 6px at 419px 40px, rgba(255, 255, 255, 0.6) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 3px 3px at 179px 593px, rgba(255, 255, 255, 0.6) 50%, rgba(0, 0, 0, 0) ), radial-gradient( 3px 3px at 66px 529px, rgba(255, 255, 255, 0.8) 50%, rgba(0, 0, 0, 0) ), radial-gradient(6px 6px at 498px 329px, #ffffff 50%, rgba(0, 0, 0, 0)), radial-gradient( 5px 5px at 381px 464px, rgba(255, 255, 255, 0.7) 50%, rgba(0, 0, 0, 0) ), radial-gradient(4px 4px at 172px 17px, #ffffff 50%, rgba(0, 0, 0, 0));\r\n        /*background-size: 600px 600px;*/\r\n        animation: snow 5s linear infinite;\r\n    }\r\n\r\n    #snow {\r\n        background: none;\r\n        z-index: -1;\r\n        background-image: url(\"https://s3-us-west-2.amazonaws.com/s.cdpn.io/191814/flake1.png\"), url(\"https://s3-us-west-2.amazonaws.com/s.cdpn.io/191814/flake2.png\"), url(\"https://s3-us-west-2.amazonaws.com/s.cdpn.io/191814/flake3.png\");\r\n        height: 100%;\r\n        left: 0;\r\n        position: absolute;\r\n        top: 0;\r\n        width: 100%;\r\n        -webkit-animation: snow 10s linear infinite;\r\n        -moz-animation: snow 10s linear infinite;\r\n        -ms-animation: snow 10s linear infinite;\r\n        animation: snow 10s linear infinite;\r\n    }\r\n\r\n    @keyframes snow {\r\n        0% {\r\n            background-position: 0px 0px, 0px 0px, 0px 0px;\r\n        }\r\n\r\n        50% {\r\n            background-position: 500px 500px, 100px 200px, -100px 150px;\r\n        }\r\n\r\n        100% {\r\n            background-position: 500px 1000px, 200px 400px, -100px 300px;\r\n        }\r\n    }\r\n\r\n    @-moz-keyframes snow {\r\n        0% {\r\n            background-position: 0px 0px, 0px 0px, 0px 0px;\r\n        }\r\n\r\n        50% {\r\n            background-position: 500px 500px, 100px 200px, -100px 150px;\r\n        }\r\n\r\n        100% {\r\n            background-position: 400px 1000px, 200px 400px, 100px 300px;\r\n        }\r\n    }\r\n\r\n    @-webkit-keyframes snow {\r\n        0% {\r\n            background-position: 0px 0px, 0px 0px, 0px 0px;\r\n        }\r\n\r\n        50% {\r\n            background-position: 500px 500px, 100px 200px, -100px 150px;\r\n        }\r\n\r\n        100% {\r\n            background-position: 500px 1000px, 200px 400px, -100px 300px;\r\n        }\r\n    }\r\n\r\n    @-ms-keyframes snow {\r\n        0% {\r\n            background-position: 0px 0px, 0px 0px, 0px 0px;\r\n        }\r\n\r\n        50% {\r\n            background-position: 500px 500px, 100px 200px, -100px 150px;\r\n        }\r\n\r\n        100% {\r\n            background-position: 500px 1000px, 200px 400px, -100px 300px;\r\n        }\r\n    }\r\n\r\n</style>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
