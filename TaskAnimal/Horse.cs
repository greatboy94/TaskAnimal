using System;

namespace TaskAnimal
{
    public class Horse: Animal
    {
        private string name { get; set; }
        
        public Horse()
        {
            
        }

        public Horse(string food, string location) : base(food, location)
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

