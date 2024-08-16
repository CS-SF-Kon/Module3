namespace Module3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName;
            byte myAge;
            bool pet;
            float shoeSize;
            myName = "Slavik";
            myAge = 30;
            pet = true;
            shoeSize = 42.5F;

            
            Console.WriteLine($"My name is {myName}");
            Console.WriteLine($"My age is {myAge}");
            Console.WriteLine($"Do i have a pet? {pet}");
            Console.WriteLine($"My shoe size is {shoeSize}");

            Console.ReadKey();
        }
    }
}
