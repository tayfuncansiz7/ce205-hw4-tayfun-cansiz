using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ce205_hw4_needleman_smith_hunt.Class1.SmithWaterman;

namespace ce205_hw4_application_cs
{
    public partial class smith_form : Form
    {

        public smith_form()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sequence1 = richTextBox1.Text;
            string sequence2 = richTextBox2.Text;

            string alignment = Align(sequence1, sequence2,1,-1,-1);

            richTextBox3.Text = "";

            int a = 0;
            int b = 0;

            for (int i = 0; i < alignment.Length; i++)
            {
                if (alignment[i] == '_')
                {
                    richTextBox3.SelectionColor = Color.Red;
                }
                else if (a < sequence1.Length && b < sequence2.Length && sequence1[a] != sequence2[b])
                {
                    richTextBox3.SelectionColor = Color.DarkOrange;
                    a++;
                    b++;
                }
                else
                {
                    a++;
                    b++;
                }

                richTextBox3.AppendText(alignment[i].ToString());
                richTextBox3.SelectionColor = richTextBox3.ForeColor;
            }
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            // First inputRichTextBox
            string dna1 = "";
            for (int i = 0; i < 20; i++)
            {
                int r = rnd.Next(4);
                if (r == 0)
                {
                    dna1 += "A";
                }
                else if (r == 1)
                {
                    dna1 += "C";
                }
                else if (r == 2)
                {
                    dna1 += "G";
                }
                else if (r == 3)
                {
                    dna1 += "T";
                }
            }
            richTextBox1.Text = dna1;

            // Second inputRichTextBox
            string dna2 = "";
            for (int i = 0; i < 16; i++)
            {
                int r = rnd.Next(4);
                if (r == 0)
                {
                    dna2 += "A";
                }
                else if (r == 1)
                {
                    dna2 += "C";
                }
                else if (r == 2)
                {
                    dna2 += "G";
                }
                else if (r == 3)
                {
                    dna2 += "T";
                }
            }
            richTextBox2.Text = dna2;
        }

        private void smith_form_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
