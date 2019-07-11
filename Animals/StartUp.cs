namespace Animals
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var animals = new List<Animal>();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Beast!")
            {
                var atributes = Console.ReadLine().Split();

                string name = atributes[0];
                int age = int.Parse(atributes[1]);
                string gender = atributes[2];

                switch (command)
                {
                    case "Animal": var animal = new Animal(name, age, gender); AddAnimal(animals, animal); break;
                    case "Cat": var cat = new Cat(name, age, gender); AddAnimal(animals, cat); break;
                    case "Dog": var dog = new Dog(name, age, gender); AddAnimal(animals, dog); break;
                    case "Frog": var frog = new Frog(name, age, gender); AddAnimal(animals, frog); break;
                    case "Kitten": var kitten = new Kitten(name, age, gender); AddAnimal(animals, kitten); break;
                    case "Tomcat": var tomcat = new Tomcat(name, age, gender); AddAnimal(animals, tomcat); break;
                    default:
                        break;
                }               
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetType().Name);
                Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
                Console.WriteLine(animal.ProduceSound());
            }

        }


        private static void AddAnimal(List<Animal> animals, Animal animal)
        {
            animals.Add(animal);
        }
    }
}
