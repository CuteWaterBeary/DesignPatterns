namespace DesignPatterns.Decorator
{
    public abstract class Decorator : ICar
    {
        protected ICar tempCar;

        public Decorator(ICar car)
        {
            this.tempCar = car;
        }


        public virtual string GetDescription()
        {
            return tempCar.GetDescription();
        }

        public virtual double GetCost()
        {
            return tempCar.GetCost();
        }
    }
}