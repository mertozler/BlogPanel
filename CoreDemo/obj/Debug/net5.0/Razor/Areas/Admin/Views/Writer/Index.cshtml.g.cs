#pragma checksum "D:\MERT\Coding\.NET CORE\BlogPanel\BlogPanel\CoreDemo\Areas\Admin\Views\Writer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8809a26c886be0f59561015788fc2d0f1d189d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Writer_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Writer/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8809a26c886be0f59561015788fc2d0f1d189d9", @"/Areas/Admin/Views/Writer/Index.cshtml")]
    public class Areas_Admin_Views_Writer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\MERT\Coding\.NET CORE\BlogPanel\BlogPanel\CoreDemo\Areas\Admin\Views\Writer\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Yazar Ajax İşlemleri</h1>
<br />
<button type=""button"" id=""btngetlist"" class=""btn btn-outline-primary"">Yazar Listesi</button>
<button type=""button"" id=""btngetbyid"" class=""btn btn-outline-success"">Yazar Getir</button>
<button type=""button"" id=""btnaddwriter"" class=""btn btn-outline-info"">Yazar Ekle</button>
<button type=""button"" id=""btndeletewriter"" class=""btn btn-outline-danger"">Yazar Sil</button>
<button type=""button"" id=""btnupdatewriter"" class=""btn btn-outline-warning"">Yazar Güncelle</button>
<br />
<br />
<div id=""writerlist"">
    Buraya yazarlar gelecek
</div>
<br />
<div id=""writerget"">
    Buraya 1 yazar gelecek
</div>
<br />
<div>
    <input type=""text"" id=""writerid"" placeholder=""Yazar ID girin"" class=""form-control"" />
</div>
<br />
<br />
<div>
    <input type=""text"" class=""form-control"" id=""txtwriterid"" placeholder=""Yazar ID""/>
    <input type=""text"" class=""form-control"" id=""txtwritername"" placeholder=""Yazar Adı""/>
</div>
<br/>
<div>
    <input type=""text"" class=""form-");
            WriteLiteral(@"control"" id=""txtid"" placeholder=""Silinecek Yazar ID"" />
</div>
<br/>
<input type=""text"" id=""txtid1"" class=""form-control"" placeholder=""Güncellenecek id""/>
<input type=""text"" id=""txtwritername1"" class=""form-control"" placeholder=""Güncellenecek isim""/>



");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(""#btngetlist"").click(function () {
            $.ajax({
                contentType: ""application/json"",
                dataType: ""json"",
                type: ""Get"",
                url: ""/Admin/Writer/WriterList/"",
                success: function (func) {
                    let w = jQuery.parseJSON(func);
                    console.log(w);
                    let tablehtml = ""<table class=table table-bordered> <tr><th>Yazar ID</th> <th> Yazar Adı </th></tr>"";
                    $.each(w, (index, value) => {
                        tablehtml += `<tr><td>${value.id}</td> <td>${value.Name}</td> </tr>`
                    });
                    tablehtml += ""</table>"";
                    $(""#writerlist"").html(tablehtml);
                }
            });
        });

        $(""#btngetbyid"").click(x => {
            let id = $(""#writerid"").val();
            $.ajax({
                contentType: ""application/json"",
                dataType: ""json"",
     ");
                WriteLiteral(@"           type: ""get"",
                url: ""/Admin/Writer/GetWriterByID/"",
                data: { writerid: id },
                success: function (func) {
                    let w = jQuery.parseJSON(func);
                    console.log(w);

                    let getvalue = `<table class=table table-bordered><tr><th>Yazar ID</th> <th>Yazar Adı</th></tr> <tr><td>${w.id}</td><td>${w.Name}</td></tr></table>`;
                    $(""#writerget"").html(getvalue);
                }
            })
        });

        $(""#btnaddwriter"").click(function () {
            let writer = {
                id: $(""#txtwriterid"").val(),
                Name: $(""#txtwritername"").val()
            };
            $.ajax({
                type: ""post"",
                url: ""/Admin/Writer/AddWriter/"",
                data: writer,
                success: function (func) {
                    let result = jQuery.parseJSON(func);
                    alert(""Yazar ekleme işlemi başarıyla gerçekleşti"");");
                WriteLiteral(@"
                }
            });
        })

        $(""#btndeletewriter"").click(x => {
            let id = $(""#txtid"").val();

            $.ajax({
                url: ""/Admin/Writer/DeleteWriter/"" + id,
                type: ""post"",
                dataType: ""json"",
                success: function (func) {
                    alert(""Yazar silme işlemi başarıyla gerçekleşti"");
                }
            });
        });

        $(""#btnupdatewriter"").click(function () {
            let writer = {
                id: $(""#txtid1"").val(),
                Name: $(""#txtwritername1"").val()
            };

            $.ajax({
                type: ""post"",
                url: ""/Admin/Writer/UpdateWriter/"",
                data: writer,
                success: function (funk) {
                    alert(""Güncelleme işlemi başarılı"")
                }
            });
        });


    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
