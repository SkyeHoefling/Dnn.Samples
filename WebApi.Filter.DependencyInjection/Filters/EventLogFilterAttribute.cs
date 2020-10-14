using DotNetNuke.Abstractions.Logging;
using DotNetNuke.DependencyInjection;
using System;
using System.Web.Http.Filters;

namespace WebApi.Filter.DependencyInjection.Filters
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class EventLogFilterAttribute : ActionFilterAttribute
    {
        [Dependency]
        protected IEventLogger Logger { get; set; }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            Logger.AddLog("Test", "Hello World", EventLogType.ADMIN_ALERT);
            base.OnActionExecuted(actionExecutedContext);
        }
    }
}
