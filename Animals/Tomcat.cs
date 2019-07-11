namespace Animals
{
    public class Tomcat : Cat
    {
        private const string tomGender = "Male";

        public Tomcat(string name, int age, string gender) 
            : base(name, age, gender)
        {
            Gender = tomGender;
        }

        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
