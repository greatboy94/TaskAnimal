using System;

namespace TaskAnimal
{
    public class Cat: Animal
    {
        private string name { get; set; }
        
        public Cat()
        {
            
        }

        public Cat(string food, string location) : base(food, location)
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

