using System;

namespace VariablesCS
{
  class Program
  {
    static void Main(string[] args)
    {
      //practice creating variables
      string numberOfCupsOfCoffee = "2";
      string fullName = "Eddy Huapaya";
      var today = DateTime.Now; 
      Console.WriteLine(" My name is " + fullName + " And usually today at this time " + today + " I drink about " + numberOfCupsOfCoffee + " cups of coffee ");

      //practice getting input from user 
      Console.WriteLine("What is your name?");
      string userName = Console.ReadLine();
      string greeting = "Bonjour, how are you " + userName + " ?";
      Console.WriteLine(greeting);
      
      //practice getting different types of input from user
      Console.WriteLine("What is your favorite lucky number?");
      string firstNumberAsString = Console.ReadLine();
      Console.WriteLine("Cool, Thanks what is your second favorite lucky number?");
      string secondNumberAsString = Console.ReadLine();
      Console.WriteLine("Thank you " + userName + " we appreciate it");

      //Converting String Input Into Numbers
      var firstOperand = double.Parse(firstNumberAsString);
      var secondOperand = double.Parse(secondNumberAsString);
      var sum = firstOperand + secondOperand;
      Console.WriteLine("Great we added your favorite lucky numbers " + sum);


    
          }
  }
}
