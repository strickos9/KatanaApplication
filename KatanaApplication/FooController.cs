using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KatanaApplication
{
    [RoutePrefix("api/foo")]
    public class FooController : ApiController
    {
        [Route("getfoo/{name}")]
        public HttpResponseMessage Get(string name)
        {
            return Request.CreateResponse(HttpStatusCode.OK, $"Foo {name}");
        }
    }
}