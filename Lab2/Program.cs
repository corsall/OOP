using System.Text;
using System;

namespace Lab2;
class Program
{
    static void Main(string[] arg)
    {
        Console.OutputEncoding = Encoding.UTF8;

        if(arg[0] == "task1")
        {
            int[] numbers = GenerateRandArray(10);
            PrintArray(numbers);

            System.Console.WriteLine(Task1.FindMax(numbers));
            System.Console.WriteLine("With LINQ");
            System.Console.WriteLine(numbers.Max());
        }

        else if(arg[0] == "task2")
        {
            System.Console.WriteLine("Введіть вимірність векторів");
            Random r = new Random();
            int input = IntegerInputCheck();
            Vector a = new Vector(input);
            Vector b = new Vector(input);

            for(int i = 0; i < input; i++)
            {
                a[i] = r.Next(0, 10);
                b[i] = r.Next(0, 10);
            }
            System.Console.WriteLine("Vector a:");
            PrintVector(a);
            System.Console.WriteLine("Vector b:");
            PrintVector(b);

            System.Console.WriteLine("Result " + Task2.ScalarProduct(a, b));
        }

        else if(arg[0] == "task3")
        {
            System.Console.WriteLine("Введіть довжину массива");
            int input = IntegerInputCheck();

            int[] inputArray = GenerateRandArray(input);

            PrintArray(inputArray);

            int[] sortedArray = Task3.CustomSort(inputArray); //?
            System.Console.WriteLine("Sorted Array: ");
            PrintArray(sortedArray);

            Console.ReadLine();
        }

        else if(arg[0] == "task4")
        {
            System.Console.WriteLine("Введіть довжину сторони квадратної матриці ");
            int l = IntegerInputCheck();
            System.Console.WriteLine("Введіть максимальне випадкове число ");
            int max = IntegerInputCheck();
            System.Console.WriteLine("Введіть мінімальне випадкове число ");
            int min = IntegerInputCheck();
            int[,] examplArray = GenerateSquareMatrix(l, min, max);
            Print2dArray(examplArray);

            System.Console.WriteLine();

            Print2dArray(Task4.CustomEvenSort(examplArray));
        }

        else if(arg[0] == "task5")
        {
            System.Console.WriteLine("Введіть довжину прямокутної матриці ");
            int l = IntegerInputCheck();
            System.Console.WriteLine("Введіть ширину прямокутної матриці ");
            int w = IntegerInputCheck();
            System.Console.WriteLine("Введіть максимальне випадкове число ");
            int max = IntegerInputCheck();
            System.Console.WriteLine("Введіть мінімальне випадкове число ");
            int min = IntegerInputCheck();

            int[,] exampleArray = GenerateRectangularMatrix(l, w, min, max);

            Print2dArray(exampleArray);

            System.Console.WriteLine(Task5.CheckForZeros(exampleArray));
        }

        else if(arg[0] == "task6")
        {
            System.Console.WriteLine("Введіть довжину прямокутної матриці ");
            int l = IntegerInputCheck();
            System.Console.WriteLine("Введіть ширину прямокутної матриці ");
            int w = IntegerInputCheck();
            System.Console.WriteLine("Введіть максимальне випадкове число ");
            int max = IntegerInputCheck();
            System.Console.WriteLine("Введіть мінімальне випадкове число ");
            int min = IntegerInputCheck();

            int[,] testArray = GenerateRectangularMatrix(l, w, min, max);

            Print2dArray(testArray);

            System.Console.WriteLine(Task6.Combo(testArray));
        }
    }

    public static int[] GenerateRandArray(int Length)
    {
        Random rand = new Random();
        int[] numbers = new int[Length];

        for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(-10, 10);
        }

        return numbers;
    }

    public static int[,] GenerateSquareMatrix(int size, int minValue, int maxValue)
    {
        int[,] matrix = new int[size, size];
        Random random = new Random();

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                matrix[i, j] = random.Next(minValue, maxValue);
            }
        }

        return matrix;
    }

    public static int[,] GenerateRectangularMatrix(int rows, int columns, int minValue, int maxValue)
    {
        int[,] matrix = new int[rows, columns];
        Random random = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = random.Next(minValue, maxValue);
            }
        }

        return matrix;
    }

    public static void PrintArray(int[] array)
    {
        Console.WriteLine($"Array: {string.Join(", ", array)}");
    }

    public static void Print2dArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public static void PrintVector(Vector x)
    {
        for(int i = 0; i < x.Dimension(); i++)
        {
            Console.Write(x[i] + " ");
        }
        Console.WriteLine();
    }

    public static int IntegerInputCheck()
    {
        string input = Console.ReadLine()!;
        int number;
        if (int.TryParse(input, out number))
        {
            return number;
        }
        else
        {
            throw new ArgumentException("Ви ввели неправильне значення");
        }
    }
}




public static class Task1
{
    public static int FindMax(int[] arr)
    {
        int maxNumber = arr[0];

        for(int i = 1; i < arr.Length; i++)
        {
            if(arr[i] > maxNumber)
            {
                maxNumber = arr[i];
            }
        }

        return maxNumber;
    }
}

public static class Task2
{
    public static double ScalarProduct(Vector a, Vector b)
    {
        double result = 0;
        for(int i = 0; i < a.Dimension(); i++)
        {
            result += a[i] * b[i];
        }
        return result;
    }
}

public class Vector
{
    private double[] coordinates;

    public Vector(int n)
    {
        coordinates = new double[n];
    }

    public double this[int index]
    {
        get { return coordinates[index]; }
        set { coordinates[index] = value; }
    }

    public int Dimension()
    {
        return coordinates.Length;
    }
}

public static class Task3
{
    public static int[] CustomSort(int[] array)
    {
        int[] sortedArray = QuickSort(array, 0, array.Length - 1);

        List<int> positiveArray = new List<int>();
        List<int> negativeArray = new List<int>();
        for(int i = 0; i < sortedArray.Length; i++)
        {
            if(sortedArray[i] < 0)
            {
                negativeArray.Add(sortedArray[i]);
            }
            if(sortedArray[i] >= 0)
            {
                positiveArray.Add(sortedArray[i]);
            }
        }

        return negativeArray.Concat(positiveArray).ToArray();
    }


    public static int[] QuickSort(int[] array, int minIndex, int maxIndex)
    {
        if (minIndex >= maxIndex)
        {
            return array;
        }

        int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);

        QuickSort(array, minIndex, pivotIndex - 1);

        QuickSort(array, pivotIndex + 1, maxIndex);

        return array;
    }

    public static int GetPivotIndex(int[] array, int minIndex, int maxIndex)
    {
        int pivot = minIndex - 1;

        for (int i = minIndex; i <= maxIndex; i++)
        {
            if (array[i] < array[maxIndex])
            {
                pivot++;
                Swap(ref array[pivot], ref array[i]);
            }
        }

        pivot++;
        Swap(ref array[pivot], ref array[maxIndex]);

        return pivot;
    }

    public static void Swap(ref int leftItem, ref int rightItem)
    {
        int temp = leftItem;

        leftItem = rightItem;

        rightItem = temp;
    }

    public static int[] SortArray(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            if (arr[left] >= 0 && arr[right] < 0)
            {
                // swap
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;

                left++;
                right--;
            }
            else if (arr[left] < 0)
            {
                left++;
            }
            else if (arr[right] >= 0)
            {
                right--;
            }
        }

        return arr;
    }
}

public static class Task4
{
    public static int[,] CustomEvenSort(int[,] array)
    {
        int aLenght = array.GetLength(0);

        int[,] sortedArray = new int[aLenght,aLenght];


        int[] column = new int[aLenght];

        for(int k =0; k < aLenght; k+=2)
        {
            for (int i = 0; i < aLenght; i++)
            {
                column[i] = array[i,k];
            }
            Task3.QuickSort(column, 0, column.Length - 1);

            for (int i = 0; i < aLenght; i++)
            {
                sortedArray[i,k] = column[i];
            }
        }




        for(int k =1; k < aLenght; k+=2)
        {
            for (int i = 0; i < aLenght; i++)
            {
                sortedArray[i, k] = array[i, k];
            }
        }

        return sortedArray;
    }
}

public static class Task5
{
    public static int CheckForZeros(int[,] array)
    {
        int result = 0;
        int rowLenght = array.GetLength(0);
        int colLenght = array.GetLength(1);

        for(int k =0; k < colLenght; k++)
        {
            for (int i = 0; i < rowLenght; i++)
            {
                if(array[i,k] == 0)
                {
                    result++;
                    break;
                }
            }
        }

        return result;
    }
}

public static class Task6
{
    public static int Combo(int[,] array)
    {
        int comboRow = -1;
        int maxLength = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            int length = 1;
            for (int j = 1; j < array.GetLength(1); j++)
            {
                if (array[i, j] == array[i, j - 1])
                {
                    length++;
                    if (length > maxLength)
                    {
                        maxLength = length;
                        comboRow = i;
                    }
                }
                else
                {
                    length = 1;
                }
            }
        }

        return comboRow;
    }
}