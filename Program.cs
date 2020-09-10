using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Assignment1_Calculator_
{
    class Program
    {
        static void Main(string[] args)
        {
            string oper = "";
            double result = 0;
            bool runMenu = true;
            char usrChoice = 'y';

            Console.Write("Enter a number:");
            result = Convert.ToDouble(Console.ReadLine());

            while (runMenu)
            {
                Console.Write("Choose an operator (+,-,*,/,=):");
                oper = Console.ReadLine();

                switch (oper)
                {
                    case "+": 
                        result=Add(result);
                        break;

                    case "-":
                        result=Sub(result);
                        break;

                    case "*":
                        result=Mul(result);
                        break;

                    case "/":
                        result=Div(result);
                        break;
                    case "=":
                        DisplayResult(result);
                        Console.Write("Do you want to cont...(y/n):");
                        usrChoice = Convert.ToChar(Console.ReadLine());
                        if (usrChoice == 'n')
                        {
                            runMenu = false;
                        }
                        else
                        {
                            Console.Clear();
                            result = 0;
                            Console.Write("Enter a number:");
                            result = Convert.ToDouble(Console.ReadLine());
                            runMenu = true;
                        }
                        break;
                }
                
                             
            }

           


        }  
        static double Add(double result)
        {
            double num2;
            Console.Write("Enter a number:");
            num2 = Convert.ToDouble(Console.ReadLine());
            return result + num2;

        }

        static double Sub(double result)
        {
            double num2;
            Console.Write("Enter a number:");
            num2 = Convert.ToDouble(Console.ReadLine());
            return result - num2;
        }

        static double Mul(double result)
        {
            double num2;
            Console.Write("Enter a number:");
            num2 = Convert.ToDouble(Console.ReadLine());
            return result * num2;

        }

        static double Div(double result)
        {
            double num2;
            Console.Write("Enter a number:");
            num2 = Convert.ToDouble(Console.ReadLine());
            return result / num2;

        }

        static void DisplayResult(double result)
        {
            Console.WriteLine("Result=" + result);

        }


    }
}
