using UnityEngine;

namespace DesignPatterns.Decorator
{
    public class AutomaticCar : Decorator
    {
        public AutomaticCar(ICar newPizza) : base(newPizza)
        {
            Debug.Log("Automatic car");
        }

        public override string GetDescription()
        {
            return tempCar.GetDescription() + ", Automatic car";
        }

        public override double GetCost()
        {
            return tempCar.GetCost() + 10000;
        }
    }
}