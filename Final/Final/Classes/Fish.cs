using Final.Interfaces;

namespace Final.Classes
{
    internal class Fish : Animal, ISwim
    {
        private byte Size { get; set; }

        public Fish() { }

        public void Swim(int hours)
        {
            Calories -= hours * Size;
        }

        protected override void Talk()
        {
            Console.WriteLine("…");
        }
    }
}
