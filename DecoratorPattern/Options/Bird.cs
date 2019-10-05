namespace DecoratorPattern
{
    class Bird : IAnimal
    {
        private readonly IAnimal animal;

        public Bird(IAnimal animal)
        {
            this.animal = animal;
        }

        public string Description()
        {
            return animal.Description() + ", flys";
        }
    }
}
