namespace Anagrams.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public interface IDataService
    {
        Task<List<string>> GetTestData();
    }
}
