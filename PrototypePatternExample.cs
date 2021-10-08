using System;
using PrototypePatternExample.Objects;

namespace PrototypePatternExample
{
    internal static class PrototypePatternExample
    {
        /*
         * The majority of this code is mocked or directly taken from the Derek Banas YouTube series in
         * an effort to teach myself and get familiar with these patterns.  None of this is meant to be
         * original content, and if you see this and wonder why it's in my repo, mostly it's for me, but
         * I'm happy that you're here and here's proof that I have at least heard of this particular
         * pattern!
         *
         * Author: Nicholas Larsen
         * Date: 2021/10/07
         */
        private static void Main()
        {
            //Here we can see a simple version of the prototype pattern
            var cloneFactory = new CloneFactory();
            // Make sally
            var sally = new Sheep { Name = "Sally", Type = "Jenny" };
            // Copy sally here
            var dolly = cloneFactory.GetClone(sally);

            Console.WriteLine(sally.Name);
            Console.WriteLine(dolly.Name);

            // If dolly were a simple reference to sally, this would change both names
            dolly.Name = "Dolly";
            
            // Since it's a full copy, dolly is its own object.
            Console.WriteLine(sally.Name);
            Console.WriteLine(dolly.Name);
        }
    }
}