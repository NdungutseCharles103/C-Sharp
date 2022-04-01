using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      // Type your username and press enter
      Console.WriteLine("Enter username:");

      // Create a string variable and get user input from the keyboard and store it in the variable
      string userName = Console.ReadLine();

      Console.WriteLine("Enter your gender: ");
      string gender = Console.ReadLine();
      // Print the value of the variable (userName), which will display the input value
      Console.WriteLine("Your Username is: " + userName + "your gender is: " + gender);
    }
  }
}
