#pragma checksum "C:\Users\Jovani Salas Cruz\source\repos\ProExaChubb\Products\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd76ab4dcaacfe97beca2e7912de42ba5edb5e3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Index.cshtml", typeof(AspNetCore.Views_Products_Index))]
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
#line 1 "C:\Users\Jovani Salas Cruz\source\repos\ProExaChubb\Products\Views\_ViewImports.cshtml"
using Products;

#line default
#line hidden
#line 2 "C:\Users\Jovani Salas Cruz\source\repos\ProExaChubb\Products\Views\_ViewImports.cshtml"
using Products.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd76ab4dcaacfe97beca2e7912de42ba5edb5e3d", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"148c3c49f2a018175631a3f0648da03bd8c1f699", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Comida", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Servicio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Salud", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Basico", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Jovani Salas Cruz\source\repos\ProExaChubb\Products\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Listado de productos";

#line default
#line hidden
            BeginContext(58, 6487, true);
            WriteLiteral(@"<script type=""text/javascript"">


    $(document).ready(function () {
        ConsultAllProducts();
        $(""button"").click(function () {
            if (this.title==""editar"") {
                ConsultProduct(this.id);
                $(""#btnGuardar"").hide();
                $(""#btnActualizar"").show();
            }
            if (this.title == ""eliminar"") {
                DeleteProduct(this.id)
            }
        });
    });

    function ConsultAllProducts() {
        $.ajax({
            type: ""GET"",
            url: ""https://localhost:44321/api/products"",
            success: function (listProducts) {
                try {                   
                    if (listProducts != null) {
                        FillListProduct(listProducts);
                    }
                } catch (e) { }
            }
        });
    }

    function FillListProduct(listProducts) {
        var valuehtml = """";
        $.each(listProducts, function (index, prod) {
            ");
            WriteLiteral(@"valuehtml += '<tr id=""rowb' + prod.id + '"">';
            valuehtml += '<td>' + prod.name + '</td>';
            valuehtml += '<td>' + prod.description + '</td>';
            valuehtml += '<td>' + prod.categoryType + '</td>';
            valuehtml += '<td>' + prod.price + '</td>';
            valuehtml += '<td>' + prod.quantity + '</td>';
            valuehtml += '<td><button id=""' + prod.id + '"" title=""editar"" >Editar</button></td>';
            valuehtml += '<td><button id=""' + prod.id + '"" title=""eliminar"" >Eliminar</button></td>';
            valuehtml += '</tr>';
        });
        $('#tProducts >tbody').html(valuehtml);
    }

    function createProduct() {
        var parametros = {
            Name: $(""#inputNombre"").val(),
            Description: $(""#inputDescripcion"").val(),
            CategoryType: $(""#inputCategoria"").val(),
            Price: $(""#inputPrecio"").val(),
            Quantity: $(""#inputCantidad"").val()
        }
        var valuesdata = {
            Product: ");
            WriteLiteral(@"parametros
        }
        $.ajax({
            type: ""POST"",
            url: ""https://localhost:44321/api/products/alta"",
            data: valuesdata,
            success: function (listProducts) {
                try {
                    if (listProducts != null) {
                        FillListProduct(listProducts);
                    }
                } catch (e) { }
            }
        });
    }

    function ConsultProduct(id) {
        $.ajax({
            type: ""GET"",
            url: ""https://localhost:44321/api/products/""+id,            
            success: function (Product) {
                try {
                    if (Product != null) {
                        $(""#inputNombre"").val(Product.name);
                        $(""#inputDescripcion"").val(Product.description);
                        $(""#inputCategoria"").val(Product.categoryType);
                        $(""#inputPrecio"").val(Product.price);
                        $(""#inputCantidad"").val(Product.qu");
            WriteLiteral(@"antity);
                    }
                } catch (e) { }
            }
        });
    }

    function EditProductProduct() {
        var parametros = {
            Name: $(""#inputId"").val(),
            Name: $(""#inputNombre"").val(),
            Description: $(""#inputDescripcion"").val(),
            CategoryType: $(""#inputCategoria"").val(),
            Price: $(""#inputPrecio"").val(),
            Quantity: $(""#inputCantidad"").val()
        }
        var valuesdata = {
            Product: parametros
        }
        $.ajax({
            type: ""PUT"",
            url: ""https://localhost:44321/api/products"",
            data: valuesdata,
            success: function (listProducts) {
                try {
                    if (listProducts != null) {
                        FillListProduct(listProducts);
                        $(""#btnGuardar"").show();
                        $(""#btnActualizar"").hide();
                    }
                } catch (e) { }
            }
 ");
            WriteLiteral(@"       });
    }

    function DeleteProduct(id) {
        $.ajax({
            type: ""DELETE"",
            url: ""https://localhost:44321/api/products/"" + id,
            success: function (listProducts) {
                try {
                    if (listProducts != null) {
                        FillListProduct(listProducts);                       
                    }
                } catch (e) { }
            }
        });
    }
</script>
<h2>Listado de Productos</h2>
<button data-toggle=""modal"" data-target=""#formProduct"">Agregar</button>
<br />
<br />
<table id=""tProducts"" class=""table table-bordered table-inverse dt-responsive"">
    <thead>
        <tr>
            <th>Nombre</th>
            <th>Descripción</th>
            <th>Categoria</th>
            <th>Precio</th>
            <th>Cantidad</th>
            <th>Editar</th>
            <th>Eliminar</th>
        </tr>
    </thead>
    <tbody>
    </tbody>
</table>
<button id=""confirmsuccesslogout""  >Abrir</butto");
            WriteLiteral(@"n>
 
<div class=""modal fade"" id=""formProduct"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">

            <!-- successLogout Header -->
            <div class=""modal-header"">
                <h4 class=""modal-title"">Alta de Nuevo Producto</h4>
            </div>
            <div class=""form-row"">
                <div class=""form-group col-md-12"">
                    <label class=""control-label"" for=""inputNombre""><span style=""color: red;"">*</span>  Nombre</label>
                    <input type=""hidden"" class=""form-control"" id=""inputId"" name=""inputId"">
                    <input type=""text"" class=""form-control"" id=""inputNombre"" name=""inputNombre"" placeholder=""Nombre"">
                </div>
                <div class=""form-group col-md-12"">
                    <label class=""control-label"" for=""inputDescripcion""><span style=""color: red;"">*</span>  Descripcion</label>
                    <input type=""text"" class=""form-control"" id=""inputDescripcion"" name=""inputDescripcion"" pl");
            WriteLiteral(@"aceholder=""Descripcion"">
                </div>
                <div class=""form-group col-md-12"">
                    <label class=""control-label"" for=""inputCategoria""><span style=""color: red;"">*</span> Categoria</label>
                    <select id=""inputCategoria"" name=""inputCategoria"" class=""form-control"">
                        ");
            EndContext();
            BeginContext(6545, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cca1cc0b9af74ff59772323072f25d56", async() => {
                BeginContext(6563, 9, true);
                WriteLiteral("ELEGIR...");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6581, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(6607, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67b9a94a3c3e4f3b91b1086b040ab019", async() => {
                BeginContext(6630, 6, true);
                WriteLiteral("Comida");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6645, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(6671, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d149e03ad0d4e5da26fbb96b820645b", async() => {
                BeginContext(6696, 8, true);
                WriteLiteral("Servicio");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6713, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(6739, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "966db87e36924cb18a4add08e93648c0", async() => {
                BeginContext(6761, 5, true);
                WriteLiteral("Salud");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6775, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(6801, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f19f6c12c6140dcb1bf78fab7498897", async() => {
                BeginContext(6824, 6, true);
                WriteLiteral("Basico");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6839, 1193, true);
            WriteLiteral(@"
                    </select>

                </div>

                <div class=""form-group col-md-12"">
                    <label class=""control-label"" for=""inputPrecio""><span style=""color: red;"">*</span>  Precio</label>
                    <input type=""text"" class=""form-control"" id=""inputPrecio"" name=""inputPrecio"" placeholder=""Precio"">
                </div>

                <div class=""form-group col-md-12"">
                    <label class=""control-label"" for=""inputCantidad""><span style=""color: red;"">*</span>  Cantidad</label>
                    <input type=""text"" class=""form-control"" id=""inputCantidad"" name=""inputCantidad"" placeholder=""Cantidad"">
                </div>
            </div>
           

            <!-- successLogout footer -->
            <div class=""modal-footer"">
                <button id=""btnGuardar"" type=""button"" class=""btn btn-success"" data-dismiss=""modal"" onclick=""createProduct();""> Guardar</button>
                <button id=""btnActualizar"" type=""button"" cla");
            WriteLiteral("ss=\"btn btn-success\" data-dismiss=\"modal\" onclick=\"EditProductProduct();\"> Guardar</button>\r\n\r\n                \r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
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
