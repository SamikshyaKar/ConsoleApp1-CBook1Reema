using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_CBook1Reema.Array
{
    public class Array1
    {
        public static Random rand = new Random();

        public static void FindSecLargest()
        {
            int[] arr = new int[10];
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = rand.Next(1, 100);
            }
            foreach(int i in arr)
            {
                Console.Write( "  " + i);
            }
            int largest = arr[0];int lar_pos = 0;

            for(int i=0; i<arr.Length;i++)
            {
                if(arr[i] > largest)
                {
                    largest = arr[i];
                    lar_pos = i;
                }

            }
            int Sec_largest = arr[arr.Length-lar_pos-1]; int Sec_largePos = 0;
            for(int i=0;i<arr.Length; i++)
            {
                if(i!=lar_pos)
                {
                    if (arr[i] > Sec_largest)
                    {
                        Sec_largest = arr[i];
                        Sec_largePos = i;
                    }
                       
                }
            }
            Console.WriteLine();
            Console.WriteLine(" The Largest Position is " + lar_pos + " And the Largest Number is " + largest);
            Console.WriteLine();
            Console.WriteLine(" The Second Largest Position is " + Sec_largePos + " And The Second Largest Num " +Sec_largest);
            Console.ReadLine();
        }
    }
}
