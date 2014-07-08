using System;

class CalculateSurfaceOfTriangle
{
    /*Write methods that calculate the surface of a triangle by given:
    Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.*/

    static void Main()
    {
        double sideA = 0;
        double sideB = 0;
        double sideC = 0;
        double alt = 0;
        double angle = 0;
        
        Console.WriteLine("Please enter side \"A\" and a altitude to it (\"0\" if the altitude is unknown):");
        Console.Write("Side A: ");
        sideA = double.Parse(Console.ReadLine());
        Console.WriteLine("Altitude: ");
        alt = double.Parse(Console.ReadLine());

        if (alt == 0)
        {
            Console.WriteLine("Please enter side \"B\" and the angle between them (\"0\" if the angle is unknown):");
            Console.Write("Side B: ");
            sideB = double.Parse(Console.ReadLine());
            Console.WriteLine("Angle: ");
            angle = double.Parse(Console.ReadLine());

            if (angle == 0)
            {
                Console.WriteLine();
                Console.Write("Please enter side \"C\": ");
                sideC = double.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("The surface of the triangle is: {0}", triangleArray(sideA, sideB, sideC, alt, angle));
    }

    static double triangleArray(double sideA, double sideB, double sideC, double alt, double angle)

        {
            double surface;
            if (alt == 0)
            {
            
                if (angle == 0)
                {
                
                    double semi = (sideA + sideB + sideC) / 2;
                    surface = Math.Sqrt(semi * (semi - sideA) * (semi - sideB) * (semi - sideC));
                }
                else
                {
                    double sinA = Math.Sin(Math.PI * angle / 180);
                    surface = sideA * sideB * sinA / 2;
                }
            }
            else
            {
                surface = sideA * alt / 2;
            }

            

        return surface;
        }
    }
