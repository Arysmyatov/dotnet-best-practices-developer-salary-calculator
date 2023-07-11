using FluentAssertions;
using Xunit;

namespace FullDeveloperSalary.UnitTests;

public class CompensationsBonusTests
{
    [Fact]
    public void FullSalaryForDefaultDeveloper_ShouldCalculateFullSalary_WhenAllParametersAreValid()
    {
        // Arrange
        var juniorDeveloper = BuildDeveloperFroTheSalary(Position.None);
        
        // Act
        var bonusProviderFactory = new CompensationBonusProviderFactory();

        var provider = bonusProviderFactory.GetProviderByUserPosition(juniorDeveloper.UserPosition);
        var fullCompensation = provider.GetFullCompensation(juniorDeveloper);

        // Assert
        fullCompensation.Should().Be(500);
    }
    
    [Fact]
    public void FullSalaryForJuniorDeveloper_ShouldCalculateFullSalary_WhenAllParametersAreValid()
    {
        // Arrange
        var juniorDeveloper = BuildDeveloperFroTheSalary(Position.Junior);

        // Act
        var bonusProviderFactory = new CompensationBonusProviderFactory();

        var provider = bonusProviderFactory.GetProviderByUserPosition(juniorDeveloper.UserPosition);
        var fullCompensation = provider.GetFullCompensation(juniorDeveloper);

        // Assert
        fullCompensation.Should().Be(600);
    }
    
    
    [Fact]
    public void FullSalaryForMiddleDeveloper_ShouldCalculateFullSalary_WhenAllParametersAreValid()
    {
        // Arrange
        var juniorDeveloper = BuildDeveloperFroTheSalary(Position.Middle);

        // Act
        var bonusProviderFactory = new CompensationBonusProviderFactory();

        var provider = bonusProviderFactory.GetProviderByUserPosition(juniorDeveloper.UserPosition);
        var fullCompensation = provider.GetFullCompensation(juniorDeveloper);

        // Assert
        fullCompensation.Should().Be(700);
    }
    
    [Fact]
    public void FullSalaryForSeniorDeveloper_ShouldCalculateFullSalary_WhenAllParametersAreValid()
    {
        // Arrange
        var juniorDeveloper = BuildDeveloperFroTheSalary(Position.Senior);

        // Act
        var bonusProviderFactory = new CompensationBonusProviderFactory();

        var provider = bonusProviderFactory.GetProviderByUserPosition(juniorDeveloper.UserPosition);
        var fullCompensation = provider.GetFullCompensation(juniorDeveloper);

        // Assert
        fullCompensation.Should().Be(1000);
    }
    
    private Developer BuildDeveloperFroTheSalary(Position position)
    {
        return new Developer(
            name: "Joe Doe",
            age: 21,
            userPosition: position,
            salary: 500
        );
    }
}