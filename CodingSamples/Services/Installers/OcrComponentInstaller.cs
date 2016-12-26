using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using CodingSamples.Services.Interfaces;
using CodingSamples.Services.OcrRecognition;
using CodingSamples.Services.OcrRecognition.Models;

namespace CodingSamples.Services.Installers
{
    public class OcrComponentInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IConverter<string, string>>().ImplementedBy<CharacterDefinitionToCharacterConverter>());
            container.Register(Component.For<IConverter<CharacterModel, string>>().ImplementedBy<CharacterModelToCharacterDefinitionConverter>());
            container.Register(Component.For<ICharacterModelReader>().ImplementedBy<CharacterModelReader>());
            container.Register(Component.For<ILineModelReader>().ImplementedBy<LineModelReader>());
            container.Register(Component.For<CharacterDefinitions>());
            container.Register(Component.For<ILineReader>().ImplementedBy<LineReader>());
            container.Register(Component.For<IOcrProcessor>().ImplementedBy<OcrProcessor>());
            container.Register(Component.For<IOcrOutputGenerator>().ImplementedBy<OcrOutputGenerator>());
            container.Register(Component.For<IFileReader>().ImplementedBy<FileReader>());
        }
    }
}