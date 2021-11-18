using System;
using System.Collections.Generic;
/*
 * //Hannah Stern
 * Recursion Assignment
 * //10/6/2021
 * Based on Dogon Pot pseudo code from the book
 * African Fractals: Modern Computing and Indigenous Design by Ron Eglash
 */


namespace Recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Example steps to draw a Dogon-like pot.";
            new Pot();
           
            Console.ReadKey();

        }
    }
}