using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calendar;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool a = true;
            CalendarPro cc = new CalendarPro();
            
            
            do
            {
 
                double num1, num2;
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Mudulas");
                Console.WriteLine("6. Factorial");
                Console.WriteLine("7. Exit System()");
                Console.WriteLine("Enter The Option:");
                n = Convert.ToInt16(Console.ReadLine());
                switch (n) {
                    case 1:
                        Console.WriteLine("Enter Two Number to Addtion");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Your Result {num1} + {num2} is {Addition(num1,num2)}");
                        break;
                    case 2:
                        Console.WriteLine("Enter Two Number to Subtraction");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Your Result {num1} - {num2} is {subtraction((int)num1, (int)num2)}");
                        break;
                    case 3:
                        Console.WriteLine("Enter Two Number to Multiply");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Your Result {num1} x {num2} is {multiplay(num1, num2)}");
                        break;
                    case 4:
                        Console.WriteLine("Enter Two Number to Division");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Your Result {num1} / {num2} is {Division(num1, num2)}");
                        break;
                    case 5:
                        Console.WriteLine("Enter Two Number to Mudulas");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Your Result {num1} % {num2} is {Mod((int)num1, (int)num2)}");
                        break;
                    case 6:
                        Console.WriteLine("Enter a number to find factorial");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Factorial of {num1}! is {factorial((int)num1)}");
                        break;
                    case 7:
                        a = false;
                        break;
                    
                    default:
                        Console.WriteLine("Please Enter Valid key");
                        break;
                }

            } while (a);
        }
        
        private static double Addition(double a, double b)
        {
            return a + b;
        }
        private static double subtraction(int a,int b)
        {
            return a - b;
        }
        private static Double multiplay(double a, double b)
        {
            return a * b;
        }
        private static double Division(double a, double b)
        {
            return a / b;            
        }
        private static int factorial(int n)
        {
            if (n <= 1)
                return n;
            return n * factorial(n - 1);
        }
        private static int Mod(int a,int b)
        {
            return a % b;
        }
    }
}
