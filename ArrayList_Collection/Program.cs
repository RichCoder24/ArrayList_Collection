using System;
using System.Collections;
using System.Collections.Generic;


namespace ArrayList_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList(2);
            Console.WriteLine(array.Capacity);
            array.Add(10);
            Console.WriteLine(array.Capacity);
            array.Add(20);
            array.Add(30);
            array.Add(40);
            Console.WriteLine(array.Capacity);
            array.Add(50);
            Console.WriteLine(array.Capacity);
            array.Add(60);
            Console.WriteLine(array.Capacity);

            Console.WriteLine("Added project to the GitHub Repository !");
            
            foreach (object i in array)
            {
                Console.Write(i + " ");
            }
            array.Insert(3, 35);

            Console.WriteLine();
            foreach (object i in array)
            {
                Console.Write(i + " ");
            }

            //array.Remove(50);
            array.RemoveAt(5);
            Console.WriteLine();

            foreach (object i in array)
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();
        }
    }
}
