using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    public static class Extensions
    {
        public static int[] SelectDemo(this string[] arr)
        {
            int[] intArr = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                intArr[i] = int.Parse(arr[i]);
            }

            return intArr;
        }
    }
}
