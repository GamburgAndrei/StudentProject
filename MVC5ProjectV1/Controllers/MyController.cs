using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC5ProjectV1.Controllers
{
    public class MyController:IController
    {
        public void Execute(RequestContext requestContext)
        {
            string ip = requestContext.HttpContext.Request.UserHostAddress;
            var browser = requestContext.HttpContext.Request.Browser;
            var response = requestContext.HttpContext.Response;
            response.Write("Ваш IP" + ip+"Ваш браузер:"+browser);
        }
    }
}