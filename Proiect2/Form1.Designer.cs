namespace Proiect2 {
    partial class NeuronalNetwork {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NeuronalNetwork));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonNewNetworn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonOutput = new System.Windows.Forms.Button();
            this.buttonHiddendLayer3 = new System.Windows.Forms.Button();
            this.buttonHiddendLayer2 = new System.Windows.Forms.Button();
            this.buttonHiddendLayer1 = new System.Windows.Forms.Button();
            this.LayerInfo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.buttonNewNetworn);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 765);
            this.panel1.TabIndex = 0;
            // 
            // buttonNewNetworn
            // 
            this.buttonNewNetworn.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonNewNetworn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNewNetworn.Location = new System.Drawing.Point(13, 12);
            this.buttonNewNetworn.Name = "buttonNewNetworn";
            this.buttonNewNetworn.Size = new System.Drawing.Size(135, 71);
            this.buttonNewNetworn.TabIndex = 0;
            this.buttonNewNetworn.Text = "New Neuronal Network";
            this.buttonNewNetworn.UseVisualStyleBackColor = false;
            this.buttonNewNetworn.Click += new System.EventHandler(this.buttonNewNetworn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.buttonOutput);
            this.panel2.Controls.Add(this.buttonHiddendLayer3);
            this.panel2.Controls.Add(this.buttonHiddendLayer2);
            this.panel2.Controls.Add(this.buttonHiddendLayer1);
            this.panel2.Controls.Add(this.LayerInfo);
            this.panel2.Location = new System.Drawing.Point(162, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1375, 52);
            this.panel2.TabIndex = 1;
            // 
            // buttonOutput
            // 
            this.buttonOutput.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOutput.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonOutput.Location = new System.Drawing.Point(1228, 4);
            this.buttonOutput.Name = "buttonOutput";
            this.buttonOutput.Size = new System.Drawing.Size(117, 46);
            this.buttonOutput.TabIndex = 3;
            this.buttonOutput.Text = "Output";
            this.buttonOutput.UseVisualStyleBackColor = false;
            // 
            // buttonHiddendLayer3
            // 
            this.buttonHiddendLayer3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHiddendLayer3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonHiddendLayer3.Location = new System.Drawing.Point(808, 3);
            this.buttonHiddendLayer3.Name = "buttonHiddendLayer3";
            this.buttonHiddendLayer3.Size = new System.Drawing.Size(117, 46);
            this.buttonHiddendLayer3.TabIndex = 2;
            this.buttonHiddendLayer3.Text = "Hidden Layer 3";
            this.buttonHiddendLayer3.UseVisualStyleBackColor = false;
            // 
            // buttonHiddendLayer2
            // 
            this.buttonHiddendLayer2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHiddendLayer2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonHiddendLayer2.Location = new System.Drawing.Point(948, 3);
            this.buttonHiddendLayer2.Name = "buttonHiddendLayer2";
            this.buttonHiddendLayer2.Size = new System.Drawing.Size(117, 46);
            this.buttonHiddendLayer2.TabIndex = 2;
            this.buttonHiddendLayer2.Text = "Hidden Layer 2";
            this.buttonHiddendLayer2.UseVisualStyleBackColor = false;
            // 
            // buttonHiddendLayer1
            // 
            this.buttonHiddendLayer1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHiddendLayer1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonHiddendLayer1.Location = new System.Drawing.Point(1091, 3);
            this.buttonHiddendLayer1.Name = "buttonHiddendLayer1";
            this.buttonHiddendLayer1.Size = new System.Drawing.Size(117, 46);
            this.buttonHiddendLayer1.TabIndex = 2;
            this.buttonHiddendLayer1.Text = "Hidden Layer 1";
            this.buttonHiddendLayer1.UseVisualStyleBackColor = false;
            // 
            // LayerInfo
            // 
            this.LayerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LayerInfo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LayerInfo.Location = new System.Drawing.Point(7, 12);
            this.LayerInfo.Name = "LayerInfo";
            this.LayerInfo.Size = new System.Drawing.Size(122, 31);
            this.LayerInfo.TabIndex = 0;
            this.LayerInfo.Text = "Layer Info";
            // 
            // NeuronalNetwork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1590, 767);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NeuronalNetwork";
            this.Text = "Neuronal Network";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonNewNetworn;
        private System.Windows.Forms.Label LayerInfo;
        private System.Windows.Forms.Button buttonHiddendLayer3;
        private System.Windows.Forms.Button buttonHiddendLayer2;
        private System.Windows.Forms.Button buttonHiddendLayer1;
        private System.Windows.Forms.Button buttonOutput;
    }
}

