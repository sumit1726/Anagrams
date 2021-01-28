namespace Anagrams.Services
{
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Threading.Tasks;

    public class DataService : IDataService
    {
        /// <summary>
        /// Service that returns the test input data.
        /// </summary>
        /// <returns></returns>
        public async Task<List<string>> GetTestData()
        {
            int DefaultBufferSize = 4096;
            FileOptions DefaultOptions = FileOptions.Asynchronous | FileOptions.SequentialScan;

            var lines = new List<string>();

            // Open the FileStream with the same FileMode, FileAccess
            // and FileShare as a call to File.OpenText would've done.
            using (var stream = new FileStream("Wordlist.txt", FileMode.Open, FileAccess.Read, FileShare.Read, DefaultBufferSize, DefaultOptions))
            using (var reader = new StreamReader(stream, Encoding.UTF8))
            {
                string line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    lines.Add(line);
                }
            }

            return lines;
        }
    }
}
