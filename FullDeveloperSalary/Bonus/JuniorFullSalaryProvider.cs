namespace FullDeveloperSalary.Bonus;

public class JuniorFullSalaryProvider : IFullSalaryProvider
{
    public decimal GetFullCompensation(Developer developer)
    {
        return developer.Salary + 100;
    }

    public Position DeveloperPosition { get; } = Position.Junior;
}