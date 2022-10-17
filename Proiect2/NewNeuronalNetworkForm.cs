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
    public partial class NewNeuronalNetworkForm : Form {

        public static int _numberNeuronsInputLayer = 1;
        public static int _numberNeuronsOutputLayer = 1;
        public static int _numberOfHiddenLayers = 1;
        public static int _numberNeuronsHiddenLayer1 = 1;
        public static int _numberNeuronsHiddenLayer2 = 1;
        public static int _numberNeuronsHiddenLayer3 = 1;

        public NewNeuronalNetworkForm() {
            InitializeComponent();
           Load += new EventHandler(onLoad);

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            button1.TabStop = false;

            label6.Visible = false;
            numericUpDown6.Visible = false;
            label7.Visible = false;
            numericUpDown7.Visible = false;
        }

        private void onLoad(object sender, EventArgs e) {
          _numberNeuronsInputLayer = 1;
          _numberNeuronsOutputLayer = 1;
          _numberOfHiddenLayers = 1;
          _numberNeuronsHiddenLayer1 = 1;
          _numberNeuronsHiddenLayer2 = 1;
          _numberNeuronsHiddenLayer3 = 1;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e) {
            if (numericUpDown4.Value == 1) {
                _numberOfHiddenLayers = 1;
                _numberNeuronsHiddenLayer2 = 1;
                _numberNeuronsHiddenLayer3 = 1;

                label6.Visible = false;
                numericUpDown6.Visible = false;
                label7.Visible = false;
                numericUpDown7.Visible = false;
            }
            else if (numericUpDown4.Value == 2) {
                _numberOfHiddenLayers = 2;
                _numberNeuronsHiddenLayer3 = 1;

                label6.Visible = true;
                numericUpDown6.Visible = true;
                label7.Visible = false;
                numericUpDown7.Visible = false;
            }
            else if(numericUpDown4.Value == 3) {
                _numberOfHiddenLayers = 3;

                label6.Visible = true;
                numericUpDown6.Visible = true;
                label7.Visible = true;
                numericUpDown7.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
            _numberNeuronsInputLayer = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e) {
            _numberNeuronsOutputLayer = (int)numericUpDown2.Value;
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e) {
            _numberNeuronsHiddenLayer1 = (int)numericUpDown5.Value;
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e) {
            _numberNeuronsHiddenLayer2 = (int)numericUpDown6.Value;
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e) {
            _numberNeuronsHiddenLayer3 = (int)numericUpDown7.Value;
        }
    }
}
