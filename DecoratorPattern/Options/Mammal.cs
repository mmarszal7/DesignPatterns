namespace DecoratorPattern
{
    class Mammal : IAnimal
    {
        private readonly IAnimal animal;

        public Mammal(IAnimal animal)
        {
            this.animal = animal;
        }

        public string Description()
        {
            return animal.Description() + ", mammal";
        }
    }
}
