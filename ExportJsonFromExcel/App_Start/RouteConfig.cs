using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ExportJsonFromExcel
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
              name: "Default Home Page",
              url: "",
              defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
              namespaces: new[] { "ExportJsonFromExcel.Controllers" }
          );


            routes.MapRoute(
            "Yes24-linhduong-tool-export-json",
            "export-json",
            new { controller = "Home", action = "ExportJson", id = UrlParameter.Optional }, new[] { "ExportJsonFromExcel.Controllers" }
            );
            routes.MapRoute(
           "Yes24-linhduong-tool-export-json-2",
           "Home/SubmitSelectedColumn/{id}",
           new { controller = "Home", action = "SubmitSelectedColumn", id = UrlParameter.Optional }, new[] { "ExportJsonFromExcel.Controllers" }
           );
            routes.MapRoute(
           "Yes24-linhduong-tool-download-json",
           "export-json/download",
           new { controller = "Home", action = "DownloadJson", id = UrlParameter.Optional }, new[] { "ExportJsonFromExcel.Controllers" }
           );
            routes.MapRoute(
          "Yes24-linhduong-tool-export-product-code-to-one-line",
          "product-code-comma",
          new { controller = "Home", action = "ExportProductCode", id = UrlParameter.Optional }, new[] { "ExportJsonFromExcel.Controllers" }
          );

            routes.MapRoute(
            "export-html-table",
            "export-html-table/{id}",
            new { controller = "Home", action = "ExportHtmlTable", id = UrlParameter.Optional }, new[] { "ExportJsonFromExcel.Controllers" }
            );
            routes.MapRoute(
             "export-link-pro-tag-a",
             "export-link-pro-tag-a",
             new { controller = "Home", action = "ExportLinkPro", id = UrlParameter.Optional }, new[] { "ExportJsonFromExcel.Controllers" }
             );
            routes.MapRoute(
             "export-link-pro-ajax",
             "export-link-pro-ajax",
             new { controller = "Home", action = "ExportLinkProTagA", id = UrlParameter.Optional }, new[] { "ExportJsonFromExcel.Controllers" }
             );
            routes.MapRoute(
             "beauty-code",
             "beauty-code",
             new { controller = "BeautyCode", action = "Index", id = UrlParameter.Optional }, new[] { "ExportJsonFromExcel.Controllers" }
             );

            routes.MapRoute(
            "create-tab",
            "create-html-tab",
            new { controller = "Home", action = "CreateTab", id = UrlParameter.Optional }, new[] { "ExportJsonFromExcel.Controllers" }
            );

            routes.MapRoute(
            "setup-layout",
            "setup-layout",
            new { controller = "Home", action = "SetupLayout", id = UrlParameter.Optional }, new[] { "ExportJsonFromExcel.Controllers" }
            );


            routes.MapRoute(
              name: "Default",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
              namespaces: new[] { "ExportJsonFromExcel.Controllers" }
          );
        }
    }
}
