using Final.Interfaces;

namespace Final.Classes
{
    internal class Reptile : Animal, IWalk, ISwim
    {

        protected enum AnimalType
        {
            Lizard,
            Crocodile,
        }

        private readonly AnimalType _animalType;

        protected override void Talk()
        {
            Console.WriteLine("Ssrr");
        }

        public void Walk(int hours)
        {
            switch (_animalType)
            {
                case AnimalType.Lizard:
                    Calories -= hours * 10;
                    break;
                case AnimalType.Crocodile:
                    Calories -= hours * 15;
                    break;
            }
        }

        public void Swim(int hours)
        {
            switch (_animalType)
            {
                case AnimalType.Lizard:
                    Calories -= hours * 5;
                    break;
                case AnimalType.Crocodile:
                    Calories -= hours * 10;
                    break;
            }
        }
    }
}
