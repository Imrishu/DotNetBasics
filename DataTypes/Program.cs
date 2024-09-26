using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 *                                                        C# Data Types
 *                                   --------------------------------------------------------                 
 *                                  |                             |                          |
 *                         Value DataType             Pointer DataType             Reference DataType
 *                                |                                                     |
 *              -------------------------------                      ------------------------------
 *             |                               |                     |                             |
 *         Pre defined                   User defined          Pre defined               User defined  
 *              |                              |                      |                        |
 *           int, bool, char               struct, enum            string, object     class, interface
 */

// value data type = The data type which stores the value directly in the memory is called the Value Data Type in C#
// reference data type = the reference types do not store the actual data stored in a variable, rather they store the reference to the variables.
// pointer data type = pointer-type variables stores the memory address of another type.

namespace DataTypes
{
    internal class Program
    {
        struct q
        {
            public int a;
            public string b;
        };

        enum days
        {
            sun,
            mon,
            tue
        }

        static void Main(string[] args)
        {
            byte a = 200;  // byte stores 2^8 = 256 numbers max i.e 0 to 255
            sbyte b = 100; // sbyte is signed version of byte stores -128 to 127 numbers
            short c = 1234; // 2 bytes 
            ushort d = 123; // 2 bytes unsigned
            Int16 e = 132; // 2 bytes int
            int f = 132; // 4 bytes int or Int32
            Int64 g = 132; // 8 bytes int
            UInt16 h = 145; // 2 bytes unsigned int
            uint i = 1323; // 4 bytes unsigned int
            UInt64 j = 1313; // 8 bytes unsigned int
            float k = 1.23f; // 4 bytes with suffix f at end
            double l = 1.23323;  // 8 byte , by default all decimal numbers are double
            decimal m = 1.2332m; // 16 bytes with suffix m at end
            char n = 'A'; // 2 byte
            bool o = true; // 1 byte
            string p = "Hello"; // 2 * number of characters in the string

            /*
             * to get size of pre-defined data types = sizeof() method
             * to get default value of pre-defined data type = default() method
             * to get min and max value of pre-defined data type = MinValue() and MaxValue() method
             */

            q struc;
            struc.a = 12;
            struc.b = "structure";

            days day = days.mon;  // by default 0 is assign to first followed by 1 and so on
        }
    }
}
