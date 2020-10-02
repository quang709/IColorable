using System;

namespace interface_IColorable
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Shape Test
            Shape shape = new Shape();
            Console.WriteLine(shape);
            shape = new Shape("red", false);
            Console.WriteLine(shape);
            Circle circle = new Circle();
            Console.WriteLine(circle);
            circle = new Circle(3.5);
            Console.WriteLine(circle);
            circle = new Circle(3.5, "indigo", false);
            Console.WriteLine(circle);
            Square square = new Square();
            Console.WriteLine(square);
            square = new Square(2.3);
            Console.WriteLine(square);
            square = new Square(5.8, "yellow", true);
            Console.WriteLine(square);*/

            Shape[] shape = new Shape[2];
            //Shape[] shape = { new Square(3.5), new Rectangle(6.5, 3) };


            Square square = new Square(3);
            Rectangle rec = new Rectangle(3, 4);

            shape[0] = square;
            shape[1] = rec;
            for (int i = 0; i < shape.Length; i++)
            {
                Console.WriteLine(shape[i].Name() + " ");
                Console.WriteLine(shape[i].GetArea());
                if (shape[i] is IColorable)
                {
                    shape[i].HowToColor();
                }
            }
        }
    }
}