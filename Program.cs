using System;
using System.IO;


namespace CalcNamespace{

    class CalculatorClass{
        
        
        public static void Main(string[] args){
            string value;
            do
            {
                int result;
                int numberOne;
                int numberTwo;
                Console.WriteLine("Whats the first number you want to enter into the operation?");
                string firstNumber = Console.ReadLine();
                try
                {
                    numberOne = Convert.ToInt32(firstNumber);
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong type of input!");
                    throw;
                }

                Console.WriteLine("Whats the first number you want to enter into the operation?");
                string secondNumber = Console.ReadLine();
                try{
                    numberTwo = Convert.ToInt32(secondNumber);
                    
                }
                catch(Exception){
                    Console.WriteLine("Wrong type of input!");
                    throw;
                }
                
                Console.WriteLine("What Operation?");
                string operation = Console.ReadLine();
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
            Console.WriteLine("Do you wish to continue? Y/n");
            value = Console.ReadLine();
            } while (value == "Y" || value =="y");
        }
    }
}