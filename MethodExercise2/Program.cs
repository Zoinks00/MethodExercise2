using System;

namespace MethodExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1  = 0;
            int num2 = 0;
            int sumAdd = 0;
            int sumSub = 0;
            int sumMulti = 0;
            int sumDiv = 0;
            //int num3 = 0;
            //int num4 = 0;

            Console.WriteLine($"Enter a value for your first number.");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value for your second number.");
            num2 = Convert.ToInt32(Console.ReadLine());

            sumAdd = Add(num1, num2);
            sumSub = Sub(num1, num2);
            sumMulti = Multiply(num1, num2);
            sumDiv = Divide(num1, num2);


            Console.WriteLine($"The result of {num1} and {num2} when added is {sumAdd}.");
            Console.WriteLine($"The result of {num1} and {num2} when subtracted is {sumSub}.");
            Console.WriteLine($"The result of {num1} and {num2} when multipled is {sumMulti}.");
            Console.WriteLine($"The result of {num1} and {num2} when divided is  {sumDiv}.");
        }

        public static int Add(int n1, int n2)
        {
            int Sum = n1 + n2;
            return Sum;
        }

        public static int Sub(int n1, int n2)
        {
            int Sum = n1 - n2;
            return Sum;
        }

        public static int Multiply(int n1, int n2)
        {
            int Sum = n1 * n2;
            return Sum;
        }

        public static int Divide(int n1, int n2)
        {
            
            int Sum = n1 / n2;
            return Sum;
        }
    }
}
