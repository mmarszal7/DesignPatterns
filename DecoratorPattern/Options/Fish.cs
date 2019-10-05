namespace DecoratorPattern
{
    class Fish : IAnimal
    {
        private readonly IAnimal animal;

        public Fish(IAnimal animal)
        {
            this.animal = animal;
        }

        public string Description()
        {
            return animal.Description() + ", can swim";
        }
    }
}
