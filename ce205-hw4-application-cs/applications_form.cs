using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoyerMooreGUI;

namespace ce205_hw4_application_cs
{
    public partial class applications_form : Form
    {
        public applications_form()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            needleman_form form = new needleman_form();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            smith_form form = new smith_form();
            form.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            hunt_form form = new hunt_form();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            trie_form form = new trie_form();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            knuth_form form = new knuth_form();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            horspool_form form = new horspool_form();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            boyer_form form = new boyer_form();
            form.Show();
        }

        private void applications_form_Load(object sender, EventArgs e)
        {

        }
    }
}
