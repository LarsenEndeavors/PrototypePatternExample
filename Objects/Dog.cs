using System;

namespace PrototypePatternExample.Objects
{
    public class Dog : IAnimal
    {
        public Dog()
        {
            Console.WriteLine("Dog made!");
        }

        public object Clone()
        {
            Console.WriteLine("Dog is being cloned!");

            var dog = new Dog
            {
                Name = Name,
                Type = Type
            };

            return dog;

        }

        public string Name { get; set; }
        public string Type { get; set; }
    }
}