namespace Anagrams
{
    public class AnagramEngine
    {
        public List<string> GetPermutations(string originalWord)
        {
            char[] charArray = originalWord.ToCharArray();

            List<string> anagrams = new() { new string(charArray) };

            if (originalWord.Length > 1)
            {
                Array.Reverse(charArray);
                anagrams.Add(new string(charArray));
            }


            return anagrams;
        }


    }
}