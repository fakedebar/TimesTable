﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Ask the user for a number for the table
 * Write a for loop to print X times table
 */
namespace PartII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            int number = Convert.ToInt32(Console.ReadLine());   

            for (int i =1; i <=10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", i,number,i*number);
            }
            Console.ReadLine();
        }
    }
}
