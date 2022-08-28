using Microsoft.Extensions.DependencyInjection;
using PackIt.Domain.Factories;
using PackIt.Domain.Policies;
using PackIt.Shared;

namespace PackIt.Application;

public static class Extensions
{
    public static IServiceCollection AddApplication(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddCommands();
        serviceCollection.AddSingleton<IPackingListFactory, PackingListFactory>();
        
        //Automatic policies registration with Scrutor from Nuget.
        serviceCollection.Scan(b => b.FromAssemblies(typeof(IPackingItemsPolicy).Assembly)
            .AddClasses(c => c.AssignableTo(typeof(IPackingItemsPolicy)))
            .AsImplementedInterfaces()
            .WithSingletonLifetime());
        
        return serviceCollection;
    }
}