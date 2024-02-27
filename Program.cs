using ConsoleAppAnimalSounds.Animals;

namespace ConsoleAppAnimalSounds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>
            {
                new Dog(),
                new Cat(),
                new Cow()
            };

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.Type} makes sound: {animal.MakeSound()}");
            }
        }
    }
}
