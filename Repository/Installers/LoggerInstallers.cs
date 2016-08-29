using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Repository.Models;

namespace Repository.Installers
{
    public class LoggerInstallers : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Classes.FromThisAssembly()
                    .BasedOn<ILogger>()
                    .WithService.Select(new[] {typeof(ILogger)})
                    .Configure(c => c.Named(c.Implementation.Name))
                    .LifestyleTransient());
        }
    }
}