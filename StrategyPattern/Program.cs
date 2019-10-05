namespace StrategyPattern
{
    // Strategy definition
    // Define a family of algorithms (Options/Sounds), encapsulate each one, and make them interchangeable (Sound interface). 
    // Strategy lets the algorithm vary independently from clients that use it.
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            Animal cat = new Cat();

            dog.MakeASound();
            cat.MakeASound();

            System.Console.ReadLine();
        }
    }
}
