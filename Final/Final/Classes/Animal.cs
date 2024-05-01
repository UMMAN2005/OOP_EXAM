namespace Final.Classes
{
    internal abstract class Animal
    {

        protected enum SkinColor
        {
            Black,
            White,
            Grey,
        }

        protected readonly byte _age;
        protected readonly SkinColor _skinColor;
        protected int Calories { get; set; }

        public Animal()
        {
            Random random = new();
            _age = (byte)random.Next(1, 100);
            _skinColor = (SkinColor)random.Next(0, 3);
            Calories = random.Next(500, 1000);
        }

        protected abstract void Talk();

        protected void Sleep(int hours)
        {
            Calories += hours * 20;
        }

        protected void Eat(int calories)
        {
            Calories += calories;
        }


    }
}
