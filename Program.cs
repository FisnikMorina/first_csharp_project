using System;
using System.IO;


namespace CalcNamespace{

    class CalculatorClass{
        
        
        public static void Main(string[] args){
            string firstNumber;
            string secondNumber;
            string operation;
            int result;
            Console.WriteLine("Whats the first number you want to enter into the operation?");
            firstNumber = Console.ReadLine();
            int numberOne = Convert.ToInt32(firstNumber);
            Console.WriteLine("Whats the first number you want to enter into the operation?");
            secondNumber = Console.ReadLine();
            int numberTwo = Convert.ToInt32(secondNumber);
            Console.WriteLine("What Operation?");
            operation = Console.ReadLine();
            switch (operation){
                case "+":
                result = numberOne + numberTwo;
                Console.WriteLine($"Result: {result}");
                break;

                case "-":
                result = numberOne - numberTwo;
                Console.WriteLine($"Result: {result}");
                break;

                case "/":
                result = numberOne / numberTwo;
                Console.WriteLine($"Result: {result}");
                break;

                case "*":
                result = numberOne * numberTwo;
                Console.WriteLine($"Result: {result}");
                break;

                default:
                Console.WriteLine("Wrongggg");
                break;
            }
        }
    }
}