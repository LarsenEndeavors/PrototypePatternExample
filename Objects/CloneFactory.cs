namespace PrototypePatternExample.Objects
{
    public class CloneFactory
    {
        public IAnimal GetClone(IAnimal animalSample)
        {
            return (IAnimal)animalSample.Clone();
        }
    }
}