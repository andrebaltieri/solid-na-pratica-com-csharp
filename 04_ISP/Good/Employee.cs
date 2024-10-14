namespace SolidNaPratica._04_ISP.Good;

public interface ISalaryCalculator
{
    void CalculateSalary();
}

public interface IBenefitsCalculator
{
    void CalculateBenefits();
}

public class FullTimeEmployee : ISalaryCalculator, IBenefitsCalculator
{
    public string Name { get; set; }

    public void CalculateSalary()
    {
        Console.WriteLine("Calculating full-time employee salary.");
    }

    public void CalculateBenefits()
    {
        Console.WriteLine("Calculating benefits for full-time employee.");
    }
}

public class ContractEmployee : ISalaryCalculator
{
    public string Name { get; set; }

    public void CalculateSalary()
    {
        Console.WriteLine("Calculating contract employee salary.");
    }
}
