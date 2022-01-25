namespace ConsoleApp1.Foods
{
    class Banana : Food
    {
        public override string ToString()
        {
            return "Banana";
        }
        public Banana(int weight)
        {
            this.Weight = weight;
        }
        public Banana()
        {

        }
    }
}
