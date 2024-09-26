using System;                      // importing namspaces, can be pre-defined or user-defined  
using System.Collections.Generic;  //  for using properties and methods of that class or interface 
using System.Linq;                 //  present under that namespace 
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasics  // declaring namespaces which binds methods and prperties of 
                       // classes and interfaces under one namespace, can be used as import namespace
{

    class Addition  // class declaration
    {
        public int add(int a, int b)  // method or function
        {
            return a + b;
        }
    }

    internal class Program      // class declaration
    {
        static void Main(string[] args)     // main method, starting point of execution
        {
            int a, b;       // varaible declaration
            Addition addition = new Addition();     // object of class is created
            Console.WriteLine("Enter the value of first number");   // printing in console
            a = Int32.Parse(Console.ReadLine());    // reading input from user
            Console.WriteLine("Enter the value of second number");  // printing in console
            b = Int32.Parse(Console.ReadLine());    // reading input from user
            int sum = addition.add(a, b);   // function call with the help of object 
            Console.WriteLine($"The addition of {a}, {b} is : {sum}");
            Console.ReadKey();  // holding console until a key is pressed 
        }
    }
}
