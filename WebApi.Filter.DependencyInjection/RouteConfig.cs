using DotNetNuke.Web.Api;

namespace WebApi.Filter.DependencyInjection
{
    public class RouteConfig : IServiceRouteMapper
    {
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {
            mapRouteManager.MapHttpRoute(
                "AndrewHoefling/WebApi/DependencyInjection", 
                "default", 
                "{controller}/{action}",
                new[] { "WebApi.Filter.DependencyInjection.Controllers" });
        }
    }
}
