using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello world!!");
                
                Console.WriteLine("Put in a number:");
                var number1 = ConvertKeyInputToInt(Console.ReadLine());

                Console.WriteLine("Put in another number:");
                var number2 = ConvertKeyInputToInt(Console.ReadLine());
                
                Console.WriteLine("Operation:");
                Console.WriteLine("1 - Add");
                Console.WriteLine("2 - Subtract");
                Console.WriteLine("3 - Multiply");
                Console.WriteLine("4 - Divide");
                var operation = Console.ReadLine();

                var result = new CalcIt(number1, number2, operation).Calc();

                Console.WriteLine($"Result: {result}");

            }
            catch(Exception ex)
            {
                Console.WriteLine($"That ain't no number!! - {ex.Message}");
                Console.WriteLine("Outta here...");
                
            }
            Console.WriteLine();
            Console.WriteLine($"press to exit...");
            Console.ReadLine();
        }

        private static int ConvertKeyInputToInt(string userKeyboardInput)
        {
            if (!int.TryParse(userKeyboardInput, out int convertedNum))
            {
                throw new Exception("Non-numeric input");
            }
            return convertedNum;
        }
    }

    public class CalcIt
    {
        private readonly int _num1;
        private readonly int _num2;
        private readonly string _oper;

        public CalcIt(int num1, int num2, string oper)
        {
            _num1 = num1;
            _num2 = num2;
            _oper = oper;
        }

        public double Calc()
        {
            double result;

            switch (_oper)
            {
                case "1":
                    result = Add();
                    break;
                case "2":
                    result = Subtract();
                    break;
                case "3":
                    result = Multiply();
                    break;
                case "4":
                    result = Divide();
                    break;
                default:
                    throw new InvalidOperationException("Invalid operation selected!");
            }
            return result;
        }

        private double Add()
        {
            return (_num1 + _num2);
        }
        private double Subtract()
        {
            return (_num1 - _num2);
        }
        private double Multiply()
        {
            return (_num1 * _num2);
        }
        private double Divide()
        {
            if (_num2 == 0)
            {
                return 0.0;
            }
            return (_num1 / _num2);
        }
    }
}
