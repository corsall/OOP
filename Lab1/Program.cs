using OOP_1;
using System.Collections.Generic;
using System.Reflection;

bool exit = true;
TSquare square = new TSquare();
TCube cube = new TCube();

Console.WriteLine("Options Menu:");
Console.WriteLine("Exit program type {exit}:");

Console.WriteLine("\n--------Commands for square--------\n");

Console.WriteLine("Create square {square create}:");
Console.WriteLine("Find Perimeter of square {square perimeter}:");
Console.WriteLine("Find Area of square {square area}:");
Console.WriteLine("Print sides of square {square length}:");
Console.WriteLine("Add squares +:");
Console.WriteLine("Subtract squares -:");
Console.WriteLine("Multiply the side of the square by some number *:");
Console.WriteLine("Compare squares: {square copmpare}");

Console.WriteLine("\n--------Commands for cube--------\n");

Console.WriteLine("Create cube {cube create}:");
Console.WriteLine("Find Perimeter of cube {cube perimeter}:");
Console.WriteLine("Find Area of cube {cube area}:");
Console.WriteLine("Find Volume of cube {cube volume}:");
Console.WriteLine("Print sides of cube {cube length}:");
Console.WriteLine("Add cubes +:");
Console.WriteLine("Subtract cubes -:");
Console.WriteLine("Multiply the side of the cube by some number *:");
Console.WriteLine("Compare cubes: {cube copmpare}");


while (exit)
{
    string options = Console.ReadLine()!;
    switch (options)
    {
        case "exit":
            exit = false;
            break;
        case "square create":
            square.Entry();
            break;
        case "square perimeter":
            Console.WriteLine($"{square.Perimeter()}");
            break;
        case "square area":
            Console.WriteLine($"{square.Area()}");
            break;
        case "square length":
            square.Output();
            break;
        case "+ s":
            Console.WriteLine("Enter length of second square to add");
            float number = float.Parse(Console.ReadLine()!);
            square = square + new TSquare(number);
            square.Output();
            break;
        case "- s":
            Console.WriteLine("Enter length of second square to substract");
            number = float.Parse(Console.ReadLine()!);
            square = square - new TSquare(number);
            square.Output();
            break;
        case "* s":
            Console.WriteLine("Enter a number to multiply by the side of the square");
            number = float.Parse(Console.ReadLine()!);
            square = square * number;
            square.Output();
            break;
        case "square compare":
            Console.WriteLine("Enter length of the side, to create new square and compare to the first one:");
            number = float.Parse(Console.ReadLine()!);
            TSquare square2 = new TSquare(number);
            if (square.CompareTo(square2))  Console.WriteLine("First square is bigger then second one");
            else Console.WriteLine("Second square is bigger then first one");
            break;
        case "cube create":
            cube.Entry();
            break;
        case "cube perimeter":
            Console.WriteLine($"{cube.Perimeter()}");
            break;
        case "cube area":
            Console.WriteLine($"{cube.Area()}");
            break;
        case "cube volume":
            Console.WriteLine($"{cube.Volume()}");
            break;
        case "cube length":
            cube.Output();
            break;
        case "+ c":
            Console.WriteLine("Enter length of second cube to add");
            number = float.Parse(Console.ReadLine()!);
            cube = cube + new TCube(number);
            cube.Output();
            break;
        case "- c":
            Console.WriteLine("Enter length of second cube to substract");
            number = float.Parse(Console.ReadLine()!);
            cube = (TCube)(cube - new TCube(number));
            square.Output();
            break;
        case "* c":
            Console.WriteLine("Enter a number to multiply by the side of the cube");
            number = float.Parse(Console.ReadLine()!);
            cube = (TCube)(cube * number);
            square.Output();
            break;
        case "cube compare":
            Console.WriteLine("Enter length of the side, to create new cube and compare to the first one:");
            number = float.Parse(Console.ReadLine()!);
            TCube cube2 = new TCube(number);
            if (cube.CompareTo(cube2)) Console.WriteLine("First cube is bigger then second one");
            else Console.WriteLine("Second cube is bigger then first one");
            break;
        default:
            break;
    }
}
