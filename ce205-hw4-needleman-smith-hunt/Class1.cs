using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * @file ce205-hw4-needleman-smith-hunt.cs
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

namespace ce205_hw4_needleman_smith_hunt
{
    public class Class1
    {

        public static class NeedlemanWunsch
        {
            /**
            *   @name   Align
            *
            *   @brief Needleman Wunsch Algorithm
            *
            *   Calculates the Needleman Wusnch algorithm in the given inputs and return as output
            *
            *   @param  [in] sequence1 [\b string]  is the first input to be entered
            *   
            *   @param  [in] sequence2 [\b string]  is the second input to be entered
            *   
            *   @param  [in] match [\b int] is the score that is assigned when two characters from the two sequences match. 
            *   
            *   @param  [in] mismatch [\b int] is the score that is assigned when two characters from the two sequences do not match.
            *
            *   @param  [in] gap [\b int] is the penalty that is assigned when there is a gap in one of the sequences
            *
            *   @retval [\b int] if finds return first aligned sequence with newline second aligned sequence
            **/
            public static string Align(string sequence1, string sequence2, int match, int mismatch, int gap)
            {
                // Initialize the scoring matrix with zeros
                int[,] scoreMatrix = new int[sequence1.Length + 1, sequence2.Length + 1];

                // Fill in the scoring matrix
                for (int x = 1; x <= sequence1.Length; x++)
                {
                    for (int y = 1; y <= sequence2.Length; y++)
                    {
                        int matchScore = scoreMatrix[x - 1, y - 1] + (sequence1[x - 1] == sequence2[y - 1] ? match : mismatch);
                        int delete = scoreMatrix[x - 1, y] + gap;
                        int insert = scoreMatrix[x, y - 1] + gap;
                        scoreMatrix[x, y] = Math.Max(Math.Max(matchScore, delete), insert);
                    }
                }

                // Initialize the aligned sequences
                string alignedSeq1 = "";
                string alignedSeq2 = "";

                // Traceback to compute the alignment
                int k = sequence1.Length;
                int l = sequence2.Length;
                while (k > 0 && l > 0)
                {
                    if (k > 0 && l > 0 && scoreMatrix[k, l] == scoreMatrix[k - 1, l - 1] + (sequence1[k - 1] == sequence2[l - 1] ? match : mismatch))
                    {
                        alignedSeq1 = sequence1[k - 1] + alignedSeq1;
                        alignedSeq2 = sequence2[l - 1] + alignedSeq2;
                        k--;
                        l--;
                    }
                    else if (k > 0 && scoreMatrix[k, l] == scoreMatrix[k - 1, l] + gap)
                    {
                        alignedSeq1 = sequence1[k - 1] + alignedSeq1;
                        alignedSeq2 = "_" + alignedSeq2;
                        k--;
                    }
                    else
                    {
                        alignedSeq1 = "_" + alignedSeq1;
                        alignedSeq2 = sequence2[l - 1] + alignedSeq2;
                        l--;
                    }
                }
                // Return the aligned sequences as a single string, separated by a new line character
                return alignedSeq1 + "\n" + alignedSeq2;
            }
        }
        public static class SmithWaterman
        {
            /**
            *   @name   Align
            *
            *   @brief Smith-Waterman Algorithm
            *
            *   Calculates the Needleman Wusnch algorithm in the given inputs and return as output
            *
            *   @param  [in] sequence1 [\b string]  is the first input to be entered
            *   
            *   @param  [in] sequence2 [\b string]  is the second input to be entered
            *   
            *   @param  [in] match [\b int] is the score that is assigned when two characters from the two sequences match. 
            *   
            *   @param  [in] mismatch [\b int] is the score that is assigned when two characters from the two sequences do not match.
            *
            *   @param  [in] gap [\b int] is the penalty that is assigned when there is a gap in one of the sequences
            *
            *   @retval [\b int] if finds return first aligned sequence with newline second aligned sequence
            **/
            public static string Align(string sequence1, string sequence2, int match, int mismatch, int gap)
            {
                // Create a 2D array to store the dynamic programming values
                int[,] dp = new int[sequence1.Length + 1, sequence2.Length + 1];
                // Initialize the first row and column of the array to 0
                for (int k = 0; k <= sequence1.Length; k++)
                {
                    dp[k, 0] = 0;
                }
                for (int l = 0; l <= sequence2.Length; l++)
                {
                    dp[0, l] = 0;
                }

                // Loop through the array, filling in the values using the Smith-Waterman algorithm
                for (int x = 1; x <= sequence1.Length; x++)
                {
                    for (int y = 1; y <= sequence2.Length; y++)
                    {
                        int currMatch = 0;
                        int currMismatch = 0;
                        int currGap ;

                        // Calculate the match, mismatch, and gap values based on the characters at each position
                        if (sequence1[x - 1] == sequence2[y - 1])
                        {
                            currMatch = dp[x - 1, y - 1] + match;
                        }
                        else
                        {
                            currMismatch = dp[x - 1, y - 1] + mismatch;
                        }
                        currGap = Math.Max(dp[x - 1, y] + gap, dp[x, y - 1] + gap);

                        // Take the maximum value between match/mismatch and gap as the current value
                        dp[x, y] = Math.Max(Math.Max(currMatch, currMismatch), currGap);
                    }
                }

                // Initialize variables to store the aligned sequences
                string alignedSequence1 = "";
                string alignedSequence2 = "";

                // Loop through the array, starting from the bottom right corner
                int i = sequence1.Length;
                int j = sequence2.Length;
                while (i > 0 && j > 0)
                {
                    // If the current value is a match or mismatch, add the characters to the aligned sequences and move diagonally
                    if (dp[i, j] == dp[i - 1, j - 1] + (sequence1[i - 1] == sequence2[j - 1] ? match : mismatch))
                    {
                        alignedSequence1 = sequence1[i - 1] + alignedSequence1;
                        alignedSequence2 = sequence2[j - 1] + alignedSequence2;
                        i--;
                        j--;
                    }
                    // If the current value is a gap, add a gap character to the aligned sequence that corresponds to the gap and move up or left
                    else if (dp[i, j] == dp[i - 1, j] + gap)
                    {
                        alignedSequence1 = sequence1[i - 1] + alignedSequence1;
                        alignedSequence2 = "_" + alignedSequence2;
                        i--;
                    }
                    else
                    {
                        alignedSequence1 = "_" + alignedSequence1;
                        alignedSequence2 = sequence2[j - 1] + alignedSequence2;
                        j--;
                    }
                }
                // Add any remaining characters to the aligned sequences, adding gap characters as necessary
                while (i > 0)
                {
                    alignedSequence1 = sequence1[i - 1] + alignedSequence1;
                    alignedSequence2 = "_" + alignedSequence2;
                    i--;
                }
                while (j > 0)
                {
                    alignedSequence1 = "_" + alignedSequence1;
                    alignedSequence2 = sequence2[j - 1] + alignedSequence2;
                    j--;
                }

                // Return the aligned sequences as a single string, separated by a new line character
                return alignedSequence1 + "\n"+ alignedSequence2;
            }

        }
            public static class HuntSzymanski
            {
           
            /**
            *   @name   Align
            *
            *   @brief Hunt-Szymanski Algorithm
            *
            *   Calculates the Needleman Wusnch algorithm in the given inputs and return as output
            *
            *   @param  [in] sequence1 [\b string]  is the first input to be entered
            *   
            *   @param  [in] sequence2 [\b string]  is the second input to be entered
            *   
            *   @param  [in] match [\b int] is the score that is assigned when two characters from the two sequences match. 
            *   
            *   @param  [in] mismatch [\b int] is the score that is assigned when two characters from the two sequences do not match.
            *
            *   @param  [in] gap [\b int] is the penalty that is assigned when there is a gap in one of the sequences
            *
            *   @retval [\b int] if finds return first aligned sequence with newline second aligned sequence
            **/

            public static string Align(string sequence1, string sequence2, int gap, int match, int mismatch)
                {
                    // Create a 2D array to store the dynamic programming values
                    int[,] dp = new int[sequence1.Length + 1, sequence2.Length + 1];

                // Initialize the first row and column of the array to 0
                    for (int x = 0; x <= sequence1.Length; x++)
                    {
                        dp[x, 0] = 0;
                    }
                    for (int y = 0; y <= sequence2.Length; y++)
                    {
                        dp[0, y] = 0;
                    }

                    // Loop through the array, filling in the values using the Smith-Waterman algorithm
                    for (int k = 1; k <= sequence1.Length; k++)
                    {
                        for (int l = 1; l <= sequence2.Length; l++)
                        {
                            int currMatch = 0;
                            int currMismatch = 0;
                            int currGap;

                            // Calculate the match, mismatch, and gap values based on the characters at each position

                    if (sequence1[k - 1] == sequence2[l - 1])
                            {
                                currMatch = dp[k - 1, l - 1] + match;
                            }
                            else
                            {
                                currMismatch = dp[k - 1, l - 1] + mismatch;
                            }
                            currGap = Math.Max(dp[k - 1, l] + gap, dp[k, l - 1] + gap);

                            // Take the maximum value between match/mismatch and gap as the current value
                            dp[k, l] = Math.Max(Math.Max(currMatch, currMismatch), Math.Max(currGap, 0));
                        }
                    }

                    // Initialize variables to store the aligned sequences
                    string alignedSequence1 = "";
                    string alignedSequence2 = "";

                    // Loop through the array, starting from the bottom right corner
                    int i = sequence1.Length;
                    int j = sequence2.Length;
                    while (i > 0 && j > 0)
                    {
                        // If the current value is a match or mismatch, add the characters to the aligned sequences and move diagonally
                        if (dp[i, j] == dp[i - 1, j - 1] + (sequence1[i - 1] == sequence2[j - 1] ? match : mismatch))
                        {
                            alignedSequence1 = sequence1[i - 1] + alignedSequence1;
                            alignedSequence2 = sequence2[j - 1] + alignedSequence2;
                            i--;
                            j--;
                        }
                        // If the current value is a gap, add a gap character to the aligned sequence that corresponds to the gap and move up or left
                        else if (dp[i, j] == dp[i - 1, j] + gap)
                        {
                            alignedSequence1 = sequence1[i - 1] + alignedSequence1;
                            alignedSequence2 = "_" + alignedSequence2;
                            i--;
                        }
                        else if (dp[i, j] == dp[i, j - 1] + gap)
                        {
                            alignedSequence1 = "_" + alignedSequence1;
                            alignedSequence2 = sequence2[j - 1] + alignedSequence2;
                            j--;
                        }
                        // If the current value is 0, move up or left to the next value
                        else
                        {
                            i--;
                            j--;
                        }
                    }
                    // Add any remaining characters to the aligned sequences, adding gap characters as necessary
                    while (i > 0)
                    {
                        alignedSequence1 = sequence1[i - 1] + alignedSequence1;
                        alignedSequence2 = "_" + alignedSequence2;
                        i--;
                    }
                    while (j > 0)
                    {
                        alignedSequence1 = "_" + alignedSequence1;
                        alignedSequence2 = sequence2[j - 1] + alignedSequence2;
                        j--;
                    }

                    // Return the aligned sequences as a single string, separated by a new line character
                    return alignedSequence1 + "\n"+ alignedSequence2;
                }

            }
    }
}