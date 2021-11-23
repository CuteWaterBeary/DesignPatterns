using UnityEngine;

namespace DesignPatterns.Decorator
{
    public class Sunroof : Decorator
    {
        public Sunroof(ICar car) : base(car)
        {
            Debug.Log("Adding sun roof");
        }

        public override string GetDescription()
        {
            return tempCar.GetDescription() + ", sunroof";
        }

        public override double GetCost()
        {
            return tempCar.GetCost() + 10000;
        }
    }
}