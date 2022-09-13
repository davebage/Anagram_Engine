namespace Anagrams
{
    public class AnagramEngine
    {
        public List<string> GetPermutations(string originalWord)
        {
            if (originalWord.Length <= 1)
                return new List<string>() { originalWord };

            List<string> anagrams = new List<string>();

            for (int loopIndex = 0; loopIndex < originalWord.Length; loopIndex++)
            {
                var leadCharacter = originalWord.Substring(loopIndex, 1);
                var preLeadCharacter = originalWord.Substring(0, loopIndex);
                var postLeadCharacter = originalWord.Substring(loopIndex + 1);
                var permutations = GetPermutations($"{preLeadCharacter}{postLeadCharacter}");

                foreach (var permutation in permutations)
                    anagrams.Add($"{leadCharacter}{permutation}");
            }

            return anagrams;
        }


    }
}