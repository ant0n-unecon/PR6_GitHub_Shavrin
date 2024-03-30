using System;

namespace PR6_Shavrin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точки А:");
            int[] pointA = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine("Введите координаты точки B:");
            int[] pointB = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine("Введите координаты точки C:");
            int[] pointC = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine("Введите координаты точки D:");
            int[] pointD = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool ArePointsValid(int[] pointA, int[] pointB, int[] pointC, int[] pointD)
            {
                if ((pointA[0] == pointB[0] && pointB[0] == pointC[0] && pointC[0] == pointD[0]) ||
                    (pointA[1] == pointB[1] && pointB[1] == pointC[1] && pointC[1] == pointD[1]))
                {
                    return false; // Points are on the same line
                }
                else if (pointA.SequenceEqual(pointB) || pointA.SequenceEqual(pointC) || pointA.SequenceEqual(pointD) ||
                        pointB.SequenceEqual(pointC) || pointB.SequenceEqual(pointD) || pointC.SequenceEqual(pointD))
                {
                    return false; // At least two points are equal
                }
                else
                {
                    return true; // Points are valid
                }
            }

            double Distance(int[] point1, int[] point2)
            {
                int deltaX = point2[0] - point1[0];
                int deltaY = point2[1] - point1[1];
                return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            }

            double AB = Distance(pointA, pointB);
            double AC = Distance(pointA, pointC);
            double AD = Distance(pointA, pointD);
            double BC = Distance(pointB, pointC);
            double BD = Distance(pointB, pointD);
            double CD = Distance(pointC, pointD);

            double Perimeter(double a, double b, double c)
            {
                return a + b + c;
            }

            double perimeterABC = Perimeter(AB, AC, BC);
            double perimeterABD = Perimeter(AB, AD, BD);
            double perimeterACD = Perimeter(AC, AD, CD);
            double perimeterBCD = Perimeter(BC, BD, CD);

            double minPerimeter = Math.Min(Math.Min(perimeterABC, perimeterABD), Math.Min(perimeterACD, perimeterBCD));

            Console.WriteLine("Наименьший периметр среди всех возможных треугольников равен: " + minPerimeter);
        }
    }
}


