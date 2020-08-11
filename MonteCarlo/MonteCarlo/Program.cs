using System;

namespace MonteCarlo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input array size");

            int input = int.Parse(Console.ReadLine());

            Random rnd = new Random();

            XY hyp = new XY();


            double[,] arr = new double[input, 2];

            int length1 = arr.Length - input;

            int counter = 0;


            for (int i = 0; i < length1; ++i)

            {

                XY rand = new XY(rnd);

                arr[i, 0] = rand.X();

                arr[i, 1] = rand.Y();

                Console.WriteLine($"X: {rand.X()}.  Y: {rand.Y()}");

                Console.WriteLine($"Hyp: {hyp.Hypotenuse(rand.X(), rand.Y())}");


                if (hyp.Hypotenuse(rand.X(), rand.Y()) <= 1)

                {

                    counter++;

                }

            }

            double length = length1;
            double coordinates = 0;
            double total = counter;

            coordinates += total / length;

            double coordinatesTotal = coordinates * 4;


            Console.WriteLine($"Counter: {counter}");

            Console.WriteLine($"Result: {coordinatesTotal}");

            double difference = Math.Abs(coordinatesTotal - Math.PI);

            Console.WriteLine($"Difference: {difference}");


            Console.WriteLine($" ");


        }
    }
}
