namespace ConsoleApp1.ImplementStrategy_DesignPattern_
{
    class StrategyB : IStrategy
    {
        public double HowToAnimalHungry(double a)
        {
            return a - 0.05;
        }
    }
}
