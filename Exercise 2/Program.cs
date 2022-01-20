using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog(Dog.Breed.Chihuahua, Animal.Type.mammal);
            Console.WriteLine(dog.Info());
            Console.WriteLine($"Sound: {dog.Sound()}");

            Animal cat = new Cat(Cat.Climb.tree, Animal.Type.bird);
            Console.WriteLine(cat.Info());
            Console.WriteLine($"Sound: {cat.Sound()}");

            Animal duck = new Duck(Duck.Swim.pond, Animal.Type.bird);
            Console.WriteLine(duck.Info());
            Console.WriteLine($"Sound: {duck.Sound()}");
        }
    }
}
