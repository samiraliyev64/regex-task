using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Rectangularin sahesi");
            Console.WriteLine("2. Squarenin sahesi");
            Console.WriteLine("3. Cixish\n");

            int input = Convert.ToInt32(Console.ReadLine());

            Rectangle rectangle = new Rectangle();
            Square square = new Square();

            while (true)
            {
                if (input == 1)
                {
                    Console.Write("Teref 1 : ");
                    rectangle.Side1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Teref 2 : ");
                    rectangle.Side2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n");
                    rectangle.CalcArea();
                    Console.WriteLine("\n");
                    Console.WriteLine("1. Duzbucaqlinin sahesi");
                    Console.WriteLine("2. Kvadratin sahesi");
                    Console.WriteLine("3. Cixish");
                    input = 43423;
                    input = Convert.ToInt32(Console.ReadLine());

                }

                else if (input == 2)
                {
                    Console.Write("Teref : ");
                    square.Side = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n");
                    square.CalcArea();
                    Console.WriteLine("\n");
                    Console.WriteLine("1. Duzbucaqlinin sahesi");
                    Console.WriteLine("2. Kvadratin sahesi");
                    Console.WriteLine("3. Cixish");
                    input = 432423;
                    input = Convert.ToInt32(Console.ReadLine());

                }

                else if (input == 3)
                {
                    Console.WriteLine("program dayandi");
                    break;
                }

                else
                {
                    Console.WriteLine("Duzgun input daxil edin");
                    input = Convert.ToInt32(Console.ReadLine());
                }
            }
            
            
        }
    }
}
