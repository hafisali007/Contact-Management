#pragma checksum "E:\Personal\Contact-Management\ContactManagement\Views\Demo\ShowGrid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2eb55e388340046b3b645c14045bab038c579bbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Demo_ShowGrid), @"mvc.1.0.view", @"/Views/Demo/ShowGrid.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2eb55e388340046b3b645c14045bab038c579bbd", @"/Views/Demo/ShowGrid.cshtml")]
    public class Views_Demo_ShowGrid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Personal\Contact-Management\ContactManagement\Views\Demo\ShowGrid.cshtml"
  
    ViewData["Title"] = "ShowGrid";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<script src=\"//ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2eb55e388340046b3b645c14045bab038c579bbd3622", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<link href=""https://cdn.datatables.net/1.10.15/css/dataTables.bootstrap.min.css"" rel=""stylesheet"" />
<link href=""https://cdn.datatables.net/responsive/2.1.1/css/responsive.bootstrap.min.css"" rel=""stylesheet"" />

<script src=""https://cdn.datatables.net/1.10.15/js/jquery.dataTables.min.js""></script>
<script src=""https://cdn.datatables.net/1.10.15/js/dataTables.bootstrap4.min.js ""></script>


<div class=""container"">
    <br />
    <div style=""width:90%; margin:0 auto;"">
        <table id=""example"" class=""table table-striped table-bordered dt-responsive nowrap"" width=""100%"" cellspacing=""0"">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>FirstName</th>
                    <th>LastName</th>
                    <th>Email</th>
                    <th>Phoneno</th>
                    <th>Edit</th>
                    <th>Delete</th>
                </tr>
            </thead>
        </table>
    </div>
</div>

<script>


    $(document)");
            WriteLiteral(@".ready(function() {
        $(""#example"").DataTable({
            ""processing"": true, // for show progress bar
            ""serverSide"": true, // for process server side
            ""filter"": true, // this is for disable filter (search box)
            ""orderMulti"": false, // for disable multiple column at once
            ""ajax"": {
                ""url"": ""~/DemoGrid/LoadData"",
                ""type"": ""POST"",
                ""datatype"": ""json""
            },
            ""columnDefs"": [{
                ""targets"": [0],
                ""visible"": false,
                ""searchable"": false
            }],
            ""columns"": [
                { ""data"": ""Id"", ""name"": ""Id"", ""autoWidth"": true },
                { ""data"": ""FirstName"", ""name"": ""FirstName"", ""autoWidth"": true },
                { ""data"": ""LastName"", ""name"": ""LastName"", ""autoWidth"": true },
                { ""data"": ""Email"", ""name"": ""Email"", ""autoWidth"": true },
                { ""data"": ""Phoneno"", ""name"": ""Phoneno"", ""autoWidth"":");
            WriteLiteral(@" true },
                {
                    ""render"": function(data, type, full, meta) { return '<a class=""btn btn-info"" href=""/DemoGrid/Edit/' + full.ID + '"">Edit</a>'; }
                },
                {
                    data: null,
                    render: function(data, type, row) {
                        return ""<a href='#' class='btn btn-danger' onclick=DeleteData('"" + row.ID + ""'); >Delete</a>"";
                    }
                },
            ]

        });
    });


function DeleteData(CustomerID) {
    if (confirm(""Are you sure you want to delete ...?"")) {
        Delete(CustomerID);
    } else {
        return false;
    }
}


function Delete(CustomerID) {
    var url = '");
#nullable restore
#line 87 "E:\Personal\Contact-Management\ContactManagement\Views\Demo\ShowGrid.cshtml"
          Write(Url.Content("~/"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + ""DemoGrid/Delete"";

    $.post(url, { ID: CustomerID }, function(data) {
        if (data) {
            oTable = $('#example').DataTable();
            oTable.draw();
        } else {
            alert(""Something Went Wrong!"");
        }
    });
}

</script>

");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
