namespace FullDeveloperSalary;

public class Developer
{
    public string Name { get; }
    public byte Age { get; }
    public Position UserPosition { get; }
    public decimal Salary { get; }

    public Developer(
        string name,
        byte age,
        Position userPosition,
        decimal salary)
    {
        Name = name;
        Age = age;
        UserPosition = userPosition;
        Salary = salary;
    }
}
