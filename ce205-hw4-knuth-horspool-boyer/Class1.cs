using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * @file ce205_hw4_knuth_horspool_boyer.cs
 * @author Tayfun CANSIZ, Ömer Talha ÖKSÜZ
 * @date 29 December 2022
 *
 * @brief <b> HW-4 Functions </b>
 *
 * HW-4 Sample Functions
 *
 * @see http://bilgisayar.mmf.erdogan.edu.tr/en/
 *
 */

namespace ce205_hw4_knuth_horspool_boyer
{
    public class Class1
    {
        public static class Knuth_Morris_Pratt_Algorithm
        {
            /**
            *   @name   ComputeLps
            *
            *   @brief  This method computes the longest prefix suffix (lps) values for the given pattern.
            *   
            *   @param  [in] pattern [\b string]  is the pattern input to be entered
            *
            *   @retval [\b int] return lps 
            **/
            public static int[] ComputeLps(string pattern)
            {
                int[] lps = new int[pattern.Length];
                int i = 1;
                int j = 0;
                // compare the current character at index 'i' with the current character at index 'j'
                while (i < pattern.Length)
                {
                    if (pattern[i] == pattern[j])
                    {
                        // If the characters match, set the value of lps[i] to j+1 and increment both 'i' and 'j'
                        lps[i] = j + 1;
                        i++;
                        j++;
                    }
                    else
                    {
                        if (j == 0)
                        {
                            // If the characters don't match and 'j' is 0, set the value of lps[i] to 0 and increment 'i'
                            lps[i] = 0;
                            i++;
                        }
                        else
                        {
                            j = lps[j - 1];
                        }
                    }
                }
                // Return the lps array
                return lps;
            }

            /**
            *   @name   KMPSearch
            *
            *   @brief  Knuth Morris Pratt Algorithm
            *   
            *   This method performs a Knuth Morris Pratt (KMP) search on the given text for the given pattern.
            *   
            *   @param  [in] text [\b string]  is the text input to be entered
            *   
            *   @param  [in] pattern [\b string]  is the pattern input to be entered
            *
            *   @retval [\b int] if patttern length equal j, return i-j. Else return -1.
            **/
            public static int KMPSearch(string text, string pattern)
            {
                // It returns the index at which the pattern is found in the text, or -1 if the pattern is not found.
                int[] lps = ComputeLps(pattern);
                int i = 0;
                int j = 0;
                // While the index 'i' is less than the length of the text
                while (i < text.Length)
                {
                    if (text[i] == pattern[j])
                    {
                        i++;
                        j++;
                    }
                    // If 'j' has reached the end of the pattern, it means the pattern has been found.
                    if (j == pattern.Length)
                    {
                        return i - j;
                    }
                    else if (i < text.Length && text[i] != pattern[j])
                    {
                        if (j == 0)
                        {
                            i++;
                        }
                        else
                        {
                            j = lps[j - 1];
                        }
                    }
                }
                // If the loop has finished and the pattern has not been found, return -1
                return -1;
            }
        }
        public static class Horspool_Algorithm
        {
            /**
            *   @name   Search
            *
            *   @brief Horspool Algorithm
            *
            *   Calculates the Horspool algorithm in the given inputs and return as output
            *
            *   @param  [in] haystack [\b string]  is the pattern input to be entered
            *   
            *   @param  [in] needle [\b string]  is the text input to be entered
            *   
            *   @param  [in] startIndex [\b int]  is the starting index
            *
            *   @retval [\b int] if finds return the index if not return -1 
            **/
            public static int Search(string haystack, string needle, int startIndex)
            {

                int haystackLength = haystack.Length;
                int needleLength = needle.Length;

                for (int i = startIndex + needleLength - 1; i < haystackLength; i++)
                {
                    int j;
                    // starting from the last character in the needle and working backwards.
                    for (j = 0; j < needleLength; j++)
                    {
                        if (haystack[i - j] != needle[needleLength - 1 - j])
                        {
                            // If any characters do not match, break out of the inner loop.
                            break;
                        }
                    }
                    // If all characters in the needle match, return the index at which the needle starts in the haystack.
                    if (j == needleLength)
                    {
                        return i - needleLength + 1;
                    }
                }
                // If the loop has finished and the needle has not been found, return -1
                return -1;
            }


        }

        public static class BoyerMooreAlgorithm
        {
            /**
            *   @name   boyerMooreSearch
            *
            *   @brief Boyer Moore Algorithm
            *
            *   Calculates the Boyer Moore Algorithm in the given inputs and return as output
            *
            *   @param  [in] text [\b string]  is the text input to be entered
            *   
            *   @param  [in] pattern [\b string]  is the pattern input to be entered
            *
            *   @retval [\b int] if finds return i if not return -1 
            **/
            public static int boyerMooreSearch(string text, string pattern)
            {
                // when searching key word, moves through a string of text
                for (int i = 0; i < text.Length - pattern.Length; i++)
                {
                    int j;

                    // search key word
                    for (j = pattern.Length - 1; j >= 0; j--)
                    {
                        if (pattern[j] != text[i + j])
                        {
                            break;
                        }
                    }

                    // if found keyword return
                    if (j < 0)
                    {
                        return i;
                    }
                }

                // if not found, return -1
                return -1;
            }
        }
    }
}