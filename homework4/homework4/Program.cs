using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 0;
    
            Console.WriteLine("Enter the size of an array");
            while ((!int.TryParse(Console.ReadLine(), out size)) || size == 0)
            {
                Console.WriteLine("this is BUKWA or 0");
                Console.WriteLine("Try again..");
            }
            Console.WriteLine("you selected: " + size+ " type each element and press enter.");
            
            int[] array1 = new int[size];
            for (int j = 0; j < size; j++)
            {
               // array1[j] = Convert.ToInt32(Console.ReadLine());
               while ((!Int32.TryParse(Console.ReadLine(),out  array1[j]))|| array1[j]<0)
                {
                    Console.WriteLine("Try again..");
                }
            }
            //verify what we have in array
            Console.WriteLine("[{0}]", string.Join(", ", array1));

            //maximal value 
            int maxV = 0;
            
            for (int i=0; i<size; i++)
            {
                if (array1[i] > maxV)
                {
                    maxV = array1[i];
                }
                
            }
            Console.WriteLine(maxV);
            //minimal value
            int minV = array1[1];

            for (int i = 0; i < size; i++)
            {
                if (minV > array1[i])
                {
                    minV = array1[i];
                }

            }
            Console.WriteLine(minV);

            Console.ReadLine();
        }




    }

}
