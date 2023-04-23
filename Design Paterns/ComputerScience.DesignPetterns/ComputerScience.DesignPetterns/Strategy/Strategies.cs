using System.Threading.Channels;

namespace ComputerScience.DesignPeterns.Strategy;

public class Strategies
{
    public class FirstStrategy : IStrategy
    {
        public void Run()
        {
            Console.WriteLine("First strategy - Invoked");
        }
    }
    
    
    public class SecondStrategy : IStrategy
    {
        public void Run()
        {
            Console.WriteLine("Second strategy - Invoked");
        }
    }
    
    
    public class ThirdStrategy : IStrategy
    {
        public void Run()
        {
            Console.WriteLine("Third strategy - Invoked");
        }
    }
}