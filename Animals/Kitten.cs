namespace Animals
{
    class Kitten : Cat
    {
        private const string kittenGender = "Female";

        public Kitten(string name, int age, string gender) 
            : base(name, age, gender)
        {
            Gender = kittenGender;
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
