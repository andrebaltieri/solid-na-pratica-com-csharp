namespace SolidNaPratica._04_ISP.Bad;

public interface IEmployee
{
    string Name { get; set; }
    void CalculateSalary();
    void CalculateBenefits(); // Only relevant for full-time employees
}

public class FullTimeEmployee : IEmployee
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

public class ContractEmployee : IEmployee
{
    public string Name { get; set; }

    public void CalculateSalary()
    {
        Console.WriteLine("Calculating contract employee salary.");
    }

    public void CalculateBenefits()
    {
        throw new NotImplementedException("Contract employees do not have benefits.");
    }
}
