using System;
using System.Runtime.CompilerServices;

namespace Session04Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string inputData = "   ";

            // Kontrollera om strängen är tilldelad ett värde
            bool inputIsNull = inputData == null;
            bool inputIsEmty = inputData == string.Empty; // inputData == "";

            // Snabbmetod för att kontrollera innehållet i en sträng
            bool inputIsNullOrEmty = string.IsNullOrEmpty(inputData);

            // Ytterliggare kontroller om strängen innehåller vettig data
            bool inputNullOrWhitespace = string.IsNullOrWhiteSpace(inputData);

            string sentence = "   This is a sentence of text, it contains many words.    ";

            // Trimma bort mellanslag och andra whitespace-tecken från början och slutet
            string trimmedSentence = sentence.Trim();
            string endTrimmedSentence = sentence.TrimEnd();

            // Det går att ange ett speciellt tecken som skall tas bort
            string punctuationTrimmeSentence = endTrimmedSentence.TrimEnd('.');


            string searchForWord = "text";
            int indexOfText = trimmedSentence.IndexOf(searchForWord);

            // Hämta bara området som letas efter
            string hitsubString = trimmedSentence.Substring(indexOfText, searchForWord.Length);
            string beforehitsubString = trimmedSentence.Substring(0, indexOfText);

            // Stora små bokstäver
            string uppercaseString = trimmedSentence.ToUpper();
            string lowercaseString = trimmedSentence.ToLower();

            // Struntar i språkinställningar
            string uppercaseInvariantString = trimmedSentence.ToUpperInvariant();

            // Komma åt ett enskilt tecken
            char oneCharater = trimmedSentence[0];

            for(int i = 0; i < trimmedSentence.Length; i++)
            {
                //Loopa igenom en sträng, tecken för tecken
                char currentCharacter = trimmedSentence[i];

            }
            char[] trimmedSentenceCharArray = trimmedSentence.ToCharArray();

            // Modifiera datat;

            trimmedSentence = new string(trimmedSentenceCharArray);

            trimmedSentence = trimmedSentence + "...";
            // samma sak som ovan
            // trimmedSentence += "...";

            //1
            //123
            //2
            //23
            //3

            //001
            //002
            //003
            //023
            //123

            var numberInString = "12";
            var paddeNumberInString = numberInString.PadLeft(3, '0');







        }
    }
}
