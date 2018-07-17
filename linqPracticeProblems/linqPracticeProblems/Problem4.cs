using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqPracticeProblems
{
    class Problem4
    {
        public static string lastName = "Terrill";
        
        public static void SearchString()
        {
            var stringLetters =
                        from l in lastName
                        group l by l into y
                        select y;

            foreach (var letter in stringLetters)
            {
                Console.WriteLine("Character " + letter.Key + ": " + letter.Count() + " times");
            }
            Console.ReadLine();
        }
    }
}
