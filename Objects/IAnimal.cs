using System;

namespace PrototypePatternExample.Objects
{
    public interface IAnimal : ICloneable
    {
        public string Name { get; set; }
        public string Type { get; set; }
        
    }
}