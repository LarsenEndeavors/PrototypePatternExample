using System;

namespace PrototypePatternExample.Objects
{
    public class Sheep : IAnimal
    {
        public Sheep()
        {
            Console.WriteLine("Sheep Made!");
        }

        public object Clone()
        {
            Console.WriteLine("Sheep being made!");
            return new Sheep
            {
                Name = Name,
                Type = Type
            };
        }

        public string Name { get; set; }
        public string Type { get; set; }
    }
}