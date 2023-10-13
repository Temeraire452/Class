namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5); // 2 circlar skapade med 2 olika radie
            Circle circle2 = new Circle(6);

            float area1 = circle1.getArea(); // Beräknar de 2 cirklarnas area
            float area2 = circle2.getArea();

            Console.WriteLine("Circelns area med en radie på 5 är: " + area1); // Skriver ut arean på de 2 cirklarna
            Console.WriteLine("Circelns area med en radie på 6 är: " + area2);
        }
    }

    public class Circle // Skapar en klass
    {
        float _pi = 3.141f;
        int _radius;

        public Circle (int radius) // Konstruktor som tar in radie
        {
            _radius = radius;
        }
        public float getArea() // Metod som räknar ut/returnerar arean
        {
            return _pi * _radius * _radius;
        }

    }
}