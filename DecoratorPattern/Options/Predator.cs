namespace DecoratorPattern
{
    class Predator : IAnimal
    {
        private readonly IAnimal animal;

        public Predator(IAnimal animal)
        {
            this.animal = animal;
        }

        public string Description()
        {
            return animal.Description() + ", hunts and eats meat";
        }
    }
}
