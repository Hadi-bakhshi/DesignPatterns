namespace C_DesignPatterns.FactoryMethod.Example1;

class ConcreteCreators1 : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProducts1();
    }
}
class ConcreteCreators2 : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProducts2();
    }
}
