//Noa Denise Ishac NET23

using System;

namespace GrundernaOOP
{
    class Circle //här skapas klassen Circle
    {
        private double _radius;

        public Circle(double r) //radien r som parameter
        {
            _radius = r;
        }

        public double GetArea()//här skapas metoden för att räkna ut arean
        {
            return _radius * _radius * Math.PI;//returnerar önskat värde
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //här skapar vi en ny cirkel och anropar metoden för att beräkna area för cirkel 1
            Circle circle1 = new Circle(5);
            double area1 = circle1.GetArea();
            Console.WriteLine("Arean för cirkeln med radie 5 är: " + area1);

            //här skapar vi en ny cirkel och anropar metoden för att beräkna area för cirkel 2
            Circle circle2 = new Circle(6);
            double area2 = circle2.GetArea();
            Console.WriteLine("Arean för cirkeln med radie 6 är: " + area2);
        }
    }
}