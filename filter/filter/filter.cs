//Angelo Maragos
// This program devines a generic interface IFilterable<T>.  This is interface is used to filter a collection of elements on some critera (greater/less than, length, 
// or if a certain element is equal to a specific value.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UML.Assignment8
{
    class Program
    {

        static void Main(string[] args)
        {

            FilteredList<int> fi = new FilteredList<int>();
            Console.WriteLine("Given the following list of numbers: ");
            Console.WriteLine("-601, 100, 200, 300, 400, 500, 501, 600, 700, 800, 900");
            Console.WriteLine("Show those numbers that are greater than 500.");
            Console.WriteLine();
            fi.AddRange(new int[] { -601, 100, 200, 300, 400, 500, 501, 600, 700, 800, 900 }); ////adding the following int elements

            foreach (int i in fi)
            {
                if (fi.ElementBelongs(i, j => j > 500))  //for each int element greater than 500, display int element
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine();

            FilteredList<string> fs = new FilteredList<string>();
            fs.AddRange(new string[] {  
                "joe", "jack", "marcy", "angelo", "kim", "sugar", "melissa", "jessica", "jill", "john" });  //adding the following string elements
            Console.WriteLine("Given the following names:");
            Console.WriteLine("joe, jack, marcy, angelo, kim, sugar, melissa, jessica, jill, john");
            Console.WriteLine("Show those names that are greater than four charaters/letters long in length");
            Console.WriteLine();
            foreach (string s in fs)
            {
                if (fs.ElementBelongs(s, name => name.Length > 4))  //for each string element greater than 4 characters, display string
                {
                    Console.WriteLine(s);
                }
            }

            Console.WriteLine();

            int i0 = 0;
            FilteredList<char> fc = new FilteredList<char>();
            fc.AddRange(new char[] {  
            'a', 'b', 'c', 'c', 'c', 'd', 'e', 'f','c' });  //adding the following char elements

            Console.WriteLine("Given the following char characters/letters:");
            Console.WriteLine(" 'a', 'b', 'c', 'c', 'c', 'd', 'e', 'f','c' ");
            Console.WriteLine("How many times does 'c' appear?");
            Console.WriteLine();

            foreach (char c in fc)
            {
                if (fc.ElementBelongs(c, chars => chars.Equals('c')))  // for each elemen 'c', increment counter
                {
                    i0++;

                   
                }


            }

            Console.WriteLine(i0);
            Console.WriteLine();


            int x = 0;

            //create polar point objects.
            //polar point coordinates are made of radius and angle values
            Pnt.PolarPoint fp0 = new Pnt.PolarPoint(3, 5);
            Pnt.PolarPoint fp1 = new Pnt.PolarPoint(3, 6);
            Pnt.PolarPoint fp2 = new Pnt.PolarPoint(1, 6);
            Pnt.PolarPoint fp3 = new Pnt.PolarPoint(3, 7);
            FilteredList<Pnt.PolarPoint> fp = new FilteredList<Pnt.PolarPoint>();
            fp.AddRange(new Pnt.PolarPoint[] 
            {
                fp0, fp1, fp2, fp3   //add polar point objects
            });

            Console.WriteLine("Given the following Polar Point (radius & angle) coordinates:");
            Console.WriteLine(" (3, 5), (3, 6), (1, 6), (3, 7)");
            Console.WriteLine("How many Polar Point coordinates have an angle of 6?");
            Console.WriteLine();
            foreach (Pnt.PolarPoint p0 in fp)
            {
             
               
                if (fp.ElementBelongs(p0, pp0 => pp0._angle.Equals(6)))   //for each polar point object that meets this critera (angle = 6)  increment cntr
                {
                  
                    x++;
                 
                }
             
               

            }


            Console.WriteLine(x);
            Console.WriteLine();

            Console.WriteLine("Press enter to exit.");

            Console.ReadLine();
        }
    }
}
