using System;

namespace Calculator
{
    class Program
   {
        static void Main(string[] args)
         {
            Console.WriteLine("================Simple Calculator=================");
            for (int i = 0; i < 1; i--)
            {
                Console.WriteLine("Enter the first number: ");
                decimal num1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter the second number: ");
                decimal num2 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter the operator (+,/,*,-): ");
                string op = Console.ReadLine();

                switch (op)
                {
                    case "+":
                        Console.WriteLine("The result is " + num1 + num2);
                        break;
                    case "-":
                        Console.WriteLine("The result is " + (num1 - num2));
                        break;
                    case "*":
                        Console.WriteLine("The result is " + num1 * num2);
                        break;
                    case "/":
                        Console.WriteLine("The result is " + num1 / num2);
                        break;
                    default:
                        Console.WriteLine("Please enter the shown operators only");
                        break;
                }
                Console.WriteLine("Do you want to continue?(y/n)");
                char res =Convert.ToChar(Console.ReadLine());
                if (res == 'y')
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("===============Thank you for using this program===========");
                    System.Environment.Exit(0);
                }
            }
            Console.ReadLine();
        }
    }
  
}
