using System.Web.Http;

namespace KatanaApplication
{
    public class GreetingController : ApiController
    {
        public Greeting Get(string name)
        {
            return new Greeting {Text = $"Hello {name}"};
        }
    }
}