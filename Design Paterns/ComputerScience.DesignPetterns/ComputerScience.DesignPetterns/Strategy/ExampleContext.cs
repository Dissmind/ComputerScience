namespace ComputerScience.DesignPeterns.Strategy;

public class ExampleContext
{
    public static void Context()
    {
        var strategy = new Strategies.FirstStrategy();
        var myClass = new MyClass(strategy);
        
        myClass.Run(); // First strategy invoked
        
        myClass.SetStrategy(new Strategies.SecondStrategy());
        myClass.Run(); // Second strategy invoked
    }
}