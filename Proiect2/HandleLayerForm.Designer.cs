namespace Proiect2 {
    partial class HandleLayerForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HandleLayerForm));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxInput = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxActivation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownTeta = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownG = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Functions";
            // 
            // comboBoxInput
            // 
            this.comboBoxInput.FormattingEnabled = true;
            this.comboBoxInput.Items.AddRange(new object[] {
            "Suma",
            "Produs",
            "Minim",
            "Maxim"});
            this.comboBoxInput.Location = new System.Drawing.Point(27, 51);
            this.comboBoxInput.Name = "comboBoxInput";
            this.comboBoxInput.Size = new System.Drawing.Size(121, 24);
            this.comboBoxInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Activation Functions";
            // 
            // comboBoxActivation
            // 
            this.comboBoxActivation.FormattingEnabled = true;
            this.comboBoxActivation.Items.AddRange(new object[] {
            "Semn",
            "Treapta",
            "Sifmoidala",
            "Tangenta",
            "Liniara"});
            this.comboBoxActivation.Location = new System.Drawing.Point(27, 129);
            this.comboBoxActivation.Name = "comboBoxActivation";
            this.comboBoxActivation.Size = new System.Drawing.Size(121, 24);
            this.comboBoxActivation.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Teta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "G/A";
            // 
            // numericUpDownTeta
            // 
            this.numericUpDownTeta.Location = new System.Drawing.Point(275, 52);
            this.numericUpDownTeta.Name = "numericUpDownTeta";
            this.numericUpDownTeta.Size = new System.Drawing.Size(105, 22);
            this.numericUpDownTeta.TabIndex = 6;
            // 
            // numericUpDownG
            // 
            this.numericUpDownG.Location = new System.Drawing.Point(275, 136);
            this.numericUpDownG.Name = "numericUpDownG";
            this.numericUpDownG.Size = new System.Drawing.Size(105, 22);
            this.numericUpDownG.TabIndex = 7;
            this.numericUpDownG.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(219, 185);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 20);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Binar";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Result Binar or Real";
            // 
            // HandleLayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 276);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDownG);
            this.Controls.Add(this.numericUpDownTeta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxActivation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxInput);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HandleLayerForm";
            this.Text = "HandleLayerForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxActivation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownTeta;
        private System.Windows.Forms.NumericUpDown numericUpDownG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
    }
}