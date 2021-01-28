namespace Anagrams.Helper
{
    public static class StringExtensionMethods
    {
        /// <summary>
        /// Extension method that returns an array having counter of each alphabet
        /// in an index based fashion.
        /// </summary>
        /// <param name="word">Given word</param>
        /// <returns></returns>
        public static int[] GetAplhabetCounters(this string word)
        {
            int[] arr = new int[26];

            foreach (var item in word)
            {
                int index = -1;
                if (item >= 'A' && item <= 'Z')
                {
                    index = item - 'A';
                }
                else if (item >= 'a' && item <= 'z')
                {
                    index = item - 'a';
                }
                else continue;
                if(index > -1)
                {
                    arr[index]++;
                }
            }

            return arr;
        }
    }
}
