using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] ar = new int[5] { 1, 2, 3, 4, 5 };
            Delete();
            Console.WriteLine();
            matrix();
        }

        public static void Delete()
        {
            int i, pos, n;
            int[] arr1 = new int[50]; 

            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine()); 

            Console.Write("Input {0} elements in the array in ascending order:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine()); 
            }

            Console.Write("\nInput the position where to delete: ");
            pos = Convert.ToInt32(Console.ReadLine()); 
            i = 0;
            while (i != pos - 1)
                i++; 

            while (i < n)
            {
                arr1[i] = arr1[i + 1]; 
                i++;
            }
            n--; 

            Console.Write("\nThe new list is : ");
            for (i = 0; i < n; i++)
            {
                Console.Write("  {0}", arr1[i]); 
            }
            Console.Write("\n\n");
        }


        public static void matrix()
        {
            int[,] a = new int[3,3];


            for(int i = 0; i<3; i++)
            {
                for(int j = 0; j<3; j++)
                {
                    Console.Write("Element: " , i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Matrix");

            for(int i = 0;i<3; i++)
            {
                Console.WriteLine();
                for (int j = 0;j<3; j++)
                {
                    Console.Write("{0}", a[i, j]);
                }
            }

            Console.WriteLine();
        }
    }
}
