using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Proiect2 {
    public partial class InitializeInput : Form {

        private NeuronalNetwork form1;
        private int position;
      
        public InitializeInput(NeuronalNetwork form,int pos, double value) {
            InitializeComponent();

            numericUpDown1.Maximum = 1;
            numericUpDown1.Minimum = -1;
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Increment = 0.01m;
            this.form1 = form;
            this.position = pos;

            numericUpDown1.Value = (decimal)value;
            this.Text = "Input Neuron " + position.ToString();
        }

        private void button1_Click(object sender, EventArgs e) {

           form1.neuronsList[0][position]._globalOutput = (double)numericUpDown1.Value;
           form1.updateData();
            this.Close();
        }
    }
}
