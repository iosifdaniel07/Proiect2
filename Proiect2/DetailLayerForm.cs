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
    public partial class DetailLayerForm : Form {

        private int layer;
        private int position;
        private NeuronalNetwork form;
        private List<NumericUpDown> numericUpDownListX;
        public List<NumericUpDown> numericUpDownListW;
        private List<Label> labelsX;
        private List<Label> labelsW;
        public DetailLayerForm(NeuronalNetwork form1,int layer,int position) {
            InitializeComponent();

            textBoxActivation.Enabled = false;
            textBoxInput.Enabled = false;   
            textBoxOutput.Enabled = false;

            this.layer = layer;
           this.position = position;    
            form = form1;
            this.Text = "Layer "+ layer + " neuron number " + position;
             
            if(form.listFunctionsActivation[layer-1] == 0) {  //0-semn,1-treapta,2-sigmoidala,3-tangenta,4-liniara
                activation.Text = "Semn";      
            }
            else if(form.listFunctionsActivation[layer - 1] == 1) {
                activation.Text = "Treapta";
            }
            else if(form.listFunctionsActivation[layer-1] == 2) {
                activation.Text = "Sigmoidala";
            }
            else if(form.listFunctionsActivation[layer-1] == 3) {
                activation.Text = "Tangenta";

            }else if (form.listFunctionsActivation[layer - 1] == 4) {
                activation.Text = "Liniara";
            }

            if (form1.listFunctionsInput[layer - 1] == 0) {//0-suma ,1-produs,2-minim,3-maxim
                Input.Text = "Suma";
            }
            else if (form1.listFunctionsInput[layer - 1] == 1) {
                Input.Text = "Produs";
            }
            else if (form1.listFunctionsInput[layer - 1] == 2) {
                Input.Text = "Minim";
            }else if(form.listFunctionsInput[layer - 1] == 3) {
                Input.Text = "Maxim";
            }

            if(form1.listBinar[layer - 1] == 0) { //0-real,1-binar
                binary.Text = "Real";
            }else if(form1.listBinar[layer - 1] == 1) {
                binary.Text = "Binar";
            }

            textBoxInput.Text = form1.neuronsList[layer][position]._globalInput.ToString();
            textBoxOutput.Text = form1.neuronsList[layer][position]._globalOutput.ToString();   
            textBoxActivation.Text = form1.neuronsList[layer][position]._activation.ToString();

            int nr = form1.neuronsList[layer][position]._inputX.Count;

            numericUpDownListX = new List<NumericUpDown>();
            numericUpDownListW = new List<NumericUpDown>();
            labelsX = new List<Label>();    
            labelsW = new List<Label>();

            for (int i = 0; i < nr; ++i) {
                //x
                NumericUpDown Xinput = new NumericUpDown();
                Xinput.Size = new System.Drawing.Size(50, 20);
                Xinput.DecimalPlaces = 2;
                Xinput.Increment = 0.01M;
                Xinput.Minimum = -300;
                Xinput.Maximum = 300;
                Xinput.Name = Convert.ToString(i);
                Xinput.Enabled = false;
                Xinput.Value = (decimal)form.neuronsList[layer][position]._inputX[i];
                numericUpDownListX.Add(Xinput);
                //label
                Label label1 = new Label();
                label1.Size = new System.Drawing.Size(30, 30);
                label1.Text = "X" + i;
                label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
               labelsX.Add(label1);
                //w
                NumericUpDown Winput = new NumericUpDown();
                Winput.Size = new System.Drawing.Size(50, 20);
                Winput.DecimalPlaces = 2;
                Winput.Increment = 0.01M;
                Winput.Minimum = 0;
                Winput.Maximum = 1;
                Winput.Name = Convert.ToString(i);
                Winput.Value = (decimal)form.neuronsList[layer][position]._weight[i];
                Winput.ValueChanged += numericUpDown_Value_Changed;
                numericUpDownListW.Add(Winput);

                Label label2 = new Label();
                label2.Size = new System.Drawing.Size(30, 30);
                label2.Text = "W" + i;
                label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
                labelsW.Add(label2);

                flowLayoutPanel1.Controls.Add(label1);
                flowLayoutPanel1.Controls.Add(Xinput);
                flowLayoutPanel1.Controls.Add(label2);
                flowLayoutPanel1.Controls.Add(Winput);

            }
          
        }

        private void numericUpDown_Value_Changed(object sender, EventArgs e) {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            int posW = int.Parse(numericUpDown.Name);
            form.neuronsList[layer][position]._weight[posW] = (double)numericUpDown.Value;
           
        }

        private void button1_Click(object sender, EventArgs e) {
            form.updateData();
            this.Close();
        }
    }
}
