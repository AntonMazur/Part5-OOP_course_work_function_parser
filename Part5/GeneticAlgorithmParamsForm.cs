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
    public partial class GeneticAlgorithmParamsForm : Form
    {
        public int iterCount;
        public int individualCount;
        public double crossoverProb;
        public double mutationProb;
        public double maxGenotypeDelta;

        public GeneticAlgorithmParamsForm()
        {
            InitializeComponent();
        }

        private void GeneticAlgorithmParamsForm_Load(object sender, EventArgs e)
        {
            var toolTip = new ToolTip();

            toolTip.SetToolTip(tB_iterCount, "Пример: \"30\"");
            toolTip.SetToolTip(tB_individualsCount, "Пример: \"50\"");
            toolTip.SetToolTip(tB_crossoverProb, "Пример: \"0,2\"");
            toolTip.SetToolTip(tB_mutationProb, "Пример: \"0,3\"");
            toolTip.SetToolTip(tB_maxGenotypeDelta, "Пример: \"2\"");

            toolTip.ShowAlways = true;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                iterCount = int.Parse(tB_iterCount.Text);
                individualCount = int.Parse(tB_individualsCount.Text);
                crossoverProb = double.Parse(tB_crossoverProb.Text);
                mutationProb = double.Parse(tB_mutationProb.Text);
                maxGenotypeDelta = double.Parse(tB_maxGenotypeDelta.Text);
                this.Close();
            } catch (Exception er)
            {
                tB_iterCount.Clear();
                tB_individualsCount.Clear();
                tB_crossoverProb.Clear();
                tB_mutationProb.Clear();
                tB_maxGenotypeDelta.Clear();

                MessageBox.Show("Неправильный формат ввода! Попробуйте ещё раз!");
            }
        }
    }
}
