using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Collections.Generic;
using static ce205_hw4_needleman_smith_hunt.Class1;
using static ce205_hw4_knuth_horspool_boyer.Class1;
using static ce205_hw4_trie.Class1;
using System.ComponentModel;

namespace ce205_hw4_test_cs
{
    [TestClass]
    public class UnitTest1
    {
        /*String alignment algorithm Tests Start*/

        [TestClass]
        public class NeedlemanTest
        {
            [TestMethod]
            public void Needleman_Test1()
            {
                string sequence1 = "ATCG";
                string sequence2 = "ATCG";
                int match = 1;
                int mismatch = -1;
                int gap = -1;
                string expected = "ATCG\nATCG";
                string actual = NeedlemanWunsch.Align(sequence1, sequence2, match, mismatch, gap);
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Needleman_Test2()
            {
                string sequence1 = "ATCG";
                string sequence2 = "TAGC";
                int match = 1;
                int mismatch = -1;
                int gap = -1;
                string expected = "ATCG\nAGC_";
                string actual = NeedlemanWunsch.Align(sequence1, sequence2, match, mismatch, gap);
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Needleman_Test3()
            {
                string sequence1 = "ATCG";
                string sequence2 = "TCG";
                int match = 1;
                int mismatch = -1;
                int gap = -1;
                string expected = "ATCG\n_TCG";
                string actual = SmithWaterman.Align(sequence1, sequence2, match, mismatch, gap);
                Assert.AreEqual(expected, actual);
            }
        }

        [TestClass]
        public class SmithWatermanTest
        {
            [TestMethod]
            public void SmithWaterman_Test1()
            {
                string sequence1 = "AGCAT";
                string sequence2 = "GAC";
                int match = 1;
                int mismatch = -1;
                int gap = -1;
                string expected = "AGCAT\n_G_AC";
                string actual = SmithWaterman.Align(sequence1, sequence2, match, mismatch, gap);
                Assert.AreEqual(expected, actual);
            }
            
            [TestMethod]
            public void SmithWaterman_Test2()
            {
                string sequence1 = "ATCG";
                string sequence2 = "TCG";
                int match = 1;
                int mismatch = -1;
                int gap = -1;
                string expected = "ATCG\n_TCG";
                string actual = SmithWaterman.Align(sequence1, sequence2, match, mismatch, gap);
                Assert.AreEqual(expected, actual);
            }
            
            [TestMethod]
            public void SmithWaterman_Test3()
            {
                string sequence1 = "TGCAT";
                string sequence2 = "AGCAT";
                int match = 1;
                int mismatch = -1;
                int gap = -1;
                string expected = "TGCAT\nAGCAT";
                string actual = NeedlemanWunsch.Align(sequence1, sequence2, match, mismatch, gap);
                Assert.AreEqual(expected, actual);
            }

        }

        [TestClass]
        public class HuntTest
        {
            [TestMethod]
            public void HuntSzymanski_Test1()
            {
                string sequence1 = "AGCAT";
                string sequence2 = "GAC";
                int gap = -1;
                int match = 1;
                int mismatch = -1;

                string expected = "AGCAT\n_G_AC";
                string actual = HuntSzymanski.Align(sequence1, sequence2, gap, match, mismatch);

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void HuntSzymanski_Test2()
            {
                string sequence1 = "ACAGT";
                string sequence2 = "ACGT";
                int gap = -1;
                int match = 1;
                int mismatch = -1;

                string expected = "ACAGT\nAC_GT";
                string actual = HuntSzymanski.Align(sequence1, sequence2, gap, match, mismatch);

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void HuntSzymanski_Test3()
            {
                string sequence1 = "TGCAT";
                string sequence2 = "AGCAT";
                int gap = -1;
                int match = 1;
                int mismatch = -1;

                string expected = "GCAT\nGCAT";
                string actual = HuntSzymanski.Align(sequence1, sequence2, gap, match, mismatch);

                Assert.AreEqual(expected, actual);
            }
        }

        /*String alignment algorithm Tests End*/

        /*String search algorithm Tests START */


        [TestClass]
        public class HorspoolTest
        {

            [TestMethod]
            public void horspoolSearch_Test1()
            {
                string haystack = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam dignissim justo ut erat blandit, id ultrices est condimentum.";
                string needle =  "erat blandit";

                int result = Horspool_Algorithm.Search(haystack, needle, 0);

                Assert.AreEqual(80, result);
            }

            [TestMethod]
            public void horspoolSearch_Test2()
            {
                string haystack = "Duis erat lectus, condimentum ac sem eu, pretium blandit tellus.";
                string needle = "ac sem eu";

                int result = Horspool_Algorithm.Search(haystack, needle, 0);

                Assert.AreEqual(30, result);
            }

            [TestMethod]
            public void horspoolSearch_Test3()
            {
                string haystack = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
                string needle = "consectetur";

                int result = Horspool_Algorithm.Search(haystack, needle, 0);

                Assert.AreEqual(28, result);
            }

        }

        [TestClass]
        public class KnuthTest
        {
            [TestMethod]
            public void kmpSearch_Test1()
            {
                string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam dignissim justo ut erat blandit, id ultrices est condimentum.";
                string pattern = "dignissim justo";
                int expected = 61;
                int result = Knuth_Morris_Pratt_Algorithm.KMPSearch(text, pattern);
                Assert.AreEqual(expected, result);
            }

            [TestMethod]
            public void kmpSearch_Test2()
            {
                string text = "In lacus justo, tempor nec consequat ut, pretium malesuada augue.";
                string pattern = "tempor nec consequat ";
                int expected = 16;
                int result = Knuth_Morris_Pratt_Algorithm.KMPSearch(text, pattern);
                Assert.AreEqual(expected, result);
            }

            [TestMethod]
            public void kmpSearch_Test3()
            {
                string text = "Duis erat lectus, condimentum ac sem eu, pretium blandit tellus.";
                string pattern = "pretium blandit";
                int expected = 41;
                int result = Knuth_Morris_Pratt_Algorithm.KMPSearch(text, pattern);
                Assert.AreEqual(expected, result);
            }

        }

        [TestClass]
        public class BoyerTest
        {
            [TestMethod]
            public void boyerMooreSearch_Test1()
            {
                // create test data.
                string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
                string pattern = "sit";

                // BoyerMooreSearch() call method and assign the result.
                int result = BoyerMooreAlgorithm.boyerMooreSearch(text, pattern);

                // check expected result
                Assert.AreEqual(18, result);
            }


            [TestMethod]
            public void boyerMooreSearch_Test2()
            {
                // create test data.
                string text = "Aliquam congue auctor euismod.";
                string pattern = "auctor";

                // BoyerMooreSearch() call method and assign the result.
                int result = BoyerMooreAlgorithm.boyerMooreSearch(text, pattern);

                // check expected result
                Assert.AreEqual(15, result);
            }


            [TestMethod]
            public void boyerMooreSearch_Test3()
            {
                // create test data
                string text = "Phasellus scelerisque efficitur mi vitae tempor. Maecenas imperdiet risus a enim condimentum varius.";
                string pattern = "risus";

                // BoyerMooreSearch() call method and assign the result.
                int result = BoyerMooreAlgorithm.boyerMooreSearch(text, pattern);

                // check expected result
                Assert.AreEqual(68, result);
            }

        }
       
        //TRIE ALGORITHM TESTS

        [TestClass]
        public class TrieTests
        {


            [TestMethod]
            public void Trie_Test1()
            {
                // Arrange
                Trie trie = new Trie();
                trie.Insert("car");
                trie.Insert("card");
                trie.Insert("care");
                trie.Insert("cares");
                trie.Insert("cared");
                trie.Insert("careful");
                trie.Insert("carefully");

                // Act
                IEnumerable<string> words = trie.GetWords("ca");

                // Assert
                CollectionAssert.AreEqual(new string[] { "car", "card", "care", "cares", "cared", "careful", "carefully" }, words.ToArray());
            }

            [TestMethod]
            public void Trie_Test2()
            {
                // Arrange
                var trie = new Trie();
                trie.Insert("cat");
                trie.Insert("car");
                trie.Insert("cart");
                trie.Insert("dog");
                trie.Insert("dot");

                // Act
                var words = trie.GetWords("x").ToList();

                // Assert
                CollectionAssert.AreEqual(new List<string>() {/*must empty for result correct*/}, words);
            }

            [TestMethod]
            public void Trie_Test3()
            {
                // Arrange
                var trie = new Trie();
                trie.Insert("dong");
                trie.Insert("door");
                trie.Insert("down");
                trie.Insert("fee");
                trie.Insert("free");

                // Act
                var words = trie.GetWords("fly").ToList();

                // Assert
                CollectionAssert.AreEqual(new List<string>(), words);
            }

        }





    }
}