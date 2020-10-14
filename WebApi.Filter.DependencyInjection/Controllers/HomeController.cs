using DotNetNuke.Security;
using DotNetNuke.Web.Api;
using System.Net.Http;
using System.Web.Http;
using WebApi.Filter.DependencyInjection.Filters;

namespace WebApi.Filter.DependencyInjection.Controllers
{
    [DnnModuleAuthorize(AccessLevel = SecurityAccessLevel.View)]
    public class HomeController : DnnApiController
    {
        [HttpGet]
        [AllowAnonymous]
        [EventLogFilter]
        public HttpResponseMessage Index()
        {
            return new HttpResponseMessage(System.Net.HttpStatusCode.OK) { Content = new StringContent("Hello World") };
        }
    }
}
