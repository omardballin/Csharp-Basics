using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics
{
    class Program
    {
        public static object Definitions { get; private set; }

        static void Main(string[] args)
        {
            byte sample1 = 0x3A;

            byte sample2 = 58;

            int heartRate = 58;

            double deposits = 135002796;

            float acceleration = 9.800f;

            float mass = 14.6f;

            double distance = 129.763001;

            bool lost = true;

            int choice = 2;

            bool expensive = true;

            const char integral = '\u222B';

            const string greeting = ("Hello");

            string name = ("Karen");

            var force = mass * acceleration;

            int age = 0;

            if (sample1 == sample2)
            {
                Console.WriteLine("The samples are equal");
            } else
            {
                Console.WriteLine("The Samples are not equal");
            }
            if (heartRate >= 40 && heartRate <= 80)
            {
                Console.WriteLine("Heart rate is normal");
            } else
            {
                Console.WriteLine("Heart rate is not normal");
            }
            if (deposits >= 100000000)
            {
                Console.WriteLine("You are exceedingly wealthy");
            } else
            {
                Console.WriteLine("Sorry, you are so poor");
            }
            Console.WriteLine("force = " + force);
            Console.WriteLine(distance + " is the distnce");

            if (lost == true && expensive == true)
            {
                Console.WriteLine("I am really sorry! I will get the manager.");
            } else if (lost == true && expensive == false)
            {
                Console.WriteLine("Here is a coupon for 10% off");
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("You chose 1");
                    break; /* optional */
                case 2:
                    Console.WriteLine("You chose 2");
                    break; /* optional */
                case 3:
                    Console.WriteLine("You chose 3");
                    break; /* optional */
                
                default: /* Optional */
                    Console.WriteLine("You made an unkown choice");
                    break;

            }

            Console.WriteLine(integral + " is an integral");

             for (int i = 5; i < 11; i++)
            {
                Console.WriteLine(i);
            }
            while (age < 6) {
                Console.WriteLine("age = " + age);
                age++;
              }

            Console.WriteLine(greeting + " " + name + ", " + " welcome back!");
            Console.ReadLine();
            }
        }
    }
