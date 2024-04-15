namespace first_class
{
    internal class Program
    {
        static void Main()
        {
            Dog dog1 = new Dog();
            Dog pomen = new Dog();

            dog1.name = "Pomen";
            dog1.breed = "Ulichna prevyzhodna";
            dog1.age = 2;
            dog1.weight = 7.78;
            dog1.CanBark();


            pomen.name = "4erev";
            pomen.age = 6;
            pomen.breed = "Ulichna prevyzhodna";

            pomen.CanBark();

            Console.WriteLine("Happy Birthday " +pomen.GrowUp());

        }
    }
}
