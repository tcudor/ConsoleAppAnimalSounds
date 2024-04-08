using ConsoleAppAnimalSounds.Animals.Base;

namespace ConsoleAppAnimalSounds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BaseAnimal> animals =
            [
                new Dog(),
                new Cat(),
                new Cow()
            ];

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.AnimalType()} makes sound: {animal.MakeSound()}");
            }
        }
    }
}
