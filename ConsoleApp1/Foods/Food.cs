namespace ConsoleApp1.Foods
{
    public class Food
    {
        public int Weight { get; set; }
        public TypesOfFood FoodType { get;}
        public Food()
        {

        }
        public Food(int weight,TypesOfFood typesOfFood)
        {
            this.Weight = weight;
            this.FoodType = typesOfFood;
        }

    }
}
