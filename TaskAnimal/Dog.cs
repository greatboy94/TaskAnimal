using System;

namespace TaskAnimal
{
    public class Dog: Animal
    {
        private string name { get; set; }

        public Dog()
        {
            
        }

        public Dog(string food, string location) : base(food, location)
        {
            
        }

        public void MakeNoise()
        {
            Console.WriteLine($"{name} животное спит");
        }

        public void Eat()
        {
            
        }
    }
   
}

