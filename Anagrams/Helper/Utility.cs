namespace Anagrams.Helper
{
    public static class Utility
    {
        /// <summary>
        /// Utility to check if given alphabet counter arrays are equal
        /// </summary>
        /// <param name="counterArray1"></param>
        /// <param name="counterArray2"></param>
        /// <returns></returns>
        public static bool AreEqual(int[] counterArray1, int[] counterArray2)
        {
            bool areEqual = true;
            int l1 = counterArray1.Length;
            int l2 = counterArray2.Length;
            if (l1 == l2)
            {
                for (int i = 0; i < l1; i++)
                {
                    if (counterArray1[i] != counterArray2[i])
                    {
                        areEqual = false;
                        break;
                    }
                }

            }
            else
            {
                areEqual = false;
            }


            return areEqual;
        }
    }
}
