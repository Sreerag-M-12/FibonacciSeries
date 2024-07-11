using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static float PI = 3.14f;
        static void Main(string[] args)
        {


            Console.BackgroundColor = ConsoleColor.DarkRed;
           

            Console.WriteLine("Enter number for fibonacci");
            int fibNumber = Convert.ToInt32(Console.ReadLine());
            int fib0 = 0, fib1 = 1, fibFinal;
            if (fibNumber == 0)
                Console.WriteLine(fib0);
            else if (fibNumber == 1)
                Console.WriteLine(fib0 + " " + fib1);
            else
            {
                int i = 0;
                while (i < fibNumber)
                {
                    fibFinal = fib0 + fib1;
                    Console.Write(fib0 + " ");
                    fib0 = fib1;
                    fib1 = fibFinal;
                    i++;
                }
            }

            //Magic number
            Console.WriteLine("Enter radius");
            float radius = Convert.ToSingle(Console.ReadLine());
            float circleArea = PI * radius * radius;
            float sphereVolume = PI * radius * radius * radius;
            Console.WriteLine("area of circle is " + circleArea + " squnit");

            Console.WriteLine("volume of sphere is " + sphereVolume + " cuunit");

            //arguments

            Console.WriteLine("The numbers are" + args[0] + " " + args[1] + " " + args[2] + " " + args[3] + " " + args[4]);

            int[] argument = new int[5];
            int sum = 0;
            for (int i = 0; i < argument.Length; i++)
            {
                argument[i] = Convert.ToInt32(args[i]);
                sum = sum + argument[i];
            }
            int average = sum / 5;

            int max = 0, min = argument[0];
            for (int i = 0; i < argument.Length; i++)
            {
                if (argument[i] > max)
                    max = argument[i];
                if (argument[i] < min)
                    min = argument[i];

            }

            Console.WriteLine("SUM of argument series is " + sum);
            Console.WriteLine("AVG of argument series is " + average);
            Console.WriteLine("MAX number in argument series is " + max);

        }

    }

}

