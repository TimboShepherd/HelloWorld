using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                
                var result = new AddIt(number1, number2).Add();

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

    public class AddIt
    {
        private int Num1;
        private int Num2;

        public AddIt(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }
        public int Add()
        {
            return (Num1 + Num2);
        }
    }
}
