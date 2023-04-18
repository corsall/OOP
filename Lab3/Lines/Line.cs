namespace Lab3;

public class Line : ILine
{
    public double X1 { get; set; }
    public double Y1 { get; set; }
    public double X2 { get; set; }
    public double Y2 { get; set; }

    public Line(double x1, double y1, double x2, double y2)
    {
        X1 = x1;
        Y1 = y1;
        X2 = x2;
        Y2 = y2;
    }

    public MainLine GetPoints()
    {
        var line = new MainLine();

        line.X1 = this.X1;
        line.Y1 = this.Y1;
        line.X2 = this.X2;
        line.Y2 = this.Y2;

        return line;
    }
}