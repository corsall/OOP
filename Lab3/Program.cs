namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        //these lines are parallel
        var lineA = new LineB(new Point(0, 0), new Point(0, 1));
        var lineB = new LineB(new Point(1, 0), new Point(1, 1));

        bool result = Calculate.AreParallel(lineA, lineB);

        Console.WriteLine(result);
    }
}
