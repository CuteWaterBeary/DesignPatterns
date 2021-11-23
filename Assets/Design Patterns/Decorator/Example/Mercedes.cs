//-------------------------------------------------------------------------------------
//	DecoratorPatternExample2.cs
//-------------------------------------------------------------------------------------

namespace DesignPatterns.Decorator
{
    public class Mercedes : ICar
    {
        public string GetDescription()
        {
            return "Mercedes Benz";
        }

        public double GetCost()
        {
            return 1000;
        }
    }
}