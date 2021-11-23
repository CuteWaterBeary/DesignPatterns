//-------------------------------------------------------------------------------------
//	DecoratorPatternExample2.cs
//-------------------------------------------------------------------------------------

using UnityEngine;

namespace DesignPatterns.Decorator
{
    public class DecoratorPatternExample : MonoBehaviour
    {
        void Start()
        {
            // Make Pizzas:
            ICar car = new AutomaticCar(new Sunroof(new Mercedes()));
            Debug.Log(car.GetDescription());
            Debug.Log("Total Cost: " + car.GetCost());
        }
    }
}