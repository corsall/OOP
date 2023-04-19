namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        //these lines are parallel
        // var lineA = new LineB(new Point(0, 0), new Point(0, 1));
        // var lineB = new LineB(new Point(1, 0), new Point(1, 1));

        // bool result = Calculate.AreParallel(lineA, lineB);

        // Console.WriteLine(result);


        double X1 = 0;
        double Y1 = 0;
        double X2 = 0;
        double Y2 = 1;

        X1 = Double.Parse(Console.ReadLine());
        Y1 = Double.Parse(Console.ReadLine());
        X2 = Double.Parse(Console.ReadLine());
        Y2 = Double.Parse(Console.ReadLine());
        Line lineA = new Line(X1, Y1, X2, Y2);

        Console.WriteLine("now enter the second line");
        X1 = Double.Parse(Console.ReadLine());
        Y1 = Double.Parse(Console.ReadLine());
        X2 = Double.Parse(Console.ReadLine());
        Y2 = Double.Parse(Console.ReadLine());
        Line lineB = new Line(X1, Y1, X2, Y2);

        Console.WriteLine("the lines are parallel: " + Calculate.AreParallel(lineA, lineB));
        Console.WriteLine("the lines are perpendicular: " + Calculate.ArePerpendicular(lineA, lineB));

    }
}
