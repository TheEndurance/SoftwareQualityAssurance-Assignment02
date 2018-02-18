using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static int PrintMenu()
        {
            string userInput = string.Empty;
            int menuSelection = -1;
            Console.Clear();
            Console.WriteLine("1. Enter triangle dimensions");
            Console.WriteLine("2. Exit");

            userInput = Console.ReadLine();
            try
            {
                menuSelection = int.Parse(userInput);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return menuSelection;
        }

        static int[] GetTriangleDimensions()
        {
            int[] triangleLengths = new int[3];
            for (int i = 0; i < 3; i++)
            {
                string userInput = string.Empty;
                int triangleLength = -1;

                while (triangleLength < 1)
                {
                    Console.WriteLine($"Enter the length of side {i+1} of the triangle (enter positive values):");
                    userInput = Console.ReadLine();
                    try
                    {
                        triangleLength = Int32.Parse(userInput);
                        triangleLengths[i] = triangleLength;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"An error occured : {ex.Message}");
                    }
                }
            }

            return triangleLengths;
        }


        public static void Main(string[] args)
        {
            int menuSelected;
            bool exited = false;

            while (!exited)
            {
                menuSelected = PrintMenu();
                while (menuSelected == -1)
                {
                    menuSelected = PrintMenu();
                }

                switch (menuSelected)
                {
                    case 1:
                        int[] triangleLengths = GetTriangleDimensions();
                        string result = TriangleSolver.Analyze(triangleLengths[0], triangleLengths[1], triangleLengths[2]);
                        Console.WriteLine(result);
                        break;
                    case 2:
                        Console.WriteLine("Thank you, exiting now...");
                        exited = true;
                        break;  
                }
                if (!exited)
                {
                    Console.WriteLine("press any key to continue to menu");
                    Console.ReadKey();
                }
            }
        }
    }
}
