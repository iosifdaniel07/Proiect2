namespace Proiect2 {
    partial class DetailLayerForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailLayerForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.Input = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.activation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.binary = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxActivation = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(269, 308);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Function:";
            // 
            // Input
            // 
            this.Input.AutoSize = true;
            this.Input.Location = new System.Drawing.Point(620, 36);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(44, 16);
            this.Input.TabIndex = 2;
            this.Input.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Activation Function:";
            // 
            // activation
            // 
            this.activation.AutoSize = true;
            this.activation.Location = new System.Drawing.Point(620, 88);
            this.activation.Name = "activation";
            this.activation.Size = new System.Drawing.Size(44, 16);
            this.activation.TabIndex = 4;
            this.activation.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Binary State:";
            // 
            // binary
            // 
            this.binary.AutoSize = true;
            this.binary.Location = new System.Drawing.Point(623, 149);
            this.binary.Name = "binary";
            this.binary.Size = new System.Drawing.Size(44, 16);
            this.binary.TabIndex = 6;
            this.binary.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Input Value:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(445, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Activationt Value:";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(623, 200);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(100, 22);
            this.textBoxInput.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Output Value:";
            // 
            // textBoxActivation
            // 
            this.textBoxActivation.Location = new System.Drawing.Point(623, 259);
            this.textBoxActivation.Name = "textBoxActivation";
            this.textBoxActivation.Size = new System.Drawing.Size(100, 22);
            this.textBoxActivation.TabIndex = 11;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(623, 315);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(100, 22);
            this.textBoxOutput.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 41);
            this.button1.TabIndex = 13;
            this.button1.Text = "CONFIRM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DetailLayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxActivation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.binary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.activation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetailLayerForm";
            this.Text = "DetailLayerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label activation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label binary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxActivation;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button button1;
    }
}