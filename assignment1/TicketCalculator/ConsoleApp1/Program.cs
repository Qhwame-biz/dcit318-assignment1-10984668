namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            int ticketPrice;

            if (age <= 12 || age >= 65)
            {
                ticketPrice = 7;
            }
            else
            {
                ticketPrice = 10;
            }

            Console.WriteLine("The ticket price is GHC" + ticketPrice);

        }
    }
}
