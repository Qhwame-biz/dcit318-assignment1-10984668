namespace gradeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome");
 Console.WriteLine(" Please Enter your Score from 0 - 100");
 int Score = Convert.ToInt32(Console.ReadLine());
 if (Score >= 90)
 {
     Console.WriteLine("Your Grade is : A");
 }
 else if (Score <= 89 && Score >= 80)
 {
     Console.WriteLine("Your Grade is : B");

 }
 else if (Score <= 79 && Score >= 70)
 {
     Console.WriteLine("Your Grade is : C");

 }
 else if (Score <= 69 && Score >= 60)
 {
     Console.WriteLine("Your Grade is : D");

 }
 else
 {
     Console.WriteLine("You Fail");
 } 

        }
    }
}
