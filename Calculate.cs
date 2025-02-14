using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    /// <summary>
    /// класс, описывающий вычисления
    /// </summary>
    class Calculate
    {
        /// <summary>
        /// поля
        /// </summary>
        private double value1;
        private double value2;

        public double Value1
        {
            get => value1;
            set
            {
                if (value < 0) 
                    throw new ArgumentException("Value1 cannot be negative");
                value1 = value;
            }
        }

        public double Value2
        {
            get => value2;
            set
            {
                if (value < 0)  
                    throw new ArgumentException("Value2 cannot be negative");
                value2 = value;
            }
        }

        /// <summary>
        /// конструктор без параметров
        /// </summary>
        public Calculate()
        {

        }

        /// <summary>
        /// конструктор с одним параметром
        /// </summary>
        /// <param name="value1"></param>
        public Calculate(double value1)
        {
            this.Value1 = value1;
        }
        /// <summary>
        /// конструктор с двумя параметрами
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        public Calculate(double value1, double value2) :this(value1)
        {
            this.Value2 = value2;
        }
        /// <summary>
        /// метод, вычисляющий корень квадратный из произведенеия двух чисел
        /// </summary>
        /// <returns></returns>
        public double CalculateSquareRoot()
        {
            return Math.Sqrt(Value1 * Value2);
        }

        /// <summary>
        /// переопределние метода ToString
        /// </summary>
        /// <returns></returns>
        
        public override string ToString()
        {
            return $"value1 = {Value1}, value2 = {Value2}";
        }

        public void ShowInfo()
        {
            Console.WriteLine($"value1 = {Value1}, value2 = {Value2}");
        }
    }
}
