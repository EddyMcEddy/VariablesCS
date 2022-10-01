using System;
using System.Collections.Generic;

namespace PracticeHere
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Bonjour, How many cups of coffee do you drink everyday?: ");
            double numberOfCupsOfCoffee = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(
                $"Awesome, thank you for telling me that you drink {numberOfCupsOfCoffee} cups of coffee!!!"
            );
            Console.WriteLine();
            Console.Write($"Now, may I have your name?");
            var fullName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(
                $"Awesome, what a beautiful name that is {fullName}! It has a ring to it. "
            );
            var today = DateTime.Now;
            Console.WriteLine();

            Console.WriteLine(
                $"So {fullName} thank you for answering a few questions on {today}. It is amazing to know that you drink {numberOfCupsOfCoffee} cups of coffee!"
            );
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Now let's see how many cups of liquid you drink per day.");
            Console.Write($"How many cups of water do you drink per day?: ");
            double userCupsOfWater = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(
                $"You drink {numberOfCupsOfCoffee} cups of coffee and {userCupsOfWater} cups of water."
            );
            var sum = numberOfCupsOfCoffee + userCupsOfWater;
            var quotient = numberOfCupsOfCoffee % userCupsOfWater;
            var product = numberOfCupsOfCoffee * userCupsOfWater;

            Console.WriteLine();

            Console.WriteLine($"in total you drink {sum} amounts of liquid per day!");
            Console.WriteLine(
                $"Or if you want to divide the liquids, you've drank {quotient} of liquids divided"
            );
            Console.WriteLine(
                $"But if you want to get the multiplication of your liquid consumption it would be {product}"
            );
        }
    }
}
