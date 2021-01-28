namespace Anagrams.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public interface IAnagramService
    {
        Task<List<string>> GetAnagrams(List<string> input, string givenWord);
    }
}
