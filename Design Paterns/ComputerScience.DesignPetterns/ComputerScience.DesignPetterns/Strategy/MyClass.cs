namespace ComputerScience.DesignPeterns.Strategy;

public class MyClass : IStrategy
{
    public MyClass(IStrategy strategy)
    {
        _strategy = strategy;
    }
    
    
    private IStrategy _strategy = null;

    
    
    public void SetStrategy(IStrategy strategy) => _strategy = strategy;
    
    
    public void Run()
    {
        _strategy.Run();
    }
}