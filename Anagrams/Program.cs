namespace Anagrams
{
    using Anagrams.Services;
    using System.Threading.Tasks;

    class Program
    {
        static async Task Main(string[] args)
        {
            AnagramsTest anagramsTest = new AnagramsTest(new DataService(), new AnagramService());
            await anagramsTest.Test();
        }
    }
}
