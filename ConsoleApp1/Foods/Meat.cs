namespace ConsoleApp1.Foods
{
    class Meat : Food
    {
        public override string ToString()
        {
            return "Meat";
        }
        public Meat(int weight)
        {
            this.Weight = weight;
        }
        public Meat()
        {

        }
    }
}
