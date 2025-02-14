using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            // объект без явной инициализации
            var calc1 = new Calculate();
            calc1.Value1 = 12.21;
            calc1.Value2 = 4.2;
            Console.WriteLine($"объект н1:{calc1.ToString()}");

            // объект с явной инициализацией
            var calc2 = new Calculate(1.32, 2.45);
            Console.WriteLine($"объект н2:{calc2.ToString()}");

            // объект с двумя параметрами, введенными с клавиатуры
            Console.Write("введите первое значение: ");
            double value1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("введите второе значение: ");
            double value2 = Convert.ToDouble(Console.ReadLine());
            var userCalc = new Calculate(value1, value2);
            Console.WriteLine($"объект н3:{userCalc.ToString()}");

            Console.WriteLine($"корень квадратный из произведенеия чисел объекта 1: {calc1.CalculateSquareRoot()}");
            Console.WriteLine($"корень квадратный из произведенеия чисел объекта 2: {calc2.CalculateSquareRoot()}");
            Console.WriteLine($"корень квадратный из произведенеия чисел объекта 3: {userCalc.CalculateSquareRoot()}");

            Console.ReadKey();
        }
    }
}
