﻿namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        public RaceMotorcycle(int horsePower, double fuel)
            :base(horsePower, fuel)
        {
            FuelConsumption = 8;
            
        }
    }
}
