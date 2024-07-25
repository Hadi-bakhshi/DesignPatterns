namespace C_DesignPatterns.FactoryMethod.Example1;

class Client
{
    public void Main()
    {
        Console.WriteLine("App: Launched with the ConcreteCreator1.");
        ClientCode(new ConcreteCreators1());

        Console.WriteLine("");

        Console.WriteLine("App: Launched with the ConcreteCreator2.");
        ClientCode(new ConcreteCreators2());
    }
    public void ClientCode(Creator creator)
    {
     
        Console.WriteLine("Client: I'm not aware of the creator's class," +
            "but it still works.\n" + creator.SomeOperation());
       
    }
}
