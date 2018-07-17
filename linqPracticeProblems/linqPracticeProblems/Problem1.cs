using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqPracticeProblems
{
    class Problem1
    {
       	public static List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
        public static void SearchWord()
        {
            var substringList =
                        from m in words
                        where m.Contains("th")
                        select m;
            foreach (var word in substringList)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
        }
       
    }
}
