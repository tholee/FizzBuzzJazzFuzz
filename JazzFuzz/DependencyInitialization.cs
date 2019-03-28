using JazzFuzz.RangeConfigurations;
using JazzFuzz.ReplacementConfigurations;
using JazzFuzz.Services.Generators;
using JazzFuzz.Services.Presenters;
using Microsoft.Extensions.DependencyInjection;

namespace JazzFuzz
{
    public static class DependencyInitialization
    {
        public static ServiceProvider SetupDependencies()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddSingleton<IRangeConfiguration, AscendingRangeConfiguration>();
            services.AddSingleton<IReplacementConfiguration, JazzFuzzReplacementConfiguration>();
            services.AddSingleton<IGeneratorService, GeneratorService>();
            services.AddSingleton<IPresenterService, MorseBeepPresenterService>();
            return services.BuildServiceProvider();
        }
    }
}
