using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace AzureFunctionsContinuousDelivery
{
    public static class HelloWorld
    {
        [FunctionName("HelloWorld")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)]HttpRequestMessage req, TraceWriter log)
        {

            return req.CreateResponse(HttpStatusCode.OK, new Response() { status = true, data = "Hello world" });

        }
    }

    public class Response
    {
        public bool status { get; set; }
        public object data { get; set; }
    }
}
