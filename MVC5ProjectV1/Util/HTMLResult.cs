using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MVC5ProjectV1.Util
{
    public class HTMLResult:ActionResult
    {
        private string HTMLCode;
        public HTMLResult(string Html)
        {
            HTMLCode = Html;
        }
        public override void ExecuteResult(ControllerContext context)
        {
            string fullhtmlcode = "<!DOCTYPE html><html><head>";
            fullhtmlcode += "<title>Главная страница</title>";
            fullhtmlcode += "<meta charset=utf-8/>";
            fullhtmlcode += "</head><body>";
            fullhtmlcode += HTMLCode;
            fullhtmlcode += "</body></html>";
            context.HttpContext.Response.Write(fullhtmlcode);
        }
    }
}