namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int sum = a + b;
            int diff = a - b;
            int product = a * b;
            int quotient = a / b;
            int rem = a % b;

            Console.WriteLine("a+b=" + sum);
            Console.WriteLine("a-b=" + diff);
            Console.WriteLine("a*b=" + product);
            Console.WriteLine("a/b=" + quotient + " remainder " + rem);

            //circle
            Console.WriteLine("Enter a radius of a circle: ");
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine("area of a circle with radius "+radius+" is: " + AreaOfCircle(radius));
        }

        //compute area of circle
        static double AreaOfCircle(double radius) {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
