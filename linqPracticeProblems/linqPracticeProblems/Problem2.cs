using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqPracticeProblems
{
    class Problem2
    {
        public static List<string> names = new List<string>() { "Mike", "Dan", "Scott", "Nick", "Mike" };
        public static void SearchList()
        {

            var distinctNames = names.Distinct().ToList().OrderBy(d => d);


            foreach (var word in distinctNames)
            {
                Console.WriteLine(word.ToString());
            }
            Console.ReadLine();

        }
      
        

    }
}
