namespace Restaurant
{
    public class Beverage : Product
    {
        public double Millilitres { get; set; }

        public Beverage(string name, decimal price, double millilitres)
            :base(name, price)
        {
            this.Millilitres = millilitres;
        }
    }
}
