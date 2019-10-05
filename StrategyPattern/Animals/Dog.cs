namespace StrategyPattern
{
    public class Dog : Animal
    {
        public Dog()
        {
            Sound = new Bark();
        }
    }
}
