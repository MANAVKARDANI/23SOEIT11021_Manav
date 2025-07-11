using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6] { 4,6,3,1,5,2};

//index wise
            for (int i = 1; i < arr.Length; i++)
            {
                //arr[i] = i;
                Console.WriteLine(arr[i]);  

            }
            Console.WriteLine("for each loop");
//element wise 
            foreach (int j in arr)
            {
                Console.WriteLine("using foreach loop"+j);
            }
            
        }
    }
}
