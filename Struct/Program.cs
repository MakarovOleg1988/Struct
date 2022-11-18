using System;

namespace ExampleStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = Convert.ToInt32(Console.ReadLine());
            int width = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());

            Cuboid cuboid = new Cuboid(length, width, height);

            Console.WriteLine("Volume: " + cuboid.Volume());
            Console.WriteLine("Perimeter: " + cuboid.Perimeter());
        }
    }

    struct Cuboid
    {
        public int length;
        public int width;
        public int height;

        public Cuboid(int length, int width, int height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }



        public int Volume()
        {
            return length * width * height;
        }
        //завершите данный метод
        public int Perimeter()
        {
            return 4 * (length + width + height);
        }
    }
}