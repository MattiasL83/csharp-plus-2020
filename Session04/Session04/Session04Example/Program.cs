using System;
using System.Linq;

namespace Session04Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[4] { 1, 2, 3, 4 };

            // Antalet värden i arrayen
            int arrayLenght = array.Length;

            // Komma åt data i arrayen, index är baserat på 0
            int firstposition = array[0];

            char[] vowels = new char[] { 'a', 'e', 'o', 'u', 'i', 'y', 'å', 'ä', 'ö' };

            //Se om arayen innehåller ett värde
            //Använda Linq
            vowels.Contains('å');

            //Ger ett index på vilken position i arrayen som innehåller tex å
            // -1 om det givna värdet inte finns
            int vovwelIndex = Array.IndexOf(vowels, 'å');

            // Ovan är samma som detta, det som skiljer är att man får tillbaks sista positionen.
            int vowelIndexFromLoop = -1;

            for (int i = 0; i < vowels.Length; i++)
            {
                var currentVowel = vowels[i];
                if (currentVowel == 'å')
                {
                    vowelIndexFromLoop = currentVowel;
                    break;

                }

                // Man bör skriva så här
                vowelIndexFromLoop = -1;

                for (int i = 0; i < vowels.Length; i++)
                {
                    var currentVowel = vowels[i];
                    if (currentVowel != 'å')
                        continue;
                    
                        vowelIndexFromLoop = currentVowel;
                        break;

                }
                // Går att göra samma sak med tex språk-koder

                string [] supportedLanguages = new string[] { "sv", "no", "dk" };


                }

            




            






        }
    }
}
, 