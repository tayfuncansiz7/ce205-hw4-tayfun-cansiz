using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ce205_hw4_knuth_horspool_boyer.Class1.Knuth_Morris_Pratt_Algorithm;
using static System.Net.Mime.MediaTypeNames;


namespace ce205_hw4_application_cs
{
    public partial class knuth_form : Form
    {
        public knuth_form()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // Get the input and pattern strings from the RichTextBox controls
            string input = inputRichTextBox.Text;
            string pattern = patternRichTextBox.Text;

            // Compute the LPS array
            int[] lps = ComputeLps(pattern);

            // Initialize the indices for the input and pattern strings
            int i = 0;
            int j = 0;
            int k = 0;
            //int result = KMPSearch(input.Substring(k), pattern);
           
            // Set the result RichTextBox text to the input string
            resultRichTextBox.Text = input;

            //clear result label
            resultLabel.Text = "";

            while (k < input.Length)
            {
                int result = KMPSearch(input.Substring(k), pattern);
                
                if (result >= 0)
                {

                    resultLabel.Text += "Pattern found at index: " + (k + result) + Environment.NewLine;
                    k += result + 1;
                }
                else
                {
                    k++;
                }

            }
            // Loop through the input string
            while (i < input.Length)
            {
                

                if (input[i] == pattern[j])
                {
                    // If the characters match, increment both indices
                    i++;
                    j++;
                }

                if (j == pattern.Length)
                {
                    // If the pattern is found, highlight it in the result RichTextBox

                    resultRichTextBox.Select(i - j, j);
                    resultRichTextBox.SelectionColor = Color.Red;

                    // Reset the pattern index
                    j = lps[j - 1];
                }
                else if (i < input.Length && input[i] != pattern[j])
                {
                    if (j != 0)
                    {
                        // If the characters don't match and the pattern index is not at the beginning,
                        // set the pattern index to the value in the LPS array
                        j = lps[j - 1];
                    }
                    else
                    {
                        // If the pattern index is at the beginning, move to the next character in the input string
                        i++;
                    }
                }

            }

        }

        private void resultRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void patternRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultLabel_Click(object sender, EventArgs e)
        {

        }

        private void randomButton_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();
            string loremtext = "";
            for (int i = 0; i < 1; i++)
            {
                int r = rnd.Next(6);
                if (r == 0)
                {
                    loremtext += "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur a mollis dolor. In et laoreet erat. Donec vitae ex ac augue facilisis tincidunt laoreet sed odio. Maecenas at mauris euismod leo maximus commodo. Donec leo libero, cursus in ex ut, cursus rutrum erat. Mauris malesuada auctor tortor sit amet suscipit. Nullam vitae purus ante. Duis vel leo fringilla, lobortis mi eget, efficitur elit.";
                }
                else if (r == 1)
                {
                    loremtext += "Ut volutpat ante sed lacus facilisis pulvinar. Nunc vitae justo quis erat pretium iaculis. In at dapibus dui. Sed ornare arcu nisi, et scelerisque metus consequat sed. Sed commodo sollicitudin magna, non dignissim est pulvinar non. In egestas, leo vestibulum aliquet lacinia, magna orci accumsan mi, id luctus eros ante et enim. Donec dapibus, elit ut pellentesque molestie, metus turpis bibendum dui, ut malesuada nisl nibh at tellus. Nulla orci tellus, volutpat eget odio vel, vehicula pulvinar magna. Ut in metus id magna pellentesque pretium sed vitae eros. Donec lorem lectus, pulvinar vel rhoncus sed, elementum eget turpis. Maecenas pharetra vulputate lacus at sagittis. Sed venenatis ipsum felis, id suscipit risus luctus ac.";
                }
                else if (r == 2)
                {
                    loremtext += "Aenean ac ligula metus. Fusce rutrum hendrerit aliquet. Donec ac purus vehicula, vehicula nibh tincidunt, consequat nisi. Quisque dignissim, erat eu aliquet porttitor, sapien est tincidunt sem, vitae commodo lorem erat ut quam. Nunc et molestie mauris, non tempus metus. Aliquam id iaculis nibh. Maecenas quis nulla mi. In hac habitasse platea dictumst. Integer eget diam a massa accumsan vestibulum. Ut at libero vulputate est sollicitudin lacinia. Integer sem ante, dignissim vitae augue viverra, congue maximus orci. Quisque nec elit sed metus semper facilisis facilisis a mauris.";
                }
                else if (r == 3)
                {
                    loremtext += "Vivamus accumsan dui nisi, ac bibendum dolor suscipit eget. Donec elementum nibh purus, a venenatis tellus condimentum id. Phasellus luctus vel ipsum vel vestibulum. Suspendisse tincidunt dapibus volutpat. Vivamus condimentum mi non sem fringilla, at consequat erat interdum. Proin tempus vestibulum consectetur. Suspendisse in dui et urna faucibus facilisis quis et sem. Nam varius orci sit amet erat egestas, et bibendum lacus egestas. Nulla non blandit enim. Aenean ac felis vel magna efficitur suscipit.";
                }
                else if (r == 4)
                {
                    loremtext += "Praesent luctus elementum dui, in euismod arcu commodo a. Nunc sit amet ante sit amet enim tristique dictum. Sed ac ipsum eget nunc pulvinar convallis eget ac ante. Suspendisse potenti. In semper malesuada ipsum id efficitur. Aliquam vel pulvinar est. Aliquam ut feugiat purus, ac gravida felis. Pellentesque lacinia nunc id efficitur accumsan. Mauris nunc purus, consectetur id mollis at, rutrum a libero.";
                }
                else if (r == 5)
                {
                    loremtext += "Morbi quis mollis massa, ut imperdiet urna. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Mauris aliquet sed metus sit amet commodo. Nunc risus velit, vestibulum facilisis dui sit amet, condimentum vulputate tellus. Nam et viverra magna. Nulla non leo quis tellus faucibus pretium nec eget nisl. Curabitur in tortor gravida, interdum nibh vel, lacinia orci. Fusce turpis nunc, tincidunt vitae tellus eget, pharetra eleifend justo. Phasellus tincidunt, odio sit amet iaculis ultricies, massa ante interdum justo, eget mollis ipsum ex vel felis.";
                }
            }
            inputRichTextBox.Text = loremtext;


        }

        private void knuth_form_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
