namespace NeedForSpeed
{
    public class Vehicle
    {
        public int HorsePower { get; set; }

        public double Fuel { get; set; }

        public double DefaultFuelConsumption { get; set; }

        public double FuelConsumption { get; set; }

        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;

            this.DefaultFuelConsumption = 1.25;
            this.FuelConsumption = DefaultFuelConsumption;
        }

        public virtual void Drive(double kilometers)
        {
            Fuel -= FuelConsumption * kilometers;
        }
    }
}
