using System;
using Castle.Core.Resource;
using Castle.MicroKernel;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using CodingSamples.Services.Interfaces;
using CodingSamples.Services.Logging;

namespace CodingSamples.Services
{
    public class ServiceLocator
    {
        private static WindsorContainer _container;

        public static WindsorContainer Instance
        {
            get
            {
                if (_container == null)
                {
                    throw new Exception("ServiceLocator has to be initialized before usage.");
                }
                return _container;
            }
        }

        public static T Resolve<T>()
        {
            return Instance.Resolve<T>();
        }

        public static void Initialize(WindsorContainer container)
        {
            //container.AddFacility<LogTypeResolverFacility>();
            _container = container;
            InitializeLog();
        }
        public static void Initialize(IWindsorInstaller[] installers)
        {
            var container = new WindsorContainer();
            container.AddFacility<LogTypeResolverFacility>();
            container.Install(installers);
            _container = container;
            InitializeLog();
        }

        internal static void InitializeLog()
        {
            //TODO: *consider breaking initialization of program when log cannot be initialized properly.
            log4net.Config.XmlConfigurator.Configure();
        }

        /// <summary>
        ///     Returns logger instance for specified type.
        /// </summary>
        /// <param name="type">type of the object the logger is created for.</param>
        /// <returns>ILog instance</returns>
        public static ILog GetLogger(Type type)
        {
            var logger = log4net.LogManager.GetLogger(type) as log4net.ILog;
            return new Log(logger);
        }

        /// <summary>
        ///     Returns logger instance for specified type.
        /// </summary>
        /// <typeparam name="T">type of the object the logger is created for.</typeparam>
        /// <returns>ILog instance</returns>
        public static ILog GetLogger<T>()
        {
            return GetLogger(typeof(T));
        }
        public static void Dispose()
        {
            _container.Dispose();
        }
    }
}