using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_overloading_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        //2 integer parameters

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        //2 decimal parameters
        public static decimal Add(decimal num1, decimal num2)
        {
            return (decimal)num1 + num2;
        }

        //3 parameters:  2 integer parameters, 1 boolean parameters
        public static string Add(int num1, int num2, bool isDollars)
        {
            return isDollars ? (num1 + num2) + ((num1+num2==1)? " dollar":" dollars") : (num1 + num2) + "";
        }

    }
}
