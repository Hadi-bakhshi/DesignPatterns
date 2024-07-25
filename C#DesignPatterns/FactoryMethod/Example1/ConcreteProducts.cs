namespace C_DesignPatterns.FactoryMethod.Example1;

public class ConcreteProducts1 : IProduct
{
    public string Operation()
    {
        return "{Result of ConcreteProduct1}";
    }
}
public class ConcreteProducts2 : IProduct
{
    public string Operation()
    {
        return "{Result of ConcreteProduct2}";
    }
}
