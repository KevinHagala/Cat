using System;

namespace Cat
{
    class Program
    {
        class Cat
        {
            string name;
            string color;
            double hunger;

            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
            }

            public string Name
            {
                get { return name; }
            }

            public string Color
            {
                get { return color; }
            }

            public double Hunger
            {
                get { return hunger; }
            }

            public void Sleep()
            {
                hunger += 0.2;
                Console.WriteLine("zzzz");
            }

            public void ShowCatDetails()
            {
                Console.WriteLine($"Name: {name};\n Color: {color};\n Hunger: {Hunger};\n");
            }
        }
        static void Main(string[] args)
        {
            Cat newCat = new Cat("kiisu", "black");
            while(newCat.Hunger != 1)
            {
                newCat.Sleep();
            }
            Console.WriteLine("Meow-Meow");
            newCat.ShowCatDetails();
        }
    }
}
