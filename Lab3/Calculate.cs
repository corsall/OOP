using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3;

public class Calculate
{
    public static bool AreParallel(ILine lineA, ILine lineB)
    {
        var _lineA = lineA.GetPoints();
        var _lineB = lineB.GetPoints();
        if ((_lineA.Y2 - _lineA.Y1) / (_lineA.X2 - _lineA.X1) == (_lineB.Y2 - _lineB.Y1) / (_lineB.X2 - _lineB.X1)) return true;
        return false;
    }

    public static bool ArePerpendicular(ILine lineA, ILine lineB)
    {
        // Визначаємо координати векторів, які визначають кожну з прямих
        var _lineA = lineA.GetPoints();
        var _lineB = lineB.GetPoints();
        double vector1X = _lineA.X2 - _lineA.X1;
        double vector1Y = _lineA.Y2 - _lineA.Y1;

        double vector2X = _lineB.X2 - _lineB.X1;
        double vector2Y = _lineB.Y2 - _lineB.Y1;

        // Обчислюємо добуток скалярних векторів
        double dotProduct = vector1X * vector2X + vector1Y * vector2Y;

        // Якщо добуток дорівнює нулю, то вектори перпендикулярні
        return dotProduct == 0;
    }

}