namespace ConsoleApp1.ImplementStrategy_DesignPattern_
{
    class StrategyA : IStrategy
    {
        public double HowToAnimalHungry(double a)
        {
            return a - 0.3;
        }
    }
}
