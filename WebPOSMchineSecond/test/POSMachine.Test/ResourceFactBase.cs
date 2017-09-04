using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;
using Newtonsoft.Json.Linq;

namespace POSMachine.Test
{
    public class ResourceFactBase:IDisposable
    {
        readonly HttpServer httpServer;
        static readonly Uri WebApiUri = new Uri("http://www.baidu.com");
        protected HttpClient Client { get; }

        readonly StringContent httpContent;

        public StringContent GetHttpContent(JArray json=null)
        {
            var paramater ="";
            if (json != null)
            {
                paramater = json.ToString();
            }
            var httpContent = new StringContent(paramater, Encoding.UTF8);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return httpContent;
        }

        public ResourceFactBase()
        {
            httpServer = CreateHttpServer();
            Client = CreateHttpClient(httpServer);
        }

        static HttpClient CreateHttpClient(HttpMessageHandler handler)
        {
            return new HttpClient(handler)
            {
                BaseAddress = WebApiUri
            };
        }

        static HttpServer CreateHttpServer()
        {
            var config = new HttpConfiguration();
            Bootstrapper.Init(config);
            var httpServer = new HttpServer(config);
            return httpServer;
        }

        public void Dispose()
        {
            httpServer?.Dispose();
            Client?.Dispose();
        }
    }
}