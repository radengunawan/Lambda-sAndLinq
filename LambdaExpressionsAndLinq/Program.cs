using System;

namespace LambdaExpressionsAndLinq
{
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            //var array = new[] { 1, 2, 3, 4,10 };                  // <-- after originally

            List<int> array = new List<int>() { 1, 2, 3, 4, 10 }; // <-- after modification

            var result = array.Select(i => i * 3); // from i in array select i * 2;
            
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}
