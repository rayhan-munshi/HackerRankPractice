using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hr_Sparse_Array
{
    class Result
    {

        /*
         * Complete the 'matchingStrings' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. STRING_ARRAY stringList
         *  2. STRING_ARRAY queries
         */

        public static List<int> matchingStrings(List<string> stringList, List<string> queries)
        {
            List<int> returnList = new List<int>();


            foreach (var q in queries)
            {
                int found = 0;
                foreach (var str in stringList)
                {
                    if (str == q)
                    {
                        found++;
                    }
                }
                returnList.Add(found);
            }
            return returnList;

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {


            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int stringListCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> stringList = new List<string>();

            for (int i = 0; i < stringListCount; i++)
            {
                string stringListItem = Console.ReadLine();
                stringList.Add(stringListItem);
            }

            int queriesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> queries = new List<string>();

            for (int i = 0; i < queriesCount; i++)
            {
                string queriesItem = Console.ReadLine();
                queries.Add(queriesItem);
            }

            List<int> res = Result.matchingStrings(stringList, queries);

            //textWriter.WriteLine(String.Join("\n", res));

            //textWriter.Flush();
            //textWriter.Close();


        }
    }
}
