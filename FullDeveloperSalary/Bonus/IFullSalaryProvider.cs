namespace FullDeveloperSalary.Bonus;

public interface IFullSalaryProvider
{
    decimal GetFullCompensation(Developer developer);
    Position DeveloperPosition { get;  }
}