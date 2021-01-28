namespace Anagrams
{
    using Anagrams.Services;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public class AnagramsTest
    {
        private readonly IDataService dataService;
        private readonly IAnagramService anagramService;
        public AnagramsTest(IDataService dataService, IAnagramService anagramService)
        {
            this.dataService = dataService;
            this.anagramService = anagramService;
        }
        public async Task Test()
        {
            List<string> testData = await dataService.GetTestData();

            string userInput;
            while (true)
            {
                Console.Write("Enter Word (Ctrl+C to abort): ");
                userInput = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Your input: {0}", userInput);
                Console.WriteLine();

                var collection = await anagramService.GetAnagrams(testData, userInput);
                if(collection != null && collection.Count > 0)
                {
                    Console.WriteLine("List of found anagrams:");
                    for (int index = 0; index < collection.Count; index++)
                    {
                        string item = collection[index];
                        Console.WriteLine($"{index + 1}: {item}");
                    }
                } else
                {
                    Console.WriteLine("No matching anagrams found.");
                }

                Console.WriteLine();

            }
        }
    }
}
