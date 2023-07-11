namespace FullDeveloperSalary.Bonus;

public class MiddleFullSalaryProvider : IFullSalaryProvider
{
    public decimal GetFullCompensation(Developer developer)
    {
        return developer.Salary + 200;
    }

    public Position DeveloperPosition { get; } = Position.Middle;
}