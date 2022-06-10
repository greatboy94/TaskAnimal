using System;


namespace TaskAnimal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Animal[] animal = new Animal[3];

            animal[0] = new Dog("Food for Dog", "Home");
            animal[1] = new Cat("Food for Cat", "Street");
            animal[2] = new Horse("Food for Horse", "Field");
            

            foreach (var el in animal)
            {
                Treat.TreatAnimal(el);
            }
        }
    }
}