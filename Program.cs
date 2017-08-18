using System;

namespace GettersSetters
{
    class Program
    {
        static void Main(string[] args)
        {

            var guest = new Person();

            guest.Age = 22;

            Console.WriteLine("There age is " + guest.Age + " can this person drink: " + guest.CanDrink);
            

            Console.WriteLine("Hello World!");
        }
    }
}
