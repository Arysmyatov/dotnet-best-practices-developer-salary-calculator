namespace FullDeveloperSalary.Bonus;

public class SeniorFullSalaryProvider : IFullSalaryProvider
{
    public decimal GetFullCompensation(Developer developer)
    {
        return developer.Salary * 2;
    }

    public Position DeveloperPosition { get; } = Position.Senior;
}