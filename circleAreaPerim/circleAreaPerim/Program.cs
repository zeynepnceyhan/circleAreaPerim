namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            double perimeter, area;
            int radius;
            Console.WriteLine("enter a radius value: ");
            radius = Convert.ToInt32(Console.ReadLine());


            perimeter = 2 * pi * radius;
            area = pi * radius * radius;

            Console.WriteLine("The perimeter of the circle: " + perimeter);
            Console.WriteLine("The area of the circle: " + area);
            Console.ReadLine();
        }

    }

}