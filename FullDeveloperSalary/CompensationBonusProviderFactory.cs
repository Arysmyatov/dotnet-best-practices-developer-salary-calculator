using System.Collections.Immutable;
using FullDeveloperSalary.Bonus;

namespace FullDeveloperSalary;

public class CompensationBonusProviderFactory
{
    private readonly IReadOnlyDictionary<Position, IFullSalaryProvider> compensationBonusProviders;

    public CompensationBonusProviderFactory()
    {
        var fullSalaryProviderType = typeof(IFullSalaryProvider);
        compensationBonusProviders = typeof(IFullSalaryProvider).Assembly.ExportedTypes
            .Where(x => fullSalaryProviderType.IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
            .Select(Activator.CreateInstance)
            .Cast<IFullSalaryProvider>()
            .ToImmutableDictionary(x => x.DeveloperPosition, x => x);
    }

    public IFullSalaryProvider GetProviderByUserPosition(Position developerPosition)
    {
        var provider = compensationBonusProviders.GetValueOrDefault(developerPosition);
        return provider ?? new DefaultFullSalaryProvider();
    }
}