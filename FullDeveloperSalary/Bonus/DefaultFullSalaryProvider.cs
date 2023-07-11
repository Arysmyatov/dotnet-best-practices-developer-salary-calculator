namespace FullDeveloperSalary.Bonus;

public class DefaultFullSalaryProvider : IFullSalaryProvider
{
    public decimal GetFullCompensation(Developer developer)
    {
        return developer.Salary;
    }

    public Position DeveloperPosition => Position.None;
}