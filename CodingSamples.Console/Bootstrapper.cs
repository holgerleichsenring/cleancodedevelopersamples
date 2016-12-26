using System.Collections.Generic;
using Castle.MicroKernel.Registration;
using CodingSamples.Services;
using CodingSamples.Services.Installers;

namespace CodingSamples.Console
{
    internal class Bootstrapper
    {
        public void Initialize()
        {
            var installers = new List<IWindsorInstaller>
            {
                new OcrComponentInstaller()
            };

            ServiceLocator.Initialize(installers.ToArray());
        }
    }
}