#pragma checksum "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\ReturnAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd939bb2428d858069122952a6bdebda93f50e2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Sale.Pages_FytAdmin_Sale_ReturnAdd), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Sale/ReturnAdd.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Sale/ReturnAdd.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Sale.Pages_FytAdmin_Sale_ReturnAdd), null)]
namespace FytSoa.Web.Pages.FytAdmin.Sale
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\_ViewImports.cshtml"
using FytSoa.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd939bb2428d858069122952a6bdebda93f50e2b", @"/Pages/FytAdmin/Sale/ReturnAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Sale_ReturnAdd : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("from-app"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/js/modules/vue.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\ReturnAdd.cshtml"
  
    ViewData["Title"] = "添加返货订单";
    Layout = "~/Pages/FytAdmin/_Layout.cshtml";

#line default
#line hidden
            BeginContext(152, 236, true);
            WriteLiteral("<style>\r\n    .layui-btn .layui-icon {\r\n        vertical-align: middle;\r\n        top: -2px;\r\n        position: relative;\r\n    }\r\n</style>\r\n<div id=\"app\">\r\n    <div class=\"layui-form list-search\" style=\"margin:0px 12px 0 12px;\">\r\n        ");
            EndContext();
            BeginContext(388, 949, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65359f16bc57470e9951caf588546cdc", async() => {
                BeginContext(437, 788, true);
                WriteLiteral(@"
            <div class=""layui-inline"">
                <input class=""layui-input"" id=""GoodsGuid"" name=""GoodsGuid"" lay-verify=""required"" lay-verType=""tips"" autocomplete=""off"" placeholder=""条形码"">
            </div>
            <div class=""layui-inline"">
                <input class=""layui-input"" id=""Summary"" name=""Summary""  autocomplete=""off"" placeholder=""（选填）返货描述"" style=""width:260px;"">
            </div>
            <div class=""layui-inline"">
                <input class=""layui-input"" id=""ReturnCount"" name=""ReturnCount"" value=""1"" autocomplete=""off"" placeholder=""数量"">
            </div>
            <div class=""layui-inline"">
                <button class=""layui-btn"" lay-submit="""" lay-filter=""submit"">添加返货</button>
                <button type=""button"" class=""layui-btn"" ");
                EndContext();
                BeginContext(1226, 104, true);
                WriteLiteral("@click=\"btnOkSubmit\" style=\"margin-left:100px;\" v-html=\"btnHtml\"></button>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1337, 1104, true);
            WriteLiteral(@"
    </div>
    <div class=""layui-row"">
        <div class=""layui-col-xs12 layui-col-sm12 layui-col-md12"">
            <div class=""list-wall"" style=""padding-top:0px; padding-right:6px;"">
                <table class=""layui-table fyt-table"">
                    <thead>
                        <tr>
                            <th width=""40""><span>序号</span></th>
                            <th><span>条形码</span></th>
                            <th width=""100""><span>数量</span></th>
                            <th width=""300""><span>返货原因</span></th>
                            <th width=""60""><span>操作</span></th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr v-for=""it,index in tabList"">
                            <td align=""center"">{{index+1}}</td>
                            <td>{{it.Code}}</td>
                            <td><input type=""number"" v-model=""it.ReturnCount"" class=""layui-input"" style=""height:26px;"" /></td>
        ");
            WriteLiteral("                    <td>{{it.Summary}}</td>\r\n                            <td><i ");
            EndContext();
            BeginContext(2442, 255, true);
            WriteLiteral("@click=\"delTableRow(index)\" class=\"layui-icon layui-icon-close\" style=\"cursor:pointer\"></i></td>\r\n                        </tr>\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n        \r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(2697, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa2ab6fa9bb848c383a757290ab1f3ab", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2770, 307, true);
            WriteLiteral(@"
<script>
    var cusFun,vm = new Vue({
        el: '#app',
        data: {
            tabList: [
                 //{ 'Code': 'abc','summary':'', 'Count': '1' }
            ],
            btnHtml: '<i class=""layui-icon layui-icon-ok""></i> 提交返货信息',
            parm: {
                ShopGuid: '");
            EndContext();
            BeginContext(3078, 14, false);
#line 72 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\ReturnAdd.cshtml"
                      Write(Model.shopGuid);

#line default
#line hidden
            EndContext();
            BeginContext(3092, 2590, true);
            WriteLiteral(@"',
                StaffGuid: 'admin',
                goodsJson:''
            }
        },
        methods: {
            delTableRow: function (index) {
                this.tabList.splice(index,1);
            },
            btnOkSubmit: function () {
                cusFun.submit();
            }
        }
    });
    layui.config({
        base: '/themes/js/modules/'
    }).use(['table','layer', 'jquery', 'common', 'form'], function () {
        var table = layui.table, form = layui.form, $ = layui.$, os = layui.common, resList;
        var index = parent.layer.getFrameIndex(window.name);
        $(""#GoodsGuid"").focus();
        cusFun = {
            submit: function () {
                if (vm.tabList.length == 0) {
                    os.error('请添加返货信息~~~');
                    return;
                }
                vm.parm.goodsJson = JSON.stringify(vm.tabList);
                console.log(vm.parm);
                os.ajax('api/stock/return/add', vm.parm, function (res");
            WriteLiteral(@") {
                    if (res.statusCode == 200) {
                        parent.layer.close(index);
                    }
                    else {
                        os.error(res.message);
                    }
                });
            }
        };

        //对比提交
        form.on('submit(submit)', function (data) {
            var digIndex = layer.load(1, {
                shade: [0.1, '#fff'] 
            });
            os.ajax('api/goods/bycode', { shopGuid: vm.parm.ShopGuid, code: data.field.GoodsGuid }, function (res) { 
                console.log(res);
                if (res.statusCode == 200) {
                    var isEx = false;
                    for (var i = 0; i < vm.tabList.length; i++) {
                        if (vm.tabList[i].GoodsGuid == res.data.guid) {
                            isEx = true;
                            vm.tabList[i].ReturnCount = parseInt(vm.tabList[i].ReturnCount) + parseInt($(""#ReturnCount"").val());
                        }");
            WriteLiteral(@"
                    }
                    if (!isEx) {
                        vm.tabList.push({ Code: data.field.GoodsGuid, 'GoodsGuid': res.data.guid, 'Summary': data.field.Summary, 'ReturnCount': data.field.ReturnCount });
                    }
                } else {
                    os.error('加盟商下没有该商品信息！');
                }
                layer.close(digIndex);
            });   
            $(""#GoodsGuid"").val('');
            $(""#GoodsGuid"").focus();
            return false;
        });
    });
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Sale.ReturnAddModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Sale.ReturnAddModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Sale.ReturnAddModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Sale.ReturnAddModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
