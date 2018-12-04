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
    public partial class SwarmAlgorithmParamsForm : Form
    {
        public int iterationCount;
        public int particleCount;
        public double localMinWeight;
        public double globalMinWeight;

        public SwarmAlgorithmParamsForm()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                this.iterationCount = int.Parse(tB_iterCount.Text);
                this.particleCount = int.Parse(tB_particleCount.Text);
                this.localMinWeight = double.Parse(tB_localMinImpact.Text);
                this.globalMinWeight = double.Parse(tB_globalMinImpact.Text);
                this.Close();

            } catch (Exception ex)
            {
                tB_iterCount.Clear();
                tB_particleCount.Clear();
                tB_localMinImpact.Clear();
                tB_globalMinImpact.Clear();

                MessageBox.Show("Неправильный формат ввода! Попробуйте ещё раз!");
            }
        }
    }
}
