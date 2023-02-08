using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal class TSquare
    {
        protected float sideLength;

        public TSquare()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            this.sideLength = random.Next(1, 100);
        }

        public TSquare(float length)
        {
            this.sideLength = length;
        }

        //Copy constructor
        public TSquare(TSquare previousSquare)
        {
            this.sideLength = previousSquare.sideLength;
        }

        public virtual void Entry()
        {
            Console.WriteLine("Введiть довжину сторони квадрата:");
            int length;
            if (!Int32.TryParse(Console.ReadLine(), out length))
            {
                Console.WriteLine("Ooops, це було не число");
                return;
            }
            if (length < 0)
            {
                Console.WriteLine("Число не є додатнім");
                return;
            }
            this.sideLength = length;
        }

        public virtual void Output()
        {
            Console.WriteLine($"Довжина сторони квадрата {this.sideLength}");
        }

        public virtual float Area()
        {
            return this.sideLength * this.sideLength;
        }

        public virtual float Perimeter()
        {
            return this.sideLength * 4;
        }

        public bool CompareTo(TSquare squareToCompare) //returns true if current square is bigger then squareToCompare
        {
            return this.sideLength > squareToCompare.sideLength;
        }

        public static TSquare operator +(TSquare square1, TSquare square2)
        {
            return new TSquare(square1.sideLength + square2.sideLength);
        }

        public static TSquare operator -(TSquare square1, TSquare square2)
        {
            return new TSquare(Convert.ToUInt16(square1.sideLength - square2.sideLength));
        }

        public static TSquare operator *(TSquare square1, float multipl)
        {
            return new TSquare(square1.sideLength * multipl);
        }

    }
}
