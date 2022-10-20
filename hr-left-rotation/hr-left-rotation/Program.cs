using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hr_left_rotation
{
    internal class Program
    {
        class Result
        {

            /*
             * Complete the 'rotateLeft' function below.
             *
             * The function is expected to return an INTEGER_ARRAY.
             * The function accepts following parameters:
             *  1. INTEGER d
             *  2. INTEGER_ARRAY arr
             */

            //public static List<int> rotateLeft(int d, List<int> a)
            //{
            //    int v;

            //    for (int i = 0; i < d; i++)
            //    {
            //        v = a[0];
            //        for (int j = 0; j < a.Count; j++)
            //        {
            //            if (j + 1 < a.Count)
            //                a[j] = a[j + 1];
            //        }
            //        a[a.Count - 1] = v;
            //    }

            //    return a;
            //}
            public static List<int> rotateLeft(int d, List<int> arr)//this is efficient solution
            {
                List<int> res = new List<int>();
                for (int i = d; i < arr.Count; i++)
                    res.Add(arr[i]);
                for (int i = 0; i < d; i++)
                    res.Add(arr[i]);
                return res;
            }

        }
        static void Main(string[] args)
        {
            

            string[] firstMultipleInput = "5 4".Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int d = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = "1 2 3 4 5".Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            //constraints
            if (n >= 100000 || n < 1)
            {
                return;
            }

            if (d > n || n < 1)
            {
                System.Environment.Exit(1);
            }

            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 1000000 || arr[i] < 1)
                {
                    return;
                }
            }

            List<int> result = Result.rotateLeft(d, arr);

            Console.WriteLine(String.Join(" ", result));

           
        }
    }
}
