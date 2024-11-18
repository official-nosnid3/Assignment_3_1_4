using System.ComponentModel;

namespace Assignment_3_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Assignment 3.1.4
             * Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
             * Test Data :
             * Input the value for X coordinate :7
             * Input the value for Y coordinate :9
             * Expected Output :
             * The coordinate point (7,9) lies in the First quadrant.
             * */

            bool runProgram = true;
            try
            {
                do
                {
                    Console.Clear();

                    Console.WriteLine("Quadrant Locator");

                    Console.WriteLine("\nEnter the X-coordinate: ");
                    double xCoord = Convert.ToDouble( Console.ReadLine() );

                    Console.WriteLine("\nEnter the Y-Coordinate: ");
                    double yCoord = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine(QuadrantLocator(xCoord, yCoord));

                    Console.WriteLine("\nEnter any key to restart\nEnter 'Q' to quit");
                    string entry = Console.ReadLine().ToLower();

                    if (entry == "q")
                        runProgram = false;
                }
                while (runProgram);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        static string QuadrantLocator(double x, double y)
        {
            string message = "";
            
            if (x < 0)
            {
                if (y < 0)
                    message = "These coordinates are located on quadrant 3.";
                else if (y > 0)
                    message = "These coordinates are located on quadrant 2.";
                else message = "These coordinates are located inbetween quadrants 2 and 3.";
            }
            else if (x > 0)
            {
                if (y < 0)
                    message = "These coordinates are located on quadrant 4.";
                else if (y > 0)
                    message = "These coordinates are located on quadrant 1.";
                else message = "These coordinates are located inbetween quadrants 1 and 4.";
            }
            else if (x == 0)
            {
                if (y < 0)
                    message = "These coordinates are located inbetween quadrants 3 and 4.";
                else if (y > 0)
                    message = "These coordinates are located inbetween quadrants 1 and 2.";
                else message = "These coordinates are located inbetween all quadrants at (0, 0).";
            }

            return message;
        }
    }
}
