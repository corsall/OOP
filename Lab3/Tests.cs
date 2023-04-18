using Xunit;
namespace Lab3;

public class Tests
{
    [Fact]
    public void PassingParallelLineB()
    {
        //these lines are parallel
        var lineA = new LineB(new Point(0, 0), new Point(0, 1));
        var lineB = new LineB(new Point(1, 0), new Point(1, 1));

        bool result = Calculate.AreParallel(lineA, lineB);

        Assert.True(result);
    }

    [Fact]
    public void FailingParallelLineB()
    {
        //these lines are not parallel
        var lineA = new LineB(new Point(0, 2), new Point(0, 1));
        var lineB = new LineB(new Point(1, 1), new Point(1, 30));

        bool result = Calculate.AreParallel(lineA, lineB);

        Assert.False(result);
    }

    [Fact]
    public void PassingParallelLine()
    {
        //these lines are parallel
        var lineA = new Line(0,0,0,1);
        var lineB = new Line(1,0,1,1);


        bool result = Calculate.AreParallel(lineA, lineB);

        Assert.True(result);
    }

    [Fact]
    public void FailingParallelLine()
    {
        //these lines are not parallel
        var lineA = new LineB(new Point(0, 0), new Point(0, 1));
        var lineB = new LineB(new Point(1, 20), new Point(1, 1));

        bool result = Calculate.AreParallel(lineA, lineB);

        Assert.False(result);
    }

    [Fact]
    public void PassingParallelLineC()
    {
        //these lines are parallel
        var line1 = new LineC(3, 1);
        var line2 = new LineC(3, 5);


        bool result = Calculate.AreParallel(line1, line2);

        Assert.True(result);
    }

    [Fact]
    public void FailingParallelLineC()
    {
        //these lines are parallel
        var line1 = new LineC(1, 1);
        var line2 = new LineC(2, 5);


        bool result = Calculate.AreParallel(line1, line2);

        Assert.False(result);
    }

    [Fact]

    //TODO: Перпеникулярність прямих
    public void PassingPerpendicularityLineB()
    {
        //these lines are parallel
        var lineA = new LineB(new Point(0, 1), new Point(1, 3));
        var lineB = new LineB(new Point(2, 3), new Point(4, 2));

        bool result = Calculate.ArePerpendicular(lineA, lineB);

        Assert.True(result);
    }

    [Fact]
    public void FailingPerpendicularityLineB()
    {
        //these lines are not parallel
        var lineA = new LineB(new Point(0, 0), new Point(0, 1));
        var lineB = new LineB(new Point(1, 1), new Point(1, 12));

        bool result = Calculate.ArePerpendicular(lineA, lineB);

        Assert.False(result);
    }

    [Fact]
    public void PassingPerpendicularityLine()
    {
        //these lines are parallel
        var lineA = new Line(0,1,1,3);
        var lineB = new Line(2,3,4,2);


        bool result = Calculate.ArePerpendicular(lineA, lineB);

        Assert.True(result);
    }

    [Fact]
    public void FailingPerpendicularityLine()
    {
        //these lines are not parallel
        var lineA = new LineB(new Point(0, 0), new Point(0, 1));
        var lineB = new LineB(new Point(1, 20), new Point(1, 1));

        bool result = Calculate.ArePerpendicular(lineA, lineB);

        Assert.False(result);
    }

    [Fact]
    public void PassingPerpendicularityLineC()
    {
        //these lines are parallel
        var line1 = new LineC(2, 1);
        var line2 = new LineC(-0.5, 4);


        bool result = Calculate.ArePerpendicular(line1, line2);

        Assert.True(result);
    }

    [Fact]
    public void FailingPerpendicularityLineC()
    {
        //these lines are parallel
        var line1 = new LineC(1, 1);
        var line2 = new LineC(2, 5);


        bool result = Calculate.ArePerpendicular(line1, line2);

        Assert.False(result);
    }
}