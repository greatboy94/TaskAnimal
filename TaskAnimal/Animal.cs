using System;

namespace TaskAnimal
{
    public class Animal
    {
        private string food;
        private string location;

        public Animal()
        {
            
        }

        public Animal(string food, string location)
        {
            this.food = food;
            this.location = location;
        }
        
        public void MakeNoise()
        {
            Console.WriteLine();
        }

        public void Eat()
        {
            
        }

        public void Sleep()
        {
            
        }

        public override string ToString()
        {
            return $"{food},{location}";
        }
    }
}

