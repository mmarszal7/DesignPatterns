namespace DecoratorPattern
{
    // Decorator definition
    // Attach additional responsibilities (Options) to an objects dynamically keeping the same interface (IAnimal). 
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal bat = new Bird(new Predator(new Mammal(new Animal())));
            IAnimal dog = new Predator(new Mammal(new Animal()));
            IAnimal shark = new Predator(new Fish(new Animal()));

            System.Console.WriteLine(bat.Description());
            System.Console.WriteLine(dog.Description());
            System.Console.WriteLine(shark.Description());

            System.Console.ReadLine();
        }
    }
}
