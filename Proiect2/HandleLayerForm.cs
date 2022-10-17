using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect2 {
    public partial class HandleLayerForm : Form {

        public int position;
        public NeuronalNetwork form;
        public HandleLayerForm(NeuronalNetwork form1,String name) {

            InitializeComponent();
           
            numericUpDownTeta.Minimum = -1;
            numericUpDownTeta.Maximum = 1;
            numericUpDownTeta.DecimalPlaces = 2;
            numericUpDownTeta.Increment = 0.01m;

            numericUpDownG.Minimum = -1;
            numericUpDownG.Maximum = 1;
            numericUpDownG.DecimalPlaces = 2;
            numericUpDownG.Increment = 0.01m;

            comboBoxInput.SelectedIndex = 0; 
            comboBoxActivation.SelectedIndex = 0;

            form = form1;
            int nr = int.Parse(name);
            position = nr;
            nr++;
            this.Text = "Layer " + nr;

            comboBoxInput.SelectedIndex = form.listFunctionsInput[position];
            comboBoxActivation.SelectedIndex = form.listFunctionsActivation[position];
            if (form.listBinar[position] == 1) {
                checkBox1.Checked = true;
            }
            else {
                checkBox1.Checked = false;
            }
            numericUpDownTeta.Value = (decimal)form.listTeta[position];
            numericUpDownG.Value = (decimal)form.listG[position];

        }

        private void button1_Click(object sender, EventArgs e) {
            if (checkBox1.Checked) {
                form.listBinar[position] = 1;
            }
            else {
                form.listBinar[position] = 0;
            }

            form.listFunctionsInput[position] = comboBoxInput.SelectedIndex;
            form.listFunctionsActivation[position] = comboBoxActivation.SelectedIndex;
            form.listG[position] = (double)numericUpDownG.Value;
            form.listTeta[position] = (double)numericUpDownTeta.Value;
            form.updateData();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
           
        }
    }
}
