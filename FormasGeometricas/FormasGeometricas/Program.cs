using FormasGeometricas.Src;
using System;

namespace FormasGeometricas
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello to the Geometric Forms!");
            Console.WriteLine("===============================\n" +
                              "Choose the option to calculate the area:\n" +
                              "1 - Square\n" +
                              "2 - Triangle\n" +
                              "3 - Rectangle\n" +
                              "===============================\n");
            int choise = Convert.ToInt32(Console.ReadLine());



                switch (choise) {
                    case 1:
                        Console.WriteLine("Inform the base: ");
                        int squareBase = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Inform the hight: ");
                        int squarehight = Convert.ToInt32(Console.ReadLine());

                    Square square = new Square(squareBase,squarehight);

                    Console.WriteLine($"The area of square are: {square.CalcularArea()}\n");
                        break;

                    case 2:
                        Console.WriteLine("Inform the base: ");
                        int triangleBase = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Inform the hight: ");
                        int triangleHight = Convert.ToInt32(Console.ReadLine());

                    Triangle triangle = new Triangle(triangleBase, triangleHight);
                    Console.WriteLine($"The area of triangle are: {triangle.CalcularArea()}\n");
                        break;

                    case 3:
                        Console.WriteLine("Inform the base: ");
                        int rectangleBase = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Inform the hight: ");
                        int rectangleHight = Convert.ToInt32(Console.ReadLine());

                    Square rectangle = new Square(rectangleBase, rectangleHight);
                    Console.WriteLine($"The area of rectangle are: {rectangle.CalcularArea()}\n");
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            


        }
    }
}
