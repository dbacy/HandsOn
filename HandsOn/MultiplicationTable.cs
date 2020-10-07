using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOn
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            /* int sizeOfGrid;
            sizeOfGrid = Utils.GetNumber("Enter number: ");
            for (int header = 0; header<= sizeOfGrid; header++)
            {
                if (header == 0)
                {
                    Console.WriteLine("x\t|\t");
                } 
                else
                {
                    Console.WriteLine(header + "\t");
                } 
            }
            Console.WriteLine("\n--------------------------------");
            for (int x = 1; x <= sizeOfGrid; x++)
            {
                Console.WriteLine(x + "\t|\t");
                for (int y = 1; y<=sizeOfGrid; y++)
                {
                    Console.WriteLine(x * y + "\t");
                }
                Console.WriteLine("\n");

            } */


           
            
            
            
            
            
            /*int j = Utils.GetNumber("Enter A Number: ");
            for (int i = 0; i <= 300; i++)
            {
                Console.WriteLine("{1} X {0} = {2}", i, j, i * j);
                Console.ReadLine();
            } */

           
            
            
            
            
            
            
            
            int j, n;

            n = Utils.GetNumber("Enter Number: ");
            Console.Write("\n");
            for (j = 1; j <= 40; j++)
            {
                Console.Write("{0} X {1} = {2} \n", n, j, n * j);
            }
        }

    }
}
