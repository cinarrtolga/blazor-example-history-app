#pragma checksum "/home/tolgacinar/Projects/GitHub/blazor-example-history-app/Pages/Components/HistoryItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fda8da5e889a83ee459e881fc06a81d9269288b8"
// <auto-generated/>
#pragma warning disable 1591
namespace blazor_example_history_app.Pages.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/tolgacinar/Projects/GitHub/blazor-example-history-app/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/tolgacinar/Projects/GitHub/blazor-example-history-app/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/tolgacinar/Projects/GitHub/blazor-example-history-app/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/tolgacinar/Projects/GitHub/blazor-example-history-app/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/tolgacinar/Projects/GitHub/blazor-example-history-app/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/tolgacinar/Projects/GitHub/blazor-example-history-app/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/tolgacinar/Projects/GitHub/blazor-example-history-app/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/tolgacinar/Projects/GitHub/blazor-example-history-app/_Imports.razor"
using blazor_example_history_app;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/tolgacinar/Projects/GitHub/blazor-example-history-app/_Imports.razor"
using blazor_example_history_app.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/tolgacinar/Projects/GitHub/blazor-example-history-app/_Imports.razor"
using blazor_example_history_app.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/tolgacinar/Projects/GitHub/blazor-example-history-app/_Imports.razor"
using blazor_example_history_app.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/tolgacinar/Projects/GitHub/blazor-example-history-app/_Imports.razor"
using blazor_example_history_app.Core;

#line default
#line hidden
#nullable disable
    public partial class HistoryItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.AddMarkupContent(3, "<div class=\"page-header\">\n        <h1 id=\"timeline\">A brief history of the Underground </h1>\n    </div>\n    ");
            __builder.OpenElement(4, "ul");
            __builder.AddAttribute(5, "class", "timeline");
            __builder.AddMarkupContent(6, "\n\n");
#nullable restore
#line 9 "/home/tolgacinar/Projects/GitHub/blazor-example-history-app/Pages/Components/HistoryItem.razor"
 if (ComponentList != null)
{

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/tolgacinar/Projects/GitHub/blazor-example-history-app/Pages/Components/HistoryItem.razor"
 foreach (var item in ComponentList.OrderByDescending(x => x.Key))
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "    ");
            __builder.OpenElement(8, "li");
            __builder.AddAttribute(9, "class", 
#nullable restore
#line 13 "/home/tolgacinar/Projects/GitHub/blazor-example-history-app/Pages/Components/HistoryItem.razor"
                 IsLeftSide ? "timeline" : "timeline-inverted"

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(10, "\n          ");
            __builder.AddMarkupContent(11, "<div class=\"timeline-badge warning\"><i class=\"glyphicon glyphicon-credit-card\"></i></div>\n          ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "timeline-panel");
            __builder.AddMarkupContent(14, "\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "timeline-heading");
            __builder.AddMarkupContent(17, "\n              ");
            __builder.OpenElement(18, "h4");
            __builder.AddAttribute(19, "class", "timeline-title");
            __builder.AddContent(20, 
#nullable restore
#line 17 "/home/tolgacinar/Projects/GitHub/blazor-example-history-app/Pages/Components/HistoryItem.razor"
                                          item.Key

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n            ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "timeline-body");
            __builder.AddMarkupContent(25, "\n              ");
            __builder.AddContent(26, 
#nullable restore
#line 20 "/home/tolgacinar/Projects/GitHub/blazor-example-history-app/Pages/Components/HistoryItem.razor"
               item.Value

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(27, "\n              ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n          ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n");
#nullable restore
#line 24 "/home/tolgacinar/Projects/GitHub/blazor-example-history-app/Pages/Components/HistoryItem.razor"
        IsLeftSide = !IsLeftSide;
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "/home/tolgacinar/Projects/GitHub/blazor-example-history-app/Pages/Components/HistoryItem.razor"
 
}

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "/home/tolgacinar/Projects/GitHub/blazor-example-history-app/Pages/Components/HistoryItem.razor"
       
  private Dictionary<string, string> ComponentList;
      private bool IsLeftSide = true;

      protected override async Task OnInitializedAsync()
      {
          Crawler example = new Crawler();
          ComponentList = example
          .GetComponent("https://tfl.gov.uk/corporate/about-tfl/culture-and-heritage/londons-transport-a-history/london-underground/a-brief-history-of-the-underground", "content-container", "p");
      }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
