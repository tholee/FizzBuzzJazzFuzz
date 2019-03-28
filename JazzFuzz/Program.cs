using JazzFuzz.Services.Generators;
using JazzFuzz.Services.Presenters;
using Microsoft.Extensions.DependencyInjection;

namespace JazzFuzz
{
    class Program
    {
        private static ServiceProvider _serviceProvider;

        static void Main(string[] args)
        {
            _serviceProvider = DependencyInitialization.SetupDependencies();

            IGeneratorService generator = _serviceProvider.GetService<IGeneratorService>();
            IPresenterService presenter = _serviceProvider.GetService<IPresenterService>();
            presenter.Present(generator.GetValues());

            _serviceProvider.Dispose();
        }
    }
}
