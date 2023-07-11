namespace Decorator;

public interface ICar
{
    string GetDescription();
    double GetCost();
}

public class EconomyCar : ICar
{
    public string GetDescription()
    {
        return "Economy Car";
    }

    public double GetCost()
    {
        return 450000.0;
    }
}

public class DeluxeCar : ICar
{
    public string GetDescription()
    {
        return "Deluxe Car";
    }

    public double GetCost()
    {
        return 750000.0;
    }
}

public class LuxuryCar : ICar
{
    public string GetDescription()
    {
        return "Luxury Car";
    }

    public double GetCost()
    {
        return 1000000.0;
    }
}

public abstract class CarAccessoriesDecorator : ICar
{
    private ICar _car;

    public CarAccessoriesDecorator(ICar aCar)
    {
        _car = aCar;
    }

    public virtual string GetDescription()
    {
        return _car.GetDescription();
    }

    public virtual double GetCost()
    {
        return _car.GetCost();
    }
}

public class BasicAccessories : CarAccessoriesDecorator
{
    public BasicAccessories(ICar aCar)
        : base(aCar)
    {
    }

    public override string GetDescription()
    {
        return base.GetDescription() + ",Basic Accessories Package";
    }

    public override double GetCost()
    {
        return base.GetCost() + 2000.0;
    }
}

public class AdvancedAccessories : CarAccessoriesDecorator
{
    public AdvancedAccessories(ICar aCar)
        : base(aCar)
    {
    }

    public override string GetDescription()
    {
        return base.GetDescription() + ",Advanced Accessories Package";
    }

    public override double GetCost()
    {
        return base.GetCost() + 10000.0;
    }
}

public class SportsAccessories : CarAccessoriesDecorator
{
    public SportsAccessories(ICar aCar)
        : base(aCar)
    {
    }

    public override string GetDescription()
    {
        return base.GetDescription() + ",Sports Accessories Package";
    }

    public override double GetCost()
    {
        return base.GetCost() + 15000.0;
    }
}

public class SuperLuxury : ICar
{
    public string GetDescription()
    {
        return "Super Luxury Car";
    }

    public double GetCost()
    {
        return 1500000;
    }
}

public class ExtremeSportAccessories : CarAccessoriesDecorator
{
    public ExtremeSportAccessories(ICar aCar)
        : base(aCar)
    {
    }

    public override string GetDescription()
    {
        return base.GetDescription() + ",Extreme Sport Accessories";
    }

    public override double GetCost()
    {
        return base.GetCost() + 25000;
    }
}