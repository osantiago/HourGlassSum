using System;

namespace HourGlassSum
{
    class Program
    {
        // given a 6x6 matrix, We define an hourglass to be a subset of values with indices falling in this pattern graphical representation:
        // a b c 
        //   d 
        // e f g
        // Calculate the largest hour glass sum
         static int hourglassSum(int[][] arr)
        {
            int sum = 0, max = -1000;

            for (int i = 0; i < arr.Length-2; i++)
            {
                for (int j = 0; j < arr.Length-2; j++)
                {
                    sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] +
                          arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];

                    if (max < sum)
                        max = sum;
                }
            }

            return max;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[][] arr = new int[6][]
                {
                    new int[] {-1, -1, 0, -9, -2, -2},
                    new int[] {-2, -1, -6, -8, -2, -5},
                    new int[] {-1, -1, -1, -2, -3, -4},
                    new int[] {-1, -9, -2, -4, -4, -5},
                    new int[] {-7, -3, -3, -2, -9, -9},
                    new int[] {-1, -3, -1, -2, -4, -5 }
                };


            int result = hourglassSum(arr);

            Console.WriteLine(result);
        }
    }
}
