namespace StrategyPattern
{
    public class Animal
    {
        protected ISound Sound;

        public string Description()
        {
            return "Living creature";
        }

        public void MakeASound()
        {
            System.Console.WriteLine(Sound.MakeASound());
        }
    }
}
