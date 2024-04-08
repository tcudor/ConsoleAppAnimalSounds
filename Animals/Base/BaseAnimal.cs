namespace ConsoleAppAnimalSounds.Animals.Base
{
    public abstract class BaseAnimal : IBaseAnimal
    {
        public string AnimalType()
        {
            return GetType().Name;
        }
        public abstract string MakeSound();
    }
}
