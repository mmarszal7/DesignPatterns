namespace StrategyPattern
{
    public class Cat : Animal
    {
        public Cat()
        {
            Sound = new Meow();
        }
    }
}
