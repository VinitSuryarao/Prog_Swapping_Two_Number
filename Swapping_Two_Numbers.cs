using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        //   Swapping Two Number
        static void Main(string[] args)
        {
            int a = 5;
            int b = 8;
            int temp;

            // Method 1
            temp = a;
            a = b;
            b = temp;

            // Method 2
            a = a + b;
            b = a - b;
            b = a - b;

        }
    }


