using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part5
{
    public partial class RestrictionInputForm : Form
    {

        private LinkedList<string> vars;
        private LinkedList<(double, double)> restrictions = new LinkedList<(double, double)>();
        private int restrictionsEntered = 0;

        public RestrictionInputForm(LinkedList<string> vars)
        {
            this.vars = vars;
            InitializeComponent();
        }

        public LinkedList<(double, double)> getRestrictions() { return restrictions; }

        private void RestrictionInputForm_Load(object sender, EventArgs e)
        {
            lbl_varName.Text = vars.ElementAt(0);
            var toolTip = new ToolTip();

            toolTip.SetToolTip(textB_restriction, "Пример: \"-0,5;1\"");

            toolTip.ShowAlways = true;
        }

        private void textB_restriction_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    var restriction = textB_restriction.Text.Split(';').Select(token => double.Parse(token)).ToArray();
                    restrictions.AddLast((restriction[0], restriction[1]));
                    if (++restrictionsEntered < vars.Count()) {
                        textB_restriction.Text = "";
                        lbl_varName.Text = vars.ElementAt(restrictionsEntered);
                    } else
                    {
                        this.Close();
                    }
                } catch (Exception er)
                {
                    MessageBox.Show("Неправильный формат ввода! Попробуйте ещё раз!");
                    textB_restriction.Clear();
                }
            }
        }
    }
}
