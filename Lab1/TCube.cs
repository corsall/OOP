using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal class TCube : TSquare
    {

        public TCube() : base()
        {
        }

        public TCube(float length) : base(length)
        {
        }

        public override void Entry()
        {
            Console.WriteLine("Введiть довжину сторони куба:");
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
            base.sideLength = length;
        }

        public override void Output()
        {
            Console.WriteLine($"Довжина сторони куба {this.sideLength}");
        }

        public override float Perimeter()
        {
            return this.sideLength * 12;
        }

        public override float Area()
        {
            return this.sideLength * this.sideLength * 6;
        }

        public float Volume()
        {
            return this.sideLength * this.sideLength * this.sideLength;
        }

        public static TCube operator +(TCube cube1, TCube cube2)
        {
            return new TCube(cube1.sideLength + cube2.sideLength);
        }

        public static TCube operator -(TCube cube1, TCube cube2)
        {
            return new TCube(Convert.ToUInt16(cube1.sideLength - cube2.sideLength));
        }

        public static TCube operator *(TCube cube1, float multipl)
        {
            return new TCube(cube1.sideLength * multipl);
        }


    }
}
