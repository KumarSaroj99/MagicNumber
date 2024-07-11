using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of circle : ");
            int radius = Convert.ToInt32(Console.ReadLine());

            float pi = 3.14f;            //magic number
            Console.WriteLine("Area of circle is : "+2*pi*radius);
        }
    }
}
