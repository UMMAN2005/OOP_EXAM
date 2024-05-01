using Final.Interfaces;

namespace Final.Classes
{
    internal class Dog : Animal, IWalk
    {
        private readonly int _speed;

        public Dog()
        {
            Random random = new();
            _speed = random.Next(10, 20);
        }

        protected override void Talk()
        {
            Console.WriteLine("Woof!");
        }

        public void Walk(int hours)
        {
            Calories -= hours * _speed / 2;
        }
    }
}
