using System;
namespace Lab2_1
{
    class Class1
    {
        static void Main()
        {

            double a = 3;
            double b = 6;
            double dx = 0.05;
            double x = a;
            double y = 0;

            while (x < b)
            {
                y = Math.Pow(2.71, Math.Sqrt(2 * x)) * x * x;


                Console.WriteLine("x = " + x + "  " + "y = " + y);



                x += dx;
            }


        }

    }
}
