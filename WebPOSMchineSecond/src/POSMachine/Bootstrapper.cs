using System;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Routing;

namespace POSMachine
{
    public class Bootstrapper
    {
        public static void Init(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                "get product recipt",
                "getProdutcRecipt",
                new {controller="POSMachine",action= "GetRecipt" },
                new {httpMethod=new HttpMethodConstraint(HttpMethod.Post)}
                );
        }
    }
}