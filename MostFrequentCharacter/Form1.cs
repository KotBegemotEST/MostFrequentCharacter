using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;


namespace MostFrequentCharacter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Dictionary<char, int> count = new Dictionary<char, int>();
            string str = textBox1.Text;
            int len = str.Length;
            for (int i = 0; i < len; i++)
            {
                if (str[i] == ' ') continue;
                if (count.ContainsKey(str[i]))
                {
                    count[str[i]] += 1;
                }
                else
                {
                    count.Add(str[i], 1);
                }
            }

            string newString = "";
            foreach (char key in count.Keys)
            {

            }

           
            var sortedDict = count.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in sortedDict) {
                newString = kvp.Key.ToString() + " - " + kvp.Value.ToString();
                listBox1.Items.Add(newString);
            }




        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
