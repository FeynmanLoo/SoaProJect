#pragma checksum "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Goods\LossOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "838bdb32be17d3cee2bff0e5945ba9d8b67c72cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Goods.Pages_FytAdmin_Goods_LossOrder), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Goods/LossOrder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Goods/LossOrder.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Goods.Pages_FytAdmin_Goods_LossOrder), null)]
namespace FytSoa.Web.Pages.FytAdmin.Goods
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"838bdb32be17d3cee2bff0e5945ba9d8b67c72cb", @"/Pages/FytAdmin/Goods/LossOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Goods_LossOrder : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Goods\LossOrder.cshtml"
  
    ViewData["Title"] = "报损打包销售";
    Layout = AdminLayout.Pjax(HttpContext);

#line default
#line hidden
            BeginContext(149, 6007, true);
            WriteLiteral(@"<div id=""container"">
    <div class=""list-wall"">
        <div class=""layui-form list-search"">
            <div class=""layui-inline"">
                <input class=""layui-input"" id=""key"" autocomplete=""off"" placeholder=""请输入关键字查询"">
            </div>
            <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""toolSearch""><i class=""layui-icon layui-icon-search""></i> 搜索</button>
        </div>
        <table class=""layui-hide"" id=""tablist"" lay-filter=""tool""></table>
    </div>
    <script type=""text/html"" id=""toolbar"">
        <div class=""layui-btn-container"" style=""display:none;"">
            <button type=""button"" class=""layui-btn layui-btn-sm"" lay-event=""toolDel""><i class=""layui-icon layui-icon-delete""></i> 删除</button>
        </div>
    </script>
    <script>
        layui.config({
            base: '/themes/js/modules/'
        }).use(['table', 'layer', 'jquery', 'common', 'form'],
            function () {
                var table = layui.table,
                    layer =");
            WriteLiteral(@" layui.layer,
                    $ = layui.jquery,
                    os = layui.common,
                    form = layui.form;
                form.render('select');
                table.render({
                    toolbar: '#toolbar',
                    elem: '#tablist',
                    url: '/api/goods/lossorder/list',
                    cols: [
                        [
                            { type: 'checkbox', fixed: 'left' },
                            { field: 'number', width: 180, title: '订单号', fixed: 'left', sort: true, templet: function (res) { return '<a href=""javascript:void(0)""  lay-event=""skuinfo"" style=""color:#409eff"">'+res.number+'</a>'}},
                            { field: 'money', title: '金额', width: 100, sort: true},
                            { field: 'customerName', title: '客户姓名', width: 120 },
                            { field: 'customerMobile', title: '客户联系方式', width: 160 },
                            { field: 'summary', title: '备注' },
           ");
            WriteLiteral(@"                 { field: 'addDate', title: '添加时间', width: 260, sort: true},
                            { width: 140, title: '操作', templet: '#tool' }
                        ]
                    ],
                    page: { limits: [10, 20, 50, 100, 500, 1000, 5000, 10000], groups: 8 },
                    id: 'tables'
                });
                table.on('sort(tool)', function (obj) {
                    var e = layer.load(2, { shade: [.05, '#000'] });
                    table.reload('tables', {
                        initSort: obj,
                        page: {
                            curr: 1
                        },
                        where: {
                            field: obj.field,
                            order: obj.type,
                            key: $(""#key"").val()
                        },
                        done: function () {
                            layer.close(e);
                        }
                    });
              ");
            WriteLiteral(@"  });
                var guid = '', active = {
                    reload: function () {
                        table.reload('tables',
                            {
                                page: {
                                    curr: 1
                                },
                                where: {
                                    key: $(""#key"").val()
                                }
                            });
                    },
                    toolSearch: function () {
                        active.reload();
                    },
                    //查看商品详细
                    toolDel: function () {
                        var checkStatus = table.checkStatus('tables')
                            , data = checkStatus.data;
                        if (data.length === 0) {
                            os.error(""请选择要删除的项目~"");
                            return;
                        }
                        var str = '';
                  ");
            WriteLiteral(@"      $.each(data, function (i, item) {
                            str += item.guid + "","";
                        });
                        layer.confirm('确定要执行批量删除吗？', function (index) {
                            layer.close(index);
                            var loadindex = layer.load(1, {
                                shade: [0.1, '#000']
                            });
                            os.ajax('api/goods/dellossorder/', { parm: str }, function (res) {
                                layer.close(loadindex);
                                if (res.statusCode === 200) {
                                    active.reload();
                                    os.success('删除成功！');
                                } else {
                                    os.error(res.message);
                                }
                            });
                        });
                    }
                };
                table.on('toolbar(tool)', function (obj) {
 ");
            WriteLiteral(@"                   active[obj.event] ? active[obj.event].call(this) : '';
                });
                $('.list-search .layui-btn').on('click', function () {
                    var type = $(this).data('type');
                    active[type] ? active[type].call(this) : '';
                });
                //监听工具条
                table.on('tool(tool)', function (obj) {
                    var data = obj.data;
                    if (obj.event === 'skuinfo') {
                        os.Open('报损打包销售', '/fytadmin/goods/lossorderinfo?guid=' + data.guid, '1000px', '600px', function () { });
                    }
                });
            });
    </script>
    <script type=""text/html"" id=""tool"">
        <a class=""layui-btn layui-btn-primary layui-btn-xs"" lay-event=""skuinfo""><i class=""layui-icon layui-icon-list""></i> 查看详情</a>
    </script>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Goods.LossOrderModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Goods.LossOrderModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Goods.LossOrderModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Goods.LossOrderModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
