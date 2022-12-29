using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ce205_hw4_trie.Class1;


namespace ce205_hw4_application_cs
{
    public partial class trie_form : Form
    {
        private Trie trie;
        public trie_form()
        {
            InitializeComponent();
            trie = new Trie();
        }

        private void trie_form_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string word = txtInput.Text;
            trie.Insert(word);
            txtInput.Clear();
        }


        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            string prefix = txtInput.Text;
            List<string> suggestions = trie.GetWords(prefix).ToList();
            suggestionBox.DataSource = suggestions;
        }

        private void suggestionBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //get word from suggestionBox
            if (suggestionBox.SelectedItem == null)
            {
                return;
            }
            else
            {
                string word = suggestionBox.SelectedItem.ToString();

                // Delete word
                trie.Delete(word);

                string prefix = txtInput.Text;
                List<string> suggestions = trie.GetWords(prefix).ToList();
                suggestionBox.DataSource = suggestions;
            }        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texts = "Lorem ipsum dolor sit amet consectetur adipiscing elit Curabitur a mollis dolor" +
                " In et laoreet erat Donec vitae ex ac augue facilisis tincidunt laoreet sed odio" +
                " Maecenas at mauris euismod leo maximus commodo Donec leo libero cursus in ex ut" +
                " cursus rutrum erat Mauris malesuada auctor tortor sit amet suscipit Nullam vitae purus ante" +
                " Duis vel leo fringilla lobortis mi eget efficitur elit Ut volutpat ante sed lacus facilisis pulvinar" +
                " Nunc vitae justo quis erat pretium iaculis In at dapibus dui Sed ornare arcu nisi" +
                " et scelerisque metus consequat sed Sed commodo sollicitudin magna non dignissim est pulvinar non" +
                " In egestas leo vestibulum aliquet lacinia magna orci accumsan mi id luctus eros ante et enim" +
                " Donec dapibus elit ut pellentesque molestie metus turpis bibendum dui ut malesuada nisl nibh at tellus" +
                " Nulla orci tellus volutpat eget odio vel vehicula pulvinar magna Ut in metus id magna pellentesque" +
                " pretium sed vitae eros Donec lorem lectus pulvinar vel rhoncus sed elementum eget turpis" +
                " Maecenas pharetra vulputate lacus at sagittis Sed venenatis ipsum felis id suscipit risus" +
                " luctus ac Aenean ac ligula metus Fusce rutrum hendrerit aliquet Donec ac purus vehicula" +
                " vehicula nibh tincidunt consequat nisi Quisque dignissim erat eu aliquet porttitor sapien est" +
                " tincidunt sem vitae commodo lorem erat ut quam Nunc et molestie mauris non tempus metus" +
                " Aliquam id iaculis nibh Maecenas quis nulla mi In hac habitasse platea dictumst Integer" +
                " eget diam a massa accumsan vestibulum Ut at libero vulputate est sollicitudin lacinia" +
                " Integer sem ante dignissim vitae augue viverra congue maximus orci" +
                " Quisque nec elit sed metus semper facilisis facilisis a mauris Vivamus accumsan dui nisi" +
                " ac bibendum dolor suscipit eget Donec elementum nibh purus a venenatis tellus" +
                " condimentum id Phasellus luctus vel ipsum vel vestibulum Suspendisse tincidunt dapibus volutpat" +
                " Vivamus condimentum mi non sem fringilla at consequat erat interdum Proin tempus vestibulum consectetur" +
                " Suspendisse in dui et urna faucibus facilisis quis et sem Nam varius orci sit amet erat egestas" +
                " et bibendum lacus egestas Nulla non blandit enim Aenean ac felis vel magna efficitur suscipit";
            string[] words = texts.Split(' ');
            Random rnd = new Random();
            int index = rnd.Next(words.Length);
            string randomWords = words[index];

            txtInput.Text = randomWords;
            btnInsert_Click(sender,e);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
