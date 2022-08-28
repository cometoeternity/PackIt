using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using PackIt.Shared.Abstractions.Commands;
using PackIt.Shared.Commands;

namespace PackIt.Shared;

public static class Extensions
{
    public static IServiceCollection AddCommands(this IServiceCollection serviceCollection)
    {
        var assembly = Assembly.GetCallingAssembly();
        
        serviceCollection.AddSingleton<ICommandDispatcher, InMemoryCommandDispatcher>();
        //Automatic command handler registration with Scrutor from Nuget
        serviceCollection.Scan(s => s.FromAssemblies(assembly)
            .AddClasses(c => c.AssignableTo(typeof(ICommandHandler<>)))
            .AsImplementedInterfaces()
            .WithScopedLifetime());
        return serviceCollection;
    }
}