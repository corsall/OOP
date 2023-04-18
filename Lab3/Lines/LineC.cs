namespace Lab3;

public class LineC : ILine
{
    //y = kx + b 
    private double k;
    private double b;

    public LineC(double k, double b)
    {
        this.k = k;
        this.b = b;
    }

    // Метод для обчислення довільних координат точок, через які проходить пряма
    public MainLine GetPoints()
    {
        var line  = new MainLine();
        line.X1 = 0;
        line.X2 = 2;
        line.Y1 = k * line.X1 + b;
        line.Y2 = k * line.X2 + b;

        return line;
    }
}