namespace Restaurant
{
    public class Cake : Dessert
    {
        private const int grams = 250;
        private const int calories = 1000;
        private const int price = 5;

        public Cake(string name)
            :base(name, price, grams, calories)
        {
        }
    }
}
