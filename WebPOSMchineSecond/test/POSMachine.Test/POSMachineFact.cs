using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace POSMachine.Test
{
    public class POSMachineFact:ResourceFactBase
    {
        [Fact]
        public async Task should_throw_badRequest_input_null()
        {
            var json = "";
            var response = await Client.PostAsJsonAsync("getProdutcRecipt", GetHttpContent(json));
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }

    }
}