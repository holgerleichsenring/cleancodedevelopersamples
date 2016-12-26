using Castle.Core;
using Castle.MicroKernel;
using Castle.MicroKernel.Context;
using log4net;

namespace CodingSamples.Services.Logging
{
    public class LogTypeResolver : ISubDependencyResolver
    {
        public object Resolve(
            CreationContext context,
            ISubDependencyResolver contextHandlerResolver,
            ComponentModel model,
            DependencyModel dependency)
        {
            ILog logger = LogManager.GetLogger(context.RequestedType);
            return new Log(logger);
        }

        public bool CanResolve(
            CreationContext context,
            ISubDependencyResolver contextHandlerResolver,
            ComponentModel model,
            DependencyModel dependency)
        {
            return dependency.TargetType.Name == typeof (CodingSamples.Services.Interfaces.ILog).Name;
        }
    }
}