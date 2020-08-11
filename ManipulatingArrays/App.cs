using System;
using System.Collections.Generic;
using System.Text;

namespace ManipulatingArrays
{
   public class App
    {
        public static int getLength(int[] arr)

        {

            int count = 0;

            foreach (int number in arr) count++;

            return count;

        }
        public static int getSum(int[] arr)

        {

            int sum = 0;

            for (int i = 0; i < getLength(arr); i++) sum += arr[i];

            return sum;

        }

        public static double getMean(int[] arr) => getSum(arr) / getLength(arr);

        public static void reverse(int[] arr)

        {

            int[] reversed = new int[getLength(arr)];

            int index = 0;

            for (int i = getLength(arr) - 1; i >= 0; i--)

            {

                reversed[index] = arr[i];

                index++;

            }

            displayArray(reversed);
        }

        public static void rotate(string orientation, int x, int[] arr)

        {

            int[] rotated = new int[getLength(arr)];

            int index;

            while (x > arr.Length)

            {

                x -= arr.Length;

            }

            if (orientation == "right")

            {

                index = 0 + x;

                for (int i = 0; i < getLength(arr); i++)

                {

                    if (index == getLength(arr))

                    {

                        index = 0;

                    }

                    rotated[index] = arr[i];

                    index++;

                }

            }

            if (orientation == "left")

            {

                index = 0;

                for (int i = x; index < getLength(arr); i++)

                {

                    if (i == getLength(arr))

                    {

                        i = 0;

                    }

                    rotated[index] = arr[i];

                    index++;

                }

            }



            displayArray(rotated);

        }

        public static void bubbleSort(int[] arr)

        {

            int temp = 0;



            for (int i = 0; i < getLength(arr) - 1; i++)   

            {

                for (int j = i + 1; j < getLength(arr); j++)  

                {

                    if (arr[i] > arr[j])

                    {

                        temp = arr[i];     

                        arr[i] = arr[j];   

                        arr[j] = temp;

                    }

                }

            }



            displayArray(arr);

        }


        public static void displayArray(int[] arr)

        {

            foreach (int x in arr)

            {

                Console.Write(x + " ");

            }

            Console.WriteLine("");

        }

    }
}
