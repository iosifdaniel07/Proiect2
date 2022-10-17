using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;

namespace Proiect2 {
    public partial class NeuronalNetwork : Form {

        private List<List<CircularButton>> buttonList;
        public List<List<Artificial_Neuron>> neuronsList;

        public List<int> listFunctionsInput; //0-suma ,1-produs,2-minim,3-maxim
        public List<int> listFunctionsActivation;//0-semn,1-treapta,2-sigmoidala,3-tangenta,4-liniara
        public List<double> listTeta;//0
        public List<double> listG;//1
        public List<int> listBinar; //0 for false, 1 for true

        public NeuronalNetwork() {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            buttonNewNetworn.TabStop = false;
            buttonOutput.TabStop = false;
            buttonHiddendLayer1.TabStop = false;
            buttonHiddendLayer2.TabStop = false;
            buttonHiddendLayer3.TabStop = false;

            buttonOutput.Visible = false;
            buttonHiddendLayer1.Visible = false;
            buttonHiddendLayer2.Visible = false;
            buttonHiddendLayer3.Visible = false;

        }

        private void setLayer1(object sender, EventArgs e) {
            HandleLayerForm f = new HandleLayerForm(this,"0");
            f.ShowDialog();
        }
        private void setLayer2(object sender, EventArgs e) {
            HandleLayerForm f = new HandleLayerForm(this,"1");
            f.ShowDialog();
        }
        private void setLayer3(object sender, EventArgs e) {
            HandleLayerForm f = new HandleLayerForm(this,"2");
            f.ShowDialog();
        }

        private void setLayer4(object sender, EventArgs e) {
            HandleLayerForm f = new HandleLayerForm(this,"3");
            f.ShowDialog();
        }

        private void addBtn(int v1, int v2, List<CircularButton> list,string text, EventHandler e) {
           CircularButton btn = new CircularButton();
            btn.Location = new Point(v1, v2);
            btn.Width = 30;
            btn.Height = 30;
            btn.TabStop = false;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.Blue;
            btn.ForeColor = Color.Yellow;
            btn.Text = text;
            btn.Click += new EventHandler(e);
            this.Controls.Add(btn);

            list.Add(btn);
        }

        private void calculareValoareStartStrat(int[] nrNeuroniPeStrat,  int[] positiistart) {
            int max = nrNeuroniPeStrat[0];
            for (int i = 1; i < nrNeuroniPeStrat.Length; i++) {
                if (max < nrNeuroniPeStrat[i]) {
                    max = nrNeuroniPeStrat[i];
                }
            }

            for (int i = 0; i < nrNeuroniPeStrat.Length; i++) {
               if(max != nrNeuroniPeStrat[i]) {
                    positiistart[i] = 60 + 20 *(max - nrNeuroniPeStrat[i]);
                }
                else {
                    positiistart[i] = 60;
                }
            }

        }

        private void buttonNewNetworn_Click(object sender, EventArgs e) {
            NewNeuronalNetworkForm form = new NewNeuronalNetworkForm();
            var result = form.ShowDialog();
            if (result == DialogResult.OK) {
                if (buttonList == null) {
                    DrawButtons();
                    initializeNeurons();
                }
                else {
                    removeButtonsAndLines();
                    DrawButtons();
                    initializeNeurons();
                }
               
            }

        }

        public void removeButtonsAndLines() {
            if (buttonList.Count == 5) {
                buttonHiddendLayer1.Click -= setLayer1;
                buttonHiddendLayer2.Click -= setLayer2;
                buttonHiddendLayer3.Click -= setLayer3;
                buttonOutput.Click -= setLayer4;
            }
            else if (buttonList.Count == 4) {
                buttonHiddendLayer1.Click -= setLayer1;
                buttonHiddendLayer2.Click -= setLayer2;
                buttonOutput.Click -= setLayer3;
            }
            else if (buttonList.Count == 3) {
                buttonHiddendLayer1.Click -= setLayer1;
                buttonOutput.Click -= setLayer2;
            }
            
            SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Silver);
            Graphics formGraphics;
            formGraphics = this.CreateGraphics();

            int nrLayerului = 2;
            for (int i = 0; i < buttonList.Count - 1; i++) {
                for (int j = i + 1; j < nrLayerului; j++) {
                    for (int k = 0; k < buttonList[i].Count; k++) {
                        for (int l = 0; l < buttonList[j].Count; l++) {
                            formGraphics.DrawLine(System.Drawing.Pens.Silver, buttonList[i][k].Location.X + 15, buttonList[i][k].Location.Y + 15, buttonList[j][l].Location.X + 15, buttonList[j][l].Location.Y + 15);

                        }
                    }
                }
                nrLayerului++;
            }

            myBrush.Dispose();
            formGraphics.Dispose();

            for (int i = 0; i < buttonList.Count; ++i) {
                for (int j = 0; j < buttonList[i].Count; ++j) {
                    this.Controls.Remove(buttonList[i][j]);
                }
            }

            for (int i = 0; i < buttonList.Count; ++i) {
                    buttonList[i].Clear();
            }

            buttonList.Clear();
            for (int i = 0; i < neuronsList.Count; ++i) {
                neuronsList[i].Clear();
            }
            neuronsList.Clear();

            listFunctionsInput.Clear();
            listFunctionsActivation.Clear();
            listTeta.Clear();
            listG.Clear();
            listBinar.Clear();

            buttonOutput.Visible = false;
            buttonHiddendLayer1.Visible = false;
            buttonHiddendLayer2.Visible = false;
            buttonHiddendLayer3.Visible = false;

           
        }

        public void DrawButtons() {
            int nrStraturi = 2;
            nrStraturi += NewNeuronalNetworkForm._numberOfHiddenLayers;
            int[] listaNrNeuroni = new int[nrStraturi];
            if (nrStraturi == 5) {
                listaNrNeuroni[0] = NewNeuronalNetworkForm._numberNeuronsInputLayer;
                listaNrNeuroni[1] = NewNeuronalNetworkForm._numberNeuronsHiddenLayer1;
                listaNrNeuroni[2] = NewNeuronalNetworkForm._numberNeuronsHiddenLayer2;
                listaNrNeuroni[3] = NewNeuronalNetworkForm._numberNeuronsHiddenLayer3;
                listaNrNeuroni[4] = NewNeuronalNetworkForm._numberNeuronsOutputLayer;
                buttonOutput.Visible = true;
                buttonHiddendLayer1.Visible = true;
                buttonHiddendLayer2.Visible = true;
                buttonHiddendLayer3.Visible = true;

                buttonHiddendLayer1.Click += setLayer1;
                buttonHiddendLayer2.Click += setLayer2;
                buttonHiddendLayer3.Click += setLayer3;
                buttonOutput.Click += setLayer4;
            }
            else if (nrStraturi == 4) {
                listaNrNeuroni[0] = NewNeuronalNetworkForm._numberNeuronsInputLayer;
                listaNrNeuroni[1] = NewNeuronalNetworkForm._numberNeuronsHiddenLayer1;
                listaNrNeuroni[2] = NewNeuronalNetworkForm._numberNeuronsHiddenLayer2;
                listaNrNeuroni[3] = NewNeuronalNetworkForm._numberNeuronsOutputLayer;
                buttonOutput.Visible = true;
                buttonHiddendLayer1.Visible = true;
                buttonHiddendLayer2.Visible = true;

                buttonHiddendLayer1.Click += setLayer1;
                buttonHiddendLayer2.Click += setLayer2;
                buttonOutput.Click += setLayer3;
            }
            else if (nrStraturi == 3) {
                listaNrNeuroni[0] = NewNeuronalNetworkForm._numberNeuronsInputLayer;
                listaNrNeuroni[1] = NewNeuronalNetworkForm._numberNeuronsHiddenLayer1;
                listaNrNeuroni[2] = NewNeuronalNetworkForm._numberNeuronsOutputLayer;
                buttonOutput.Visible = true;
                buttonHiddendLayer1.Visible = true;

                buttonHiddendLayer1.Click += setLayer1;       
                buttonOutput.Click += setLayer2;
            }

            int nrNeuroniStrat = 0;
            int[] listPositionStart = new int[nrStraturi];
            calculareValoareStartStrat(listaNrNeuroni, listPositionStart);

            int xStartPosition = 300;//140 
            int yStartPosition; //40 positie

            buttonList = new List<List<CircularButton>>();

            for (int i = 0; i < nrStraturi; i++) {
                List<CircularButton> startbuttons = new List<CircularButton>();
                yStartPosition = listPositionStart[i];
                nrNeuroniStrat = listaNrNeuroni[i];
                for (int j = 0; j < nrNeuroniStrat; j++) {

                    //addBtn(xStartPosition, yStartPosition, startbuttons);
                    if (nrStraturi == 3) {
                        if (i == 0) {
                            addBtn(xStartPosition, yStartPosition, startbuttons,j.ToString(),input_btn_Click);
                        }
                        else if (i == 1) {
                            addBtn(xStartPosition, yStartPosition, startbuttons, j.ToString(),detail_btn_Click);
                        }
                        else if (i == 2) {
                            addBtn(xStartPosition, yStartPosition, startbuttons, j.ToString() ,detail_btn_Click);
                        }
                    }
                    else if (nrStraturi == 4) {
                        if (i == 0) {
                            addBtn(xStartPosition, yStartPosition, startbuttons, j.ToString(), input_btn_Click);
                        }
                        else if (i == 1) {
                            addBtn(xStartPosition, yStartPosition, startbuttons, j.ToString(), detail_btn_Click);
                        }
                        else if (i == 2) {
                            addBtn(xStartPosition, yStartPosition, startbuttons, j.ToString(), detail_btn_Click);
                        }
                        else if (i == 3) {
                            addBtn(xStartPosition, yStartPosition, startbuttons, j.ToString(), detail_btn_Click);
                        }
                    }
                    else if (nrStraturi == 5) {
                        if (i == 0) {
                            addBtn(xStartPosition, yStartPosition, startbuttons, j.ToString(), input_btn_Click);
                        }
                        else if (i == 1) {
                            addBtn(xStartPosition, yStartPosition, startbuttons, j.ToString(), detail_btn_Click);
                        }
                        else if (i == 2) {
                            addBtn(xStartPosition, yStartPosition, startbuttons, j.ToString(),detail_btn_Click);
                        }
                        else if (i == 3) {
                            addBtn(xStartPosition, yStartPosition, startbuttons, j.ToString(), detail_btn_Click);
                        }
                        else if (i == 4) {
                            addBtn(xStartPosition, yStartPosition, startbuttons, j.ToString(), detail_btn_Click);
                        }
                    }

                    yStartPosition += 40;

                }

                buttonList.Add(startbuttons);
                xStartPosition += 140;
            }

            SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            Graphics formGraphics;
            formGraphics = this.CreateGraphics();
          //  formGraphics.TranslateTransform(this.AutoScrollPosition.X, this.AutoScrollPosition.Y);
          //  formGraphics.SmoothingMode = SmoothingMode.AntiAlias;

            int nrLayerului = 2;
            for (int i = 0; i < buttonList.Count - 1; i++) {
                for (int j = i + 1; j < nrLayerului; j++) {
                    for (int k = 0; k < buttonList[i].Count; k++) {
                        for (int l = 0; l < buttonList[j].Count; l++) {
                            formGraphics.DrawLine(System.Drawing.Pens.Red, buttonList[i][k].Location.X + 15, buttonList[i][k].Location.Y + 15, buttonList[j][l].Location.X + 15, buttonList[j][l].Location.Y + 15);

                        }
                    }
                }
                nrLayerului++;
            }

            myBrush.Dispose();
            formGraphics.Dispose();
        }

        private void input_btn_Click(object sender, EventArgs e) {
            CircularButton btn = (CircularButton)sender;
            int pos = int.Parse(btn.Text);
            double actual_value = neuronsList[0][pos]._globalOutput ;

           InitializeInput form = new InitializeInput(this, pos, actual_value);
            form.ShowDialog();
        }

        private void detail_btn_Click(Object sender, EventArgs e) {
            CircularButton button = (CircularButton)sender;
            int layer = -1;
            for (int i = 0; i < buttonList.Count; ++i) {
                for (int j = 0; j < buttonList[i].Count; ++j) {
                    if(buttonList[i][j] == button) {
                        layer = i;
                    }
                }
            }

            int btnPos = int.Parse(button.Text);
               DetailLayerForm form = new DetailLayerForm(this,layer,btnPos);
               form.ShowDialog();
        }


        private void initializeNeurons() {  //suma-semn
          
            neuronsList = new List<List<Artificial_Neuron>>();

            listBinar = new List<int>();
            listG = new List<double>();
            listTeta = new List<double>();
            listFunctionsInput = new List<int>();
            listFunctionsActivation = new List<int>();

            for (int i = 0; i < buttonList.Count; i++) {//parcurgem lista listelor de butoane pt a ne crea
                                                        //lista cu neuroni pt fiecare start

                if(i == 0) { //input layer
                    List<Artificial_Neuron> listIL = new List<Artificial_Neuron> ();
                    for(int j = 0; j < buttonList[i].Count; j++) { //nr butoane de pe IL = nr neuroni pe IL
                        Artificial_Neuron artificial_Neuron = new Artificial_Neuron(1);//1 input
                        artificial_Neuron._globalInput = 0;
                        listIL.Add(artificial_Neuron);
                    }
                    neuronsList.Add(listIL);
                }
                else { //celelalte starturi
                    List<Artificial_Neuron> listLayers = new List<Artificial_Neuron>();
                    for(int j = 0; j <buttonList[i].Count; j++) {
                        Artificial_Neuron artificial_Neuron = new Artificial_Neuron(neuronsList[i-1].Count);
                        for(int k = 0; k < neuronsList[i - 1].Count; ++k) {//pt nr intrari de la startul precedent
                            artificial_Neuron._inputX .Add(neuronsList[i - 1][k]._globalOutput);
                            artificial_Neuron._weight.Add(0);
                        }
                        artificial_Neuron.sumFunction();
                        artificial_Neuron.functiaSigmoidala(0,1);//teta=0,g=1
                        listLayers.Add(artificial_Neuron);
   
                    }
                    neuronsList.Add(listLayers);

                    listBinar.Add(0);
                    listG.Add(1);
                    listTeta.Add(0);
                    listFunctionsInput.Add(0);
                    listFunctionsActivation.Add(2);
                }
            }
        }

        public void updateData() {

          /*  //pt primul start
            for (int i = 0; i < neuronsList[0].Count; i++) {
                neuronsList[0][i]._globalOutput = neuronsList[0][i]._inputX[0];
            }*/
            //pt celelalte straturi
            for (int i = 1; i < neuronsList.Count; i++) {
                for(int j = 0; j < neuronsList[i].Count; j++) {
                    //
                    for (int k = 0; k < neuronsList[i][j]._inputX.Count; k++) {//nr neuroni start precedent=nr lista x
                        neuronsList[i][j]._inputX[k] = neuronsList[i - 1][k]._globalOutput;
                    }

                    if (listFunctionsInput[i - 1] == 0) {//0-suma ,1-produs,2-minim,3-maxim
                        neuronsList[i][j].sumFunction();
                    } else if (listFunctionsInput[i-1] == 1) {
                        neuronsList[i][j].produs();
                    }
                    else if(listFunctionsActivation[i-1] == 2) {
                        neuronsList[i][j].minim();
                    }
                    else if(listFunctionsActivation[i-1] == 3) {
                        neuronsList[i][j].maxim();
                    }

                    if(listFunctionsActivation[i-1] == 0) {////0-semn,1-treapta,2-sigmoidala,3-tangenta,4-liniara
                      
                        if(listBinar[i-1] == 1) {
                            neuronsList[i][j].functiaSemn(listTeta[i - 1]);
                            neuronsList[i][j].activareSemn();
                        }
                        else {
                            neuronsList[i][j].functiaSemn(listTeta[i - 1]);
                        }

                    }else if (listFunctionsActivation[i - 1] == 1) {

                        if (listBinar[i - 1] == 1) {
                            neuronsList[i][j].functiaTreapta(listTeta[i - 1]);
                            neuronsList[i][j].activareTreapta();
                        }
                        else {
                            neuronsList[i][j].functiaTreapta(listTeta[i - 1]);
                        }
                       
                    }else if(listFunctionsActivation[i-1] == 2) {

                        if (listBinar[i - 1] == 1) {
                            neuronsList[i][j].functiaSigmoidala(listTeta[i - 1], listG[i - 1]);
                            neuronsList[i][j].activareSigmoidala();
                        }
                        else {
                            neuronsList[i][j].functiaSigmoidala(listTeta[i-1], listG[i-1]);
                        }
                        
                    }else if(listFunctionsActivation[i - 1] == 3) {

                        if (listBinar[i - 1] == 1) {
                            neuronsList[i][j].functiaTangentaHiperbolica(listTeta[i - 1], listG[i - 1]);
                            neuronsList[i][j].activareTangentaLiniara();
                        }
                        else {
                            neuronsList[i][j].functiaTangentaHiperbolica(listTeta[i - 1], listG[i - 1]);
                        }
                       
                    }else if(listFunctionsActivation[i - 1] == 4) {

                        if (listBinar[i - 1] == 1) {
                            neuronsList[i][j].functiaLiniara(listTeta[i - 1], listG[i - 1]);
                            neuronsList[i][j].activareTangentaLiniara();
                        }
                        else {
                            neuronsList[i][j].functiaLiniara(listTeta[i - 1], listG[i - 1]);
                        }
                        
                    }


                }
            }
        }
       
    }

    class CircularButton : Button {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e) {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
        }
    }
}
