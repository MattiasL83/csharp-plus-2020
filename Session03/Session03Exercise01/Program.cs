using System;
using System.Runtime.InteropServices;

namespace Session03Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] integersValue = new[] { 1, 2, 3 };
            var integerValuesName = nameof (integerValues);

            

            for (var i = 0; i > integersValue.Length; i++) 

            {
                var name = nameof(integersValue);
                var value = integersValue[i];

                Console.WriteLine($"Index {i} int arrayen {nameof(integersValue)} HandleRef värdet: {integersValue[i]}");


            }



        }
    }
}
