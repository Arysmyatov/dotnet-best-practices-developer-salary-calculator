using FullDeveloperSalary;

var juniorDeveloper = new Developer(
    name: "Joe Doe",
    age: 21,
    userPosition: Position.Middle,
    salary: 500
);

var bonusProviderFactory = new CompensationBonusProviderFactory();

var provider = bonusProviderFactory.GetProviderByUserPosition(juniorDeveloper.UserPosition);
var fullCompensation = provider.GetFullCompensation(juniorDeveloper);

Console.WriteLine($"Salary for developer {juniorDeveloper.Name} is {fullCompensation}");
Console.ReadKey();
