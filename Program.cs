using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace array_class_methods
{
    class Program
    {
        static void Main(string[] args)
        {
        int[] array ={23,12,4,86,72,3,11,17};
        foreach(var n in array){
            Console.WriteLine(n);
        } 
        Console.WriteLine("----------");
        Array.Sort(array);
        foreach(var n in array){
            Console.WriteLine(n);
        }
        Array.Clear(array,2,3);
        Console.WriteLine("----------");
        foreach(var n in array){
            Console.WriteLine(n);
        }
        Console.WriteLine("----------");
        Array.Reverse(array);
        foreach(var n in array){
            Console.WriteLine(n);
        }
        Console.WriteLine("----------");
        Console.WriteLine(Array.IndexOf(array,23));
        Console.WriteLine("----------");

        Array.Resize<int>(ref array,9);
        array[8]=99;
        foreach(var n in array){
            Console.WriteLine(n);
        }
        }
    }
}