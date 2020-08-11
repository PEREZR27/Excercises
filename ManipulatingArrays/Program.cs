using System;

namespace ManipulatingArrays
{
       public class Program

        {
            static void Main(string[] args)

            {

                   int[] A = new int[] { 0, 2, 4, 6, 8, 10 };
                   int[] B = new int[] { 1, 3, 5, 7, 9 };
                   int[] C = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };


               Console.WriteLine("Average of A: " + App.getMean(A));

               Console.WriteLine("Average of B: " + App.getMean(B));

                Console.WriteLine("Average of C: " + App.getMean(C));


                Console.WriteLine("Reverse the array");

                Console.Write("Reverse of A: "); App.reverse(A);

                Console.Write("Reverse of B: "); App.reverse(B);

                Console.Write("Reverse of C: "); App.reverse(C);


                Console.WriteLine("Rotates the array");

                Console.Write("Rotation of A: "); App.rotate("left", 2, A);

                Console.Write("Rotation of B: "); App.rotate("right", 2, B);

                Console.Write("Rotation of C: "); App.rotate("left", 4, C);


                Console.WriteLine("Sorts the array");

                Console.Write("Avg of C: "); App.bubbleSort(C);

            }

        }

}