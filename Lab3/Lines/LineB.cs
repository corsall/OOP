namespace Lab3;

public class LineB : ILine
{
    public Point Start { get; set; }
    public Point End { get; set; }

    public LineB(Point start, Point end)
    {
        Start = start;
        End = end;
    }

    public MainLine GetPoints()
    {
        var line = new MainLine();

        line.X1 = Start.X;
        line.Y1 = Start.Y;
        line.X2 = End.X;
        line.Y2 = End.Y;

        return line;
    }
}
