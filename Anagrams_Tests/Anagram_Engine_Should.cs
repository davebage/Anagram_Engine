using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks.Dataflow;
using Anagrams;
using NUnit.Framework;

namespace Anagrams_Tests
{
    public class Anagram_Engine_Should
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("A")]
        [TestCase("B")]
        [TestCase("C")]
        public void deduce_character_permutations_of_anagram(string anagram)
        {
            AnagramEngine _anagramEngine = new AnagramEngine();

            Assert.That(_anagramEngine.GetPermutations(anagram).First(), Is.EqualTo(anagram));
        }

        private static List<string> sdsdsdsd(params string[] words)
        {
            return words.ToList();
        }

        [Test]
        [TestCase("AB", new string[] { "AB", "BA" })]
        [TestCase("CD", new string[] { "CD", "DC" })]
        [TestCase("EF", new string[] { "EF", "FE" })]
        [TestCase("GH", new string[] { "GH", "HG" })]
        public void deduce_character_permutations_of_two_character_anagram(string anagram, string[] expectedResults)
        {
            AnagramEngine _anagramEngine = new AnagramEngine();

            List<string> permutations = _anagramEngine.GetPermutations(anagram);

            Assert.Multiple(() =>
            {
                Assert.That(permutations.Count, Is.EqualTo(expectedResults.Length));
                Assert.That(permutations, Is.EquivalentTo(expectedResults));
            });

        }


        [Test]
        [TestCase("ABC", new string[] { "ABC", "ACB", "BAC", "BCA", "CAB", "CBA" })]
        [TestCase("DEF", new string[] { "DEF", "DFE", "EDF", "EFD", "FED", "FDE" })]
        [TestCase("GOT", new string[] { "GOT", "GTO", "OGT", "OTG", "TGO", "TOG" })]
        public void deduce_character_permutations_of_three_character_anagram(string anagram, string[] expectedResults)
        {
            AnagramEngine _anagramEngine = new AnagramEngine();

            List<string> permutations = _anagramEngine.GetPermutations(anagram);

            Assert.Multiple(() =>
            {
                Assert.That(permutations.Count, Is.EqualTo(expectedResults.Length));
                Assert.That(permutations, Is.EquivalentTo(expectedResults));
            });

        }

        [Test]
        [TestCase("ABCD", new string[] { "ABCD", "ABDC", "ACDB", "ACBD", "ADBC", "ADCB", "BACD", "BADC", "BCAD", "BCDA", "BDAC", "BDCA", "CABD", "CADB", "CBAD", "CBDA", "CDAB", "CDBA", "DABC", "DACB", "DBAC", "DBCA", "DCAB", "DCBA" })]
        [TestCase("BIRO", new string[] { "BIRO", "BIOR", "BRIO", "BROI", "BORI", "BOIR", "IBRO", "IBOR", "IOBR", "IORB", "IRBO", "IROB", "RBIO", "RBOI", "RIBO", "RIOB", "ROBI", "ROIB", "OBIR", "OBRI", "OIBR", "OIRB", "ORBI", "ORIB" })]
        public void deduce_character_permutations_of_four_character_anagram(string anagram, string[] expectedResults)
        {
            AnagramEngine _anagramEngine = new AnagramEngine();

            List<string> permutations = _anagramEngine.GetPermutations(anagram);

            Assert.Multiple(() =>
            {
                Assert.That(permutations.Count, Is.EqualTo(expectedResults.Length));
                Assert.That(permutations, Is.EquivalentTo(expectedResults));
            });

        }

    }
}