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

        [Test]
        public void deduce_character_permutations_of_two_character_anagram_AB()
        {
            AnagramEngine _anagramEngine = new AnagramEngine();

            List<string> permutations = _anagramEngine.GetPermutations("AB");

            Assert.Multiple(() =>
            {
                Assert.That(permutations.Count, Is.EqualTo(2));
                Assert.That(permutations[0], Is.EqualTo("AB"));
                Assert.That(permutations[1], Is.EqualTo("BA"));
            });

        }

        [Test]
        public void deduce_character_permutations_of_two_character_anagram_CD()
        {
            AnagramEngine _anagramEngine = new AnagramEngine();

            List<string> permutations = _anagramEngine.GetPermutations("CD");

            Assert.Multiple(() =>
            {
                Assert.That(permutations.Count, Is.EqualTo(2));
                Assert.That(permutations[0], Is.EqualTo("CD"));
                Assert.That(permutations[1], Is.EqualTo("DC"));
            });

        }

        [Test]
        public void deduce_character_permutations_of_two_character_anagram_EF()
        {
            AnagramEngine _anagramEngine = new AnagramEngine();

            List<string> permutations = _anagramEngine.GetPermutations("EF");

            Assert.Multiple(() =>
            {
                Assert.That(permutations.Count, Is.EqualTo(2));
                Assert.That(permutations[0], Is.EqualTo("EF"));
                Assert.That(permutations[1], Is.EqualTo("FE"));
            });

        }


    }
}