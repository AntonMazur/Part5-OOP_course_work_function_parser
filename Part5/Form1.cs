using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Part5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void richTextBox_func_Enter(object sender, EventArgs e)
        {
            if (richTextBox_func.ForeColor == Color.LightGray)
            {
                richTextBox_func.Text = "";
            }
            richTextBox_func.ForeColor = Color.Black; 
        }


        private void richTextBox_func_Leave(object sender, EventArgs e)
        {

            if (richTextBox_func.Text == "")
            {
                richTextBox_func.ForeColor = Color.LightGray;
                richTextBox_func.Text = "Your function must be here";
            }
                
        }


        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox_func_Enter(sender, e);
            richTextBox_func.AppendText(((Button)sender).Text);
        }


        private void button_summation_Click(object sender, EventArgs e)
        {
            appndTextAndSetCaret(sender, e, "\u2211(;) () ", 6);
        }


        private void button_multiplication_Click(object sender, EventArgs e)
        {
            appndTextAndSetCaret(sender, e, "\u220F(;) () ", 6);
        }


        private void button_sin_Click(object sender, EventArgs e)
        {
            appndTextAndSetCaret(sender, e, "sin() ", 2);
        }


        private void button_cos_Click(object sender, EventArgs e)
        {
            appndTextAndSetCaret(sender, e, "cos() ", 2);
        }


        private void button_tg_Click(object sender, EventArgs e)
        {
            appndTextAndSetCaret(sender, e, "tg() ", 2);
        }


        private void appndTextAndSetCaret(object sender, EventArgs e, string appendingText, int endOffset)
        {
            richTextBox_func_Enter(sender, e);
            if (richTextBox_func.Text.Length != 0 && richTextBox_func.Text.Last() != ' ')
                richTextBox_func.AppendText(" ");
            richTextBox_func.AppendText(appendingText);
            richTextBox_func.Focus();
            richTextBox_func.SelectionStart = richTextBox_func.Text.Length - endOffset;
        }


        private void button_clear_Click(object sender, EventArgs e)
        {
            richTextBox_func.Text = "";
            richTextBox_func_Leave(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pattern = @"^((?<depth>\()|(?<-depth>\)))*$";
            Regex reg = new Regex(@".*\d.*");
            Match m = reg.Match(richTextBox_func.Text);
            if (!m.Success)
            {
                MessageBox.Show("Error – Unbalanced brackets!!!");
                //return;
            }

            DataTable dt = new DataTable();
            dataGridView_keyVals.Font = new Font("Serif", 14);
            MinFinder mf;
            double[] args = null;
            try
            {
                args = textBox_paramsVals.Text.Trim(' ').Split(' ').Select(x => double.Parse(x)).ToArray();
                mf = new MinFinder(
                    richTextBox_func.Text,
                    args,
                    dt,
                    textBox_Eps.Text == "" ? 1e-2 : double.Parse(textBox_Eps.Text),
                    textBox_maxCountIter.Text == "" ? 10 : int.Parse(textBox_maxCountIter.Text)
                    );
            }
            catch(Exception ex)
            {
                mf = new MinFinder(
                    richTextBox_func.Text,
                    dt,
                    textBox_Eps.Text == "" ? 1e-2 : double.Parse(textBox_Eps.Text),
                    textBox_maxCountIter.Text == "" ? 10 : int.Parse(textBox_maxCountIter.Text)
                    );
            }

            dataGridView_keyVals.DataSource = dt;
            label_funcMin.Text = mf.findMin().ToString();

        }
    }
}
