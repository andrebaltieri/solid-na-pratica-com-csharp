namespace SolidNaPratica._02_OCP.Bad;

public enum EProductType
{
    Electronics = 1,
    Health = 2,
    Beauty = 3,
    Fashion = 4
}

public class Discount
{
    public decimal Calculate(EProductType type, decimal price)
    {
        if (type == EProductType.Electronics)
            return price * 0.1m;
        
        if (type == EProductType.Beauty)
            return price * 0.2m;
        
        if (type == EProductType.Health)
            return price * 0.3m;
        
        if (type == EProductType.Fashion)
            return price * 0.4m;

        return price;
    }
}