using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solve = new Solution();
            int[][] ar = new int[][] { new int[] {11, 2, 4 },
                                       new int[]{ 4, 5, 6 },
                                       new int[]{ 10, 8, -12 } };

            Console.WriteLine( solve.solve(ar));

            Console.ReadLine();
        }
    }

    class Solution
    {
        public int solve(int[][] arr)
        {
            List<int> firstDiagnal = new List<int>();
            List<int> secondDiagnal = new List<int>();
            for (int i = 0; i < arr.Length ; i++)
            {
                for (int j = 0; j < arr[i].Length ; j++)
                {
                    if (i == j)
                    {
                        firstDiagnal.Add(arr[i][j]);
                    }
                }
            }

            for (int i = 0; i < arr.Length ; i++)
            {
                for (int j = arr[i].Length - 1; j >= 0; j--)
                {
                    int index = arr[i].Length;
                    //index = arr[i].Length - 
                    if (i + j == index - 1)
                    {
                        secondDiagnal.Add(arr[i][j]);
                    }
                }
            }
          
            return Math.Abs(firstDiagnal.Sum() - secondDiagnal.Sum());
        }
    }
}
