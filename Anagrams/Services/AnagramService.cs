namespace Anagrams.Services
{
    using Anagrams.Helper;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class AnagramService : IAnagramService
    {
        /// <summary>
        /// Service that returns the list of anagrams for given input list of string.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="givenWord"></param>
        /// <returns></returns>
        public async Task<List<string>> GetAnagrams(List<string> input, string givenWord)
        {
            List<string> anagrams = new List<string>();
            int[] counter2 = givenWord.GetAplhabetCounters();

            Task task = Task.Run(() => input.ForEach(word =>
            {
                int[] counter1 = word.GetAplhabetCounters();

                if (Utility.AreEqual(counter1, counter2))
                {
                    anagrams.Add(word);
                }
            }));

            await task;
            return anagrams;
        }
    }
}
