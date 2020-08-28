using System;

namespace Session02Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Binary operataion
            var additionResult = 1 + 2;

            Console.WriteLine("additionResult " + additionResult.ToString());

            var incrementResult = ++additionResult;

            Console.WriteLine("incrementResult " + incrementResult.ToString());

            var trueValue = true;

            var falseValue = false;

            var andResult = trueValue & falseValue;
            var orResult = trueValue & falseValue;
            var xorResult = trueValue ^ falseValue;

            var moduloResult = 3 % 2;


            Console.WriteLine("modulaResult " + moduloResult);

            var highInteger = 1000;
            var integerDivisionResult = highInteger / 3;

            // Implicit värdekonvertering till double
            var doubleDivisionResult = highInteger / 3.0;

            Console.WriteLine("integerDivisionResult " + integerDivisionResult);
            Console.WriteLine("doubleDivisionResult " + doubleDivisionResult);

            var castDivisionResult = (int)(highInteger / 3.0);

            Console.WriteLine("casIntDivisionResult " + castIntDivisionResult);




            var conversionResult = Convert.ToInt32(doubleDivisionResult);

            Console.WriteLine("")

            Console.ReadKey();

        





        }
    }
}
 