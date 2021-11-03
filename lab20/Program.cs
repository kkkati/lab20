using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab20
{
    class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            double r = double.Parse(Console.ReadLine());
            MyDelegate myDelegateLength = Length; 
            if (myDelegateLength!=null)
            {
                double length = myDelegateLength(r);
                Console.WriteLine("Длина окружности: {0}", length);
            }
            MyDelegate myDelegateSquare = Square;
            if (myDelegateSquare != null)
            {
                double square = myDelegateSquare(r);
                Console.WriteLine("Площадь окружности: {0}", square);
            }
            MyDelegate myDelegateVolume = Volume;
            if (myDelegateVolume != null)
            {
                double volume = myDelegateVolume(r);
                Console.WriteLine("Объем шара: {0}", volume);
            }
            Console.ReadKey();
        }
        static double Length(double r)
        {
            return 2 * Math.PI * r;
        }
        static double Square(double r)
        {
            return Math.PI * Math.Pow(r,2);
        }
        static double Volume(double r)
        {
            return (4/3)* Math.PI * Math.Pow(r, 3);
        }
    }
}
