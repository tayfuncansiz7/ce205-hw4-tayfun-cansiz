using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

/**
 * @file ce205-hw4-trie.cs
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
namespace ce205_hw4_trie
{
    public static class Class1
    {
     

        public class Trie : IEnumerable<TrieNode>
        {

            // The root node of the Trie
            private TrieNode root;

            // Constructor for the Trie
            public Trie()
            {
                root = new TrieNode();

            }

            /**
            *   @name   Insert
            *
            *   @brief  Adds the input to the trie by creating a child node in the tree
            *
            *   @param  [in] word [\b string]  is the input to be entered
            **/
            public void Insert(string word)
            {
                // Start from the root node of the Trie and add the word
                TrieNode current = root;

                foreach (char ch in word)
                {
                    if (!current.Children.ContainsKey(ch))
                    {
                        // If the character is not found in the children of the current node, create a new node and add it
                        current.Children[ch] = new TrieNode(ch, current);
                    }
                    current = current.Children[ch];
                }
                // Mark the current node as the end of the word
                current.IsEndOfWord = true;
            }

            /**
            *   @name   GetWords
            *
            *   @brief  takes a prefix as input and returns all the words in the trie that start with that prefix.
            *
            *   @param  [in] word [\b string]  is the input to be entered
            **/

            public IEnumerable<string> GetWords(string prefix)
            {
                // First, find the node related to the given prefix.
                TrieNode current = root;

                for (int i = 0; i < prefix.Length; i++)
                {
                    char ch = prefix[i];
                    // If the node related to the prefix is not found, return the result.
                    if (!current.Children.TryGetValue(ch, out TrieNode node))
                    {
                        yield break;
                    }
                    current = node;
                }

                // Create a queue containing the nodes under this node.
                Queue<TrieNode> queue = new Queue<TrieNode>();
                queue.Enqueue(current);

                // Scan the nodes in the queue.
                while (queue.Count > 0)
                {
                    TrieNode node = queue.Dequeue();

                    // If the node is the end of a word, return the word.
                    if (node.IsEndOfWord)
                    {
                        yield return GetWord(node);
                    }

                    // Add the child nodes to the queue.
                    foreach (var child in node.Children.Values)
                    {
                        if (child != null)
                        {
                            queue.Enqueue(child);
                        }
                    }
                }
            }

            /**
            *   @name   GetWord
            *
            *   @brief  This method returns the word equivalent of the given node.
            *
            *   @param  [in] node [\b string]  is the node
            **/
            private string GetWord(TrieNode node)
            {
                // Create a stack.
                Stack<char> stack = new Stack<char>();

                while (node != root)
                {
                    stack.Push(node.Value);
                    node = node.Parent;
                }
                // Return the characters in the stack as a word.
                return new string(stack.ToArray());
            }


            /**
            *   @name   Delete
            *
            *   @brief  remove word from the trie
            *
            *   @param  [in] word [\b string]  is the input to be entered
            **/

            public bool Delete(string word)
            {
                return Delete(root, word, 0);
            }

            // for deleting a word from the Trie.
            private bool Delete(TrieNode current, string word, int index)
            {
                // If reach end of the word, check current node marks the end of a word.
                if (index == word.Length)
                {
                    if (!current.IsEndOfWord)
                    {
                        return false;
                    }
                    current.IsEndOfWord = false;
                    return current.Children.Values.All(node => node == null);
                }
                // Get the child node corresponding to the next character in the word.
                char ch = word[index];
                TrieNode nodeToDelete = current.Children[ch];
                if (nodeToDelete == null)
                {
                    return false;
                }
                // Recurse to the next character in the word and check if we can delete the current node.
                bool shouldDeleteCurrentNode = Delete(nodeToDelete, word, index + 1) && !nodeToDelete.IsEndOfWord;

                if (shouldDeleteCurrentNode)
                {
                    current.Children.Remove(ch);
                    return current.Children.Values.All(n => n == null);
                }

                return false;
            }

            /**
            *   @name   GetEnumerator
            *
            *   @brief  returns an enumerator that allows the trie to be traversed in a depth-first fashion.
            *
            *   @param  [in] word [\b string]  is the input to be entered
            **/
            public IEnumerator<TrieNode> GetEnumerator()
            {
                // Create a queue to hold the TrieNodes that need to be processed
                Queue<TrieNode> queue = new Queue<TrieNode>();
                queue.Enqueue(root);

                while (queue.Count > 0)
                {
                    TrieNode current = queue.Dequeue();
                    // Yield the current node
                    yield return current;

                    // Enqueue all of the current node's children
                    foreach (var child in current.Children.Values)
                    {
                        if (child != null)
                        {
                            queue.Enqueue(child);
                        }
                    }
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                // Return the enumerator for the TrieNodes
                return GetEnumerator();
            }

            // Create a queue to hold the TrieNodes that need to be processed
            public IEnumerable<TrieNode> GetNodes()
            {
                Queue<TrieNode> queue = new Queue<TrieNode>();
                // Enqueue the root node
                queue.Enqueue(root);

                while (queue.Count > 0)
                {
                    // Dequeue the next node
                    TrieNode current = queue.Dequeue();
                    // Yield the current node
                    yield return current;
                    foreach (var child in current.Children.Values)
                    {
                        if (child != null)
                        {
                            queue.Enqueue(child);
                        }
                    }
                }
            }




        }

        public class TrieNode
        {
            // The value of the current node.
            public char Value { get; set; }
            // The parent node of the current node.
            public TrieNode Parent { get; set; }
            // The child nodes of the current node.
            public Dictionary<char, TrieNode> Children { get; set; }
            // Indicates whether the current node is the end of a word.
            public bool IsEndOfWord { get; set; }

            // Constructor for creating a new TrieNode with no parent.
            public TrieNode()
            {
                Children = new Dictionary<char, TrieNode>();
            }
            // Constructor for creating a new TrieNode with a parent.
            public TrieNode(char value, TrieNode parent)
            {
                Value = value;
                Parent = parent;
                Children = new Dictionary<char, TrieNode>();
            }
        }





    }
}
