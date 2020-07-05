using System;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace course_03 {
    class Program {
        static void Main(string[] args) {

            string data1 = "2000-08-15 13:05:58";
            string data2 = "2000-08-15T13:05:58Z";

            DateTime d1 = DateTime.Parse(data1);
            DateTime d2 = DateTime.Parse(data2);

            
            Console.WriteLine("d1:" + d1);
            Console.WriteLine("d1 Kind:" + d1.Kind);
            Console.WriteLine("d1 Local:" + d1.ToLocalTime());
            Console.WriteLine("d1 UTC:" + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2:" + d2);
            Console.WriteLine("d2 Kind:" + d2.Kind);
            Console.WriteLine("d2 Local:" + d2.ToLocalTime());
            Console.WriteLine("d2 UTC:" + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("Teste");
        }
    }
}
